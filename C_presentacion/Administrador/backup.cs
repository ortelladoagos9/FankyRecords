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
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        string backupPath;
        string nombreBd;

        public backup()
        {
            InitializeComponent();
        }
        private void Bbackup_Click(object sender, EventArgs e)
        { 
            //Se debe crear una carpeta en el disco local para poder realizar el backup, de lo contrario se genera un error
            this.backupPath = TBrutaGuardar.Text.ToString() + @"\Fanky_Records_BD " + DateTime.Now.ToString("dd-MM-yyyy HH.mm") ;

            try
            {
                // Abre la conexión con la base de datos
                conexion.Open();

                // Construir la consulta SQL para realizar el backup
                string query = $"BACKUP DATABASE [DB_FANKY_RECORDS] TO DISK = '{backupPath}.bak' WITH FORMAT, INIT;";

                // Ejecutamos el comando SQL para hacer el backup
                SqlCommand command = new SqlCommand(query, conexion);
                
                // Ejecutar la consulta
                command.ExecuteNonQuery();
                MessageBox.Show("Backup realizado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:" + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void BtnNavegar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {  
                 TBrutaGuardar.Text = folderBrowserDialog.SelectedPath;
            }
            this.nombreBd = "Fanky_Records_BD " + DateTime.Now.ToString("dd-MM-yyyy HH.mm");
            TBbaseDatos.Text = this.nombreBd;
        }

        private void Limpiar()
        {
            TBbaseDatos.Clear();
            TBrutaGuardar.Clear();
        }

    }

}
