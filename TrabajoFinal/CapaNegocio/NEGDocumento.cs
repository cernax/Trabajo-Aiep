using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGDocumento
    {
        ConsultaDocumento ConsDoc = new ConsultaDocumento();

        public List<Documento> ConsultaDocumento(Documento Documento)
        {
            if (Documento == null)
            {
                return null;
            }
            else
            {
                return ConsDoc.ConsutaDocumento(Documento);
            }
        }
        public List<Documento> BuscarDocumento(Documento Documento)
        {
            if (Documento == null)
            {
                return null;
            }
            else
            {
                return ConsDoc.BuscarDocumento(Documento);
            }
        }
        public bool registrarDocumento(Documento Documento)
        {
            if (Documento == null)
            {
                return false;
            }
            else
            {
                return ConsDoc.registraDocumento(Documento);
            }
        }
        public bool EmitirDocumento(Documento Documento)
        {
            if (Documento == null)
            {
                return false;
            }
            else
            {
                return ConsDoc.emitirDocumento(Documento);
            }
        }
        public bool eliminarDocumento(Documento Documento)
        {
            if (Documento == null)
            {
                return false;
            }
            else
            {
                return ConsDoc.eliminarDocumento(Documento);
            }
        }
    }
}
