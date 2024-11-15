using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    public class NegocioRol
    {
        private readonly DatosRol CD_Rol;

        public NegocioRol()
        {
            CD_Rol = new DatosRol();
        }
        public Categorias GuardarRol(Rol rol)
        {
            try
            {
                if (rol.ID_rol == 0)
                {
                    CD_Rol.AgregarRol(rol); // Si el ID es 0, es una nueva categoría
                }
                else
                {
                    CD_Rol.EditarCategoria(rol); // Si el ID es distinto de 0, es una actualización
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return rol;
        }

        public bool ExisteRol(string descripcion)
        {
            return CD_Rol.ExisteRol(descripcion);
        }

        public List<Rol> ListarRol()
        {
            return CD_Rol.ListarCRol();
        }

        public void EliminarRol(int id_rol)
        {
            try
            {
                CD_Rol.EliminarRol(id_rol);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Rol ObtenerRolPorID(int Id_rol)
        {
            return CD_Rol.ObtenerRolPorID(Id_rol);
        }





    }
}
