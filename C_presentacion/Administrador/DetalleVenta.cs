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
    public partial class detalleVenta : Form
    {
        public detalleVenta()
        {
            InitializeComponent();
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoVentas.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBNroDoc.Text))
            {
                MessageBox.Show("Debe ingresar el numero de documento para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
