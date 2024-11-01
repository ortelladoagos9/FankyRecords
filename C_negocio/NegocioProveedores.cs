using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    internal class NegocioProveedores
    {
        private DatosProveedores CD_Proveedores;

        public NegocioProveedores()
        {
            CD_Proveedores = new DatosProveedores();
        }

        public Proveedores GuardarProveedor(Proveedores proveedor)
        {
            if (proveedor.ID_proveedor == 0)
            {
                CD_Proveedores.AgregarProveedor(proveedor);
            }
            else
            {
                CD_Proveedores.EditarProveedor(proveedor);
            }
            return proveedor;
        }

        public List<Proveedores> ListarProveedores()
        {
            return CD_Proveedores.ListarProveedores();
        }
    }
}
