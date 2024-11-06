using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_datos
{
    public class DatosCategorias
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarCategoria(Categorias categoria)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO CATEGORIAS(Descripcion, Estado) 
                VALUES (@Descripcion, @Estado)";

                SqlParameter descripcionParam = new SqlParameter("@Descripcion", categoria.Descripcion);
                SqlParameter estadoParam = new SqlParameter("@Estado", categoria.Estado);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(descripcionParam);
                cmd.Parameters.Add(estadoParam);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627: //unique
                        throw new Exception("Error: El valor de 'Descripcion' ya existe. No se permiten duplicados.", ex);
                    case 547: //clave foranea o check
                        throw new Exception("Error: Violación de restricción de clave foránea o de otro tipo. Revisa los valores relacionados.", ex);
                    case 515: //null
                        throw new Exception("Error: No se permite el valor NULL en uno de los campos obligatorios.", ex);
                    default:
                        throw new Exception("Error de base de datos desconocido: " + ex.Message, ex);
                }
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

        public bool ExisteCategoria(string descripcion)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM CATEGORIAS WHERE Descripcion = @Descripcion";
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


        public List<Categorias> ListarCategorias() {

            List<Categorias> lista = new List<Categorias>();

            try
            {
                conexion.Open();

                string query = @"
                        select Id_categoria,Descripcion,Estado from CATEGORIAS"; 

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Categorias
                    {
                        Id_categoria = int.Parse(reader["Id_categoria"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        Estado = reader["Estado"].ToString()
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

        public void EditarCategoria(Categorias categoria)
        {
            try
            {
                conexion.Open();
                string query = @" update CATEGORIAS 
                               SET Descripcion = @Descripcion,
                               Estado = @Estado 
                               WHERE Id_categoria = @Id_categoria";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado); // Almacena "Activo" o "Inactivo" 
                cmd.Parameters.AddWithValue("@Id_categoria", categoria.Id_categoria); // Pasar el ID

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la categoría", ex);
            }
            finally { conexion.Close(); }
        }

        public void EliminarCategoria(int id_categoria)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM CATEGORIAS WHERE Id_categoria = @Id_categoria";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@Id_categoria", id_categoria));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }
    }
}
