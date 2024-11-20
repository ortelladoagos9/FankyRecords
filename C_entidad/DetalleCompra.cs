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
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public Productos Obj_producto { get; set; }
        public Compra Obj_registrarCompra { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
