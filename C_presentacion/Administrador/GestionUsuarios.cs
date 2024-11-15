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
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Vendedor;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.Properties;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionUsuarios : Form
    {
        int contador = 0;
        readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
        private readonly NegocioUsuarios CN_Usuarios;
        private readonly NegocioRol CN_Rol;
        private int usuarioIdSeleccionado;



        public GestionUsuarios()
        {
            InitializeComponent();
            CN_Usuarios = new NegocioUsuarios();
            CN_Rol = new NegocioRol();
        }




        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private List<string> ListaCampos()
        {
            // Lista de todos los TextBox y ComboBox que se deben validar
            var campos = new List<string>
            {
              TBnombre.Text,
              TBapellido.Text,
              TBdni.Text,
              TBdireccion.Text,
              TBemail.Text,
              TBclave.Text,
              TBconfirmarClave.Text,
              CBRol.Text,
              TBtelefono.Text,
              rutaFoto.Text
            };
            return campos;
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            VerificarCamposYGuardar();
        }

        private void VerificarCamposYGuardar()
        {
            // Verificar si algún campo está vacío
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Crear un objeto Rol basado en el valor del ComboBox
            Rol rolSeleccionada = new Rol
            {
                ID_rol = Convert.ToInt32(CBRol.SelectedValue),
                Descripcion = CBRol.Text
            };
            // Crear objeto usuarios
            Usuarios usuario = new Usuarios
            {
                Dni = TBdni.Text,
                Nombre = TBnombre.Text,
                Apellido = TBapellido.Text,
                FechaNacimiento = Convert.ToDateTime(DTFechanac.Text),
                Direccion = TBdireccion.Text,
                Correo = TBemail.Text,
                Telefono = TBtelefono.Text,
                Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                Obj_rol = rolSeleccionada  // Asigna el objeto de categoría
            };


            usuario.Obj_rol = rolSeleccionada;
            if (CBRol.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                usuario.Obj_rol.ID_rol = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo usuario?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Intentar guardar la categoría en la base de datos
                    CN_Usuarios.GuardarUsuarios(usuario);

                    MessageBox.Show("El Producto: " + this.TBnombre.Text + " " + this.TBapellido.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar datos y limpiar formulario
                    CargarUsuarios();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void CargarUsuarios()
        {
            List<Usuarios> usuarios = CN_Usuarios.ListarUsuarios();
            listadoUsuarios.DataSource = usuarios;
        }



        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }

        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            // Selección de la imagen
            openFileDialog1.Title = "Seleccione foto de perfil";
            openFileDialog1.Filter = "JPG|*.jpg|BMP |*.bmp|PNG |*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Ruta de destino fija
                string rutaDirectorio = @"C:\Users\ortel\source\repos\FankyRecords\bin\";
                string ruta = Path.Combine(rutaDirectorio, NombreArchivo(openFileDialog1.FileName));

                try
                {
                    // Copiar el archivo seleccionado al directorio fijo
                    File.Copy(openFileDialog1.FileName, ruta, true);
                    picFotoUsuario.Load(openFileDialog1.FileName);
                    rutaFoto.Text = ruta;
                    picFotoUsuario.BackgroundImage = null;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error al copiar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string NombreArchivo(string ruta)
        {
            // Simplificación del nombre de archivo
            return Path.GetFileName(ruta);  // Devuelve el nombre del archivo completo con extensión
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {
            VerificarCamposYEliminar();
        }

        private void VerificarCamposYEliminar()
        {
            // Verificar si algún campo está vacío
            if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
            {
                MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Verificar si el usuario existe en la base de datos
            Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(usuarioIdSeleccionado);
            if (usuarioExistente == null)
            {
                MessageBox.Show("El producto seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }

            if (C_negocio.Validaciones.mensajeEliminar())
            {
                CN_Usuarios.EliminarUsuarios(usuarioIdSeleccionado);

                // Recargar datos y limpiar formulario
                CargarUsuarios();
                Limpiar();
            }
        }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                // Limpiar todas las filas del DataGridView
                listadoUsuarios.Rows.Clear();
            }

            private void Beditar_Click(object sender, EventArgs e)
            {
                VerificarCamposYEditar();
            }

            private void VerificarCamposYEditar()
            {
                // Verificar si algún campo está vacío
                if (ListaCampos().Any(campo => C_negocio.Validaciones.EstaVacio(campo)))
                {
                    MessageBox.Show("No hay datos para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Verificar si el usuario existe en la base de datos
            try
            {
                Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(usuarioIdSeleccionado);
                if (usuarioExistente == null)
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
            
            // Crear un objeto Rol basado en el valor del ComboBox
            Rol rolSeleccionada = new Rol
            {
                ID_rol = Convert.ToInt32(CBRol.SelectedValue),
                Descripcion = CBRol.Text
            };
            // Crear objeto usuarios
            Usuarios usuario= new Usuarios
            {
                ID_usuarios= usuarioIdSeleccionado,
                Dni = TBdni.Text,
                Nombre = TBnombre.Text,
                Apellido = TBapellido.Text,
                Direccion = TBdireccion.Text,
                Correo = TBemail.Text,
                Clave = TBclave.Text,
                Telefono = TBtelefono.Text,
                FechaNacimiento = Convert.ToDateTime(DTFechanac.Text),
                Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                Obj_rol = rolSeleccionada  // Asigna el objeto de producto  
            };
            usuario.Obj_rol= rolSeleccionada;
            if (CBRol.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                usuario.Obj_rol.ID_rol = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea editar usuario?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Llamar al método de negocio para guardar/editar el producto
                    CN_Usuarios.GuardarUsuarios(usuario);

                    MessageBox.Show("El usuario: " + this.TBnombre.Text + " " + "se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de productos
                    CargarUsuarios();
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

        //Metodo para buscar datos en el datagrid
        private void BuscarDatos(string termino)
        {
            bool encontrado = false;

            // Desactivar la selección temporalmente para evitar conflictos al ocultar filas
            listadoUsuarios.ClearSelection();

            // Iterar sobre todas las filas del DataGridView
            foreach (DataGridViewRow row in listadoUsuarios.Rows)
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
                if (!filaVisible && listadoUsuarios.CurrentRow == row)
                {
                    listadoUsuarios.CurrentCell = null; // Deseleccionar la celda actual
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

   

        private void listadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = listadoUsuarios.Rows[e.RowIndex];

                // Accede al ID_usuario si existe en el DataGridView
                if (row.Cells["ID_usuario"] != null && row.Cells["ID_usuario"].Value != DBNull.Value)
                {
                   usuarioIdSeleccionado = Convert.ToInt32(row.Cells["ID_usuario"].Value);
                }

                // Rellenar otros campos del usuario seleccionado
                if (row.Cells["dni"] != null && row.Cells["dni"].Value != DBNull.Value)
                {
                    TBdni.Text = row.Cells["dni"].Value.ToString();
                }
                if (row.Cells["Nombre"] != null && row.Cells["Nombre"].Value != DBNull.Value)
                {
                    TBnombre.Text = row.Cells["Nombre"].Value.ToString();
                }
                if (row.Cells["Apellido"] != null && row.Cells["Apellido"].Value != DBNull.Value)
                {
                    TBapellido.Text = row.Cells["Apellido"].Value.ToString();
                }
                if (row.Cells["Direccion"] != null && row.Cells["Direccion"].Value != DBNull.Value)
                {
                    TBdireccion.Text = row.Cells["Direccion"].Value.ToString();
                }
                if (row.Cells["Corro"] != null && row.Cells["Correo"].Value != DBNull.Value)
                {
                    TBemail.Text = row.Cells["Correo"].Value.ToString();
                }
                if (row.Cells["Telefono"] != null && row.Cells["Telefono"].Value != DBNull.Value)
                {
                    TBtelefono.Text = row.Cells["Telefono"].Value.ToString();
                }
                if (row.Cells["Clave"] != null && row.Cells["Clave"].Value != DBNull.Value)
                {
                    TBclave.Text = row.Cells["Clave"].Value.ToString();
                }
                if (row.Cells["FechaNac"] != null && row.Cells["FechaNAc"].Value != DBNull.Value)
                {
                    DTFechanac.Text = row.Cells["FechaNac"].Value.ToString();
                }
                if (row.Cells["Estado"] != null && row.Cells["Estado"].Value != DBNull.Value)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
                if (row.Cells["objrol"] != null && row.Cells["objrol"].Value is FankyRecords.C_entidad.Rol rol)
                {
                    // Asigna la descripción de la categoría al ComboBox
                    CBRol.Text = rol.Descripcion;
                }


            }
        }


        private void listadoUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila es válido y que no es un encabezado (e.RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Deselecciona la fila actual en el DataGridView
                listadoUsuarios.ClearSelection();

                // Limpia los controles de entrada
                Limpiar();

                // Resetea el ID del cliente seleccionado
                usuarioIdSeleccionado = -1;
            }
        }

        private void TBBuscador_TextChanged(object sender, EventArgs e)
        {
            if (TBBuscador.Text == "")
            {
                CargarUsuarios();
            }
        }



        private void Limpiar()
        {
                TBnombre.Clear();
                TBapellido.Clear();
                rutaFoto.Clear();
                TBdireccion.Clear();
                TBtelefono.Clear();
                TBdni.Clear();
                TBemail.Clear();
                picFotoUsuario.Image = null;
                picFotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoUsuario.BackgroundImage")));
                TBclave.Clear();
                TBconfirmarClave.Clear();
                CBRol.SelectedIndex = -1;  // Deselect the ComboBox

        }




    } 
}

        
       

       
    

