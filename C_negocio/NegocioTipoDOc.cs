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
    public class NegocioTipoDOc
    {
        private readonly DatosTipoDoc CD_TipoDoc;

        public NegocioTipoDOc()
        {
            CD_TipoDoc = new DatosTipoDoc();
        }

        public List<TipoDoc> ListarTipoDoc()
        {
            return CD_TipoDoc.ListarTipoDoc();
        }
    }
}
