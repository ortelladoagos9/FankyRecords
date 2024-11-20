using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class detalleCompra : Form
    {
        private DatosCompra CD_Compras;
        public detalleCompra()
        {
            InitializeComponent();
            CD_Compras = new DatosCompra();
        }

        private void TxtPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TBmontoTotal.Clear();
            TBNumeroCompra.Clear();
            TBFecha.Clear();
            TBtipoDoc.Clear();
            TBNumFactura.Clear();
            TBUsuario.Clear();
            TBcuit.Clear();
            TBrazonSocial.Clear();
        }

        private void btnBuscarNroCompra_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnumCompra.Text))
            {
                MessageBox.Show("Debe ingresar el numero de compra para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            Compra compra = CD_Compras.ObtenerCompra(TBnumCompra.Text);

            if(compra.ID_compra != 0)
            {
                TBNumeroCompra.Text = compra.NumeroCompra.ToString();
                TBFecha.Text = compra.FechaCompra.ToString();
                TBtipoDoc.Text = compra.Obj_Tipo_Doc.Descripcion;
                TBNumFactura.Text = compra.NumeroFactura.ToString();
                TBUsuario.Text = compra.Obj_usuarios.NombreCompleto;
                TBcuit.Text = compra.Obj_proveedor.Cuit;
                TBrazonSocial.Text = compra.Obj_proveedor.RazonSocial;
                TBmontoTotal.Text = compra.MontoTotal.ToString();

                listadoCompras.Rows.Clear();
                if (compra.Obj_DetalleCompra != null && compra.Obj_DetalleCompra.Count > 0)
                {
                    foreach (DetalleCompra dc in compra.Obj_DetalleCompra)
                    {
                        listadoCompras.Rows.Add(
                            new object[] { dc.Obj_producto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.SubTotal });
                    }
                }

                TBmontoTotal.Text = compra.MontoTotal.ToString("0.00");
            }
        }
    }
}
