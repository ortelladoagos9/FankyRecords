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

        // Crear gráfico de torta
        public void crearGrafico()
        {
            // Contar las apariciones de cada proveedor
            Dictionary<string, int> productoContador = new Dictionary<string, int>();

            // Acceder al DataGridView pasado
            foreach (DataGridViewRow row in listadoReporteVentas.Rows)
            {
                if (row.IsNewRow) continue;

                string producto = row.Cells["nomProducto"].Value?.ToString(); // Usa el operador null-conditional (?.)
                if (string.IsNullOrEmpty(producto)) continue;  // Ignora filas sin valor de proveedor


                // Obtener la cantidad de productos adquiridos en esta fila
                int cantidadProductos = 0;
                if (int.TryParse(row.Cells["cantidad"].Value?.ToString(), out cantidadProductos))
                {
                    // Sumar la cantidad de productos al proveedor correspondiente
                    if (productoContador.ContainsKey(producto))
                    {
                        productoContador[producto] += cantidadProductos; // Sumar a la cantidad total de productos
                    }
                    else
                    {
                        productoContador[producto] = cantidadProductos; // Inicializar la cantidad de productos
                    }
                }

            }

            // Crear el gráfico
            GraficoVentas.Series.Clear();
            Series serie = new Series
            {
                Name = "Productos",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie,
                LabelFormat = "0", // Si solo quieres mostrar los números de las compras
            };
            GraficoVentas.Series.Add(serie);

            // Establecer la fuente para los labels de los puntos en el gráfico
            Font labelFont = new Font("Century Schoolbook", 8.2f, FontStyle.Bold);

            // Agregar puntos al gráfico
            foreach (var producto in productoContador)
            {
                // Crear un DataPoint y agregarlo a la serie
                DataPoint punto = new DataPoint();
                punto.SetValueXY(producto.Key, producto.Value);  // Establecer el valor X (Proveedor) y Y (Cantidad)

                // Establecer la etiqueta visible para cada punto en el gráfico
                punto.Label = $"{producto.Value}"; // La cantidad de productos

                // Cambiar la fuente del Label del punto
                punto.Font = labelFont;

                // Establecer el ToolTip para cada punto
                punto.ToolTip = $"{producto.Key} ({producto.Value})"; // Muestra nombre del proveedor en el tooltip

                // Agregar el punto a la serie
                serie.Points.Add(punto);
            }

            // Forzar redibujo del gráfico
            GraficoVentas.Invalidate();
            GraficoVentas.Update();
            GraficoVentas.Refresh();

            // Verificar si el gráfico es visible
            GraficoVentas.Visible = true;
        }


        private void MDRepVentas_Load(object sender, EventArgs e)
        {
            // Agregar título al gráfico
            Title title = new Title("Gráfico de Ventas de Productos");
            GraficoVentas.Titles.Add(title);

            // Cambiar el estilo de la fuente del título
            Font titleFont = new Font("Century Schoolbook", 10.2f, FontStyle.Bold);
            title.Font = titleFont;
            // Cambiar el color del título a DarkRed
            title.ForeColor = Color.DarkRed;

            // Configurar los ejes con sus títulos
            ChartArea chartAreaConfig = GraficoVentas.ChartAreas["MainArea"];

          

            this.Size = new Size(800, 600); // Ajusta el tamaño del formulario para permitir mostrar el gráfico
            crearGrafico(); // Crear el gráfico al cargar el formulario




        }
    }
}
