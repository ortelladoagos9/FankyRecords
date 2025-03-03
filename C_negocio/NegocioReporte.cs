using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System.Data.SqlClient;

namespace FankyRecords.C_negocio
{
    public class NegocioReporte
    {
        
        private readonly DatosReporte objcd_reporte;

        public NegocioReporte()
        {
            objcd_reporte = new DatosReporte();
        }
         public List<ReporteCompras> Compra(DateTime fechaInicio, DateTime fechaFin, int ID_proveedor)
        {
            return objcd_reporte.Compra(fechaInicio, fechaFin, ID_proveedor);
        }

        public List<ReporteVentas> Venta(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_reporte.Venta(fechaInicio, fechaFin);
        }

        


    }
}
