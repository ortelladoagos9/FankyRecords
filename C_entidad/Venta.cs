using FankyRecords.C_presentacion.Administrador;
using FankyRecords.C_presentacion.Modales;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Clientes Obj_cliente { get; set; }
        public Usuarios Obj_usuarios { get; set; }
        public TipoDoc Obj_Tipo_Doc { get; set; }
        // Inicializar la lista para evitar referencias nulas
        public List<DetalleVenta> Obj_DetalleVenta { get; set; } = new List<DetalleVenta>();
    }
}