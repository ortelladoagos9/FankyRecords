using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FankyRecords.C_presentacion.Administrador;

namespace FankyRecords.C_presentacion.Modales
{
    public partial class MDRepCompras : Form
    {
        // Propiedad pública para acceder al TextBox
        public TextBox TextBoxFecha
        {
            get { return this.TBfechaInicio; }
            set { this.TBfechaInicio.Text = value.Text; }
        }
        // Propiedad pública para acceder al TextBox
        public TextBox TextBoxFecha2
        {
            get { return this.TBfechaFin; }
            set { this.TBfechaFin.Text = value.Text; }
        }
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

        // Crear gráfico de barras
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


                // Obtener la cantidad de productos adquiridos en esta fila
                int cantidadProductos = 0;
                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidadProductos))
                {
                    // Sumar la cantidad de productos al proveedor correspondiente
                    if (proveedorContador.ContainsKey(proveedor))
                    {
                        proveedorContador[proveedor] += cantidadProductos; // Sumar a la cantidad total de productos
                    }
                    else
                    {
                        proveedorContador[proveedor] = cantidadProductos; // Inicializar la cantidad de productos
                    }
                }
            }

            // Crear el gráfico
            GraficoCompras.Series.Clear();
            Series serie = new Series
            {
                Name = "Proveedores",
                IsValueShownAsLabel = false,
                ChartType = SeriesChartType.Column,
                LabelFormat = "0", // Si solo quieres mostrar los números de las compras
            };
            GraficoCompras.Series.Add(serie);

            // Lista de colores para diferenciar cada categoría
            Color[] colores = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Yellow };
            int colorIndex = 0;

            // Agregar puntos al gráfico
            foreach (var proveedor in proveedorContador)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(proveedor.Key, proveedor.Value);
                punto.Color = colores[colorIndex % colores.Length]; // Asigna un color distinto a cada barra
                punto.ToolTip = $"{proveedor.Key}: ({proveedor.Value})";

                serie.Points.Add(punto);
                colorIndex++; // Cambia al siguiente color en la lista
            }

            // Configuración del eje X ()
            GraficoCompras.ChartAreas[0].AxisX.Title = "Proveedores";
            GraficoCompras.ChartAreas[0].AxisX.TitleFont = new Font("Century Schoolbook", 16, FontStyle.Bold);
            GraficoCompras.ChartAreas[0].AxisX.TitleForeColor = Color.Gray;
            GraficoCompras.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Schoolbook", 14, FontStyle.Bold);
            GraficoCompras.ChartAreas[0].AxisX.Interval = 1;

            // Configuración del eje Y (
            GraficoCompras.ChartAreas[0].AxisY.Title = "Cantidad de productos comprados";
            GraficoCompras.ChartAreas[0].AxisY.TitleFont = new Font("Century Schoolbook", 16, FontStyle.Bold);
            GraficoCompras.ChartAreas[0].AxisY.TitleForeColor = Color.Gray;
            GraficoCompras.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Schoolbook", 14, FontStyle.Bold);
            GraficoCompras.ChartAreas[0].AxisY.Interval = 10; 

            // Forzar redibujo del gráfico
            GraficoCompras.Invalidate();
            GraficoCompras.Update();
            GraficoCompras.Refresh();

            // Verificar si el gráfico es visible
            GraficoCompras.Visible = true;
        }

        public void MDRepCompras_Load(object sender, EventArgs e)
        {
            // Agregar título al gráfico
            Title title = new Title("Gráfico de Compras por Proveedor");
            GraficoCompras.Titles.Add(title);

            // Cambiar el estilo de la fuente del título
            Font titleFont = new Font("Century Schoolbook", 16f, FontStyle.Bold);
            title.Font = titleFont;
            // Cambiar el color del título a DarkRed
            title.ForeColor = Color.DarkRed;

            crearGrafico(); // Crear el gráfico al cargar el formulario
        }
    }
}
