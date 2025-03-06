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
    public class DatosClientes
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarCliente(Clientes cliente)
        {
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO Clientes (Documento, Nombre, Apellido, Correo, Telefono, Domicilio, Estado) 
                VALUES (@Documento, @Nombre, @Apellido, @Correo, @Telefono, @Domicilio, @Estado)";

                SqlParameter documentoParam = new SqlParameter("@Documento", cliente.Documento);
                SqlParameter nombreParam = new SqlParameter("@Nombre", cliente.Nombre);
                SqlParameter apellidoParam = new SqlParameter("@Apellido", cliente.Apellido);
                SqlParameter correoParam = new SqlParameter("@Correo", cliente.Correo);
                SqlParameter telefonoParam = new SqlParameter("@Telefono", cliente.Telefono);
                SqlParameter domicilioParam = new SqlParameter("@Domicilio", cliente.Domicilio);
                SqlParameter estadoParam = new SqlParameter("@Estado", cliente.Estado);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(documentoParam);
                cmd.Parameters.Add(nombreParam);
                cmd.Parameters.Add(apellidoParam);
                cmd.Parameters.Add(correoParam);
                cmd.Parameters.Add(telefonoParam);
                cmd.Parameters.Add(domicilioParam);
                cmd.Parameters.Add(estadoParam);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
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

        //LISTADO DE CLIENTES PARA EL MODAL
        public List<Clientes> ListarClientesModal()
        {
            List<Clientes> listaClientes = new List<Clientes>();

            try
            {
                conexion.Open();

                string query = @"
                        select 
                            ID_cliente, 
                            Documento, 
                            CONCAT_WS(' ', Nombre, Apellido) as 'NombreCompleto',
                            Correo, 
                            Telefono, 
                            Domicilio,
                            Estado 
                        from Clientes";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaClientes.Add(new Clientes
                    {
                        ID_cliente = int.Parse(reader["ID_cliente"].ToString()),
                        Documento = reader["Documento"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Domicilio = reader["Domicilio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaClientes;
        }

        public List<Clientes> ListarClientes()
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                conexion.Open();
                string query = @"
                        select 
                            ID_cliente, 
                            Documento, 
                            Nombre, 
                            Apellido, 
                            Correo, 
                            Telefono,
                            Domicilio,
                            Estado 
                        from Clientes";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Imprimir los nombres de las columnas para depuración
                    Console.WriteLine(reader["ID_cliente"].ToString());
                    Console.WriteLine(reader["Documento"].ToString());
                    Console.WriteLine(reader["Nombre"].ToString());
                    Console.WriteLine(reader["Apellido"].ToString());
                    Console.WriteLine(reader["Correo"].ToString());
                    Console.WriteLine(reader["Telefono"].ToString());
                    Console.WriteLine(reader["Domicilio"].ToString());
                    Console.WriteLine(reader["Estado"].ToString());

                    lista.Add(new Clientes
                    {
                        ID_cliente = int.Parse(reader["ID_cliente"].ToString()),
                        Documento = reader["Documento"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Domicilio = reader["Domicilio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                    });
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
            return lista;
        }

        public void EditarCliente(Clientes cliente)
        {
            try
            {
                conexion.Open();
                string query = "UPDATE Clientes     " +
                        "SET  " +
                        "Documento = @Documento, " +
                        "Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "Correo = @Correo, " +
                        "Telefono = @Telefono,  " +
                        "Domicilio = @Domicilio, " +
                        "Estado = @Estado " +
                        "WHERE ID_cliente = @ID_cliente";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Domicilio", cliente.Domicilio);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado); // Convertir "Activo"/"Inactivo" a bit
                cmd.Parameters.AddWithValue("@ID_cliente", cliente.ID_cliente);

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
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
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public bool ExisteDocumento(string documento)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Clientes WHERE Documento = @Documento";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Documento", documento);

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

        public bool ExisteTelefono(string telefono)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Clientes WHERE Telefono = @Telefono";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);

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

        public bool ExisteCorreo(string correo)
        {
            bool existe = false;
            try
            {
                conexion.Open();
                string query = "SELECT COUNT(1) FROM Clientes WHERE Correo = @Correo";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Correo", correo);

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

        public void EliminarCliente(int ID_cliente)
        {
            try
            {
                conexion.Open();
                string query = @"
                        UPDATE Clientes
                        SET Estado = @Inactivo
                        WHERE ID_cliente = @ID_cliente";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_cliente", ID_cliente));
                cmd.Parameters.Add(new SqlParameter("@Inactivo", "Inactivo")); // Asigna el valor deseado

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public Clientes ObtenerClientePorID(int ID_cliente)
        {
            Clientes cliente = null;
            try 
            {
                conexion.Open();
                string query = "SELECT * FROM Clientes WHERE ID_cliente = @ID_cliente";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cliente = new Clientes
                    {
                        ID_cliente = Convert.ToInt32(reader["ID_cliente"]),
                        Documento = reader["Documento"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Domicilio = reader["Domicilio"].ToString(),
                        Estado = reader["Estado"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return cliente;
        }
    }
}
