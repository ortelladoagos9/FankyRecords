using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;

namespace FankyRecords.C_datos
{
    public class DatosRol
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public List<Rol> ListarRol()
        {

            List<Rol> lista = new List<Rol>();

            try
            {
                conexion.Open();

                string query = @"
                        select ID_rol,Descripcion from Rol";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Rol
                    {
                        ID_rol = int.Parse(reader["ID_rol"].ToString()),
                        Descripcion = reader["Descripcion"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return lista;
        }
    }
}
