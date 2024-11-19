using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    public class NegocioDetalleCompra
    {
        private readonly DatosDetalleCompra CD_DetalleCompra;
        public NegocioDetalleCompra()
        {
            CD_DetalleCompra = new DatosDetalleCompra();
        }

    }
}
