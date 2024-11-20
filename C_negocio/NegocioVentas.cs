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
    public class NegocioVentas
    {
       
            private DatosVentas CD_Ventas;
            public NegocioVentas()
            {
                CD_Ventas = new DatosVentas();
            }

            public Venta GuardarVenta(Venta venta)
            {
                try
                {
                    if (venta.ID_ventas == 0)
                    {
                        CD_Ventas.AgregarVenta(venta);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }

                return venta;
            }

            public List<Venta> ListarVentas()
            {
                return CD_Ventas.ListarVentas();
            }

    }
}
