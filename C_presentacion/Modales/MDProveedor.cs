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

        private void BuscarDatos(string termino)
        {
            bool encontrado = false;

            // Desactivar la selección temporalmente para evitar conflictos al ocultar filas
            listaproveedores.ClearSelection();

            // Iterar sobre todas las filas del DataGridView
            foreach (DataGridViewRow row in listaproveedores.Rows)
            {
                bool filaVisible = false;

                // Iterar sobre todas las celdas de la fila
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().StartsWith(termino.ToLower()))
                    {
                        filaVisible = true;
                        encontrado = true;
                        break; // Detener la búsqueda en esta fila si ya hay coincidencia
                    }
                }

                // Cambiar la fila actual para evitar que esté en una fila que se va a hacer invisible
                if (!filaVisible && listaproveedores.CurrentRow == row)
                {
                    listaproveedores.CurrentCell = null; // Deseleccionar la celda actual
                }

                // Mostrar u ocultar la fila según si hubo coincidencia
                row.Visible = filaVisible;
            }

            // Mostrar mensaje si no se encontraron coincidencias
            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.");
                TBBuscador.Clear();
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
                BuscarDatos(terminoBusqueda);
            }
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
