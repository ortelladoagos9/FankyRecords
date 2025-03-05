using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
                INSERT INTO Productos(Codigo, Nombre, Descripcion, Estado, Stock_min, Id_categoria) 
                VALUES (@Codigo, @Nombre, @Descripcion, @Estado, @Stock_min, @Id_categoria)";

                SqlParameter Codigo = new SqlParameter("@Codigo", producto.Codigo);
                SqlParameter Nombre = new SqlParameter("@Nombre", producto.Nombre);
                SqlParameter Descripcion = new SqlParameter("@Descripcion", producto.Descripcion);
                SqlParameter Estado = new SqlParameter("@Estado", producto.Estado);
                SqlParameter Stock_min = new SqlParameter("@Stock_min", producto.Stock_min);
                SqlParameter Id_categoria = new SqlParameter("@Id_categoria", producto.Obj_categoria.Id_categoria);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(Codigo);
                cmd.Parameters.Add(Nombre);
                cmd.Parameters.Add(Descripcion);
                cmd.Parameters.Add(Estado);
                cmd.Parameters.Add(Stock_min);
                cmd.Parameters.Add(Id_categoria);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ_Productos_codigo"))
                {
                    throw new Exception("El código ya existe. No se permite duplicados", ex);
                }
                else if (ex.Message.Contains("CK_Productos_stock"))
                {
                    throw new Exception("El stock debe ser mayor a 0", ex);
                }
                else if (ex.Message.Contains("CK_Productos_stock_min"))
                {
                    throw new Exception("El stock minimo debe ser mayor a 0", ex);
                }
                else if (ex.Message.Contains("CK_Productos_stock_mayor_stock_min"))
                {
                    throw new Exception("El stock minimo debe ser menor al stock", ex);
                }
                else if (ex.Message.Contains("CK_Productos_precioVenta"))
                {
                    throw new Exception("El precio de venta debe ser mayor a 0", ex);
                }
                else if (ex.Message.Contains("CK_Productos_precioCompra"))
                {
                    throw new Exception("El precio de compra debe ser mayor a 0", ex);
                }
                
                else
                {
                    throw new Exception("Error vuelva a intentarlo", ex);
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
                        SELECT 
                            p.ID_producto, 
                            p.Codigo,
                            p.Nombre,
                            p.Descripcion, 
                            p.Stock_min, 
                            p.Stock, 
                            FORMAT(p.PrecioCompra, 'N2', 'es-ES') AS PrecioCompra, 
                            FORMAT(p.PrecioVenta, 'N2', 'es-ES') AS PrecioVenta, 
                            p.Estado, 
                            c.Id_categoria, 
                            c.Descripcion AS Categoria
                        FROM Productos p 
                        INNER JOIN Categorias c ON p.Id_categoria = c.Id_categoria";
                
                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaProductos.Add(new Productos
                    {
                        ID_producto = Convert.ToInt32(reader["ID_producto"]),
                        Codigo = Convert.ToInt32(reader["Codigo"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Stock = reader["Stock"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Stock"]),
                        PrecioVenta = reader["PrecioVenta"] == DBNull.Value ? 0 :Convert.ToDecimal(reader["PrecioVenta"]),
                        PrecioCompra = reader["PrecioCompra"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["PrecioCompra"]),
                        Estado = reader["Estado"].ToString(),
                        Stock_min = Convert.ToInt32(reader["Stock_min"]),
                        Obj_categoria = new Categorias
                        {
                            Id_categoria = Convert.ToInt32(reader["Id_categoria"]),
                            Descripcion = reader["Categoria"].ToString()
                        }
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

        public void EditarProductos(Productos producto)
        {
            try
            {
                conexion.Open();

                // Actualizar la tabla Productos
                string queryProducto = @"
                 UPDATE Productos
                 SET 
                 Codigo = @NuevoCodigo,
                 Nombre = @NuevoNombre,
                 Descripcion = @NuevaDescripcion,
                 Stock_min = @NuevoStockMin,
                 Estado = @NuevoEstado,
                 Id_categoria = @IdCategoria
                 WHERE ID_producto = @IDProducto";

                SqlCommand cmdProducto = new SqlCommand(queryProducto, conexion);
                cmdProducto.Parameters.AddWithValue("@NuevoCodigo", producto.Codigo);
                cmdProducto.Parameters.AddWithValue("@NuevoNombre", producto.Nombre);
                cmdProducto.Parameters.AddWithValue("@NuevaDescripcion", producto.Descripcion);
                cmdProducto.Parameters.AddWithValue("@NuevoStockMin", producto.Stock_min);
                cmdProducto.Parameters.AddWithValue("@NuevoEstado", producto.Estado);
                cmdProducto.Parameters.AddWithValue("@IDProducto", producto.ID_producto);
                cmdProducto.Parameters.AddWithValue("@IdCategoria", producto.Obj_categoria.Id_categoria);

                cmdProducto.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el producto y la categoría", ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarProductos(int ID_producto)
        {
            try
            {
                conexion.Open();
                string query = @"
                        UPDATE Productos
                        SET Estado = @Inactivo
                        WHERE ID_producto = @ID_producto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_producto", ID_producto));
                cmd.Parameters.Add(new SqlParameter("@Inactivo", "Inactivo")); // Asigna el valor deseado

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public Productos ObtenerProductosPorID(int ID_producto)
        {
            Productos productos = null;
            try
            {
                conexion.Open();
                string query = @"
                         select p.ID_producto, 
                                p.Codigo, 
                                p.Nombre, 
                                p.Descripcion, 
                                p.Stock_min, 
                                p.Stock, 
                                p.PrecioCompra, 
                                p.PrecioVenta, 
                                p.Estado, 
                                c.Id_categoria, 
                                c.Descripcion as Categoria 
                        from Productos p inner join Categorias c 
                        on p.Id_categoria = c.Id_categoria 
                        WHERE p.ID_producto = @ID_producto";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_producto", ID_producto);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos = new Productos
                    {
                        ID_producto = int.Parse(reader["ID_producto"].ToString()),
                        Codigo = int.Parse(reader["Codigo"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Stock = reader["Stock"] == DBNull.Value ? 0 : int.Parse(reader["Stock"].ToString()),
                        PrecioVenta = reader["PrecioVenta"] == DBNull.Value ? 0 : decimal.Parse(reader["PrecioVenta"].ToString()),
                        PrecioCompra = reader["PrecioCompra"] == DBNull.Value ? 0 : decimal.Parse(reader["PrecioCompra"].ToString()),
                        Estado = reader["Estado"].ToString(),
                        Stock_min = int.Parse(reader["Stock_min"].ToString()),
                        Obj_categoria = new Categorias
                        {
                            Id_categoria = int.Parse(reader["Id_categoria"].ToString()),
                            Descripcion = reader["Categoria"].ToString()
                        }  
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return productos;
        }
    }
}
