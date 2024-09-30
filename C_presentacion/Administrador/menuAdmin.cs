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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            
            this.Size = new Size(1200, 820);
        }

        private void IconSalirAdministrador_Click(object sender, EventArgs e)
        {
            // volver al login
            Form login = new Login();
            login.Show();
            this.Hide();    
        }

        private void IconExpandirAdministrador_Click(object sender, EventArgs e)
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

        private void IconMinimizarAdministrador_Click(object sender, EventArgs e)
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
        
        private void MenuUsuariosAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new GestionUsuarios());
        }

        private void MenuProductoAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new gestionProductos());
        }

        private void SubmenuRegistrarVentasAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new registrarVentas());
        }

        private void MenuProveedorAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new GestionProveedores());
        }

        private void MenuCategoriaAdministrativo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new GestionCategorias());
        }
        private void SubmenuRegistrarComprasAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new registrarCompra());
        }
    }
}
