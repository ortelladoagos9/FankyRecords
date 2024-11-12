using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    public class NegocioProveedores
    {
        private readonly DatosProveedores CD_Proveedores;

        public NegocioProveedores()
        {
            CD_Proveedores = new DatosProveedores();
        }

        public Proveedores GuardarProveedor(Proveedores proveedor)
        {
            try
            {
                if (proveedor.ID_proveedor == 0)
                {
                    CD_Proveedores.AgregarProveedor(proveedor); // Si el ID es 0, es una nueva categoría
                }
                else
                {
                    CD_Proveedores.EditarProveedor(proveedor); // Si el ID es distinto de 0, es una actualización
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return proveedor;
        }
        public bool ExisteProveedor(string RazonSocial)
        {
            return CD_Proveedores.ExisteProveedor(RazonSocial);
        }

        public List<Proveedores> ListarProveedores()
        {
            return CD_Proveedores.ListarProveedores();
        }

        public void EliminarProveedor(int id_proveedor)
        {
            CD_Proveedores.EliminarProveedor(id_proveedor);
        }

        public Proveedores ObtenerProveedoresPorID(int ID_proveedor)
        {
            // Llamar al método que consulta la base de datos y devolver el resultado
            return CD_Proveedores.ObtenerProveedoresPorID(ID_proveedor);
        }

    }
}
