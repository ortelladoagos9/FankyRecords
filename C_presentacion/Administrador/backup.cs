using FankyRecords.C_datos;
using FankyRecords.C_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrador
{
    public partial class backup : Form
    {

        string backupPath;

        public backup()
        {
            InitializeComponent();
        }


        private void Bbackup_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                this.backupPath = TBrutaGuardar.Text.ToString() + @"\Back_Up_" + DateTime.Now.ToString("ddMMyyyyHHmmss");
                string query = $"BACKUP DATABASE [db_Pharmasuite] TO DISK = '{backupPath}'";

               conexion.Database.ExecuteSqlRaw(query);

            }
            this.registroBackup();

        }

        private void registroBackup()
        {
            
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                /* this.usuario = queryUsuario.buscarPorIdPers(this.usuarioActual.IdPersona);
                   string query = "INSERT INTO registro_backup (id_usuario,ruta_guardado)" +
                     "VALUES ("+this.usuario.IdUsuario+","+ txbRuta.Text.ToString()+")";
                 */
                string query = "INSERT INTO registro_buckup (ruta_guardado)" +
                    "VALUES (" + 1 + ",'" + this.backupPath + "')";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();

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

        private void TBrutaGuardar_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
