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

        private void CompararFechas()
        {
            DateTime fecha1 = DTinicio.Value;
            DateTime fecha2 = DTfin.Value;
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
                    DTinicio.Value.ToString(),
                    DTfin.Value.ToString(),
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
            
            List<Proveedores> lista =  CN_Proveedor.ListarProveedores();

            //CBproveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
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

            }
        }
    }
}
