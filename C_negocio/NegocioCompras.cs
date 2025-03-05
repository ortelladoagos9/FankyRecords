using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System.Data.SqlClient;
using System.Data;

namespace FankyRecords.C_negocio
{
    public class NegocioCompras
    {
        private DatosCompra CD_Compras;
        public NegocioCompras()
        {
            CD_Compras = new DatosCompra();
        }

        public int ObtenerCorrelativo()
        {
            return CD_Compras.ObtenerCorrelativo();
        }

        public bool RegistrarCompra(Compra compra, DataTable detalleCompra, out string Mensaje)
        {
            return CD_Compras.RegistrarCompra(compra,detalleCompra,out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            return CD_Compras.ObtenerCompra(numero);
        }

        public List<Compra> ListarCompras()
        {
            return CD_Compras.ListarCompras();
        }
    }
}
