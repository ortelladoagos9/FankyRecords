using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class TipoDoc
    {
        public int ID_Tipo_Doc { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion; // Ahora mostrará el valor correcto
        }
    }
}
