using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrativo
{
    public partial class formMenuAdministrativo : Form
    {
        public formMenuAdministrativo()
        {
            InitializeComponent();
        }

        private void iconMenuItemSalirAdministrativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMenuItemExpandirAdministrativo_Click(object sender, EventArgs e)
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

        private void iconMenuItemMinimizarAdministrativo_Click(object sender, EventArgs e)
        {
            // Cambia el estado del formulario a minimizado
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
