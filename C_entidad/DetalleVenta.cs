using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class DetalleVenta
    {
        public int ID_detalleVenta {  get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public Productos Obj_producto { get; set; }
        public Venta Obj_registrarVenta { get; set; }

    }
}
