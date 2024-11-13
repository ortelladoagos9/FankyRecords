using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion.Modales;
using FankyRecords.C_presentacion.Utilidades;
using FankyRecords.C_presentacion.Vendedor;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registrarCompra : Form
    {
        
        private readonly NegocioProductos CN_Productos;
        private readonly DatosProductos CD_Productos;
        decimal sumaSubtotal = 0;
        public registrarCompra()
        {
            InitializeComponent();
            
            CN_Productos = new NegocioProductos();
            CD_Productos = new DatosProductos();


            /*this.cbTipoDoc.SelectedIndex = 0*/
            ;
        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            //Verificamos que todos los campos estésn completos.
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text)
                || C_negocio.Validaciones.EstaVacio(TBcuit.Text)
                || C_negocio.Validaciones.EstaVacio(TBprecio_compra.Text)
                || C_negocio.Validaciones.EstaVacio(TBNumFactura.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    bool prodExiste = false;
                    decimal subtotal = cantProd.Value * Convert.ToDecimal(TBprecio_compra.Text);
                    sumaSubtotal += subtotal;
                    TBtotalPagar.Text = sumaSubtotal.ToString();

                    foreach (DataGridViewRow fila in listaCompras.Rows)
                    {
                        if (fila.Cells["codigoProducto"].Value.ToString() == TBCodProd.Text)
                        {
                            prodExiste = true;
                            break;
                        }
                    }
                    if (!prodExiste)
                    {
                        Productos productos = new Productos
                        {
                            Codigo = Convert.ToInt32(TBCodProd.Text),

                          
                        };
                        try
                        {
                            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo proveedor?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (ask == DialogResult.Yes)
                            {
                                // Intentar guardar la categoría en la base de datos
                                CN_Productos.GuardarProductos(productos);

                                MessageBox.Show("El producto: " + this.TBCodProd.Text + " " + "se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Recargar datos y limpiar formulario
                                AgregarProducto();
                                Limpiar();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                        }

                    }

                    
                    Limpiar();
                }
            }
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            RegistrarCompra();
        }

        private void RegistrarCompra()
        {
            if (C_negocio.Validaciones.EstaVacio(TBtotalPagar.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas registrar la compra?",
                                                          "Confirmación",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Limpiar();
                    TBtotalPagar.Clear();

                    MessageBox.Show("La compra ha sido registrada correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La operación de registrar compra ha sido cancelada.",
                                         "Cancelado",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                }

            }
        }
        
        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBCodProd.Text = modal.Productomd.Codigo.ToString();
                    TBproducto.Text = modal.Productomd.Nombre.ToString();
                    TBPrecio_Venta.Text = modal.Productomd.PrecioVenta.ToString();
                    
                }
                else
                {
                   
                }
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MDProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TBrazonSocial.Text = modal.Proveedormd.RazonSocial.ToString();
                    TBcuit.Text = modal.Proveedormd.Cuit.ToString();

                }
                else
                {
                    TBrazonSocial.Select();
                }
            }
        }

        private void Limpiar()
        {
          
            TBCodProd.Clear();
            TBproducto.Clear();
            TBprecio_compra.Clear();
            TBcuit.Clear();
            cantProd.Value = 1;
        }

        private void TBprecio_compra_TextChanged(object sender, EventArgs e)
        {
            if (TBprecio_compra.Text == "")
            {
                TBPrecio_Venta.Text = "";
            }
            else
            {
                decimal precioVenta = (Convert.ToDecimal(0.2) * Convert.ToDecimal(TBprecio_compra.Text)) + Convert.ToDecimal(TBprecio_compra.Text);
                TBPrecio_Venta.Text = precioVenta.ToString();
            }   
        }

        private void registrarCompra_Load(object sender, EventArgs e)
        {
            cbTipoDoc.Items.Add(new OpcionCombo() { Valor = "Factura A", Texto = "Factura A" });
            cbTipoDoc.Items.Add(new OpcionCombo() { Valor = "Remito", Texto = "Remito" });
            cbTipoDoc.DisplayMember = "Texto";
            cbTipoDoc.ValueMember = "Valor";


        }

      

       

    } 
}