using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_datos
{
    public class DatosUsuarios
    {
        SqlConnection conexion = new SqlConnection(Conexion.cadena);

        public void AgregarUsuario(Usuarios usuario)
        {
            DateTime fechaActual = DateTime.Now;
            try
            {
                conexion.Open();

                string query = @"
                INSERT INTO Usuarios(Dni, Nombre, Apellido, Correo, Clave, FechaCreacion,Direccion, Telefono, FechaNacimiento, Estado,  ID_rol) 
                VALUES (@Dni, @Nombre, @Apellido, @Correo, @Clave, @FechaCreacion,@Direccion, @Telefono, @FechaNacimiento, @Estado, @ID_rol)";

                SqlParameter Dni = new SqlParameter("@Dni", usuario.Dni);
                SqlParameter Nombre = new SqlParameter("@Nombre", usuario.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", usuario.Apellido);
                SqlParameter Correo = new SqlParameter("@Correo", usuario.Correo);
                SqlParameter Clave = new SqlParameter("@Clave", usuario.Clave);
                SqlParameter FechaCreacion = new SqlParameter("@FechaCreacion", fechaActual);
                SqlParameter Direccion = new SqlParameter("@Direccion", usuario.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", usuario.Telefono);
                SqlParameter FechaNacimiento = new SqlParameter("@FechaNacimiento", usuario.FechaNacimiento);
                SqlParameter Estado = new SqlParameter("@Estado", usuario.Estado);
                SqlParameter ID_rol = new SqlParameter("@ID_rol", usuario.Obj_rol.ID_rol);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(Dni);
                cmd.Parameters.Add(Nombre);
                cmd.Parameters.Add(Apellido);
                cmd.Parameters.Add(Correo);
                cmd.Parameters.Add(Clave);
                cmd.Parameters.Add(FechaCreacion);
                cmd.Parameters.Add(Direccion);
                cmd.Parameters.Add(Telefono);
                cmd.Parameters.Add(FechaNacimiento);
                cmd.Parameters.Add(Estado);
                cmd.Parameters.Add(ID_rol);

                cmd.ExecuteNonQuery();
            }/*
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UQ_Usuarios_dni"))
                {
                    throw new Exception("El dni ya existe. No se permite duplicados", ex);
                }
                else if (ex.Message.Contains("CK_Usuarios_Edad"))
                {
                    throw new Exception("La edad del usuario debe ser mayor a 18", ex);
                }
                else if (ex.Message.Contains("CK_Usuarios_claveMin"))
                {
                    throw new Exception("La clave debe tener mas de 4 caracteres y menos de  10", ex);
                }
                else if (ex.Message.Contains("UQ_Usuarios_correo"))
                {
                    throw new Exception("El correo ya existe. No se permite duplicados", ex);
                }
                else
                {
                    throw new Exception("Error vuelva a intentarlo", ex);
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

        public List<Usuarios> ListarUsuarios()
        {

            List<Usuarios> listaUsuarios = new List<Usuarios>();

            try
            {
                conexion.Open();

                string query = @"
                        select u.ID_usuarios, u.Dni,u.Nombre,u.Apellido, u.Correo, u.Clave, u.Direccion, u.Telefono, u.Estado, u.FechaNacimiento, r.ID_rol, r.Descripcion as Rol
                        from Usuarios u inner join Rol r on u.ID_rol= r.ID_rol";

                SqlCommand cmd = new SqlCommand(query, conexion);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaUsuarios.Add(new Usuarios
                    {
                        ID_usuarios = Convert.ToInt32(reader["ID_usuarios"]),
                        Dni = reader["Dni"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                        Estado = reader["Estado"].ToString(),
                        Obj_rol = new Rol
                        {
                            ID_rol = Convert.ToInt32(reader["ID_rol"]),
                            Descripcion = reader["Rol"].ToString()
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return listaUsuarios;
        }

        public void EditarUsuarios(Usuarios usuario)
        {
            try
            {
                conexion.Open();

                // Actualizar la tabla Productos
                string queryUsuario = @"
                 UPDATE Usuarios
                 SET 
                 Dni = @NuevoDni,
                 Nombre = @NuevoNombre,
                 Apellido = @NuevaApellido,
                 Correo = @NuevoCorreo,
                 Clave = @NuevoClave,
                 Direccion = @NuevoDireccion,
                 Telefono = @NuevoTelefono,
                 FechaNacimiento = @NuevoFechaNacimiento,
                 Estado = @NuevoEstado,
                 ID_rol = @ID_rol
                 WHERE ID_usuarios = @ID_usuarios";

                SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conexion);
                cmdUsuario.Parameters.AddWithValue("@NuevoDni", usuario.Dni);
                cmdUsuario.Parameters.AddWithValue("@NuevoNombre", usuario.Nombre);
                cmdUsuario.Parameters.AddWithValue("@NuevaApellido", usuario.Apellido);
                cmdUsuario.Parameters.AddWithValue("@NuevoCorreo", usuario.Correo);
                cmdUsuario.Parameters.AddWithValue("@NuevoClave", usuario.Clave);
                cmdUsuario.Parameters.AddWithValue("@NuevoDireccion", usuario.Direccion);
                cmdUsuario.Parameters.AddWithValue("@NuevoTelefono", usuario.Telefono);
                cmdUsuario.Parameters.AddWithValue("@NuevoFechaNacimiento", usuario.FechaNacimiento);
                cmdUsuario.Parameters.AddWithValue("@NuevoEstado", usuario.Estado);
                cmdUsuario.Parameters.AddWithValue("@ID_usuarios", usuario.ID_usuarios);
                cmdUsuario.Parameters.AddWithValue("@ID_rol", usuario.Obj_rol.ID_rol);

                cmdUsuario.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el usuario y el rol", ex);
            }
            finally
            {
                conexion.Close();
            }
        }


        public void EliminarUsuarios(int ID_usuarios)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Usuarios WHERE ID_usuario = @ID_usuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@ID_usuarios", ID_usuarios));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }
        }

        public Usuarios ObtenerUsuariosPorID(int ID_usuarios)
        {
            Usuarios usuarios = null;
            try
            {
                conexion.Open();
                string query = @"
                         select u.ID_usuarios, u.Dni, u.Nombre, u.Apellido, u.Correo, u.Clave, u.Direccion, u.Telefono, u.FechaNacimiento, u.Estado, r.ID_rol, r.Descripcion as Rol 
                         from Usuarios u inner join Rol r on u.ID_rol= r.ID_rol WHERE u.ID_usuarios = @ID_usuarios";


                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@ID_usuarios", ID_usuarios);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuarios = new Usuarios
                    {
                        ID_usuarios = int.Parse(reader["ID_usuarios"].ToString()),
                        Dni = reader["Dni"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString()),
                        Estado = reader["Estado"].ToString(),
                        Obj_rol = new Rol
                        {
                            ID_rol = int.Parse(reader["ID_rol"].ToString()),
                            Descripcion = reader["Rol"].ToString()
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado: " + ex.Message, ex);
            }
            finally { conexion.Close(); }

            return usuarios;
        }



    }
}
