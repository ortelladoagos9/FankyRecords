using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Vendedor
{
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
            this.CBbuscarProductos.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscador.Text))
            {
                MessageBox.Show("Debe escribir el código, nombre, categoria o estado de un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoProductos.Rows.Clear();
        }
    }
}
