using FankyRecords.C_presentacion.Modales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Venta
    {
        public int ID_ventas { get; set; }
        public int NumeroFactura { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaVenta { get; set; }
        public Usuarios Obj_usuarios { get; set; }
        public Clientes Obj_clientes { get; set; }
        public TipoDoc Obj_Tipo_Doc { get; set; }

      
    }
}
