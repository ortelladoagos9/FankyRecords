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

        private void btnVentas_Click(object sender, EventArgs e)
        {

            // Crear una nueva instancia del formulario 'ventas'
           // ventasAdmin ventas = new ventasAdmin();
            //ventas.TopLevel = false;
            //this.panelContenedor.Controls.Add(ventas);

            // Especificar que el formulario de ventas es hijo del MDI Parent
            //ventas.MdiParent = this;

            // Mostrar el formulario de ventas
            //ventas.Show();
            //this.panelContenedor.Controls.(ventas);


           // ventas.BringToFront();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario 'ventas'
            //inicioMenuAdmin inicioMenu = new inicioMenuAdmin();
           
            //this.panel1.Controls.Add(inicioMenu);

            // Especificar que el formulario de ventas es hijo del MDI Parent
         //   inicioMenu.MdiParent = this;

            // Mostrar el formulario de ventas
          //  inicioMenu.Show();


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

        
    }
}
