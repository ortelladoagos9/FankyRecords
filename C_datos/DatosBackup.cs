using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FankyRecords.C_presentacion;
using FankyRecords.C_negocio;


namespace FankyRecords.C_datos
{
    public class DatosBackup
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);


        public void BackUpDatabase(string consulta)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar el respaldo de la base de datos.", ex);
            }
            finally { conexion.Close(); }

        }


    }
}
