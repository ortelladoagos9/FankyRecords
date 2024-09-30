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

namespace FankyRecords.C_presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Bingresar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBDni.Text) || C_negocio.Validaciones.EstaVacio(TBClave.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TBDni.Text == "101010" && TBClave.Text == "123")
                {
                     // Menu administrador
                     Form menuAdministrador = new FormMenuAdmin();

                     // Mostrar el formulario
                     menuAdministrador.Show();

                     this.Hide();
                } 
                else if (TBDni.Text == "202020" && TBClave.Text == "456")
                {
                    // Menu administrativo
                    Form menuAdministrativo = new FormMenuAdministrativo();

                    // Mostrar el formulario
                    menuAdministrativo.Show();
                    this.Hide();

                } else if (TBDni.Text == "303030" && TBClave.Text == "789")
                {
                    // Menu Vendedor
                    Form menuVendedor = new FormMenuVendedor();

                    // Mostrar el formulario
                    menuVendedor.Show();
                    this.Hide();
                } else
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
            DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?",
                                                      "Confirmación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
