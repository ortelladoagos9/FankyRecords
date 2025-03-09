using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class reporteVentas : Form
    {

        private readonly NegocioReporte CN_Reporte;
        private readonly NegocioProductos CN_Producto;

        public reporteVentas()
        {
            InitializeComponent();
            CN_Reporte = new NegocioReporte();
            CN_Producto = new NegocioProductos();
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechas();
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            Grafico();
        }

        public void Grafico()
        {

            if (listadoReporteVentas.Rows.Count == 0 || (listadoReporteVentas.Rows.Count == 1 && listadoReporteVentas.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                // Pasa el DataGridView a MDRepCompras
                using (var modal = new MDRepVentas(listadoReporteVentas)) // Pasa el DataGridView al constructor
                {
                    // Pasar la fecha de inicio al TextBox de MDRepCompras
                    modal.TextBoxFecha.Text = DTinicio.Value.ToString("dd/MM/yyyy"); // Aquí formateamos la fecha

                    // Pasar la fecha de fin al TextBox de MDRepCompras
                    modal.TextBoxFecha2.Text = DTfin.Value.ToString("dd/MM/yyyy"); // Aquí formateamos la fecha

                    modal.ShowDialog(); // Mostrar el modal
                }
            }
        }

        private void CompararFechas()
        {

            listadoReporteVentas.Rows.Clear();

            //Convertir un datetimepicker en string
            string fechaComoString1 = DTinicio.Value.ToString();
            string fechaComoString2 = DTfin.Value.ToString();

            //Convertir un string en datetime
            DateTime fecha1 = DateTime.Parse(fechaComoString1);
            DateTime fecha2 = DateTime.Parse(fechaComoString2);
            
            // Comparar las fechas
            int resultado = DateTime.Compare(fecha1, fecha2);

            // Establecer la condición basada en la comparación
            if (resultado > 0)
            {
                // fecha1 es posterior a fecha2
                MessageBox.Show("La fecha de inicio es posterior a la fecha de fin!");
                return;
            }
            else
            {
                List<ReporteVentas> lista = new List<ReporteVentas>();

                lista = CN_Reporte.Venta(
                    DTinicio.Value,
                    DTfin.Value
                );

                // Verificar si la lista tiene datos
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el rango de fechas seleccionadas.");
                    return;
                }

                listadoReporteVentas.Rows.Clear();

                foreach (ReporteVentas rv in lista)
                {
                    listadoReporteVentas.Rows.Add(new object[]
                    {
                        rv.FechaVenta,
                        rv.ID_Tipo_Doc,
                        rv.NumeroFactura,
                        rv.ID_cliente,
                        rv.CodigoProducto,
                        rv.NombreProducto,
                        rv.Categoria,
                        rv.Precioventa.ToString("N2"),
                        rv.Cantidad,
                        rv.MontoTotal.ToString("N2")
                    });
                }
            }
        }
  
        private void reporteVentas_Load(object sender, EventArgs e)
        {
            
            DTinicio.MaxDate = DateTime.Now.Date;
            DTinicio.Value = DateTime.Now.Date;
            DTinicio.Format = DateTimePickerFormat.Short;

            DTfin.MaxDate = DateTime.Now.Date;
            DTfin.Value = DateTime.Now.Date;
            DTfin.Format = DateTimePickerFormat.Short;
        }

        private void DTinicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listadoReporteVentas.Rows.Clear();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void descargarExcel_Click(object sender, EventArgs e)
        {
            if (listadoReporteVentas.Rows.Count == 0 || (listadoReporteVentas.Rows.Count == 1 && listadoReporteVentas.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in listadoReporteVentas.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in listadoReporteVentas.Rows)
                {
                    if (row.Visible)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < listadoReporteVentas.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                        }
                        dt.Rows.Add(dataRow);
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte generado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte de ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
