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
                BuscarDatos(terminoBusqueda);
            }
        }

        private void BuscarDatos(string termino)
        {
            bool encontrado = false;
            string busqueda = termino.ToLower().Trim(); // Convertir a minúsculas y quitar espacios extra

            // Desactivar la selección para evitar conflictos
            listadoProductos.ClearSelection();
            listadoProductos.CurrentCell = null;

            foreach (DataGridViewRow row in listadoProductos.Rows)
            {
                bool filaVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        continue;

                    string textoCelda = cell.Value.ToString().ToLower().Trim();

                    // Separar el contenido de la celda en palabras (quitando espacios extras)
                    string[] palabrasCelda = textoCelda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (busqueda.Contains(" "))
                    {
                        // Búsqueda multi-palabra: dividimos el término en palabras
                        string[] palabrasBusqueda = busqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // Revisar cada segmento contiguo de palabras en la celda con la cantidad de palabras en la búsqueda
                        for (int i = 0; i <= palabrasCelda.Length - palabrasBusqueda.Length; i++)
                        {
                            bool coincideTodo = true;
                            for (int j = 0; j < palabrasBusqueda.Length; j++)
                            {
                                // Se usa StartsWith para permitir coincidencias parciales en cada palabra
                                if (!palabrasCelda[i + j].StartsWith(palabrasBusqueda[j]))
                                {
                                    coincideTodo = false;
                                    break;
                                }
                            }
                            if (coincideTodo)
                            {
                                filaVisible = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Búsqueda de una sola palabra: se comprueba si alguna palabra de la celda comienza con el término
                        if (palabrasCelda.Any(palabra => palabra.StartsWith(busqueda)))
                        {
                            filaVisible = true;
                        }
                    }

                    if (filaVisible)
                        break;
                }

                // Si la fila actual está oculta y es la fila con foco, cambiar a otra fila visible
                if (!filaVisible && listadoProductos.CurrentRow == row)
                {
                    foreach (DataGridViewRow otraFila in listadoProductos.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoProductos.CurrentCell = otraFila.Cells[0];
                            break;
                        }
                    }
                }

                // Aplicar la visibilidad a la fila
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
