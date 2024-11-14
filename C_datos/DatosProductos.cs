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
                        select p.ID_producto, p.Codigo,p.Nombre,p.Descripcion, p.Stock_min, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, c.Id_categoria, c.Descripcion as Categoria
                        from Productos p inner join Categorias c on p.Id_categoria = c.Id_categoria";
                
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
                        PrecioVenta = reader["PrecioVenta"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["PrecioVenta"]),
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
                 Estado = @NuevoEstado
                 WHERE ID_producto = @IDProducto";

                SqlCommand cmdProducto = new SqlCommand(queryProducto, conexion);
                cmdProducto.Parameters.AddWithValue("@NuevoCodigo", producto.Codigo);
                cmdProducto.Parameters.AddWithValue("@NuevoNombre", producto.Nombre);
                cmdProducto.Parameters.AddWithValue("@NuevaDescripcion", producto.Descripcion);
                cmdProducto.Parameters.AddWithValue("@NuevoStockMin", producto.Stock_min);
                cmdProducto.Parameters.AddWithValue("@NuevoEstado", producto.Estado);
                cmdProducto.Parameters.AddWithValue("@IDProducto", producto.ID_producto);

                cmdProducto.ExecuteNonQuery();

                // Actualizar la tabla Categorias
                string queryCategoria = @"
                  UPDATE Categorias
                  SET 
                  Descripcion = @NuevaDescripcionCategoria
                  WHERE Id_categoria = @IdCategoria";

                SqlCommand cmdCategoria = new SqlCommand(queryCategoria, conexion);
                cmdCategoria.Parameters.AddWithValue("@NuevaDescripcionCategoria", producto.Obj_categoria.Descripcion);
                cmdCategoria.Parameters.AddWithValue("@IdCategoria", producto.Obj_categoria.Id_categoria);

                cmdCategoria.ExecuteNonQuery();
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
                string query = @"DELETE FROM Productos WHERE ID_producto = @ID_producto";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_producto", ID_producto));

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
