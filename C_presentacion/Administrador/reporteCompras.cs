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
using ClosedXML.Excel;


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
           // this.CBproveedor.SelectedIndex = 0; 
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechas();              
        }

        private void CompararFechas()

        {   
            //Convertir un datetimepicker en string
            string fechaComoString1 = DTinicio.Value.ToString();
            string fechaComoString2 = DTfin.Value.ToString();

            //Convertir un string en datetime
            DateTime fecha1 = DateTime.Parse(fechaComoString1);
            DateTime fecha2 = DateTime.Parse(fechaComoString2);
            int ID_proveedor = Convert.ToInt32(CBproveedor.SelectedValue);
           // int idProveedor = Convert.ToInt32(((OpcionCombo)CBproveedor.SelectedItem).Valor.ToString());


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
                        rc.ID_Tipo_Doc,
                        rc.MontoTotal,
                        rc.CuitProveedor,
                        rc.RazonSocial,
                        rc.CodigoProducto,
                        rc.NombreProducto,
                        rc.PrecioCompra,
                        rc.Cantidad,
                       
                    });
                }


            }
           
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            CompararFechas();
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            if(listadoReporteCompras.Rows.Count < 1)
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
                foreach(DataGridViewRow row in listadoReporteCompras.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),

                        });

                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = string.Format("ReporteCompras_(0).xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    saveFile.Filter = "Excel Files | xlsx";

                    if(saveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XLWorkbook wb = new XLWorkbook();
                            var hoja = wb.Worksheets.Add(dt, "informe");
                            hoja.columnUsed().AdjustToContents();
                            wb.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {

                            MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }

                }



            }
        }

        private void DTinicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
