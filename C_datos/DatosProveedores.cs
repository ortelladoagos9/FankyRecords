using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FankyRecords.C_datos
{
    public class DatosProveedores
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);
        public void AgregarProveedor(Proveedores proveedor)
        {
            try
            {
                conexion.Open();
                
                string query = @"
                        INSERT INTO Proveedores (RazonSocial, Correo, Telefono, Estado, Cuit, Domicilio) 
                        values (@RazonSocial, @Correo, @Telefono, @Estado, @Cuit, @Domicilio)";

                SqlParameter RazonSocial = new SqlParameter("@RazonSocial", proveedor.RazonSocial);
                SqlParameter Correo = new SqlParameter("@Correo", proveedor.Correo);
                SqlParameter Telefono = new SqlParameter("@Telefono", proveedor.Telefono);
                SqlParameter Estado = new SqlParameter("@Estado", proveedor.Estado);
                SqlParameter Cuit = new SqlParameter("@Cuit", proveedor.Cuit);
                SqlParameter Domicilio = new SqlParameter("@Domicilio", proveedor.Domicilio);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(RazonSocial);
                cmd.Parameters.Add(Correo);
                cmd.Parameters.Add(Telefono);
                cmd.Parameters.Add(Estado);
                cmd.Parameters.Add(Cuit);
                cmd.Parameters.Add(Domicilio);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }   
            finally { conexion.Close(); }
        }


        public List<Proveedores> ListarProveedores()
        {

            List<Proveedores> lista = new List<Proveedores>();

            try
            {
                conexion.Open();

                string query = @"
                        select ID_proveedor,RazonSocial,Correo,Telefono,Estado,Cuit,Domicilio from Proveedores";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Proveedores
                    {
                        ID_proveedor = int.Parse(reader["ID_proveedor"].ToString()),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Cuit = reader["Cuit"].ToString(),
                        Domicilio = reader["Domicilio"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error: "+ ex.Message, ex);
            }
            finally { conexion.Close(); }

            return lista;
        }
        public void EditarProveedor(Proveedores proveedor)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE Proveedores SET  RazonSocial = @RazonSocial, Correo = @Correo, Telefono = @Telefono,  Estado = @Estado, Cuit = @Cuit, Domicilio = @Domicilio WHERE ID_proveedor = @ID_proveedor";

                SqlCommand cmd = new SqlCommand(query, conexion);
                
                cmd.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Estado", proveedor.Estado == "Activo" ? 1 : 0); // Convertir "Activo"/"Inactivo" a bit
                cmd.Parameters.AddWithValue("@Cuit", proveedor.Cuit);
                cmd.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                cmd.Parameters.AddWithValue("@ID_proveedor", proveedor.ID_proveedor);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
        }

    }
}
