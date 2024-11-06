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
    public class DatosProductos
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarProducto(Productos producto)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO Productos(Codigo, Nombre, Descripcion, Stock, PrecioVenta, PrecioCompra, Estado, Stock_min, Obj_categoria) 
                VALUES (@Codigo, @Nombre, @Descripcion, @Stock, @PrecioVenta, @PrecioCompra, @Estado, @Stock_min, @Obj_categoria)";

                SqlParameter Codigo = new SqlParameter("@Codigo", producto.Codigo);
                SqlParameter Nombre = new SqlParameter("@Nombre", producto.Nombre);
                SqlParameter Descripcion = new SqlParameter("@Descripcion", producto.Descripcion);
                SqlParameter Stock = new SqlParameter("@Stock", producto.Stock);
                SqlParameter PrecioVenta = new SqlParameter("@PrecioVenta", producto.PrecioVenta);
                SqlParameter PrecioCompra = new SqlParameter("@PrecioCompra", producto.PrecioCompra);
                SqlParameter Estado = new SqlParameter("@Estado", producto.Estado);
                SqlParameter Stock_min = new SqlParameter("@Stock_min", producto.Stock_min);
                SqlParameter Obj_categoria = new SqlParameter("@Obj_categoria", producto.Obj_categoria);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(Codigo);
                cmd.Parameters.Add(Nombre);
                cmd.Parameters.Add(Descripcion);
                cmd.Parameters.Add(Stock);
                cmd.Parameters.Add(PrecioVenta);
                cmd.Parameters.Add(PrecioCompra);
                cmd.Parameters.Add(Estado);
                cmd.Parameters.Add(Stock_min);
                cmd.Parameters.Add(Obj_categoria);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                switch (ex.Number)
                {
                    case 2627: //unique
                        throw new Exception("Error: El valor de 'Codigo' ya existe. No se permiten duplicados.", ex);
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

        public List<Productos> ListarProductos()
        {

            List<Productos> listaProductos = new List<Productos>();

            try
            {
                conexion.Open();

                string query = @"
                        select ID_producto, Codigo, Nombre, Descripcion, Stock, PrecioVenta, PrecioCompra, Estado, Stock_min, Obj_categoria
                        from Productos";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaProductos.Add(new Productos
                    {
                        ID_producto = int.Parse(reader["ID_producto"].ToString()),
                        Codigo = int.Parse(reader["Codigo"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Stock = int.Parse(reader["Stock"].ToString()),
                        PrecioVenta = decimal.Parse(reader["PrecioVenta"].ToString()),
                        PrecioCompra = decimal.Parse(reader["PrecioCompra"].ToString()),
                        Estado = reader["Estado"].ToString(),
                        Stock_min = int.Parse(reader["Stock_min"].ToString()),
                        //Obj_categoria = Categorias(reader["Obj_categoria"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaProductos;
        }

    }
}
