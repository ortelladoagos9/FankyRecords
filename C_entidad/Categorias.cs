using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Categorias
    {
        public int Id_categoria { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        // Sobrescribe el método ToString para devolver la descripción
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
