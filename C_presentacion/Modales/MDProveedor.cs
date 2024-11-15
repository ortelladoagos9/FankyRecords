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

        private readonly DatosProveedores CD_Proveedores;
        private readonly NegocioProveedores CN_Proveedores;
        private int proveedorIdSeleccionado; // Variable para almacenar el Id del proveedor seleccionado
        public MDProveedor()
        {
            InitializeComponent();
            CD_Proveedores = new DatosProveedores();
            CN_Proveedores = new NegocioProveedores();
        }

        private void MDProveedor_Load(object sender, EventArgs e)
        {
            List<Proveedores> proveedores = CN_Proveedores.ListarProveedores();
            listaproveedores.DataSource = proveedores;
        }

        private void DGlistaproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if(iRow > 0 && iCol >0)
            {   //creo objeto proveedor y le asigno los datos del proveedor seleccionado en el datagrid
                Proveedormd = new Proveedores()
                {
                    //solo necesito esos datos
                    RazonSocial = listaproveedores.Rows[iRow].Cells["razonSocialDataGridViewTextBoxColumn"].Value.ToString(),
                    Cuit = listaproveedores.Rows[iRow].Cells["cuitDataGridViewTextBoxColumn"].Value.ToString(),

                };
                // devuelve OK y cierra form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
            }
        }
    }
    
}
