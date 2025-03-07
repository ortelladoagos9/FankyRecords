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
                string[] columnas = { "ID_producto", "Codigo", "Nombre", "Descripcion", "Stock", "Stock_min", "PrecioVenta", "PrecioCompra", "Estado", "Obj_categoria" };
                BuscarDatos(terminoBusqueda, listadoProductos, columnas);
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
