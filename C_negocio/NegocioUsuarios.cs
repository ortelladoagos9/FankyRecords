using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FankyRecords.C_negocio
{
    public class NegocioUsuarios
    {
        private readonly DatosUsuarios CD_Usuarios;

        public NegocioUsuarios()
        {
            CD_Usuarios = new DatosUsuarios();
        }

        public Usuarios GuardarUsuarios(Usuarios usuarios)
        {
            try
            {
                if (usuarios.ID_usuarios == 0)
                {
                    CD_Usuarios.AgregarUsuario(usuarios); // Si el ID es 0, es un nuevo producto
                }
                else
                {
                    CD_Usuarios.EditarUsuarios(usuarios); // Si el ID es distinto de 0, es una actualización
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return usuarios;
        }

        public List<Usuarios> ListarUsuarios()
        {
            return CD_Usuarios.ListarUsuarios();
        }

        public void EliminarUsuarios(int ID_usuario)
        {
            try
            {
                CD_Usuarios.EliminarUsuarios(ID_usuario);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuarios ObtenerUsuariosPorID(int ID_usuarios)
        {
            // Llamar al método que consulta la base de datos y devolver el resultado
            return CD_Usuarios.ObtenerUsuariosPorID(ID_usuarios);
        }

        public bool ExisteDocumento(string dni)
        {
            return CD_Usuarios.ExisteDocumento(dni);
        }

        public bool ExisteTelefono(string telefono)
        {
            return CD_Usuarios.ExisteTelefono(telefono);
        }
        public bool ExisteCorreo(string correo)
        {
            return CD_Usuarios.ExisteCorreo(correo);
        }
    }

}

