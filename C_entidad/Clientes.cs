using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Clientes
    {
        public int ID_cliente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string  Correo { get; set; }
        public string  Telefono {  get; set; }
        public string  Estado {  get; set; }
    }
}
