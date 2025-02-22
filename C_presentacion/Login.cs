using FankyRecords.C_presentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Administrativo;
using FankyRecords.C_presentacion.Vendedor;
using FankyRecords.C_entidad;

namespace FankyRecords.C_presentacion
{
    public partial class Login : Form
    {
        private readonly NegocioUsuarios CN_Usuarios;
        private readonly NegocioRol CN_Rol;

        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;         
            CN_Rol = new NegocioRol();
            CN_Usuarios = new NegocioUsuarios();
        }

        private void Bingresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            List<Usuarios> ListaUsuario = CN_Usuarios.ListarUsuarios();
            var ousuario = ListaUsuario.Where(u => u.Dni == TBDni.Text && u.Clave == TBClave.Text).FirstOrDefault();

            if (C_negocio.Validaciones.EstaVacio(TBDni.Text) || C_negocio.Validaciones.EstaVacio(TBClave.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verificar que el usuario exista
                if (ousuario == null)
                {
                    MessageBox.Show("Los datos ingresados no coinciden con ningún usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBDni.Clear();
                    TBClave.Clear();
                    return;
                }

                // Asignar el usuario autenticado a la clase estática
                SesionUsuario.UsuarioActual = ousuario;

                if (ousuario.Obj_rol.Descripcion == "Administrador")
                {
                    // Menu administrador
                    Form menuAdministrador = new FormMenuAdmin();

                    // Mostrar el formulario
                    menuAdministrador.Show();

                    this.Hide();
                }
                else if (ousuario.Obj_rol.Descripcion == "Administrativo")
                {
                    // Menu administrativo
                    Form menuAdministrativo = new FormMenuAdministrativo();

                    // Mostrar el formulario
                    menuAdministrativo.Show();
                    this.Hide();

                }
                else if (ousuario.Obj_rol.Descripcion == "Vendedor")
                {
                    // Menu Vendedor
                    Form menuVendedor = new FormMenuVendedor();

                    // Mostrar el formulario
                    menuVendedor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no coinciden con ningún usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBDni.Clear();
                    TBClave.Clear();
                }
            }
        }
        
        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void Bsalir_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();  // Llama al método Ingresar cuando se presiona Enter
                e.SuppressKeyPress = true;  // Evita el sonido de la tecla
            }
        }
    }
}
