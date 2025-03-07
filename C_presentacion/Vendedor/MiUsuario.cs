using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Administrador;
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

namespace FankyRecords.C_presentacion.Vendedor
{
    public partial class MiUsuario : Form
    {
        readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
        private readonly NegocioUsuarios CN_Usuarios;

        public MiUsuario()
        {
            InitializeComponent();
            CN_Usuarios = new NegocioUsuarios();
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
              TBtelefono.Text,
              rutaFoto.Text
            };
            return campos;
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

            // Crear objeto usuarios
            Usuarios usuario = new Usuarios
            {
                ID_usuarios = SesionUsuario.UsuarioActual.ID_usuarios,
                Dni = TBdni.Text,
                Nombre = TBnombre.Text,
                Apellido = TBapellido.Text,
                Direccion = TBdireccion.Text,
                Correo = TBemail.Text,
                Clave = TBclave.Text,
                Telefono = TBtelefono.Text,
                FechaNacimiento = Convert.ToDateTime(DTFechanac.Text)
            };
            // Verificar si el usuario existe en la base de datos
            try
            {
                Usuarios usuarioExistente = CN_Usuarios.ObtenerUsuariosPorID(SesionUsuario.UsuarioActual.ID_usuarios);
                if (usuarioExistente == null)
                {
                    MessageBox.Show("El usuario seleccionado no se encuentra en la base de datos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (clave.Length < 4 || clave.Length > 10)
            {
                MessageBox.Show("La clave debe tener un mínimo de 4 caracteres y un máximo de 10 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!C_negocio.Validaciones.ContraseñaCorrecta(clave, confirmarClave))
            {
                MessageBox.Show("La clave es incorrecta o contiene espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult ask = MessageBox.Show("¿Seguro que deseas editar el usuario: "
                    + this.TBnombre.Text + " " + this.TBapellido.Text + "?", "Confirmar edición",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    CN_Usuarios.EditarMiUsuario(usuario);

                    MessageBox.Show("El usuario: "
                        + this.TBnombre.Text + " " + this.TBapellido.Text + " se editó correctamente", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bfoto_Click(object sender, EventArgs e)
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

        private void MiUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            TBnombre.Text = SesionUsuario.UsuarioActual.Nombre;
            TBapellido.Text = SesionUsuario.UsuarioActual.Apellido;
            TBdni.Text = SesionUsuario.UsuarioActual.Dni;
            TBdireccion.Text = SesionUsuario.UsuarioActual.Direccion;
            TBemail.Text = SesionUsuario.UsuarioActual.Correo;
            TBclave.Text = SesionUsuario.UsuarioActual.Clave;
            TBtelefono.Text = SesionUsuario.UsuarioActual.Telefono;
            DTFechanac.Text = SesionUsuario.UsuarioActual.FechaNacimiento.ToString();
        }

        private void TBnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }

        private void TBapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }

        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void TBtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void TBdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsConcatenacionTextoNumero(e);
        }
    }
}
