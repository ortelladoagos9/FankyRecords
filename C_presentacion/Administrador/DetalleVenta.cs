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

            // Obtener la venta de la base de datos
            Venta venta = CN_Ventas.ObtenerVenta(TBNroVenta.Text);

            if (venta == null)
            {
                MessageBox.Show("No se encontró la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (venta.Obj_DetalleVenta == null || venta.Obj_DetalleVenta.Count == 0)
            {
                MessageBox.Show("No hay detalles de venta disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar el DataGridView antes de cargar datos
            listadoVentas.Rows.Clear();

            // Habilitar generación automática de columnas si es necesario
            if (listadoVentas.AutoGenerateColumns == false && listadoVentas.Columns.Count == 0)
            {
                listadoVentas.AutoGenerateColumns = true;
            }

            foreach (DetalleVenta dv in venta.Obj_DetalleVenta)
            {
                Console.WriteLine($"Producto: {dv.ProductoNombre}, Cantidad: {dv.Cantidad}, Subtotal: {dv.SubTotal}");
            }

            // Agregar filas al DataGridView
            foreach (DetalleVenta dv in venta.Obj_DetalleVenta)
            {
                if (dv.Obj_producto == null)
                {
                    MessageBox.Show("Un producto en los detalles de la venta es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listadoVentas.Rows.Add(
                    dv.Obj_producto.Codigo,
                    dv.Obj_producto.Nombre,
                    dv.Obj_producto.Descripcion,
                    dv.PrecioVenta.ToString("N2"),
                    dv.Cantidad,
                    dv.SubTotal.ToString("N2")
                );
            }
        }
    }
}
