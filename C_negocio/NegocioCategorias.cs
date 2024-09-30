using FankyRecords.C_datos;
using FankyRecords.C_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FankyRecords.C_negocio
{
    public class NegocioCategorias
    {
        private DatosCategorias CD_Categorias;

        public NegocioCategorias()
        {
            CD_Categorias = new DatosCategorias();
        }

        public Categorias GuardarCategoria(Categorias categoria) 
        { 
            if (categoria.Id_categoria == 0 )
            {
                CD_Categorias.AgregarCategoria(categoria);
            }
         
            return categoria;
        }

        public List<Categorias> ListarCategorias()
        {
            return CD_Categorias.ListarCategorias();
        }
        
    }
}
