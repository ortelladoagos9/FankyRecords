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
            CargarCombo();
            CargarUsuarios();
        }

        private void CargarCombo()
        {
            // Obtener todas los roles
            List<Rol> listaRol= CN_Rol.ListarRol();

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
                MessageBox.Show("Debe completar todos los campos para guardar.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            // Validación previa de duplicados en la base de datos
            if (CN_Usuarios.ExisteDocumento(TBdni.Text))
            {
                MessageBox.Show("El DNI ya existe. No se permiten duplicados.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CN_Usuarios.ExisteTelefono(TBtelefono.Text))
            {
                MessageBox.Show("El teléfono ya existe. No se permiten duplicados.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CN_Usuarios.ExisteCorreo(TBemail.Text))
            {
                MessageBox.Show("El correo ya existe. No se permiten duplicados.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = TBemail.Text;
            if (!C_negocio.Validaciones.EmailCorrecto(email))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string clave = TBclave.Text;
            string confirmarClave = TBconfirmarClave.Text;
            if (!(clave == confirmarClave))
            {
                MessageBox.Show("La clave es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // Crear un objeto Rol basado en el valor del ComboBox
            Rol rolSeleccionado = new Rol
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
                Obj_rol = rolSeleccionado  // Asigna el objeto de categoría
            };

            usuario.Obj_rol = rolSeleccionado;
            if (CBRol.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                usuario.Obj_rol.ID_rol = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol válido.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo usuario?", "Confirmar inserción", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    CN_Usuarios.GuardarUsuarios(usuario);

                    MessageBox.Show("El usuario: " 
                        + this.TBnombre.Text + " " + this.TBapellido.Text + " " + "se insertó correctamente", "Guardar", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //var usuariosActivos = usuarios.Where(c => c.Estado == "Activo").ToList();
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
                    MessageBox.Show($"Error al copiar el archivo: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe completar todos campos para eliminar.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si el usuario existe en la base de datos
            Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(usuarioIdSeleccionado);
            if (usuarioExistente == null)
            {
                MessageBox.Show("El usuario seleccionado no se encuentra en la base de datos.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (CBRol.Text == "Administrador")
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR EL USUARIO ADMINISTRADOR!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe completar todos los campos para editar", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si el usuario existe en la base de datos
            try
            {
                Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(usuarioIdSeleccionado);
                if (usuarioExistente == null)
                {
                    MessageBox.Show("El usuario seleccionado no se encuentra en la base de datos.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string clave = TBclave.Text;
            string confirmarClave = TBconfirmarClave.Text;
            if (!(clave == confirmarClave))
            {
                MessageBox.Show("Las claves no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // Crear un objeto Rol basado en el valor del ComboBox
            Rol rolSeleccionado = new Rol
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
                Obj_rol = rolSeleccionado  // Asigna el objeto de producto  
            };

            usuario.Obj_rol= rolSeleccionado;
            
            if (CBRol.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                usuario.Obj_rol.ID_rol = (int)opcionSeleccionada.Valor;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol válido.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que deseas editar el usuario: "
                    + this.TBnombre.Text + " " + this.TBapellido.Text + "?", "Confirmar edición", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Llamar al método de negocio para guardar/editar el producto
                    CN_Usuarios.GuardarUsuarios(usuario);

                    MessageBox.Show("El usuario: " 
                        + this.TBnombre.Text + " " + this.TBapellido.Text + " se editó correctamente", "Guardar", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ValidarYBuscar();
        }

        private void ValidarYBuscar()
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe ingresar un dato para buscar", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            listadoUsuarios.ClearSelection();

            // Primero, deselecciona la celda actual
            listadoUsuarios.CurrentCell = null;

            foreach (DataGridViewRow row in listadoUsuarios.Rows)
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
                if (!filaVisible && listadoUsuarios.CurrentRow == row)
                {
                    // Buscar otra fila visible para asignar el foco
                    foreach (DataGridViewRow otraFila in listadoUsuarios.Rows)
                    {
                        if (otraFila != row && otraFila.Visible)
                        {
                            listadoUsuarios.CurrentCell = otraFila.Cells[0];
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

        private void listadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que el índice de fila es válido
            {
                DataGridViewRow row = listadoUsuarios.Rows[e.RowIndex];
                
                // Accede al ID_usuario si existe en el DataGridView
                if (row.Cells["ID_usuarios"] != null && row.Cells["ID_usuarios"].Value != DBNull.Value)
                {
                   usuarioIdSeleccionado = Convert.ToInt32(row.Cells["ID_usuarios"].Value);
                }

                // Rellenar otros campos del usuario seleccionado
                if (row.Cells["Dni"] != null && row.Cells["Dni"].Value != DBNull.Value)
                {
                    TBdni.Text = row.Cells["Dni"].Value.ToString();
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
                if (row.Cells["Correo"] != null && row.Cells["Correo"].Value != DBNull.Value)
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
                if (row.Cells["FechaNacimiento"] != null && row.Cells["FechaNacimiento"].Value != DBNull.Value)
                {
                    DTFechanac.Text = row.Cells["FechaNacimiento"].Value.ToString();
                }
                if (row.Cells["Estado"] != null && row.Cells["Estado"].Value != DBNull.Value)
                {
                    string estado = row.Cells["Estado"].Value.ToString();
                    rBactivo.Checked = estado == "Activo";
                    rBinactivo.Checked = estado == "Inactivo";
                }
                
                if (row.Cells["RolDescripcion"] != null && row.Cells["RolDescripcion"].Value != DBNull.Value)
                {
                    // Si tienes una columna separada para la descripción del rol
                    CBRol.Text = row.Cells["RolDescripcion"].Value.ToString();
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

                // Resetea el ID del usuario seleccionado
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
            // Deselecciona la fila actual en el DataGridView
            listadoUsuarios.ClearSelection();
            // Resetea el ID del usuario seleccionado
            usuarioIdSeleccionado = -1;    
            TBnombre.Clear();
            TBapellido.Clear();
            rutaFoto.Clear();
            TBdireccion.Clear();
            TBtelefono.Clear();
            TBdni.Clear();
            TBemail.Clear();
            DTFechanac.Value = DTFechanac.MaxDate;
            picFotoUsuario.Image = null;
            picFotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoUsuario.BackgroundImage")));
            TBclave.Clear();
            TBconfirmarClave.Clear();
            CBRol.SelectedIndex = 0;
            rBactivo.Checked = true;
        }

        private void TBlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        
       

       
    

