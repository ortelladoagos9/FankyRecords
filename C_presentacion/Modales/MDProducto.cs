using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDProducto : Form
    {
        public Productos Productomd { get; set; }
        private readonly NegocioProductos CN_Productos;

        public MDProducto()
        {
            InitializeComponent();
            this.KeyPreview = true;
            CN_Productos = new NegocioProductos();
        }

        private void MDProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<Productos> productos = CN_Productos.ListarProductos();
            var productosActivos = productos.Where(c => c.Estado == "Activo").ToList();
            listadoProductos.DataSource = productosActivos;
        }

        private void listadoProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /* creo dos variables para recorrer el datagrid*/
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;
            //recorro el datgrid
            if (iRow >= 0 && iCol >= 0)
            {   
                Productomd = new Productos()
                {
                    ID_producto = Convert.ToInt32(listadoProductos.Rows[iRow].Cells["ID_producto"].Value.ToString()),
                    Codigo = Convert.ToInt32(listadoProductos.Rows[iRow].Cells["codigo"].Value.ToString()),
                    Nombre = listadoProductos.Rows[iRow].Cells["nombre"].Value.ToString(),
                    Descripcion = listadoProductos.Rows[iRow].Cells["descripcion"].Value.ToString(),
                    PrecioVenta = Convert.ToDecimal(listadoProductos.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                    Stock = Convert.ToInt32(listadoProductos.Rows[iRow].Cells["stock"].Value.ToString()),
                };
                // devuelve OK y cierra form
                this.DialogResult = DialogResult.OK;
                this.Close();
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
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string terminoBusqueda = TBBuscador.Text;
                string[] columnas = { "codigo", "nombre", "descripcion", "stock" };
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

        private void TBBuscador_TextChanged_1(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarProductos();
            }
        }

        private void MDProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
