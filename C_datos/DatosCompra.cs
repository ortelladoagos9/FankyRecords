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
        public void AgregarCompra(RegistrarCompra compra)
        {
            try
            {
                conexion.Open(); 

                string query = @"
                INSERT INTO Compras (NumeroCompra,  MontoTotal, NumeroFactura, FechaCompra, Obj_proveedor, Obj_usuarios,ID_Tipo_Doc) 
                VALUES (@NumeroCompra, @MontoTotal, @NumeroFactura, @FechaCompra, @Obj_proveedor, @Obj_usuarios, @ID_Tipo_Doc)";

                SqlParameter NumeroCompraParam = new SqlParameter("@NumeroCompra", compra.NumeroCompra);
                SqlParameter MontoTotalParam = new SqlParameter("@MontoTotal", compra.MontoTotal);
                SqlParameter NumeroFacturaParam = new SqlParameter("@NumeroFactura", compra.NumeroFactura);
                SqlParameter FechaCompraParam = new SqlParameter("@FechaCompra", compra.FechaCompra);
                SqlParameter Obj_proveedorParam = new SqlParameter("@Obj_proveedor", compra.Obj_proveedor);
                SqlParameter Obj_usuariosParam = new SqlParameter("@Obj_usuarios", compra.Obj_usuarios);
                SqlParameter ID_Tipo_DocParam = new SqlParameter("@ID_Tipo_Doc", compra.ID_Tipo_Doc);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(NumeroCompraParam);
                cmd.Parameters.Add(MontoTotalParam);
                cmd.Parameters.Add(NumeroFacturaParam);
                cmd.Parameters.Add(FechaCompraParam);
                cmd.Parameters.Add(Obj_proveedorParam);
                cmd.Parameters.Add(Obj_usuariosParam);
                cmd.Parameters.Add(ID_Tipo_DocParam);

                cmd.ExecuteNonQuery();
            }
            /*         catch (SqlException ex)
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
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<RegistrarCompra> ListarCompras()
        {
            List<RegistrarCompra> lista = new List<RegistrarCompra>();
            try
            {
                conexion.Open();
                string query = @"select ID_compras, NumeroCompra,  MontoTotal, NumeroFactura, FechaCompra, ID_proveedor, ID_usuarios,ID_Tipo_Doc from Compras";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Imprimir los nombres de las columnas para depuración
                    Console.WriteLine(reader["ID_compras"].ToString());
                    Console.WriteLine(reader["NumeroCompra"].ToString());
                    Console.WriteLine(reader["MontoTotal"].ToString());
                    Console.WriteLine(reader["NumeroFactura"].ToString());
                    Console.WriteLine(reader["FechaCompra"].ToString());
                    Console.WriteLine(reader["Obj_proveedor"].ToString());
                    Console.WriteLine(reader["Obj_usuarios"].ToString());
                    Console.WriteLine(reader["ID_Tipo_Doc"].ToString());

                    lista.Add(new RegistrarCompra
                    {
                        ID_compra = int.Parse(reader["ID_compra"].ToString()),
                        NumeroCompra = int.Parse(reader["NumeroCompra"].ToString()),
                        MontoTotal = int.Parse(reader["MontoTotal"].ToString()),
                        NumeroFactura = int.Parse(reader["NumeroFactura"].ToString()),
                        FechaCompra = reader["FechaCompra"].ToString(),
                        Obj_proveedor = reader["Obj_proveedor"],
                        Obj_usuarios = int.Parse(reader["Obj_usuarios"].ToString()),
                        Obj_ID_Tipo_Doc = int.Parse(reader["Obj_ID_Tipo_Doc"].ToString()),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public void EditarCompra(RegistrarCompra compra)
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
                cmd.Parameters.AddWithValue("@Obj_ID_Tipo_Doc", compra.Obj_ID_Tipo_Doc); // Convertir "Activo"/"Inactivo" a bit
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
        public RegistrarCompra ObtenerCompraPorID(int ID_compra)
        {
            RegistrarCompra compra = null;
            try
            {
                conexion.Open();
                string query = "SELECT * FROM RegistrarCompra WHERE ID_compra = @ID_compra";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_compra", ID_compra);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    compra = new RegistrarCompra
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
        }


    }
}
