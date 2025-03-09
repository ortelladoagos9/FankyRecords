using FankyRecords.C_datos;
using FankyRecords.C_negocio;
using FankyRecords.C_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            if (C_negocio.Validaciones.EstaVacio(TBrutaGuardar.Text))
            {
                MessageBox.Show("Debe agregar una ruta para guardar el backup.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Construir la ruta completa del backup
            this.backupPath = Path.Combine(TBrutaGuardar.Text, "Fanky_Records_BD " + DateTime.Now.ToString("dd-MM-yyyy HH.mm"));

            // Crear la carpeta de destino si no existe
            if (!Directory.Exists(TBrutaGuardar.Text))
            {
                Directory.CreateDirectory(TBrutaGuardar.Text);
            }

            try
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas crear el backup de los datos?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Abre la conexión con la base de datos
                    conexion.Open();

                    // Construir la consulta SQL para realizar el backup
                    string query = $"BACKUP DATABASE [DB_FANKY_RECORDS] TO DISK = '{backupPath}.bak' WITH FORMAT, INIT;";

                    // Ejecutamos el comando SQL para hacer el backup
                    SqlCommand command = new SqlCommand(query, conexion);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                    Limpiar();

                    MessageBox.Show("El backup de DB_FANKY_RECORDS se generó correctamente en: " + this.backupPath, "Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La operación ha sido cancelada.","Cancelado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Limpiar();
                }
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
            MessageBox.Show("Operación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Limpiar();
        }

        private void BtnNavegar_Click(object sender, EventArgs e)
        {
            // Ruta por defecto permitida para guardar backups en SQL Server
            string backupDefaultPath = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup";

            if (Directory.Exists(backupDefaultPath))
            {
                TBrutaGuardar.Text = backupDefaultPath;
                this.nombreBd = "Fanky_Records_BD " + DateTime.Now.ToString("dd-MM-yyyy HH.mm");
                TBbaseDatos.Text = this.nombreBd;
            }
            else
            {
                MessageBox.Show("La ruta predeterminada no existe. Verifica la instalación o configura otra ruta con permisos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void BtnNavegar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {  
                 TBrutaGuardar.Text = folderBrowserDialog.SelectedPath;
            }
            this.nombreBd = "Fanky_Records_BD " + DateTime.Now.ToString("dd-MM-yyyy HH.mm");
            TBbaseDatos.Text = this.nombreBd;
        }*/

        private void Limpiar()
        {
            TBbaseDatos.Clear();
            TBrutaGuardar.Clear();
        }
    }
}
