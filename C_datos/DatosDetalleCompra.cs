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
    }
}
