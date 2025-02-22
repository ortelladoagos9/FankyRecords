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
        public List<ReporteCompras> Compra(string fechaInicio, string fechaFin, int ID_proveedor)
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
                                ID_Tipo_Doc = int.Parse(dr["ID_Tipo_Doc"].ToString()),
                                NumeroCompra = int.Parse(dr["NumeroCompra"].ToString()),
                                MontoTotal = decimal.Parse(dr["MontoTotal"].ToString()),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                CuitProveedor = dr["CuitProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = int.Parse(dr["CodigoProducto"].ToString()),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = decimal.Parse(dr["PrecioCompra"].ToString()),
                                Precioventa = decimal.Parse(dr["Precioventa"].ToString()),
                                Cantidad = int.Parse(dr["Cantidad"].ToString()),
                                SubTotal = decimal.Parse(dr["SubTotal"].ToString()),
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


        public List<ReporteVentas> Venta(string fechaInicio, string fechaFin)
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






    }
}
