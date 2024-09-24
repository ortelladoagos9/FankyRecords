using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_negocio;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void TBdni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (C_negocio.Validaciones.EstaVacio(TBnombre.Text) ||
               C_negocio.Validaciones.EstaVacio(TBapellido.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdni.Text) ||
               C_negocio.Validaciones.EstaVacio(TBdireccion.Text) ||
               C_negocio.Validaciones.EstaVacio(TBmail.Text) ||
               C_negocio.Validaciones.EstaVacio(TBcontraseña.Text) ||
               C_negocio.Validaciones.EstaVacio(TBconfcontraseña.Text) ||
               C_negocio.Validaciones.EstaVacio(CBRol.Text) ||
               C_negocio.Validaciones.EstaVacio(TBnumTel.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                

                dataGridView1.Rows[n].Cells[0].Value = 0;
                dataGridView1.Rows[n].Cells[1].Value = TBdni.Text;
                dataGridView1.Rows[n].Cells[2].Value = TBapellido.Text;
                dataGridView1.Rows[n].Cells[3].Value = TBnombre.Text;
                dataGridView1.Rows[n].Cells[4].Value = DTFechanac.Value;
                dataGridView1.Rows[n].Cells[5].Value = TBdireccion.Text;
                dataGridView1.Rows[n].Cells[6].Value = TBmail.Text;
                dataGridView1.Rows[n].Cells[7].Value = TBnumTel.Text;
                dataGridView1.Rows[n].Cells[8].Value = CBRol.Text;
                
                if (rBactivo.Checked)
                {
                    dataGridView1.Rows[n].Cells[9].Value = "Activo";
                }
                else if (rBinactivo.Checked)
                {
                    dataGridView1.Rows[n].Cells[9].Value = "Inactivo";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[9].Value = "X";
                }

               // limpia campos
                TBnombre.Clear();
                TBapellido.Clear();
                BTfoto.Clear();
                TBdireccion.Clear();
                TBnumTel.Clear();
                TBdni.Clear();
                TBmail.Clear();
                pictureBox1.Image = null;
                TBcontraseña.Clear();
                TBconfcontraseña.Clear();


            }
        }
        private void Txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsLetra(e);
        }
        private void Txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_negocio.Validaciones.EsNumero(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void BFoto_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;
            string directorio = @"C:\Users\roo_m\source\repos\Practico5\Practico5\bin\Debug\Fotos\";
            openFileDialog1.Title = "Selecione foto de perfil";
            openFileDialog1.Filter = "JPG|*.jpg|BMP |*.bmp|PNG |*.png";

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ruta = directorio + nombrearchivo(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, ruta, true);
                pictureBox1.Load(openFileDialog1.FileName);
                BTfoto.Text = ruta;

            }
        }
        private string nombrearchivo(string ruta)
        {
            string archivo = string.Empty;
            FileInfo fi = new FileInfo(ruta);
            archivo = Path.GetFileNameWithoutExtension(fi.Name) + Path.GetExtension(fi.Name);

            return archivo;
        }

        private void TBcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBconfcontraseña_TextChanged(object sender, EventArgs e)
        {
            if(TBcontraseña != TBconfcontraseña)
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
