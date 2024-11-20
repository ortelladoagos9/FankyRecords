using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;


namespace FankyRecords.C_datos
{
    public class DatosDetalleVenta
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public List<DetalleVenta> ListarDetalleVenta()
        {

            List<DetalleVenta> listaDetalle = new List<DetalleVenta>();
            try
            {
                conexion.Open();

                string query = @"
                        select p.ID_detalleVenta, p.PrecioVenta,p.Cantidad,p.SubTotal, c.ID_producto, d.ID_venta, d.NumeroFactura as Venta, c.Descripcion as Producto
                        from DetalleVenta p inner join Productos c on p.ID_producto = c.ID_producto";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaDetalle.Add(new DetalleVenta
                    {
                        ID_detalleVenta = Convert.ToInt32(reader["ID_detalleVenta"]),
                        PrecioVenta = Convert.ToInt32(reader["PrecioVenta"]),
                        Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                        SubTotal = Convert.ToInt32(reader["Descripcion"].ToString()),
                        Obj_producto = new Productos
                        {
                            ID_producto = Convert.ToInt32(reader["ID_producto"]),
                            Stock = Convert.ToInt32(reader["Producto"].ToString()),
                            PrecioCompra = Convert.ToInt32(reader["Producto"].ToString())

                        },
                        Obj_registrarVenta= new Venta
                        {
                            ID_ventas = Convert.ToInt32(reader["ID_venta"]),
                            NumeroFactura = Convert.ToInt32(reader["Venta"])
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




    }
}
