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
using FankyRecords.Properties;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionUsuarios : Form
    {
        int contador = 0;
        readonly System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));

        public GestionUsuarios()
        {
            InitializeComponent();      
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            this.CBRol.SelectedIndex = 0;
            this.CBbuscar.SelectedIndex = 0;
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
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    //validar constraseñas 
                    string password = TBclave.Text;
                    string confirmPassword = TBconfirmarClave.Text;
                    string email = TBemail.Text;

                    if (!C_negocio.Validaciones.ContraseñaCorrecta(password, confirmPassword))
                    {
                        MessageBox.Show("Las contraseñas no coinciden o contienen espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!C_negocio.Validaciones.EmailCorrecto(email))
                    {
                        MessageBox.Show("El formato del correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        contador += 1;
                        int n = listadoUsuarios.Rows.Add();

                        listadoUsuarios.Rows[n].Cells[0].Value = contador;
                        listadoUsuarios.Rows[n].Cells[1].Value = TBdni.Text;
                        listadoUsuarios.Rows[n].Cells[2].Value = TBapellido.Text;
                        listadoUsuarios.Rows[n].Cells[3].Value = TBnombre.Text;
                        listadoUsuarios.Rows[n].Cells[4].Value = DTFechanac.Value;
                        listadoUsuarios.Rows[n].Cells[5].Value = TBdireccion.Text;
                        listadoUsuarios.Rows[n].Cells[6].Value = TBemail.Text;
                        listadoUsuarios.Rows[n].Cells[7].Value = TBtelefono.Text;
                        listadoUsuarios.Rows[n].Cells[9].Value = CBRol.Text;

                        if (rBactivo.Checked)
                        {
                            listadoUsuarios.Rows[n].Cells[10].Value = "Activo";
                        }
                        else
                        {
                            listadoUsuarios.Rows[n].Cells[10].Value = "Inactivo";
                        }

                        Limpiar();
                    }
                }
            }
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
            else
            {
                if (C_negocio.Validaciones.mensajeEliminar())
                {
                    Limpiar();
                }
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
