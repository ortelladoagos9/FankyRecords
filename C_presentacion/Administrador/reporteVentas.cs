using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class reporteVentas : Form
    {

        private readonly NegocioReporte CN_Reporte;

        public reporteVentas()
        {
            InitializeComponent();
            CN_Reporte = new NegocioReporte();
        }

        private void buscarFecha_Click(object sender, EventArgs e)
        {
            CompararFechas();
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            CompararFechas();
        }

        private void CompararFechas()
        {
            DateTime fecha1 = DTinicio.Value;
            DateTime fecha2 = DTfin.Value;

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
                        rv.Precioventa,
                        rv.Cantidad,
                        rv.MontoTotal
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
    }
}
