using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGTipoDoc
    {
        ConsultaTipoDoc ConsTipodoc = new ConsultaTipoDoc();

        public List<TipoDoc> ConsultaTipoDoc(TipoDoc tipoDoc)
        {
            if (tipoDoc == null)
            {
                return null;
            }
            else
            {
                return ConsTipodoc.ConsutaTipoDoc(tipoDoc);
            }
        }
        public List<TipoDoc> BuscarTipoDoc(TipoDoc tipoDoc)
        {
            if (tipoDoc == null)
            {
                return null;
            }
            else
            {
                return ConsTipodoc.BuscarTipoDoc(tipoDoc);
            }
        }
        public bool registrarTipoDoc(TipoDoc tipoDoc)
        {
            if (tipoDoc == null)
            {
                return false;
            }
            else
            {
                return ConsTipodoc.registraTipoDoc(tipoDoc);
            }
        }
        public bool modificarTipoDoc(TipoDoc tipoDoc)
        {
            if (tipoDoc == null)
            {
                return false;
            }
            else
            {
                return ConsTipodoc.modificarTipoDoc(tipoDoc);
            }
        }
        public bool eliminarTipoDoc(TipoDoc tipoDoc)
        {
            if (tipoDoc == null)
            {
                return false;
            }
            else
            {
                return ConsTipodoc.eliminarTipoDoc(tipoDoc);
            }
        }
    }
}
