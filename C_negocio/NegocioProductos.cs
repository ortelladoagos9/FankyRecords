using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
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
            if (productos.ID_producto == 0)
            {
                CD_Productos.AgregarProducto(productos); // Si el ID es 0, es un nuevo producto
            }
            else
            {
                //CD_Categorias.EditarCategoria(categoria); // Si el ID es distinto de 0, es una actualización
            }
            return productos;
        }

        /*public List<Categorias> ListarCategorias()
        {
            //return CD_Categorias.ListarCategorias();
        }*/
    }
}
