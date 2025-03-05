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
using FankyRecords.C_presentacion.Modales;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class detalleCompra : Form
    {
        private NegocioCompras CN_Compras;

        public detalleCompra()
        {
            InitializeComponent();
            CN_Compras = new NegocioCompras();
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
            listadoCompras.Rows.Clear();
        }

        private void btnBuscarNroCompra_Click(object sender, EventArgs e)
        {
            using (var modal = new MDCompra())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBNumeroCompra.Text = modal.CompraMD.NumeroCompra.ToString();
                    TBFecha.Text = modal.CompraMD.FechaCompra.ToString("dd/MM/yyyy");
                    TBtipoDoc.Text = modal.CompraMD.Obj_Tipo_Doc?.Descripcion ?? "N/A";
                    TBNumFactura.Text = modal.CompraMD.NumeroFactura.ToString();
                    TBUsuario.Text = modal.CompraMD.Obj_usuarios?.NombreCompleto ?? "N/A";
                    TBcuit.Text = modal.CompraMD.Obj_proveedor?.Cuit ?? "N/A";
                    TBrazonSocial.Text = modal.CompraMD.Obj_proveedor?.RazonSocial ?? "N/A";
                    TBmontoTotal.Text = modal.CompraMD.MontoTotal.ToString("N2");
                }
                else
                {
                    TBNumeroCompra.Select();
                    return;
                }
            }

            // Obtener la compra de la base de datos
            Compra compra = CN_Compras.ObtenerCompra(TBNumeroCompra.Text);

            if (compra == null)
            {
                MessageBox.Show("No se encontró la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (compra.Obj_DetalleCompra == null || compra.Obj_DetalleCompra.Count == 0)
            {
                MessageBox.Show("No hay detalles de compra disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el DataGridView antes de cargar datos
            listadoCompras.Rows.Clear();

            // Habilitar generación automática de columnas si es necesario
            if (listadoCompras.AutoGenerateColumns == false && listadoCompras.Columns.Count == 0)
            {
                listadoCompras.AutoGenerateColumns = true;
            }

            foreach (DetalleCompra dc in compra.Obj_DetalleCompra)
            {
                Console.WriteLine($"Producto: {dc.Obj_producto?.Nombre}, Cantidad: {dc.Cantidad}, Subtotal: {dc.SubTotal}");
            }

            // Agregar filas al DataGridView
            foreach (DetalleCompra dc in compra.Obj_DetalleCompra)
            {
                if (dc.Obj_producto == null)
                {
                    MessageBox.Show("Un producto en los detalles de la compra es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listadoCompras.Rows.Add(
                    dc.Obj_producto.Codigo,
                    dc.Obj_producto.Nombre,
                    dc.Obj_producto.Descripcion,
                    dc.PrecioCompra.ToString("N2"),
                    dc.Obj_producto.PrecioVenta.ToString("N2"),
                    dc.Cantidad,
                    dc.SubTotal.ToString("N2")
                );
            }
        }
    }
}
