using FankyRecords.C_presentacion.Modales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class Compra
    {
        public int ID_compra { get; set; }
        public int NumeroCompra { get; set; }
        public decimal MontoTotal { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime FechaCompra { get; set; }
        public Proveedores Obj_proveedor { get; set; }
        public Usuarios Obj_usuarios { get; set; }
        public TipoDoc Obj_Tipo_Doc { get; set; }
        // Inicializar la lista para evitar referencias nulas
        public List<DetalleCompra> Obj_DetalleCompra { get; set; } = new List<DetalleCompra>();

    }
  
}
  
