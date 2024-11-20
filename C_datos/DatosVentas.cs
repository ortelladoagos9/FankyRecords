using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;

namespace FankyRecords.C_datos
{
    public class DatosVentas
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarVenta(Venta venta)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO Ventas (MontoTotal, NumeroFactura, FechaVenta, ID_usuarios, ID_cliente, ID_Tipo_Doc) 
                VALUES (@MontoTotal, @NumeroFactura, @FechaVenta, @ID_usuarios, @ID_cliente, @ID_Tipo_Doc)";

                SqlParameter MontoTotalParam = new SqlParameter("@MontoTotal", venta.MontoTotal);
                SqlParameter NumeroFacturaParam = new SqlParameter("@NumeroFactura", venta.NumeroFactura);
                SqlParameter FechaVentaParam = new SqlParameter("@FechaCompra", venta.FechaVenta);
                SqlParameter ID_usuarios = new SqlParameter("@ID_usuarios", venta.Obj_usuarios.ID_usuarios);
                SqlParameter ID_cliente= new SqlParameter("@ID_cliente", venta.Obj_clientes.ID_cliente);
                SqlParameter ID_Tipo_Doc = new SqlParameter("@ID_Tipo_Doc", venta.Obj_Tipo_Doc.ID_Tipo_Doc);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(MontoTotalParam);
                cmd.Parameters.Add(NumeroFacturaParam);
                cmd.Parameters.Add(FechaVentaParam);
                cmd.Parameters.Add(ID_usuarios);
                cmd.Parameters.Add(ID_cliente);
                cmd.Parameters.Add(ID_Tipo_Doc);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ_Ventas_numeroFactura"))
                {
                    throw new Exception("El valor de 'Numero Venta' ya existe. No se permiten duplicados.", ex);
                }
                else
                {
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

        public List<Venta> ListarVentas()
        {
            List<Venta> listaVenta= new List<Venta>();
            try
            {
                conexion.Open();
                string query = @"
                       select c.ID_ventas,  c.MontoTotal, c.NumeroFactura, c.FechaVenta, u.ID_usuarios, p.ID_cliente, td.ID_Tipo_Doc, 
                        CONCAT_WS(' ', u.Nombre, u.Apellido) as Usuario,CONCAT_WS(' ', p.Nombre, p.Apellido) as Cliente, td.Descripcion as Tipo_documento
                       from Compras c 
                       inner join Clientes p 
                       on  c.ID_cliente=  p.ID_cliente
                       inner join Usuarios u 
                       on u.ID_usuarios = c.ID_usuarios 
                       inner join Tipo_documento td 
                       on td.ID_Tipo_Doc = c.ID_Tipo_Doc";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaVenta.Add(new Venta
                    {
                        ID_ventas= int.Parse(reader["ID_ventas"].ToString()),
                        MontoTotal = decimal.Parse(reader["MontoTotal"].ToString()),
                        NumeroFactura = int.Parse(reader["NumeroFactura"].ToString()),
                        FechaVenta = DateTime.Parse(reader["FechaVenta"].ToString()),
                        Obj_usuarios = new Usuarios
                        {
                            ID_usuarios = Convert.ToInt32(reader["ID_usuarios"]),
                            Nombre = reader["Usuario"].ToString(),
                            Apellido = reader["Usuario"].ToString()

                        },
                        Obj_clientes = new Clientes
                        {
                            ID_cliente = Convert.ToInt32(reader["ID_cliente"]),
                            Nombre = reader["Cliente"].ToString(),
                            Apellido = reader["Cliente"].ToString()


                        },
                        Obj_Tipo_Doc = new TipoDoc
                        {
                            ID_Tipo_Doc = Convert.ToInt32(reader["ID_Tipo_Doc"]),
                            Descripcion = reader["TipoDoc"].ToString()
                        }
 ,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error: " + ex.Message, ex);
            }
            finally
            { conexion.Close(); }

            return listaVenta;
        }




    }
}
