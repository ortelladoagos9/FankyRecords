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
        public registroCompra()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(tipoDoc.Text)
                || C_negocio.Validaciones.EstaVacio(TBcuil.Text)
                || C_negocio.Validaciones.EstaVacio(TBrazonSocial.Text)
                || C_negocio.Validaciones.EstaVacio(TBcodProdunto.Text)
                || C_negocio.Validaciones.EstaVacio(TBprecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los datos han sido cargados correctamente.",
                                       "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                TBcodProdunto.Clear();
                TBproduct.Clear();
                TBprecio.Clear();
                cantProd = null;


            }
        }

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos han sido guardados correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

            TBcodProdunto.Clear();
            TBproduct.Clear();
            TBprecio.Clear();
            TBrazonSocial.Clear();
            TBcuil.Clear();
            cantProd = null;
            tipoDoc =null;
            

        }
        private void Txtpalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void Txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void tipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}