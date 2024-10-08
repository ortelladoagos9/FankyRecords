using FankyRecords.C_presentacion.Vendedor;
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
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
        }


        private void Bbackup_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBbaseDatos.Text) ||
                C_negocio.Validaciones.EstaVacio(TBrutaGuardar.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (C_negocio.Validaciones.mensajeBackup())
                {
                    Limpiar();
                }
            }
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBbaseDatos.Text) ||
                C_negocio.Validaciones.EstaVacio(TBrutaGuardar.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (C_negocio.Validaciones.mensajeCancelar())
                {
                    Limpiar();
                }
            }
        }

        private void BtnNavegar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {  
                 TBrutaGuardar.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Limpiar()
        {
            TBbaseDatos.Clear();
            TBrutaGuardar.Clear();
        }
    }

}
