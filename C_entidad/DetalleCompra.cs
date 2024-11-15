using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class DetalleCompra
    {
        public int ID_detalleCompra { get; set; }
        public int PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public float SubTotal { get; set; }
        public Productos Obj_producto { get; set; }
        public RegistrarCompra Obj_registrarCompra { get; set; }

    }
}
