using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Productos
    {
        public int ID_producto { get; set; }
        public int Codigo { get; set; }  
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra {  get; set; }
        public int Stock_min { get; set; }
        public string Estado { get; set; }
        public Categorias Obj_categoria { get; set; }
    }
}
