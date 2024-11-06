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
    public partial class gestionProductos : Form
    {
        private readonly DatosProductos CD_Productos;
        private readonly NegocioProductos CN_Productos;
        private readonly NegocioCategorias CN_Categorias;
        private int productoIdSeleccionado;

        public gestionProductos()
        {
            InitializeComponent();    
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

            // Validación previa de duplicados en la base de datos
           /* if (CN_Productos.ExisteCategoria(TBdescripcion.Text))
            {
                MessageBox.Show("El producto ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return; 
            }*/

            if (C_negocio.Validaciones.mensajeConfirmacion())
            {
                /*List<Categorias> listaCategorias = CN_Categorias.ListarCategorias();

                // Filtrar las categorías activas
                var categoriasActivas = listaCategorias.Where(c => c.Estado == "Activo").ToList();

                // Asignar la lista filtrada al ComboBox
                CBcategoria.DataSource = categoriasActivas;*/

                // Crear un objeto Categorias basado en el valor del ComboBox
                Categorias categoriaSeleccionada = new Categorias
                {
                    Id_categoria = Convert.ToInt32(CBcategoria.SelectedValue), // Suponiendo que SelectedValue tiene el Id
                    Descripcion = CBcategoria.Text,  // Suponiendo que el Text tiene la descripción de la categoría
                    Estado = "Activo"  // Solo categorías activas están en el ComboBox
                };

                // Crear objeto productos
                Productos producto = new Productos
                {
                    Codigo = Convert.ToInt32(TBcodigo_prod.Text),
                    Nombre = TBnombre_prod.Text,
                    Descripcion = TBdescripcion.Text,
                    PrecioVenta = Convert.ToDecimal(TBPrecio_Venta.Text),
                    Stock_min = Convert.ToInt32(TBStock_min.Text),
                    Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                    Obj_categoria = categoriaSeleccionada  // Asigna el objeto de categoría
                };

                // Intentar guardar la categoría en la base de datos
                CN_Productos.GuardarProductos(producto);

                // Recargar datos y limpiar formulario
               // CargarProductos();
                Limpiar();
            }
        }
        private void CargarProductos()
        {
            //List<Categorias> categorias = CN_Categorias.ListarCategorias();
           // listadoProductos.DataSource = categorias;
        }


        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        } 

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoProductos.Rows.Clear();
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            VerificarCamposYEliminar();
        }

        private void VerificarCamposYEliminar()
        {
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    Limpiar();
                }
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
            }
            else
            {
                if (C_negocio.Validaciones.mensajeEditar())
                {
                    Limpiar();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            TBcodigo_prod.Clear();
            TBnombre_prod.Clear();
            TBdescripcion.Clear();
            TBPrecio_Venta.Clear();
            CBcategoria.SelectedIndex = -1;  // Deselect the ComboBox
        }

        private void gestionProductos_Load(object sender, EventArgs e)
        {
            // Obtener todas las categorías
            List<Categorias> listaCategoria = new NegocioCategorias().ListarCategorias();

            // Filtrar las categorías activas
            var categoriasActivas = listaCategoria.Where(c => c.Estado == "Activo").ToList();

            // Limpiar items previos en el ComboBox (si es necesario)
            CBcategoria.Items.Clear();

            // Agregar solo las categorías activas al ComboBox
            foreach (Categorias item in categoriasActivas)
            {
                CBcategoria.Items.Add(new OpcionCombo() { Valor = item.Id_categoria, Texto = item.Descripcion });
            }

            // Configurar propiedades del ComboBox
            CBcategoria.DisplayMember = "Texto";
            CBcategoria.ValueMember = "Valor";

            // Seleccionar el primer elemento si hay categorías activas
            if (CBcategoria.Items.Count > 0)
            {
                CBcategoria.SelectedIndex = 0;
            }
        }
    }
}

