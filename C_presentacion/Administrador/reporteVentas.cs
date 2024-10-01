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
    public partial class reporteVentas : Form
    {
        public reporteVentas()
        {
            InitializeComponent();
        }

        private void DTfin_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            
            DateTime fecha1 = DTinicio.Value;
            DateTime fecha2 = DTfin.Value;

            // Comparar las fechas
            int resultado = DateTime.Compare(fecha1, fecha2);

            // Establecer la condición basada en la comparación
            if (resultado > 0)
            {
                // fecha1 es posterior a fecha2
                MessageBox.Show("La fecha de inicio es posterior a la fecha de fin!");
            }
        }

        
    }
}
