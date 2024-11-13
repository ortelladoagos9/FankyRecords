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
    public class NegocioCompras
    {
        private DatosCompra CD_Compras;
        public NegocioCompras()
        {
            CD_Compras = new DatosCompra();
        }

        public RegistrarCompra GuardarCompra(RegistrarCompra compra)
        {
            try
            {
                if (compra.ID_compra == 0)
                {
                    CD_Compras.AgregarCompra(compra);
                }
                else
                {
                    CD_Compras.EditarCompra(compra);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return compra;
        }
    }
}
