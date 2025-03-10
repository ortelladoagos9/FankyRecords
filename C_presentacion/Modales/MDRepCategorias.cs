using FankyRecords.C_presentacion.Administrador;
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

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepCategorias : Form
    {
        public TextBox TextBoxFecha
        {
            get { return this.TBfechaInicioV; }
            set { this.TBfechaInicioV.Text = value.Text; }
        }
        // Propiedad pública para acceder al TextBox
        public TextBox TextBoxFecha2
        {
            get { return this.TBfechaFinV; }
            set { this.TBfechaFinV.Text = value.Text; }
        }
        private readonly reporteCategorias C_Reporte;
        private readonly DataGridView listadoReporteCategoria; // Guarda el DataGridView
        public Chart GraficoCategorias { get; set; }

        public MDRepCategorias(DataGridView listadoReporteCategoria)
        {
            InitializeComponent();
            this.listadoReporteCategoria = listadoReporteCategoria; // Asigna el DataGridView recibido
            C_Reporte = new reporteCategorias();

            this.KeyPreview = true;

            // Inicializar el gráfico
            GraficoCategorias = new Chart();
            GraficoCategorias.Dock = DockStyle.Fill;

            Controls.Add(GraficoCategorias);

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("MainArea");
            GraficoCategorias.ChartAreas.Add(chartArea);
        }

        private void MDRepCategorias_Load(object sender, EventArgs e)
        {
            // Agregar título al gráfico
            Title title = new Title("Gráfico de cantidad de productos vendidos por categoría");
            GraficoCategorias.Titles.Add(title);

            // Cambiar el estilo de la fuente del título
            Font titleFont = new Font("Century Schoolbook", 16f, FontStyle.Bold);
            title.Font = titleFont;
            // Cambiar el color del título a DarkRed
            title.ForeColor = Color.DarkRed;
           
            crearGrafico(); // Crear el gráfico al cargar el formulario
        }

        public void crearGrafico()
        {
            // Acumulador de productos vendidos por categoría
            Dictionary<string, int> acumuladorCategoria = new Dictionary<string, int>();

            foreach (DataGridViewRow row in listadoReporteCategoria.Rows)
            {
                if (row.IsNewRow) continue;

                string categoria = row.Cells["Categoria"].Value?.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value); // Tomar la cantidad de productos vendidos

                if (string.IsNullOrEmpty(categoria)) continue;

                if (acumuladorCategoria.ContainsKey(categoria))
                {
                    acumuladorCategoria[categoria] += cantidad; // Acumula la cantidad de productos vendidos
                }
                else
                {
                    acumuladorCategoria[categoria] = cantidad;
                }
            }

            // Configuración del gráfico
            GraficoCategorias.Series.Clear();
            GraficoCategorias.ChartAreas.Clear();
            GraficoCategorias.ChartAreas.Add("Area1");

            // Crear la serie de barras
            Series serie = new Series
            {
                Name = "Categorías",
                IsValueShownAsLabel = false, // no Muestra los valores sobre las barras
                ChartType = SeriesChartType.Bar, // Tipo de gráfico de barras horizontal
                BorderWidth = 3 // Borde más grueso    
            };

            GraficoCategorias.Series.Add(serie);

            // Lista de colores para diferenciar cada categoría
            Color[] colores = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Yellow };
            int colorIndex = 0;

            // Agregar los datos de las categorías al gráfico
            foreach (var categoria in acumuladorCategoria)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(categoria.Key, categoria.Value);
                punto.Color = colores[colorIndex % colores.Length]; // Asigna un color distinto a cada barra
                punto.ToolTip = $"{categoria.Key}: {categoria.Value} productos vendidos";

                serie.Points.Add(punto);
                colorIndex++; // Cambia al siguiente color en la lista
            }

            // Configuración del eje X (categorías)
            GraficoCategorias.ChartAreas[0].AxisX.Title = "Categorías";
            GraficoCategorias.ChartAreas[0].AxisX.TitleFont = new Font("Century Schoolbook", 16, FontStyle.Bold);
            GraficoCategorias.ChartAreas[0].AxisX.TitleForeColor = Color.Gray;
            GraficoCategorias.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Schoolbook", 14, FontStyle.Bold);
            GraficoCategorias.ChartAreas[0].AxisX.Interval = 1;

            // Configuración del eje Y (cantidad de productos vendidos)
            GraficoCategorias.ChartAreas[0].AxisY.Title = "Cantidad de productos vendidos";
            GraficoCategorias.ChartAreas[0].AxisY.TitleFont = new Font("Century Schoolbook", 16, FontStyle.Bold);
            GraficoCategorias.ChartAreas[0].AxisY.TitleForeColor = Color.Gray;
            GraficoCategorias.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Schoolbook", 14, FontStyle.Bold);
            GraficoCategorias.ChartAreas[0].AxisY.Interval = 1; // Intervalo de 1 en 1

            // Redibujar el gráfico
            GraficoCategorias.Invalidate();
            GraficoCategorias.Update();
            GraficoCategorias.Refresh();
            GraficoCategorias.Visible = true;
        }
    }
}
