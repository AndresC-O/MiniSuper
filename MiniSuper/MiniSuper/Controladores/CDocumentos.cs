using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CDocumentos
    {
        MDocumentos mDocumentos = new MDocumentos();

        public void RegistrarDocumento(Documentos d)
        {
            mDocumentos.RegistrarDocumento(d);
        }

        public void ActualizarDocumento(Documentos d)
        {
            mDocumentos.ActualizarDocumento(d);
        }

        public void EliminarDocumento(Documentos d)
        {
            mDocumentos.EliminarDocumento(d);
        }

        public List<Documentos> ListadoDocumentos()
        {
            return mDocumentos.ListadoDocumentos();
        }
    }
}
