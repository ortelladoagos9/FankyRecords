﻿using System;
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
    public partial class devoluciones : Form
    {
        public devoluciones()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void TxtPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }



        private void Bgenerar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(CBtipoNC.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnumFactura.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnombreComprador.Text))
            { 

                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                C_negocio.Validaciones.mensajeConfirmacionGenerarNC();
            }
            // limpia campos
            TBnumFactura.Clear();
            TBnombreComprador.Clear();
          

        }

    }
}
