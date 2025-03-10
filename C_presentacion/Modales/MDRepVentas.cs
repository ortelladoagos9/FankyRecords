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
using FankyRecords.C_presentacion.Administrador;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepVentas : Form
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


        private readonly reporteVentas C_Reporte;
        private readonly DataGridView listadoReporteVentas; // Guarda el DataGridView
        public Chart GraficoVentas { get; set; }



        // Recibe el DataGridView en el constructor
        public MDRepVentas(DataGridView listadoReporteVentas)
        {
            InitializeComponent();
            this.listadoReporteVentas = listadoReporteVentas; // Asigna el DataGridView recibido
            C_Reporte = new reporteVentas();

            this.KeyPreview = true;

            // Inicializar el gráfico
            GraficoVentas = new Chart();
            GraficoVentas.Dock = DockStyle.Fill;

            Controls.Add(GraficoVentas);

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("MainArea");
            GraficoVentas.ChartAreas.Add(chartArea);
        }

        public void crearGrafico()
        {
            Dictionary<string, int> acumuladorProducto = new Dictionary<string, int>();

            // Acceder al DataGridView
            foreach (DataGridViewRow row in listadoReporteVentas.Rows)
            {
                if (row.IsNewRow) continue;

                string producto = row.Cells["NombreProducto"].Value?.ToString();
                if (string.IsNullOrEmpty(producto)) continue;

                int cantidadProductos = 0;
                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidadProductos))
                {
                    if (acumuladorProducto.ContainsKey(producto))
                        acumuladorProducto[producto] += cantidadProductos;
                    else
                        acumuladorProducto[producto] = cantidadProductos;
                }
            }

            // Calcular el total de productos vendidos
            int totalProductos = acumuladorProducto.Values.Sum();
            if (totalProductos == 0) return; // Evitar errores si no hay productos

            // Crear el gráfico
            GraficoVentas.Series.Clear();
            Series serie = new Series
            {
                Name = "Productos",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie,
                LabelFormat = "P2", // Formato de porcentaje con 2 decimales
            };
            GraficoVentas.Series.Add(serie);

            // Configurar la leyenda
            GraficoVentas.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Right, // Ubicar la leyenda a la derecha
                Font = new Font("Century Schoolbook", 12, FontStyle.Bold), // Fuente más grande para la leyenda
                BackColor = Color.Transparent
            };
            GraficoVentas.Legends.Add(legend);

            // Lista de colores vivos
            Color[] coloresVivos = new Color[]
            {
                Color.FromArgb(255, 99, 132), // Rojo vibrante
                Color.FromArgb(0, 0, 205), 
                Color.FromArgb(255, 206, 86), // Amarillo brillante
                Color.FromArgb(75, 192, 192), // Verde turquesa
                Color.FromArgb(153, 102, 255), // Morado vibrante
                Color.FromArgb(255, 159, 64), // Naranja fuerte
                Color.FromArgb(255, 105, 180),
                Color.FromArgb(0, 191, 255),                
                Color.FromArgb(127, 255, 212),
                Color.FromArgb(178, 34, 34),
                Color.FromArgb(75, 0, 130),
                Color.FromArgb(199, 21, 133),
                Color.FromArgb(46, 139, 87),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(0, 255, 0),
                Color.FromArgb(255, 20, 147),
            };

            int colorIndex = 0;

            // Agregar puntos al gráfico
            foreach (var producto in acumuladorProducto)
            {
                double porcentaje = (double)producto.Value / totalProductos; // Calcular porcentaje

                DataPoint punto = new DataPoint
                {
                    Label = porcentaje.ToString("P2"), // Mostrar en porcentaje
                    LegendText = producto.Key, // Mostrar el nombre en la leyenda
                    Font = new Font("Century Schoolbook", 11, FontStyle.Bold) // Fuente más grande para el porcentaje
                };

                punto.SetValueXY(producto.Key, producto.Value);
                punto.ToolTip = $"{producto.Key}: {producto.Value} unidades ({porcentaje:P2})";

                // Asignar un color vibrante
                punto.Color = coloresVivos[colorIndex % coloresVivos.Length];
                colorIndex++;

                // Mover las etiquetas hacia afuera
                punto.LabelForeColor = Color.Black; // Cambia el color del texto para mejor visibilidad
                punto.LabelAngle = 0; // Asegura que el texto esté recto
                punto.LabelFormat = "P2"; // Formato de porcentaje
                punto.LabelForeColor = Color.Black; // Color del texto
                punto["PieLabelStyle"] = "Outside"; // Mueve las etiquetas fuera del círculo

                serie.Points.Add(punto);
            }

            // Configurar las líneas guía de las etiquetas
            serie["PieLineColor"] = "Black"; // Hace que las líneas de guía sean negras

            // Forzar redibujo del gráfico
            GraficoVentas.Invalidate();
            GraficoVentas.Update();
            GraficoVentas.Refresh();

            // Mostrar el gráfico
            GraficoVentas.Visible = true;
        }


        private void MDRepVentas_Load(object sender, EventArgs e)
        {
            // Agregar título al gráfico
            Title title = new Title("Gráfico de Ventas de Productos");
            GraficoVentas.Titles.Add(title);

            // Cambiar el estilo de la fuente del título
            Font titleFont = new Font("Century Schoolbook", 16f, FontStyle.Bold);
            title.Font = titleFont;
            // Cambiar el color del título a DarkRed
            title.ForeColor = Color.DarkRed;

            // Configurar los ejes con sus títulos
            ChartArea chartAreaConfig = GraficoVentas.ChartAreas["MainArea"];

            crearGrafico(); // Crear el gráfico al cargar el formulario
        }  
    }
}
