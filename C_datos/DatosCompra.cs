using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;
using System.Data;
using FankyRecords.C_presentacion.Modales;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace FankyRecords.C_datos
{
    public class DatosCompra
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);
        
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            try
            {
                conexion.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select count(*) + 1 from Compras");
                SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                //cmd.CommandType = CommandType.Text;

                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                {
                    idcorrelativo = Convert.ToInt32(resultado);
                }

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de SQL: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el correlativo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return idcorrelativo;
        }

        public bool RegistrarCompra(Compra compra, DataTable detalleCompra, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", conexion);
                cmd.Parameters.AddWithValue("NumeroCompra", compra.NumeroCompra);
                cmd.Parameters.AddWithValue("MontoTotal", compra.MontoTotal);
                cmd.Parameters.AddWithValue("NumeroFactura", compra.NumeroFactura);
                cmd.Parameters.AddWithValue("FechaCompra", compra.FechaCompra);
                cmd.Parameters.AddWithValue("ID_proveedor", compra.Obj_proveedor.ID_proveedor);
                cmd.Parameters.AddWithValue("ID_usuarios", compra.Obj_usuarios.ID_usuarios);
                cmd.Parameters.AddWithValue("ID_Tipo_Doc", compra.Obj_Tipo_Doc.ID_Tipo_Doc);
                cmd.Parameters.AddWithValue("DetalleCompra", detalleCompra);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        //OBTIENE LA COMPRA POR NUMERO DE COMPRA
        public Compra ObtenerCompra(string numero)
        {
            Compra objCompra = null;  // Solo se inicializa si hay datos
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = @"
                       select c.ID_compras, c.NumeroCompra, c.MontoTotal as 'Total pagado', 
                              c.NumeroFactura, convert(char(10), c.FechaCompra, 103) as 'Fecha Compra', 
                              p.Cuit as 'CUIT Proveedor', p.RazonSocial as 'Razon Social Proveedor',
                              CONCAT_WS(' ', u.Nombre, u.Apellido) as 'Usuario',
                              td.Descripcion as 'Tipo Documento'
                        from Compras c
                        inner join Usuarios u on u.ID_usuarios = c.ID_usuarios
                        inner join Proveedores p on p.ID_proveedor = c.ID_proveedor
                        inner join Tipo_documento td on td.ID_Tipo_Doc = c.ID_Tipo_Doc
                        where c.NumeroCompra = @numero";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // Solo leer una fila
                        {
                            objCompra = new Compra()
                            {
                                ID_compras = Convert.ToInt32(reader["ID_compras"]),
                                Obj_usuarios = new Usuarios() { NombreCompleto = reader["Usuario"].ToString() },
                                Obj_proveedor = new Proveedores()
                                {
                                    Cuit = reader["CUIT Proveedor"].ToString(),
                                    RazonSocial = reader["Razon Social Proveedor"].ToString()
                                },
                                Obj_Tipo_Doc = new TipoDoc() { Descripcion = reader["Tipo Documento"].ToString() },
                                NumeroCompra = Convert.ToInt32(reader["NumeroCompra"]),
                                MontoTotal = Convert.ToDecimal(reader["Total pagado"]),
                                FechaCompra = Convert.ToDateTime(reader["Fecha Compra"]),
                                NumeroFactura = Convert.ToInt32(reader["NumeroFactura"])
                            };
                        }
                    }
                }

                if (objCompra != null)
                {
                    objCompra.Obj_DetalleCompra = ObtenerDetalleCompra(objCompra.ID_compras);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la compra: " + ex.Message, ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return objCompra;
        }

        //LISTADO DE COMPRAS PARA EL MODAL
        public List<Compra> ListarCompras()
        {
            List<Compra> listaCompras = new List<Compra>();

            try
            {
                conexion.Open();

                string query = @"
                        select c.ID_compras,
                        c.NumeroCompra,
                        c.MontoTotal as 'Total pagado',
                        c.NumeroFactura,
                        convert(char(10), c.FechaCompra, 103) as 'Fecha Compra', 
                        p.Cuit as 'CUIT Proveedor', p.RazonSocial as 'Razon Social Proveedor',
                        CONCAT_WS(' ', u.Nombre, u.Apellido) as 'Usuario',
                        td.Descripcion as 'Tipo Documento'
                        from Compras c
                        inner join Usuarios u
                        on u.ID_usuarios = c.ID_usuarios
                        inner join Proveedores p
                        on p.ID_proveedor = c.ID_proveedor
                        inner join Tipo_documento td
                        on td.ID_Tipo_Doc = c.ID_Tipo_Doc";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaCompras.Add(new Compra
                    {
                        ID_compras = Convert.ToInt32(reader["ID_compras"]),
                        NumeroCompra = Convert.ToInt32(reader["NumeroCompra"]),
                        MontoTotal = reader["Total pagado"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Total pagado"]),
                        NumeroFactura = Convert.ToInt32(reader["NumeroFactura"]),
                        FechaCompra = Convert.ToDateTime(reader["Fecha Compra"].ToString()),
                        Obj_proveedor = new Proveedores() { Cuit = reader["CUIT Proveedor"].ToString(), RazonSocial = reader["Razon Social Proveedor"].ToString() },
                        Obj_usuarios = new Usuarios() { NombreCompleto = reader["Usuario"].ToString() },
                        Obj_Tipo_Doc = new TipoDoc() { Descripcion = reader["Tipo documento"].ToString() }                      
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaCompras;
        }

        //OBTIENE EL DETALLE DE COMPRA POR ID_COMPRA
        public List<DetalleCompra> ObtenerDetalleCompra(int id_compra)
        {
            List<DetalleCompra> listaDetalleCompra = new List<DetalleCompra>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = @"
                        select p.Codigo, p.Nombre, p.Descripcion,  
                               FORMAT(dc.PrecioCompra, 'N2', 'es-ES') AS PrecioCompra, 
                               FORMAT(p.PrecioVenta, 'N2', 'es-ES') AS PrecioVenta,
                               dc.Cantidad, 
                               FORMAT(dc.SubTotal, 'N2', 'es-ES') AS SubTotal  
                        from Detalle_Compras dc
                        inner join Productos p on p.ID_producto = dc.ID_producto
                        where dc.ID_compras = @id_compra";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_compra", id_compra);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDetalleCompra.Add(new DetalleCompra()
                            {
                                Obj_producto = new Productos()
                                {
                                    Codigo = Convert.ToInt32(reader["Codigo"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"])
                                },
                                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                SubTotal = Convert.ToDecimal(reader["SubTotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los detalles de la compra: " + ex.Message, ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return listaDetalleCompra;
        }
    }
}
