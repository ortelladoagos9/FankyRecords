using FankyRecords.C_datos;
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
    public partial class detalleVenta : Form
    {
        private NegocioVentas CN_Ventas;

        public detalleVenta()
        {
            InitializeComponent();
            CN_Ventas = new NegocioVentas();
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todas las filas del DataGridView
            listadoVentas.Rows.Clear();
            TBFecha.Clear();
            TBTipoDoc.Clear();
            TBUsuario.Clear();
            TBNroDocumento.Clear();
            TBNombreCompleto.Clear();
            TBTotalPagado.Clear();
            TBNroVenta.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new MDVenta())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBNroVenta.Text = modal.VentaMD.NumeroFactura.ToString();
                    TBFecha.Text = modal.VentaMD.FechaVenta.ToString("dd/MM/yyyy");
                    TBTipoDoc.Text = modal.VentaMD.Obj_Tipo_Doc?.Descripcion ?? "N/A";
                    TBUsuario.Text = modal.VentaMD.Obj_usuarios?.NombreCompleto ?? "N/A";
                    TBNroDocumento.Text = modal.VentaMD.Obj_cliente?.Documento ?? "N/A";
                    TBNombreCompleto.Text = modal.VentaMD.Obj_cliente?.NombreCompleto ?? "N/A";
                    TBTotalPagado.Text = modal.VentaMD.MontoTotal.ToString("N2");
                }
                else
                {
                    TBNroVenta.Select();
                    return;
                }
            }
        }
    }
}
