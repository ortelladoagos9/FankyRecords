using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class formMenuAdmin : Form
    {
        public formMenuAdmin()
        {
            InitializeComponent();
        }

        private void iconMenuItemSalirAdministrador_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMenuItemExpandirAdministrador_Click(object sender, EventArgs e)
        {
            // Si el formulario ya está maximizado, restaurarlo
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;  // Restaurar el tamaño normal
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;  // Maximizar el formulario
            }
        }

        private void iconMenuItemMinimizarAdministrador_Click(object sender, EventArgs e)
        {
            // Cambia el estado del formulario a minimizado
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Limpiar cualquier formulario previamente abierto
            if (this.contenedorAdministrador.Controls.Count > 0)
            {
                foreach (Form frm in this.contenedorAdministrador.Controls.OfType<Form>())
                {
                    frm.Close(); // Cierra cualquier formulario abierto
                }
                this.contenedorAdministrador.Controls.Clear(); // Limpia el contenedor
            }
           
            // Configurar el nuevo formulario
            formulario.TopLevel = false; // Indica que el formulario no es de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Eliminar bordes del formulario
            formulario.Dock = DockStyle.Fill; // Acomoda el formulario para ocupar todo el contenedor
            this.contenedorAdministrador.Controls.Add(formulario); // Agrega el formulario al contenedor
            this.contenedorAdministrador.Tag = formulario; // Asocia el formulario al contenedor
            formulario.BringToFront(); // Trae el formulario al frente
            formulario.Show(); // Muestra el formulario
        }
        
        private void iconMenuItemUsuariosAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new GestionUsuarios());
        }

        
    }
}
