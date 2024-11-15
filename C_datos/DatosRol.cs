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

        public void AgregarRol(Rol rol)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO Rol(Descripcion) 
                VALUES (@Descripcion)";

                SqlParameter descripcionParam = new SqlParameter("@Descripcion", rol.Descripcion);
                

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(descripcionParam);
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool ExisteRol(string descripcion)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Rol WHERE Descripcion = @Descripcion";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                existe = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
            return existe;
        }

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
