using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGDetDetDocumento
    {
        ConsultaDetDocumento ConsDet = new ConsultaDetDocumento();

        public List<DetDocumento> ConsultaDetDocumento(DetDocumento DetDocumento)
        {
            if (DetDocumento == null)
            {
                return null;
            }
            else
            {
                return ConsDet.ConsutaDetDocumento(DetDocumento);
            }
        }
        public List<DetDocumento> BuscarDetDocumento(DetDocumento DetDocumento)
        {
            if (DetDocumento == null)
            {
                return null;
            }
            else
            {
                return ConsDet.BuscarDetDocumento(DetDocumento);
            }
        }
        public bool registrarDetDocumento(DetDocumento DetDocumento)
        {
            if (DetDocumento == null)
            {
                return false;
            }
            else
            {
                return ConsDet.registraDetDocumento(DetDocumento);
            }
        }        
    }
}
