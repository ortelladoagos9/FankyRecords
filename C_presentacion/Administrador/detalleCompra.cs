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
    public partial class detalleCompra : Form
    {
        public detalleCompra()
        {
            InitializeComponent();
        }

        private void TBnumCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaCopraDetalle_Click(object sender, EventArgs e)
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
    }
}