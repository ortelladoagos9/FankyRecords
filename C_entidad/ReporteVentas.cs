using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class ReporteVentas
    {
        public DateTime FechaVenta { get; set; }
        public string TipoDoc { get; set; }
        public string UsuarioRegistro { get; set; }
        public int NumeroFactura { get; set; }
        public string NombreCompleto { get; set; }
        public string Documento { get; set; }
        public decimal MontoTotal { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precioventa { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
