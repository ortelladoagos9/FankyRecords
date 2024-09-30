using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class registroCompra : Form
    {
        decimal sumaSubtotal = 0;
        public registroCompra()
        {
            InitializeComponent();
        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(cbTipoDoc.Text)
                || C_negocio.Validaciones.EstaVacio(TBcuit.Text)
                || C_negocio.Validaciones.EstaVacio(TBcodProducto.Text)
                || C_negocio.Validaciones.EstaVacio(TBprecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeConfirmacion())
                {
                    decimal subtotal = cantProd.Value * Convert.ToDecimal(TBprecio.Text);
                    sumaSubtotal += subtotal;
                    TBtotalPagar.Text = sumaSubtotal.ToString();

                    int n = listaCompras.Rows.Add();

                    listaCompras.Rows[n].Cells[0].Value = TBcodProducto.Text;
                    listaCompras.Rows[n].Cells[1].Value = " ";
                    listaCompras.Rows[n].Cells[2].Value = TBprecio.Text;
                    listaCompras.Rows[n].Cells[3].Value = cantProd.Value;
                    listaCompras.Rows[n].Cells[4].Value = subtotal;

                    // limpia campos
                    TBcodProducto.Clear();
                    cantProd.Value = 1;
                    TBprecio.Clear();
                    TBcuit.Clear();
                }
            }
        }

        private void registrarCompra_Click(object sender, EventArgs e)
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
                    TBcodProducto.Clear();
                    TBproducto.Clear();
                    TBprecio.Clear();
                    TBrazonSocial.Clear();
                    TBcuit.Clear();
                    cantProd.Value = 1;
                    

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
    } 
}