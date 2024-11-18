using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;

namespace FankyRecords.C_datos
{
    public class DatosCompra
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);
        
        public void AgregarCompra(Compra compra)
        {
            try
            {
                conexion.Open(); 

                string query = @"
                INSERT INTO Compras (NumeroCompra,  MontoTotal, NumeroFactura, FechaCompra, ID_proveedor, ID_usuarios, ID_Tipo_Doc) 
                VALUES (@NumeroCompra, @MontoTotal, @NumeroFactura, @FechaCompra, @ID_proveedor, @ID_usuarios, @ID_Tipo_Doc)";

                SqlParameter NumeroCompraParam = new SqlParameter("@NumeroCompra", compra.NumeroCompra);
                SqlParameter MontoTotalParam = new SqlParameter("@MontoTotal", compra.MontoTotal);
                SqlParameter NumeroFacturaParam = new SqlParameter("@NumeroFactura", compra.NumeroFactura);
                SqlParameter FechaCompraParam = new SqlParameter("@FechaCompra", compra.FechaCompra);
                SqlParameter ID_proveedor = new SqlParameter("@ID_proveedor", compra.Obj_proveedor.ID_proveedor);
                SqlParameter ID_usuarios = new SqlParameter("@ID_usuarios", compra.Obj_usuarios.ID_usuarios);
                SqlParameter ID_Tipo_Doc = new SqlParameter("@ID_Tipo_Doc", compra.Obj_Tipo_Doc.ID_Tipo_Doc);
         
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(NumeroCompraParam);
                cmd.Parameters.Add(MontoTotalParam);
                cmd.Parameters.Add(NumeroFacturaParam);
                cmd.Parameters.Add(FechaCompraParam);
                cmd.Parameters.Add(ID_proveedor);
                cmd.Parameters.Add(ID_usuarios);
                cmd.Parameters.Add(ID_Tipo_Doc);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ_Compras_numeroCompra"))
                {
                  throw new Exception("El valor de 'Numero Compra' ya existe. No se permiten duplicados.", ex);
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

        public List<Compra> ListarCompras()
        {
            List<Compra> listaCompra = new List<Compra>();
            try
            {
                conexion.Open();
                string query = @"
                       select c.ID_compras, c.NumeroCompra,  c.MontoTotal, c.NumeroFactura, c.FechaCompra, p.ID_proveedor, u.ID_usuarios, td.ID_Tipo_Doc, 
                       p.RazonSocial as Proveedor, CONCAT_WS(' ', u.Nombre, u.Apellido) as Usuario, td.Descripcion as Tipo_documento
                       from Compras c 
                       inner join Proveedores p 
                       on  c.ID_proveedor =  p.ID_proveedor 
                       inner join Usuarios u 
                       on u.ID_usuarios = c.ID_usuarios 
                       inner join Tipo_documento td 
                       on td.ID_Tipo_Doc = c.ID_Tipo_Doc";
                
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    listaCompra.Add(new Compra 
                    {
                        ID_compra = int.Parse(reader["ID_compra"].ToString()),
                        NumeroCompra = int.Parse(reader["NumeroCompra"].ToString()),
                        MontoTotal = decimal.Parse(reader["MontoTotal"].ToString()),
                        NumeroFactura = int.Parse(reader["NumeroFactura"].ToString()),
                        FechaCompra = DateTime.Parse(reader["FechaCompra"].ToString()),
                        Obj_proveedor =  new  Proveedores 
                        {
                            ID_proveedor = Convert.ToInt32(reader["ID_proveedor"]),
                            RazonSocial = reader["Proveedor"].ToString()
                        },
                        Obj_usuarios = new Usuarios
                        {
                            ID_usuarios = Convert.ToInt32(reader["ID_usuarios"]),
                            Nombre = reader["Usuario"].ToString(),
                            Apellido = reader["Usuario"].ToString()

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
            
            return listaCompra;
        }

        public void EditarCompra(Compra compra)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE Compras SET  NumeroCompra = @NumeroCompra, MontoTotal = @MontoTotal, NumeroFactura = @NumeroFactura, FechaCompra = @FechaCompra, ID_proveedor = @ID_proveedor,  ID_usuarios = @ID_usuarios, Obj_ID_Tipo_Doc = @Obj_ID_Tipo_Doc WHERE ID_compra = @ID_compra";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@NumeroCompra", compra.NumeroCompra);
                cmd.Parameters.AddWithValue("@MontoTotal", compra.MontoTotal);
                cmd.Parameters.AddWithValue("@NumeroFactura", compra.NumeroFactura);
                cmd.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                cmd.Parameters.AddWithValue("@Obj_proveedor", compra.Obj_proveedor);
                cmd.Parameters.AddWithValue("@Obj_usuarios", compra.Obj_usuarios); // Convertir "Activo"/"Inactivo" a bit
                cmd.Parameters.AddWithValue("@Obj_ID_Tipo_Doc", compra.Obj_Tipo_Doc); // Convertir "Activo"/"Inactivo" a bit
                cmd.Parameters.AddWithValue("@ID_compra", compra.ID_compra);

                cmd.ExecuteNonQuery();

            }
            /* catch (SqlException ex)
             {
                 if (ex.Message.Contains("UQ_Clientes_Documento"))
                 {
                     throw new Exception("El valor de 'Documento' ya existe. No se permiten duplicados.", ex);
                 }
                 else if (ex.Message.Contains("UQ_Clientes_Telefono"))
                 {
                     throw new Exception("El valor de 'Telefono' ya existe. No se permiten duplicados.", ex);
                 }
                 else if (ex.Message.Contains("UQ_Clientes_Correo"))
                 {
                     throw new Exception("El valor de 'Correo' ya existe. No se permiten duplicados.", ex);
                 }
                 else
                 {
                     throw new Exception("Error de base de datos desconocido: " + ex.Message, ex);
                 }
             }*/
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }
        /*public Compra ObtenerCompraPorID(int ID_compra)
        {
            Compra compra = null;
            try
            {
                conexion.Open();
                string query = "SELECT * FROM Compra WHERE ID_compra = @ID_compra";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_compra", ID_compra);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    compra = new Compra
                    {
                        ID_compra = Convert.ToInt32(reader["ID_compra"]),
                        NumeroCompra = Convert.ToInt32(reader["NumeroCompra"]),
                        MontoTotal = Convert.ToInt32(reader["MontoTotal"]),
                        NumeroFactura = Convert.ToInt32(reader["NumeroFactura"]),
                        Obj_proveedor = Convert.ToInt32(reader["Obj_proveedor"]),
                        Obj_usuarios = Convert.ToInt32(reader["Obj_usuarios"]),
                        Obj_ID_Tipo_Doc = Convert.ToInt32(reader["Obj_ID_Tipo_Doc"].ToString()),
                        FechaCompra = reader["FechaCompra"].ToString(),
                      
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return compra;
        }*/


    }
}
