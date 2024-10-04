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
                    TBrutaGuardar.Clear();
                    TBbaseDatos.Clear();
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
                    // limpia campos
                    TBbaseDatos.Clear();
                    TBrutaGuardar.Clear();
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
    }

}
