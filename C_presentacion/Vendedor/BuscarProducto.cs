using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Vendedor
{
    public partial class BuscarProducto : Form
    {
        private readonly NegocioProductos CN_Productos;

        public BuscarProducto()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Productos = new NegocioProductos();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            listadoProductos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            listadoProductos.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";

            listadoProductos.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-ES");
        }

        private void CargarProductos()
        {
            List<Productos> productos = CN_Productos.ListarProductos();
            var productosActivos = productos.Where(c => c.Estado == "Activo").ToList();
            listadoProductos.DataSource = productosActivos;
        }     

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe escribir datos para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string busqueda = termino.ToLower();

            // Desactivar la selección para evitar conflictos
            listadoProductos.ClearSelection();

            // Primero, deselecciona la celda actual
            listadoProductos.CurrentCell = null;

            foreach (DataGridViewRow row in listadoProductos.Rows)
            {
                // Concatenar los valores de las celdas para la búsqueda
                string filaDatos = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        filaDatos += cell.Value.ToString().ToLower() + " ";
                }

                bool filaVisible = filaDatos.Contains(busqueda);

                // Si la fila debe ocultarse pero es la fila actual, cambiar el foco a otra fila visible
                if (!filaVisible && listadoProductos.CurrentRow == row)
                {
                    // Buscar otra fila visible para asignar el foco
                    foreach (DataGridViewRow otraFila in listadoProductos.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoProductos.CurrentCell = otraFila.Cells[0];
                            break;
                        }
                    }
                }

                // Ahora es seguro modificar la visibilidad
                row.Visible = filaVisible;
                if (filaVisible)
                    encontrado = true;
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron coincidencias.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBBuscador.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TBBuscador.Clear();
            listadoProductos.ClearSelection();
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarProductos();
            }
        }

        private void BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
