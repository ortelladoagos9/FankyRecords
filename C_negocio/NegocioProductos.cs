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
    public class NegocioProductos
    {
        private readonly DatosProductos CD_Productos;

        public NegocioProductos()
        {
            CD_Productos = new DatosProductos();
        }

        public Productos GuardarProductos(Productos productos)
        {
            try
            {
                if (productos.ID_producto == 0)
                {
                    CD_Productos.AgregarProducto(productos); // Si el ID es 0, es un nuevo producto
                }
                else
                {
                    CD_Productos.EditarProductos(productos); // Si el ID es distinto de 0, es una actualización
                }
                return productos;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Productos> ListarProductos()
        {
            return CD_Productos.ListarProductos();
        }

        public void EliminarProductos(int ID_producto)
        {
            try
            {
                CD_Productos.EliminarProductos(ID_producto);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Productos ObtenerProductosPorID(int ID_producto)
        {
            // Llamar al método que consulta la base de datos y devolver el resultado
            return CD_Productos.ObtenerProductosPorID(ID_producto);
        }
    }
}
