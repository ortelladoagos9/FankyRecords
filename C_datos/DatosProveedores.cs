using FankyRecords.C_entidad;
using System.Data;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                INSERT INTO Proveedores(RazonSocial, Correo, Telefono, Estado, Cuit, Domicilio) 
                VALUES (@RazonSocial, @Correo, @Telefono, @Estado, @Cuit, @Domicilio)";

                SqlParameter RazonSocialParam = new SqlParameter("@RazonSocial", proveedor.RazonSocial);
                SqlParameter CorreoParam = new SqlParameter("@Correo", proveedor.Correo);
                SqlParameter TelefonoParam = new SqlParameter("@Telefono", proveedor.Telefono);
                SqlParameter EstadoParam = new SqlParameter("@Estado", proveedor.Estado);
                SqlParameter CuitParam = new SqlParameter("@Cuit", proveedor.Cuit);
                SqlParameter DomicilioParam = new SqlParameter("@Domicilio", proveedor.Domicilio);


                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(RazonSocialParam);
                cmd.Parameters.Add(CorreoParam);
                cmd.Parameters.Add(TelefonoParam);
                cmd.Parameters.Add(EstadoParam);
                cmd.Parameters.Add(CuitParam);
                cmd.Parameters.Add(DomicilioParam);


                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("UQ_Proveedores_Correo"))
                {
                    throw new Exception("El valor 'Correo' ya existe. No se permiten duplicados.", ex);
                }
                else if (ex.Message.Contains("UQ_Proveedores_Telefono"))
                {
                    throw new Exception("El valor 'Telefono' ya existe. No se permiten duplicados.", ex);
                }
                else if (ex.Message.Contains("UQ_Proveedores_Cuit"))
                {
                    throw new Exception("El valor 'Cuit' ya existe. No se permiten duplicados.", ex);
                }
                else
                {
                    throw new Exception("Error, vuelva a intentarlo", ex);
                }
            }
            finally
            {
                conexion.Close();
            }
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
                        Domicilio = reader["Domicilio"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return lista;
        }

        public void EditarProveedor(Proveedores proveedor)
        {
            try
            {
                conexion.Open();
                string query = @" update Proveedores 
                               SET RazonSocial = @RazonSocial,
                               Correo = @Correo,
                               Estado = @Estado,
                               Cuit = @Cuit,
                               Domicilio = @Domicilio
                               WHERE ID_proveedor = @ID_proveedor";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Estado", proveedor.Estado); // Almacena "Activo" o "Inactivo" 
                cmd.Parameters.AddWithValue("@Cuit", proveedor.Cuit);
                cmd.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                cmd.Parameters.AddWithValue("@ID_proveedor", proveedor.ID_proveedor); // Pasar el ID

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el proveedor", ex);
            }
            finally { conexion.Close(); }
        }

        public void EliminarProveedor(int id_proveedor)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Proveedores WHERE ID_proveedor = @ID_proveedor";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_proveedor", id_proveedor));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public bool ExisteProveedor(string RazonSocial)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Proveedores WHERE RazonSocial = @RazonSocial";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@RazonSocial", RazonSocial);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                existe = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
            return existe;
        }
    }
}
