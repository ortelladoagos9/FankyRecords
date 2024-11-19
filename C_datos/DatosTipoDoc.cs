using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_datos
{
    public class DatosTipoDoc
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public List<TipoDoc> ListarTipoDoc()
        {

            List<TipoDoc> listaTipoDoc = new List<TipoDoc>();

            try
            {
                conexion.Open();

                string query = @"select * from Tipo_documento";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaTipoDoc.Add(new TipoDoc
                    {
                        ID_Tipo_Doc = int.Parse(reader["ID_Tipo_Doc"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaTipoDoc;
        }
    }
}
