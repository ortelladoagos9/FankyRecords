using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_datos
{
    public class DatosDetalleCompra
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarDetalleCompra(DetalleCompra DetCompra)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO DetalleCompra (PrecioCompra, Cantidad, SubTotal, ID_producto,ID_compra) 
                VALUES (@Codigo, @Nombre, @Descripcion, @Estado, @Stock_min, @Id_categoria)";

                SqlParameter PrecioCompra = new SqlParameter("@PrecioCompra", DetCompra.PrecioCompra);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", DetCompra.Cantidad);
                SqlParameter SubTotal = new SqlParameter("@SubTotal", DetCompra.SubTotal);
                SqlParameter ID_producto = new SqlParameter("@ID_producto", DetCompra.Obj_producto.ID_producto);
                SqlParameter ID_compra = new SqlParameter("@Stock_min", DetCompra.Obj_registrarCompra.ID_compra);
               

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(PrecioCompra);
                cmd.Parameters.Add(Cantidad);
                cmd.Parameters.Add(SubTotal);
                cmd.Parameters.Add(ID_producto);
                cmd.Parameters.Add(ID_compra);
                

                cmd.ExecuteNonQuery();
            }
            /*catch (SqlException ex)
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
            }*/
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<DetalleCompra> ListarDetalleCompra()
        {

            List<DetalleCompra> listaDetalle = new List<DetalleCompra>();

            try
            {
                conexion.Open();

                string query = @"
                        select p.ID_detalleCompra, p.PrecioCompra,p.Cantidad,p.SubTotal, c.ID_producto, d.ID_compra, d.NumeroCompra as Compra, c.Descripcion as Producto
                        from DetalleCompra p inner join Productos c on p.ID_producto = c.ID_producto";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaDetalle.Add(new DetalleCompra
                    {
                        ID_detalleCompra = Convert.ToInt32(reader["ID_detalleCompra"]),
                        PrecioCompra = Convert.ToInt32(reader["PrecioCompra"]),
                        Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                        SubTotal = Convert.ToInt32(reader["Descripcion"].ToString()),
                        Obj_producto = new Productos
                        {
                            ID_producto = Convert.ToInt32(reader["ID_producto"]),
                            Stock = Convert.ToInt32(reader["Producto"].ToString()),
                            PrecioCompra = Convert.ToInt32(reader["Producto"].ToString())

                        },
                        Obj_registrarCompra = new RegistrarCompra
                        {
                            ID_compra = Convert.ToInt32(reader["ID_compra"]),
                            NumeroCompra = Convert.ToInt32(reader["Compra"])
                        }   
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaDetalle;
        }

        public void EditarDetalleCompra(DetalleCompra detalleCompra)
        {
            try
            {
                conexion.Open();

                // Actualizar la tabla Productos
                string queryProducto = @"
                 UPDATE DetalleCompra
                 SET 
                 PrecioCompra = @PrecioCompra,
                 Cantidad = @NuevaCantidad,
                 SubTotal = @NuevoSubTotal,
                 Stock_min = @NuevoStockMin,
                 Estado = @NuevoEstado
                 WHERE ID_detalleCompra= @IDdetalleCompra";

                SqlCommand cmdProducto = new SqlCommand(queryProducto, conexion);
                cmdProducto.Parameters.AddWithValue("@PrecioCompra", detalleCompra.PrecioCompra);
                cmdProducto.Parameters.AddWithValue("@NuevaCantidad", detalleCompra.Cantidad);
                cmdProducto.Parameters.AddWithValue("@NuevoSubTotal", detalleCompra.SubTotal);
                
                cmdProducto.Parameters.AddWithValue("@IDdetalleCompra", detalleCompra.ID_detalleCompra);

                cmdProducto.ExecuteNonQuery();

                // Actualizar la tabla Categorias
                string queryProductos = @"
                  UPDATE Productos
                  SET 
                  Stock  = @NuevaStockPRoducto
                  WHERE ID_producto = @IdProducto";

                SqlCommand cmdCategoria = new SqlCommand(queryProductos, conexion);
                cmdCategoria.Parameters.AddWithValue("@NuevaStockPRoducto", detalleCompra.Obj_producto.Stock);
                cmdCategoria.Parameters.AddWithValue("@IdCategoria", detalleCompra.Obj_producto.ID_producto);

                cmdCategoria.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el detalle y el producto", ex);
            }
            finally
            {
                conexion.Close();
            }
        }


        public void EliminarDetalleCompra(int ID_detalleCompra)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM DetalleCompra WHERE ID_detalleCompra = @ID_detalleCompra";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_detalleCompra", ID_detalleCompra));

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
