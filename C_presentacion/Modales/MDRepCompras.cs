using System;
using System.Collections.Generic;
using System.ComponentModel;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FankyRecords.C_presentacion.Administrador;



namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepCompras : Form
    {
        public Chart GraficoCompras { get; set; }

        private readonly NegocioReporte CN_ReporteCompra;
        
        public MDRepCompras()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // Inicializar GraficoCompras y agregarlo al formulario
            GraficoCompras = new Chart();
            GraficoCompras.Dock = DockStyle.Fill;
            GraficoCompras.Width = this.ClientSize.Width;  // Asegura que el gráfico tenga el tamaño del formulario
            GraficoCompras.Height = this.ClientSize.Height;
            Controls.Add(GraficoCompras);

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("MainArea")
            {
                BackColor = Color.White,  // Asegúrate de que el fondo sea visible
                BorderColor = Color.Black,  // Definir un borde visible
                BorderWidth = 1
            };
            GraficoCompras.ChartAreas.Add(chartArea);
          
            //CN_ReporteCompra = new NegocioReporte();

        }

        public void MDRepCompras_Load(object sender, EventArgs e)
        {
            GraficoCompras.Titles.Add("Gráfico de Compras por Proveedor");
            this.Size = new Size(800, 600); // Ajusta el tamaño del formulario para permitir mostrar el gráfico
            

        }
    }
}
