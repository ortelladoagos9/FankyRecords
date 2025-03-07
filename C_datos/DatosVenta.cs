using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FankyRecords.C_presentacion.Modales;
using System.Windows.Media.Media3D;
using System.Reflection;

namespace FankyRecords.C_datos
{
    internal class DatosVenta
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            try
            {
                conexion.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select count(*) + 1 from Ventas");
                SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

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

        public bool RegistrarVentas(Venta venta, DataTable detalleVenta, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", conexion);
                cmd.Parameters.AddWithValue("NumeroFactura", venta.NumeroFactura);
                cmd.Parameters.AddWithValue("MontoTotal", venta.MontoTotal);
                cmd.Parameters.AddWithValue("FechaVenta", venta.FechaVenta);
                cmd.Parameters.AddWithValue("ID_cliente", venta.Obj_cliente.ID_cliente);
                cmd.Parameters.AddWithValue("ID_usuarios", venta.Obj_usuarios.ID_usuarios);
                cmd.Parameters.AddWithValue("ID_Tipo_Doc", venta.Obj_Tipo_Doc.ID_Tipo_Doc);
                cmd.Parameters.Add(new SqlParameter("@DetalleVenta", SqlDbType.Structured)
                {
                    TypeName = "Detalle_Ventas",
                    Value = detalleVenta
                });
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

        //OBTIENE LA VENTA POR NUMERO DE VENTA
        public Venta ObtenerVenta(string Numero_Factura)
        {
            Venta objVenta = null;  // Solo se inicializa si hay datos
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = @"
                        select v.ID_ventas, v.NumeroFactura, v.MontoTotal as 'Total pagado', 
                           convert(char(10), v.FechaVenta, 103) as 'Fecha Venta', 
                           c.Documento as 'DNI Cliente', 
	                       CONCAT_WS(' ', c.Nombre, c.Apellido) as 'Nombre Completo',
	                       CONCAT_WS(' ', u.Nombre, u.Apellido) as 'Usuario',
                           td.Descripcion as 'Tipo Documento'
                        from Ventas v
                        inner join Usuarios u on u.ID_usuarios = v.ID_usuarios
                        inner join Clientes c on c.ID_cliente = v.ID_cliente
                        inner join Tipo_documento td on td.ID_Tipo_Doc = v.ID_Tipo_Doc
                        where v.NumeroFactura = @Numero_Factura";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Numero_Factura", Numero_Factura);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  // Solo leer una fila
                        {
                            objVenta = new Venta()
                            {
                                ID_ventas = Convert.ToInt32(reader["ID_ventas"]),
                                Obj_usuarios = new Usuarios() { NombreCompleto = reader["Usuario"].ToString() },
                                Obj_cliente = new Clientes()
                                {
                                    Documento = reader["DNI Cliente"].ToString(),
                                    NombreCompleto = reader["Nombre Completo"].ToString()
                                },
                                Obj_Tipo_Doc = new TipoDoc() { Descripcion = reader["Tipo Documento"].ToString() },
                                NumeroFactura = Convert.ToInt32(reader["NumeroFactura"]),
                                MontoTotal = Convert.ToDecimal(reader["Total pagado"]),
                                FechaVenta = Convert.ToDateTime(reader["Fecha Venta"])
                            };
                        }
                    }
                }

                if (objVenta != null)
                {
                    objVenta.Obj_DetalleVenta = ObtenerDetalleVenta(objVenta.ID_ventas);
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

            return objVenta;
        }

        //LISTADO DE VENTAS PARA EL MODAL
        public List<Venta> ListarVentas()
        {
            List<Venta> listaVentas = new List<Venta>();

            try
            {
                conexion.Open();
                
                string query = @"
                        select v.ID_ventas, 
                               v.NumeroFactura, 
                               v.MontoTotal as 'Total pagado', 
                               convert(char(10), v.FechaVenta, 103) as 'Fecha Venta', 
                               c.Documento as 'DNI Cliente', 
	                           CONCAT_WS(' ', c.Nombre, c.Apellido) as 'Nombre Completo',
                               c.Domicilio,
	                           CONCAT_WS(' ', u.Nombre, u.Apellido) as 'Usuario',
                               td.Descripcion as 'Tipo Documento'
                        from Ventas v
                        inner join Usuarios u on u.ID_usuarios = v.ID_usuarios
                        inner join Clientes c on c.ID_cliente = v.ID_cliente
                        inner join Tipo_documento td on td.ID_Tipo_Doc = v.ID_Tipo_Doc";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaVentas.Add(new Venta
                    {
                        ID_ventas = Convert.ToInt32(reader["ID_ventas"]),
                        Obj_usuarios = new Usuarios() { NombreCompleto = reader["Usuario"].ToString() },
                        Obj_cliente = new Clientes()
                        {
                            Documento = reader["DNI Cliente"].ToString(),
                            NombreCompleto = reader["Nombre Completo"].ToString(),
                            Domicilio = reader["Domicilio"].ToString()
                        },
                        Obj_Tipo_Doc = new TipoDoc() { Descripcion = reader["Tipo Documento"].ToString() },
                        NumeroFactura = Convert.ToInt32(reader["NumeroFactura"]),
                        MontoTotal = Convert.ToDecimal(reader["Total pagado"]),
                        FechaVenta = Convert.ToDateTime(reader["Fecha Venta"])
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaVentas;
        }

        //OBTIENE EL DETALLE DE VENTA POR ID_VENTA
        public List<DetalleVenta> ObtenerDetalleVenta(int id_venta)
        {
            List<DetalleVenta> listaDetalleVenta = new List<DetalleVenta>();

            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = @"
                        select p.Codigo, p.Nombre, p.Descripcion,  
                               FORMAT(dv.PrecioVenta, 'N2', 'es-ES') AS PrecioVenta, 
                               dv.Cantidad, 
                               FORMAT(dv.SubTotal, 'N2', 'es-ES') AS SubTotal  
                        from Detalle_Ventas dv
                        inner join Productos p on p.ID_producto = dv.ID_producto
                        where dv.ID_ventas = @id_venta";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_venta", id_venta);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDetalleVenta.Add(new DetalleVenta()
                            {
                                Obj_producto = new Productos()
                                {
                                    Codigo = Convert.ToInt32(reader["Codigo"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString()
                                },
                                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
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

            return listaDetalleVenta;
        }
    }
}