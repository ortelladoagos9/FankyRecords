using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_entidad;
using System.Data.SqlClient;
using System.Data;

namespace FankyRecords.C_datos
{
    public class DatosReporte
    {
        public List<ReporteCompras> Compra(DateTime fechaInicio, DateTime fechaFin, int ID_proveedor)
        {
            List<ReporteCompras> lista = new List<ReporteCompras>();


            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", conexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("IdProveedor", ID_proveedor);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompras()
                            {
                                FechaCompra = DateTime.Parse(dr["fechaCompra"].ToString()),
                                NumeroFactura = int.Parse(dr["NumeroFactura"].ToString()),
                                NumeroCompra = int.Parse(dr["NumeroCompra"].ToString()),
                                TipoDoc = dr["TipoDoc"].ToString(),
                                MontoTotal = decimal.Parse(dr["MontoTotal"].ToString()),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                CuitProveedor = dr["CuitProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = int.Parse(dr["CodigoProducto"].ToString()),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                PrecioCompra = decimal.Parse(dr["PrecioCompra"].ToString()),
                                Cantidad = int.Parse(dr["Cantidad"].ToString())
                            });
                        }   
                    }
                }
                catch(Exception ex) 
                {
                    lista = new List<ReporteCompras>();
                }
            }
            return lista;
        }

        public List<ReporteVentas> Venta(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();


            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", conexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", fechaFin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVentas()
                            {
                                FechaVenta= DateTime.Parse(dr["fechaVenta"].ToString()),
                                ID_Tipo_Doc = int.Parse(dr["ID_Tipo_Doc"].ToString()),
                                NumeroFactura= int.Parse(dr["NumeroFactura"].ToString()),
                                MontoTotal = decimal.Parse(dr["MontoTotal"].ToString()),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                ID_cliente = int.Parse(dr["ID_cliente"].ToString()),
                                CodigoProducto = int.Parse(dr["CodigoProducto"].ToString()),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                Precioventa = decimal.Parse(dr["Precioventa"].ToString()),
                                Cantidad = int.Parse(dr["Cantidad"].ToString()),
                                SubTotal = decimal.Parse(dr["SubTotal"].ToString()),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVentas>();
                }

            }
            return lista;
        }

        public List<ReporteCategorias> ReporteCategorias(DateTime fechaInicio, DateTime fechaFin, int id_categoria)
        {
            List<ReporteCategorias> listaReporteCategorias = new List<ReporteCategorias>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCategorias", conexion);
                    cmd.Parameters.AddWithValue("fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("idCategoria", id_categoria);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaReporteCategorias.Add(new ReporteCategorias()
                            {
                                FechaVenta = DateTime.Parse(dr["FechaVenta"].ToString()),
                                NumeroFactura = int.Parse(dr["NumeroFactura"].ToString()),
                                TipoDoc = dr["TipoDoc"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                CodigoProducto = int.Parse(dr["CodigoProducto"].ToString()),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                DescripcionProducto = dr["DescripcionProducto"].ToString(),
                                PrecioVenta = decimal.Parse(dr["PrecioVenta"].ToString()),
                                Cantidad = int.Parse(dr["Cantidad"].ToString()),
                                SubTotal = decimal.Parse(dr["SubTotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
                }
            }
            return listaReporteCategorias;
        }

    }
}
