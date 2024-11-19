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
        }

        private void CargarProductos()
        {
            List<Productos> productos = CN_Productos.ListarProductos();
            var productosActivos = productos.Where(c => c.Estado == "Activo").ToList();
            listadoProductos.DataSource = productosActivos;
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
                TBBuscador.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe escribir el código, nombre, categoria o estado de un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                BuscarDatos(terminoBusqueda);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TBBuscador.Clear();
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
