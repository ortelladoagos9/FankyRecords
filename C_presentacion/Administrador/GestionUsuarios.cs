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

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionUsuarios : Form
    {
    
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdireccion.Text) ||
               C_negocio.Validaciones.EstaVacio(TBemail.Text) ||
               C_negocio.Validaciones.EstaVacio(TBclave.Text) ||
               C_negocio.Validaciones.EstaVacio(TBconfirmarClave.Text) ||
               C_negocio.Validaciones.EstaVacio(CBRol.Text) ||
               C_negocio.Validaciones.EstaVacio(TBtelefono.Text) ||
               C_negocio.Validaciones.EstaVacio(rutaFoto.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
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
                       int n = listadoUsuarios.Rows.Add();

                       listadoUsuarios.Rows[n].Cells[0].Value = 0;
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

                       // limpia campos
                       TBnombre.Clear();
                       TBapellido.Clear();
                       rutaFoto.Clear();
                       TBdireccion.Clear();
                       TBtelefono.Clear();
                       TBdni.Clear();
                       TBemail.Clear();
                       picFotoUsuario.Image = null;
                       TBclave.Clear();
                       TBconfirmarClave.Clear();
                       CBRol.SelectedIndex = -1;  // Deselect the ComboBox
                       
                       MessageBox.Show("Los datos han sido guardados correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La operación de guardado ha sido cancelada.",
                                         "Cancelado",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
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
                // Selección del directorio de destino
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione el directorio donde guardar las fotos de los usuarios";
                    folderDialog.ShowNewFolderButton = true;

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaDirectorio = folderDialog.SelectedPath;
                        string ruta = Path.Combine(rutaDirectorio, NombreArchivo(openFileDialog1.FileName));

                        try
                        {
                            // Copiar el archivo seleccionado al directorio elegido
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
            }
        }

        private string NombreArchivo(string ruta)
        {
            // Simplificación del nombre de archivo
            return Path.GetFileName(ruta);  // Devuelve el nombre del archivo completo con extensión
        }

        private void Beliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoUsuarios.Rows.Clear();

        }
    }
}
