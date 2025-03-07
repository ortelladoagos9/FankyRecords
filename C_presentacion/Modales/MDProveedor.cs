using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FankyRecords.C_presentacion.Administrador;
using FankyRecords.C_negocio;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDProveedor : Form
    {
        public Proveedores Proveedormd { get; set; }
        private readonly NegocioProveedores CN_Proveedores;     

        public MDProveedor()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Proveedores = new NegocioProveedores();
        }

        private void MDProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedor();
        }

        private void CargarProveedor()
        {
            List<Proveedores> proveedores = CN_Proveedores.ListarProveedores();
            var proveedoresActivos = proveedores.Where(c => c.Estado == "Activo").ToList();
            listaproveedores.DataSource = proveedoresActivos;
        }

        private void DGlistaproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            //creo dos variables para recorrer el datagrid
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if(iRow >= 0 && iCol >= 0)
            {
                //creo objeto proveedor y le asigno los datos del proveedor seleccionado en el datagrid
                Proveedormd = new Proveedores()
                {
                    //solo necesito esos datos
                    ID_proveedor = Convert.ToInt32(listaproveedores.Rows[iRow].Cells["ID_proveedor"].Value.ToString()),
                    RazonSocial = listaproveedores.Rows[iRow].Cells["razonSocial"].Value.ToString(),
                    Cuit = listaproveedores.Rows[iRow].Cells["cuit"].Value.ToString(),
                };
                
                // devuelve OK y cierra form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                string[] columnas = { "cuit", "razonSocial" };
                BuscarDatos(terminoBusqueda, listaproveedores, columnas);
            }
        }

        private void BuscarDatos(string termino, DataGridView grid, string[] columnasBusqueda)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower().Trim();
            string[] palabrasBusqueda = busqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Desactivar la selección para evitar conflictos
            grid.ClearSelection();
            grid.CurrentCell = null;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue; // Omitir fila nueva si es editable

                bool filaVisible = false;

                // Obtener el texto combinado de las columnas especificadas
                string textoFila = ObtenerTextoFila(row, columnasBusqueda);
                string[] palabrasFila = textoFila.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Verificar si todas las palabras de búsqueda están en la fila
                if (palabrasBusqueda.All(palabra => palabrasFila.Any(p => p.StartsWith(palabra))))
                {
                    filaVisible = true;
                }

                row.Visible = filaVisible;
                if (filaVisible) encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscador.Clear();
            }
        }

        // Método para obtener el texto concatenado de las columnas especificadas
        private string ObtenerTextoFila(DataGridViewRow row, string[] columnas)
        {
            return string.Join(" ", columnas
                .Select(columna => row.Cells[columna]?.Value?.ToString().ToLower().Trim() ?? "")
                .Where(texto => !string.IsNullOrEmpty(texto)));
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarProveedor();
            }
        }
        private void MDProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }  
}
