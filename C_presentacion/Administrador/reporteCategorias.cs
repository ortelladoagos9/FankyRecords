using ClosedXML.Excel;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;
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
    public partial class reporteCategorias : Form
    {
        private readonly NegocioReporte CN_Reporte;
        private readonly NegocioCategorias CN_Categorias;

        public reporteCategorias()
        {
            InitializeComponent();
            CN_Reporte = new NegocioReporte();
            CN_Categorias = new NegocioCategorias();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechasCargarDatos();
        }

        public void CompararFechasCargarDatos()
        {
            listadoReporteCategoria.Rows.Clear();

            //Convertir un datetimepicker en string
            string fechaComoString1 = DTinicio.Value.ToString();
            string fechaComoString2 = DTfin.Value.ToString();

            //Convertir un string en datetime
            DateTime fecha1 = DateTime.Parse(fechaComoString1);
            DateTime fecha2 = DateTime.Parse(fechaComoString2);
            int id_categoria = Convert.ToInt32(((OpcionCombo)CBcategoria.SelectedItem).Valor.ToString());

            if (fecha1 == fecha2)
            {
                MessageBox.Show("Las fechas deben ser diferentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Comparar las fechas
            int resultado = DateTime.Compare(fecha1, fecha2);

            // Establecer la condición basada en la comparación
            if (resultado > 0)
            {
                // fecha1 es posterior a fecha2
                MessageBox.Show("La fecha de inicio es posterior a la fecha de fin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<ReporteCategorias> lista = new List<ReporteCategorias>();

                lista = CN_Reporte.ReporteCategorias
                (
                    DTinicio.Value,
                    DTfin.Value,
                    id_categoria
                );

                // Verificar si la lista tiene datos
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el rango de fechas y categoría seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listadoReporteCategoria.Rows.Clear();

                foreach (ReporteCategorias rc in lista)
                {
                    listadoReporteCategoria.Rows.Add(new object[]
                    {
                        rc.FechaVenta.ToString("dd/MM/yyyy"),
                        rc.NumeroFactura,
                        rc.TipoDoc,
                        rc.Categoria,
                        rc.CodigoProducto,
                        rc.NombreProducto,
                        rc.DescripcionProducto,
                        rc.PrecioVenta.ToString("N2"),
                        rc.Cantidad,
                        rc.SubTotal.ToString("N2"),
                        rc.UsuarioRegistro,
                    });
                }
            }
        }

        private void reporteCategorias_Load(object sender, EventArgs e)
        {
            List<Categorias> listaCategorias = CN_Categorias.ListarCategorias();
            var categoriasActivas = listaCategorias.Where(c => c.Estado == "Activo").ToList();

            CBcategoria.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            foreach (Categorias item in categoriasActivas)
            {
                CBcategoria.Items.Add(new OpcionCombo() { Valor = item.Id_categoria, Texto = item.Descripcion });
            }

            CBcategoria.DisplayMember = "Texto";
            CBcategoria.ValueMember = "Valor";
            CBcategoria.SelectedIndex = 0;

            DTinicio.MaxDate = DateTime.Now.Date;
            DTinicio.Value = DateTime.Now.Date;
            DTinicio.Format = DateTimePickerFormat.Short;

            DTfin.MaxDate = DateTime.Now.Date;
            DTfin.Value = DateTime.Now.Date;
            DTfin.Format = DateTimePickerFormat.Short;
        }

        private void descargarExcel_Click(object sender, EventArgs e)
        {
            if (listadoReporteCategoria.Rows.Count == 0 || (listadoReporteCategoria.Rows.Count == 1 && listadoReporteCategoria.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in listadoReporteCategoria.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in listadoReporteCategoria.Rows)
                {
                    if (row.Visible)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < listadoReporteCategoria.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                        }
                        dt.Rows.Add(dataRow);
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCategorias_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
                        MessageBox.Show("Error al generar el reporte de categorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listadoReporteCategoria.Rows.Clear();
            CBcategoria.SelectedIndex = 0;
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            Grafico();
        }

        public void Grafico()
        {
            if (listadoReporteCategoria.Rows.Count == 0 || (listadoReporteCategoria.Rows.Count == 1 && listadoReporteCategoria.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Pasa el DataGridView a MDRepCategorias
                using (var modal = new MDRepCategorias(listadoReporteCategoria)) // Pasa el DataGridView al constructor
                {
                    // Pasar la fecha de inicio al TextBox
                    modal.TextBoxFecha.Text = DTinicio.Value.ToString("dd/MM/yyyy"); // Aquí formateamos la fecha

                    // Pasar la fecha de fin al TextBox 
                    modal.TextBoxFecha2.Text = DTfin.Value.ToString("dd/MM/yyyy"); // Aquí formateamos la fecha

                    modal.ShowDialog(); // Mostrar el modal
                }
            }
        }
    }
}
