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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario 'ventas'
            ventas ventas = new ventas();

            // Especificar que el formulario de ventas es hijo del MDI Parent
            ventas.MdiParent = this;

            // Mostrar el formulario de ventas
            ventas.Show();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
