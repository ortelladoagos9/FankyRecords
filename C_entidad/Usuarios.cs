using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Usuarios
    {
        public int ID_usuarios { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public  string Estado { get; set; }
        public Rol Obj_rol { get; set; }

        public string RolDescripcion => Obj_rol?.Descripcion;
    }
}
