using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Administrador;



namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepCompras : Form
    {

        private readonly reporteCompras C_Reporte;
        private readonly DataGridView listadoReporteCompras; // Guarda el DataGridView
        public Chart GraficoCompras { get; set; }


        // Recibe el DataGridView en el constructor
        public MDRepCompras(DataGridView listadoReporteCompras)
        {
            InitializeComponent();
            this.listadoReporteCompras = listadoReporteCompras; // Asigna el DataGridView recibido
            C_Reporte = new reporteCompras();

            this.KeyPreview = true;

            // Inicializar el gráfico
            GraficoCompras = new Chart();
            GraficoCompras.Dock = DockStyle.Fill;
            
            Controls.Add(GraficoCompras);

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("MainArea");
            GraficoCompras.ChartAreas.Add(chartArea);
        }

        // Crear gráfico de torta
        public void crearGrafico()
        {
            // Contar las apariciones de cada proveedor
            Dictionary<string, int> proveedorContador = new Dictionary<string, int>();

            // Acceder al DataGridView pasado
            foreach (DataGridViewRow row in listadoReporteCompras.Rows)
            {
                if (row.IsNewRow) continue;
                string proveedor = row.Cells["RazonSocial"].Value?.ToString(); // Usa el operador null-conditional (?.)
                if (string.IsNullOrEmpty(proveedor)) continue;  // Ignora filas sin valor de proveedor

                if (proveedorContador.ContainsKey(proveedor))
                {
                    proveedorContador[proveedor]++;
                }
                else
                {
                    proveedorContador[proveedor] = 1;
                }
            }

            // Crear el gráfico
            GraficoCompras.Series.Clear();
            Series serie = new Series
            {
                Name = "Proveedores",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            GraficoCompras.Series.Add(serie);

            // Agregar puntos al gráfico
            foreach (var proveedor in proveedorContador)
            {
                serie.Points.AddXY(proveedor.Key, proveedor.Value);
            }

            // Forzar redibujo del gráfico
            GraficoCompras.Invalidate();
            GraficoCompras.Update();
            GraficoCompras.Refresh();

            // Verificar si el gráfico es visible
            GraficoCompras.Visible = true;
        }

        public void MDRepCompras_Load(object sender, EventArgs e)
        {
            GraficoCompras.Titles.Add("Gráfico de Compras por Proveedor");
            this.Size = new Size(800, 600); // Ajusta el tamaño del formulario para permitir mostrar el gráfico
            crearGrafico(); // Crear el gráfico al cargar el formulario
        }

        private void graficoCompras_Click(object sender, EventArgs e)
        {

        }










        /*private readonly reporteCompras C_Reporte;
        

        public Chart GraficoCompras { get; set; }
        
        public MDRepCompras()
        {
            InitializeComponent();
            C_Reporte = new reporteCompras();
            

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


        // Crear gráfico de torta
        public void crearGrafico(reporteCompras reporteCompras)
        {
            // Contar las apariciones de cada proveedor
            Dictionary<string, int> proveedorContador = new Dictionary<string, int>();
            foreach (DataGridViewRow row in reporteCompras.listadoReporteCompras.Rows)
            {
                if (row.IsNewRow) continue;
                string proveedor = row.Cells["RazonSocial"].Value.ToString();
                if (string.IsNullOrEmpty(proveedor)) continue;  // Ignora filas sin valor de proveedor

                if (proveedorContador.ContainsKey(proveedor))
                {
                    proveedorContador[proveedor]++;
                }
                else
                {
                    proveedorContador[proveedor] = 1;
                }
            }

            GraficoCompras.Series.Clear();
            Series serie = new Series
            {
                Name = "Proveedores",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };
            GraficoCompras.Series.Add(serie);

            foreach (var proveedor in proveedorContador)
            {
                // Verificar que los datos se están agregando correctamente
                MessageBox.Show($"Proveedor: {proveedor.Key}, Cantidad: {proveedor.Value}");
                serie.Points.AddXY(proveedor.Key, proveedor.Value);
            }

            // Forzar redibujo del gráfico
            GraficoCompras.Invalidate();
            GraficoCompras.Update();
            GraficoCompras.Refresh();


            // Verificar si el gráfico es visible
            GraficoCompras.Visible = true;
        }

        public void MDRepCompras_Load(object sender, EventArgs e)
        {
            GraficoCompras.Titles.Add("Gráfico de Compras por Proveedor");
            this.Size = new Size(800, 600); // Ajusta el tamaño del formulario para permitir mostrar el gráfico



        }*/
    }
}
