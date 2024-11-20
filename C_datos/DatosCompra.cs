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

        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();
            try
            {
                conexion.Open();
                string query = @"
                        select c.ID_compras,
                        CONCAT_WS(' ', u.Nombre, u.Apellido) as Usuario,
                        p.Cuit, p.RazonSocial,
                        td.Descripcion, c.NumeroCompra, c.MontoTotal,
                        convert(char(10), c.FechaCompra, 103) as 'FechaCompra',c.NumeroFactura
                        from [dbo].[Compras] c
                        inner join [dbo].[Usuarios] u
                        on u.ID_usuarios = c.ID_usuarios
                        inner join [dbo].[Proveedores] p
                        on p.ID_proveedor = c.ID_proveedor
                        inner join [dbo].[Tipo_documento] td
                        on td.ID_Tipo_Doc = c.ID_Tipo_Doc
                        where c.NumeroCompra = @numero";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@numero", numero);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    obj = new Compra()
                    {
                        ID_compra = Convert.ToInt32(reader["ID_compras"]),
                        Obj_usuarios = new Usuarios() { NombreCompleto = reader["Usuario"].ToString() },
                        Obj_proveedor = new Proveedores() { Cuit = reader["Cuit"].ToString(), RazonSocial = reader["RazonSocial"].ToString() },
                        Obj_Tipo_Doc = new TipoDoc() { Descripcion = reader["Descripcion"].ToString() },
                        NumeroCompra = Convert.ToInt32(reader["NumeroCompra"].ToString()),
                        MontoTotal = Convert.ToDecimal(reader["MontoTotal"].ToString()),
                        FechaCompra = Convert.ToDateTime(reader["FechaCompra"].ToString()),
                        NumeroFactura = Convert.ToInt32(reader["NumeroFactura"].ToString())
                    };
                } 
            }
            catch (Exception ex)
            {
                obj = new Compra();
            }
            finally
            { conexion.Close(); }

            return obj;
        }


        public List<DetalleCompra> ObtenerDetalleCompra(int id_compra)
        {
            List<DetalleCompra> listaDetalleCompra = new List<DetalleCompra>();
            try
            {
                conexion.Open();
                string query = @"
                        select p.Codigo, p.Nombre, dc.PrecioCompra, dc.Cantidad,dc.SubTotal
                        from [dbo].[Detalle_Compras] dc
                        inner join [dbo].[Productos] p
                        on p.ID_producto = dc.ID_producto
                        where dc.ID_compras = @id_compra";
                
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id_compra", id_compra);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    listaDetalleCompra.Add(new DetalleCompra ()
                    {
                        Obj_producto = new Productos() { Codigo = Convert.ToInt32(reader["Codigo"].ToString()), Nombre = reader["Nombre"].ToString() },
                        PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"].ToString()),
                        Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                        SubTotal = Convert.ToDecimal(reader["SubTotal"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                listaDetalleCompra = new List<DetalleCompra>();
            }
            finally
            { conexion.Close(); }
            
            return listaDetalleCompra;
        }
    }
}
