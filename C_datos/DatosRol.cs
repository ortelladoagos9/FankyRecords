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

        public void EditarRol(Rol rol)
        {
            try
            {
                conexion.Open();
                string query = @" update Rol 
                               SET Descripcion = @Descripcion
                               WHERE ID_rol = @ID_rol";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
                cmd.Parameters.AddWithValue("@ID_rol", rol.ID_rol); // Pasar el ID

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el rol", ex);
            }
            finally { conexion.Close(); }
        }

        public void EliminarRol(int id_rol)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Rol WHERE ID_rol = @ID_rol";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_rol", id_rol));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public Rol ObtenerRolPorID(int Id_rol)
        {
            Rol rol = null;
            try
            {
                conexion.Open();
                string query = "SELECT * FROM Rol WHERE ID_rol= @ID_rol";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_rol", Id_rol);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rol = new Rol
                    {
                        ID_rol= int.Parse(reader["ID_rol"].ToString()),
                        Descripcion = reader["Descripcion"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return rol;
        }




    }
}
