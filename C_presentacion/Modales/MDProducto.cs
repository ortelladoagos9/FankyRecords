using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_negocio;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDProducto : Form
    {
        public Productos Productomd { get; set; }

        private readonly DatosProductos CD_Productos;
        private readonly NegocioProductos CN_Productos;
        private int productoIdSeleccionado; // Variable para almacenar el Id del proveedor seleccionado

        public MDProducto()
        {
            CD_Productos = new DatosProductos();
            CN_Productos = new NegocioProductos();
            InitializeComponent();
        }

        private void MDProducto_Load(object sender, EventArgs e)
        {
            List<Productos> productos = CN_Productos.ListarProductos();
            listadoProductos.DataSource = productos;
        }

        private void listadoProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if (iRow > 0 && iCol > 0)
            {   //creo objeto proveedor y le asigno los datos del proveedor seleccionado en el datagrid
                Productomd = new Productos()
                {
                    //solo necesito esos datos
                    Codigo = Convert.ToInt32(listadoProductos.Rows[iRow].Cells["codigoDataGridViewTextBoxColumn"].Value.ToString()),
                    Nombre = listadoProductos.Rows[iRow].Cells["nombreDataGridViewTextBoxColumn"].Value.ToString(),
                    Descripcion = listadoProductos.Rows[iRow].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString(),
                    PrecioVenta = Convert.ToInt32(listadoProductos.Rows[iRow].Cells["precioVentaDataGridViewTextBoxColumn"].Value.ToString()),

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
            listadoProductos.ClearSelection();

            // Iterar sobre todas las filas del DataGridView
            foreach (DataGridViewRow row in listadoProductos.Rows)
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
                if (!filaVisible && listadoProductos.CurrentRow == row)
                {
                    listadoProductos.CurrentCell = null; // Deseleccionar la celda actual
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
