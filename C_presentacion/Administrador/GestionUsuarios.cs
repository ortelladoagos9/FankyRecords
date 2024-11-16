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
            CargarCombo();
        }

        private void CargarCombo()
        {
            // Obtener todas los roles
            List<Rol> listaRol= new NegocioRol().ListarRol();

            // Filtrar los roles activos
           // var rolActiva = listaCategoria.Where(c => c.Estado == "Activo").ToList();

            // Configurar propiedades del ComboBox
            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "Valor";

            // Agregar los roles al ComboBox
            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { Valor = item.ID_rol, Texto = item.Descripcion });
            }

            // Seleccionar el primer elemento si hay categorías activas
            if (CBRol.Items.Count > 0)
            {
                CBRol.SelectedIndex = 0;
            }
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
                return;
            }  // Validación previa de duplicados en la base de datos
            if (CN_Usuarios.ExisteDocumento(TBdni.Text))
            {
                MessageBox.Show("El documento ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CN_Usuarios.ExisteTelefono(TBtelefono.Text))
            {
                MessageBox.Show("El telefono ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CN_Usuarios.ExisteCorreo(TBemail.Text))
            {
                MessageBox.Show("El correo ya existe. No se permiten duplicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = TBemail.Text;

            if (!C_negocio.Validaciones.EmailCorrecto(email))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                Clave = TBclave.Text,
                Telefono = TBtelefono.Text,
                Estado = rBactivo.Checked ? "Activo" : "Inactivo",
                Obj_rol = rolSeleccionada  // Asigna el objeto de categoría
            };


            usuario.Obj_rol = rolSeleccionada;

            string clave = TBclave.Text;
            string confirmarClave = TBconfirmarClave.Text;
            if (!(clave == confirmarClave))
            {
                MessageBox.Show("La clave no es la correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
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
                        CN_Usuarios.GuardarUsuarios(usuario);

                        MessageBox.Show("El usuario: " + this.TBnombre.Text + " " + this.TBapellido.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Recargar datos y limpiar formulario
                        CargarUsuarios();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Limpiar();
                }
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
                return;
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
                    return;
              }
                // Verificar si el usuario existe en la base de datos
             try
             {
                Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(usuarioIdSeleccionado);
                 if (usuarioExistente == null)
                 {
                    MessageBox.Show("El usuario seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 MessageBox.Show("Debe seleccionar un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             try
             {
                DialogResult ask = MessageBox.Show("¿Seguro que desea editar usuario?", "Confirmar edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (ask == DialogResult.Yes)
                 {
                    // Llamar al método de negocio para guardar/editar el producto
                    CN_Usuarios.GuardarUsuarios(usuario);

                    MessageBox.Show("El usuario: " + this.TBnombre.Text + " " + this.TBapellido.Text + " se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar la lista de productos
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
                TBBuscador.Clear();
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
                if (row.Cells["nombre"] != null && row.Cells["nombre"].Value != DBNull.Value)
                {
                    TBnombre.Text = row.Cells["nombre"].Value.ToString();
                }
                if (row.Cells["apellido"] != null && row.Cells["apellido"].Value != DBNull.Value)
                {
                    TBapellido.Text = row.Cells["apellido"].Value.ToString();
                }
                if (row.Cells["direccion"] != null && row.Cells["direccion"].Value != DBNull.Value)
                {
                    TBdireccion.Text = row.Cells["direccion"].Value.ToString();
                }
                if (row.Cells["correo"] != null && row.Cells["correo"].Value != DBNull.Value)
                {
                    TBemail.Text = row.Cells["correo"].Value.ToString();
                }
                if (row.Cells["telefono"] != null && row.Cells["telefono"].Value != DBNull.Value)
                {
                    TBtelefono.Text = row.Cells["telefono"].Value.ToString();
                }
                if (row.Cells["clave"] != null && row.Cells["clave"].Value != DBNull.Value)
                {
                    TBclave.Text = row.Cells["clave"].Value.ToString();
                }
                if (row.Cells["FechaNac"] != null && row.Cells["FechaNac"].Value != DBNull.Value)
                {
                    DTFechanac.Text = row.Cells["FechaNac"].Value.ToString();
                }
                if (row.Cells["Estado"] != null && row.Cells["Estado"].Value != DBNull.Value)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
                if (row.Cells["obj_rol"] != null && row.Cells["obj_rol"].Value is FankyRecords.C_entidad.Rol rol)
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
                CBRol.SelectedIndex = 0; 

        }

        private void TBlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TBconfirmarClave_TextChanged(object sender, EventArgs e)
        {

        }

   
    } 
}

        
       

       
    

