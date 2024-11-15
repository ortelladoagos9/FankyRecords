using FankyRecords.C_presentacion.Modales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class RegistrarCompra
    {
        public int ID_compra { get; set; }
        public int NumeroCompra { get; set; }
        public float MontoTotal { get; set; }
        public int NumeroFactura { get; set; }
        public string FechaCompra { get; set; }
        public Proveedores Obj_proveedor { get; set; }
        public Usuarios Obj_usuarios { get; set; }
        public TipoDoc Obj_ID_Tipo_Doc { get; set; }

    }
  
}
  
