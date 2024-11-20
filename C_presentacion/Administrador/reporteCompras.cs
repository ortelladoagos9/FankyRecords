using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
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
    public partial class reporteCompras : Form
    {
        private readonly NegocioReporte CN_Reporte;

        public reporteCompras()
        {
            InitializeComponent();
            CN_Reporte = new NegocioReporte();
            this.CBproveedor.SelectedIndex = 0; 
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechas();              
        }

        private void CompararFechas()
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
            return;
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            CompararFechas();
        }

        private void buscarReg_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBBuscadorCompras.Text))
            {
                MessageBox.Show("Debe ingresar un dato de la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reporteCompras_Load(object sender, EventArgs e)
        {
            CargarReporteCompra();
        }

        private void CargarReporteCompra()
        {
            List<ReporteCompras> reporteCompra = CN_Reporte.Compra(DTinicio.Text, DTfin.Text, int.Parse(CBproveedor.Text));
            listadoReporteCompras.DataSource = reporteCompra;
        }

    }
}
