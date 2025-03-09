using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class ReporteCategorias
    {
        public DateTime FechaVenta { get; set; }
        public int NumeroFactura { get; set; }
        public string TipoDoc { get; set; }
        public string UsuarioRegistro { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
