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
                        insert into CATEGORIAS(Descripcion,Estado) 
                        values (@Descripcion, @Estado)";

                SqlParameter Descripcion = new SqlParameter("@Descripcion", categoria.Descripcion);
                SqlParameter Estado = new SqlParameter("@Estado", categoria.Estado);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(Descripcion);
                cmd.Parameters.Add(Estado);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }   
            finally { conexion.Close(); }
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
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }

            return lista;
        }

        public void EditarCategoria(Categorias categoria)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE CATEGORIAS SET Descripcion = @Descripcion, Estado = @Estado WHERE Id_categoria = @Id_categoria";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", categoria.Estado == "Activo" ? 1 : 0); // Convertir "Activo"/"Inactivo" a bit
                cmd.Parameters.AddWithValue("@Id_categoria", categoria.Id_categoria);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        }
    }
}
