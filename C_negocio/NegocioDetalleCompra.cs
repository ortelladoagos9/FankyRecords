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

        public DetalleCompra GuardarDetalleCompra(DetalleCompra DetalleCompra)
        {
            try
            {
                if (DetalleCompra.ID_detalleCompra == 0)
                {
                    CD_DetalleCompra.AgregarDetalleCompra(DetalleCompra); // Si el ID es 0, es un nuevo producto
                }
                else
                {
                    CD_DetalleCompra.EditarDetalleCompra(DetalleCompra); // Si el ID es distinto de 0, es una actualización
                }
                return DetalleCompra;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
