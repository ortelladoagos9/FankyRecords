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
    public class NegocioCategorias
    {
        private readonly DatosCategorias CD_Categorias;

        public NegocioCategorias()
        {
            CD_Categorias = new DatosCategorias();
        }

        public Categorias GuardarCategoria(Categorias categoria)
        {
            try
            {
                if (categoria.Id_categoria == 0)
                {
                    CD_Categorias.AgregarCategoria(categoria); // Si el ID es 0, es una nueva categoría
                }
                else
                {
                    CD_Categorias.EditarCategoria(categoria); // Si el ID es distinto de 0, es una actualización
                }
                
            }
            catch (SqlException ex) 
            {
                throw new Exception(ex.Message);
            }

            return categoria;
        }

        public bool ExisteCategoria(string descripcion)
        {
            return CD_Categorias.ExisteCategoria(descripcion);
        }

        public List<Categorias> ListarCategorias()
        {
            return CD_Categorias.ListarCategorias();
        }

        public void EliminarCategoria(int id_categoria)
        {
            try
            {
                CD_Categorias.EliminarCategoria(id_categoria);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categorias ObtenerCategoriaPorID(int Id_categoria)
        {
            return CD_Categorias.ObtenerCategoriaPorID(Id_categoria);
        }
    }
}
