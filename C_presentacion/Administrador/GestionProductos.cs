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

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionProductos : Form
    {
        private readonly NegocioProductos CN_Productos;
        private readonly NegocioCategorias CN_Categorias;
        private int productoIdSeleccionado;

        public GestionProductos()
        {
            InitializeComponent();
            CN_Productos = new NegocioProductos();
            CN_Categorias = new NegocioCategorias();
        }

        private List<string> ListaCampos()
        {
            // Lista de todos los TextBox y ComboBox que se deben validar
            var campos = new List<string>
            {
              TBcodigo_prod.Text,
              TBnombre_prod.Text,
              TBdescripcion.Text,
              TBStock_min.Text,
              CBcategoria.Text,
            };
            return campos;
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            VerificarCamposYGuardar();
        }

        private void VerificarCamposYGuardar()
        {
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear un objeto Categorias basado en el valor del ComboBox
            Categorias categoriaSeleccionada = new Categorias
            {
                Id_categoria = Convert.ToInt32(CBcategoria.SelectedValue),
                Descripcion = CBcategoria.Text,
                Estado = "Activo"
            };
            // Crear objeto productos
            Productos producto = new Productos
            {
                Codigo = Convert.ToInt32(TBcodigo_prod.Text),
                Nombre = TBnombre_prod.Text,
                Descripcion = TBdescripcion.Text,
                Stock_min = Convert.ToInt32(TBStock_min.Text),
                Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                Obj_categoria = categoriaSeleccionada  // Asigna el objeto de categoría
            };
            producto.Obj_categoria = categoriaSeleccionada;
            if (CBcategoria.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                producto.Obj_categoria.Id_categoria = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo producto?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Intentar guardar la categoría en la base de datos
                    CN_Productos.GuardarProductos(producto);

                    MessageBox.Show("El Producto: " + this.TBnombre_prod.Text + " " + this.TBdescripcion.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarProductos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        } 

        private void CargarProductos()
        {
            List<Productos> productos = CN_Productos.ListarProductos();
            //var productosActivos = productos.Where(c => c.Estado == "Activo").ToList();
            listadoProductos.DataSource = productos;
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        } 

        private void Beliminar_Click(object sender, EventArgs e)
        {
            VerificarCamposYEliminar();
        }

        private void VerificarCamposYEliminar()
        {
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("Debe completar todos los campos para poder desactivar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si el producto existe en la base de datos
            Productos productoExistente = CN_Productos.ObtenerProductosPorID(productoIdSeleccionado);
            if (productoExistente == null)
            {
                MessageBox.Show("El producto seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }

            if (C_negocio.Validaciones.mensajeEliminar())
            {
                CN_Productos.EliminarProductos(productoIdSeleccionado);

                // Recargar datos y limpiar formulario
                CargarProductos();
                Limpiar();
            }         
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            VerificarCamposYEditar();
        }

        private void VerificarCamposYEditar()
        {
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el producto existe en la base de datos
            try
            {
                Productos productoExistente = CN_Productos.ObtenerProductosPorID(productoIdSeleccionado);
                if (productoExistente == null)
                {
                    MessageBox.Show("El producto seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Crear un objeto Categorias basado en el valor del ComboBox
            Categorias categoriaSeleccionada = new Categorias
            {
                Id_categoria = Convert.ToInt32(CBcategoria.SelectedValue),
                Descripcion = CBcategoria.Text,
                Estado = "Activo"
            };
            // Crear objeto productos
            Productos productos = new Productos
            {
                ID_producto = productoIdSeleccionado,
                Codigo = Convert.ToInt32(TBcodigo_prod.Text),
                Nombre = TBnombre_prod.Text,
                Descripcion = TBdescripcion.Text,
                Stock_min = Convert.ToInt32(TBStock_min.Text),
                Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                Obj_categoria = categoriaSeleccionada  // Asigna el objeto de producto  
            };
            productos.Obj_categoria = categoriaSeleccionada;
            if (CBcategoria.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                productos.Obj_categoria.Id_categoria = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea editar producto?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Llamar al método de negocio para guardar/editar el producto
                    CN_Productos.GuardarProductos(productos);

                    MessageBox.Show("El producto: " + this.TBnombre_prod.Text + " " + "se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de productos
                    CargarProductos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Limpiar()
        {
            // Deselecciona la fila actual en el DataGridView
            listadoProductos.ClearSelection();
            // Resetea el ID del usuario seleccionado
            productoIdSeleccionado = -1;
            TBcodigo_prod.Clear();
            TBnombre_prod.Clear();
            TBdescripcion.Clear();
            TBStock_min.Clear();
            CBcategoria.SelectedIndex = 0;  // Deselect the ComboBox
            rBactivo.Checked = true;
        }

        private void gestionProductos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarProductos();
            // Suscribimos el evento para que se ejecute cuando los datos terminen de cargar
            listadoProductos.DataBindingComplete += listadoProductos_DataBindingComplete;

            listadoProductos.Columns["precioVenta"].DefaultCellStyle.Format = "N2";
            listadoProductos.Columns["precioCompra"].DefaultCellStyle.Format = "N2";

            listadoProductos.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-ES");
        }

        private void listadoProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AplicarColoresAdvertenciaStock();
        }

        private void AplicarColoresAdvertenciaStock()
        {
            bool hayAdvertencia = false; // Bandera para mostrar el mensaje solo una vez

            foreach (DataGridViewRow fila in listadoProductos.Rows)
            {
                if (fila.Cells["stock"].Value != null && fila.Cells["stockmin"].Value != null)
                {
                    if (int.TryParse(fila.Cells["stock"].Value.ToString(), out int stock) &&
                        int.TryParse(fila.Cells["stockmin"].Value.ToString(), out int stockMin))
                    {
                        if (stock <= stockMin)
                        {
                            fila.DefaultCellStyle.BackColor = System.Drawing.Color.Tomato;
                            fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                            hayAdvertencia = true; // Se activa la bandera
                        }
                        else
                        {
                            fila.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                            fila.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                        }
                    }
                }
            }

            // Muestra el mensaje solo si hay productos con stock bajo
            if (hayAdvertencia)
            {
                MessageBox.Show("Algunos productos tienen stock por debajo del mínimo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCombo()
        {
            // Obtener todas las categorías
            List<Categorias> listaCategoria = new NegocioCategorias().ListarCategorias();

            // Filtrar las categorías activas
            var categoriasActivas = listaCategoria.Where(c => c.Estado == "Activo").ToList();

            // Configurar propiedades del ComboBox
            CBcategoria.DisplayMember = "Texto";
            CBcategoria.ValueMember = "Valor";

            // Agregar solo las categorías activas al ComboBox
            foreach (Categorias item in categoriasActivas)
            {
                CBcategoria.Items.Add(new OpcionCombo() { Valor = item.Id_categoria, Texto = item.Descripcion });
            }

            // Seleccionar el primer elemento si hay categorías activas
            if (CBcategoria.Items.Count > 0)
            {
                CBcategoria.SelectedIndex = 0;
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void listadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = listadoProductos.Rows[e.RowIndex];

                // Accede al ID_producto si existe en el DataGridView
                if (row.Cells["ID_producto"] != null && row.Cells["ID_producto"].Value != DBNull.Value)
                {
                    productoIdSeleccionado = Convert.ToInt32(row.Cells["ID_producto"].Value);
                }

                // Rellenar otros campos del producto seleccionado
                if (row.Cells["codigo"] != null && row.Cells["codigo"].Value != DBNull.Value)
                {
                    TBcodigo_prod.Text = row.Cells["codigo"].Value.ToString();
                }
                if (row.Cells["Nombre"] != null && row.Cells["Nombre"].Value != DBNull.Value)
                {
                    TBnombre_prod.Text = row.Cells["Nombre"].Value.ToString();
                }
                if (row.Cells["Descripcion"] != null && row.Cells["Descripcion"].Value != DBNull.Value)
                {
                    TBdescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                }
               
                if (row.Cells["Estado"] != null && row.Cells["Estado"].Value != DBNull.Value)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
                if (row.Cells["stockmin"] != null && row.Cells["stockmin"].Value != DBNull.Value)
                {
                    TBStock_min.Text = row.Cells["stockmin"].Value.ToString(); // Asumiendo que TBStock_min es un TextBox
                }
                if (row.Cells["objcategoria"] != null && row.Cells["objcategoria"].Value is FankyRecords.C_entidad.Categorias categoria)
                {
                    // Asigna la descripción de la categoría al ComboBox
                    CBcategoria.Text = categoria.Descripcion;
                }
            }
        }

        private void listadoProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido y que no es un encabezado (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Deselecciona la fila actual en el DataGridView
                listadoProductos.ClearSelection();

                // Limpia los controles de entrada
                Limpiar();

                // Resetea el ID del producto seleccionado
                productoIdSeleccionado = -1;
            }
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarProductos();
            }
        }

        private void TBBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarYBuscar();  // Llama al método  ValidarYBuscar() cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}

