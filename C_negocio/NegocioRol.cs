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

        public List<Rol> ListarRol()
        {
            return CD_Rol.ListarRol();
        }

    }
}
