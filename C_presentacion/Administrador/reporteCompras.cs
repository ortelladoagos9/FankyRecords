using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using FankyRecords.C_presentacion.Modales;



namespace FankyRecords.C_presentacion.Administrador
{
    public partial class reporteCompras : Form
    {
        private readonly NegocioReporte CN_Reporte;
        private readonly NegocioProveedores CN_Proveedor;

        public reporteCompras()
        {
            InitializeComponent();
            CN_Reporte = new NegocioReporte();
            CN_Proveedor = new NegocioProveedores();
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechas();              
        }

        public void CompararFechas()
        {
            listadoReporteCompras.Rows.Clear();

            //Convertir un datetimepicker en string
            string fechaComoString1 = DTinicio.Value.ToString();
            string fechaComoString2 = DTfin.Value.ToString();

            //Convertir un string en datetime
            DateTime fecha1 = DateTime.Parse(fechaComoString1);
            DateTime fecha2 = DateTime.Parse(fechaComoString2);
            int ID_proveedor = Convert.ToInt32(((OpcionCombo)CBproveedor.SelectedItem).Valor.ToString());


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
                List<ReporteCompras> lista = new List<ReporteCompras>();

                lista = CN_Reporte.Compra(
                    DTinicio.Value,
                    DTfin.Value,
                    ID_proveedor
                    );

                // Verificar si la lista tiene datos
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para el rango de fechas y proveedor seleccionados.");
                    return;
                }
                listadoReporteCompras.Rows.Clear();

                foreach(ReporteCompras rc in lista)
                {
                    listadoReporteCompras.Rows.Add(new object[]
                    {
                        rc.FechaCompra,
                        rc.NumeroCompra,
                        rc.NumeroFactura,
                        rc.TipoDoc,
                        rc.CodigoProducto,
                        rc.NombreProducto,
                        rc.DescripcionProducto,
                        rc.CuitProveedor,
                        rc.RazonSocial,
                        rc.PrecioCompra,
                        rc.Cantidad,
                        rc.MontoTotal,
                        rc.UsuarioRegistro,
                    });
                }
            }
        }

        public void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            Grafico();
        }

        public void Grafico()
        {
            if (listadoReporteCompras.Rows.Count == 0 || (listadoReporteCompras.Rows.Count == 1 && listadoReporteCompras.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Pasa el DataGridView a MDRepCompras
                using (var modal = new MDRepCompras(listadoReporteCompras)) // Pasa el DataGridView al constructor
                {
                    modal.ShowDialog(); // Mostrar el modal
                }
            }
        }

        private void reporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedores> lista =   CN_Proveedor.ListarProveedores();

            CBproveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            foreach (Proveedores item in lista)
            {
                CBproveedor.Items.Add(new OpcionCombo() { Valor = item.ID_proveedor, Texto = item.RazonSocial});
            }

            CBproveedor.DisplayMember = "Texto";
            CBproveedor.ValueMember = "Valor";
            CBproveedor.SelectedIndex = 0;
        }

        private void descargarExcel_Click(object sender, EventArgs e)
        {
            if(listadoReporteCompras.Rows.Count == 0 || (listadoReporteCompras.Rows.Count == 1 && listadoReporteCompras.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach(DataGridViewColumn columna in listadoReporteCompras.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in listadoReporteCompras.Rows)
                {
                    if (row.Visible)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < listadoReporteCompras.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value?.ToString() ?? string.Empty;
                        }
                        dt.Rows.Add(dataRow);
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if(savefile.ShowDialog() == DialogResult.OK)
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
                        MessageBox.Show("Error al generar el reporte de compras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listadoReporteCompras.Rows.Clear();
            CBproveedor.SelectedIndex = 0;
        }
    }
}
