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

        public bool ExisteCuit(string cuit)
        {
            return CD_Proveedores.ExisteCuit(cuit);
        }
        public bool ExisteTelefono(string telefono)
        {
            return CD_Proveedores.ExisteTelefono(telefono);
        }

        public bool ExisteCorreo(string correo)
        {
            return CD_Proveedores.ExisteCorreo(correo);
        }

        public bool ExisteRazonSocial(string razonSocial)
        {
            return CD_Proveedores.ExisteRazonSocial(razonSocial);
        }

        public List<Proveedores> ListarProveedores()
        {
            return CD_Proveedores.ListarProveedores();
        }

        public void EliminarProveedor(int ID_proveedor)
        {
            CD_Proveedores.EliminarProveedor(ID_proveedor);
        }
    }
}
