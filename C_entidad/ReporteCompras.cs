using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_entidad
{
    public class ReporteCompras
    {
        public DateTime FechaCompra { get; set; }
        public int ID_Tipo_Doc { get; set; }
        public int   NumeroCompra { get; set; }
        public decimal MontoTotal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string CuitProveedor { get; set; }
        public string RazonSocial { get; set; }
        public int CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Precioventa { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }



    }
}
