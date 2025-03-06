using FankyRecords.C_datos;
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
    //private datos CD_Compras;

    public partial class detalleVenta : Form
    {
        public detalleVenta()
        {
            InitializeComponent();
            //CD_Compras = new DatosCompra();
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
            TBRecibe.Clear();
            TBCambio.Clear();
            TBNroVenta.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
