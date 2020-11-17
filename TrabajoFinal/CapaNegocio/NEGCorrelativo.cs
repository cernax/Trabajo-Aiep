using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGCorrelativo
    {
        ConsultaCorrelativo ConsCor = new ConsultaCorrelativo();

        public List<Correlativo> ConsultaCorrelativo(Correlativo correlativo)
        {
            if (correlativo == null)
            {
                return null;
            }
            else
            {
                return ConsCor.ConsutaCorrelativo(correlativo);
            }
        }
        public List<Correlativo> BuscarCorrelativo(Correlativo correlativo)
        {
            if (correlativo == null)
            {
                return null;
            }
            else
            {
                return ConsCor.BuscarCorrelativo(correlativo);
            }
        }
        public bool registrarCorrelativo(Correlativo correlativo)
        {
            if (correlativo == null)
            {
                return false;
            }
            else
            {
                return ConsCor.registraCorrelativo(correlativo);
            }
        }
        public bool modificarCorrelativo(Correlativo correlativo)
        {
            if (correlativo == null)
            {
                return false;
            }
            else
            {
                return ConsCor.modificarCorrelativo(correlativo);
            }
        }
        public bool eliminarCorrelativo(Correlativo correlativo)
        {
            if (correlativo == null)
            {
                return false;
            }
            else
            {
                return ConsCor.eliminarCorrelativo(correlativo);
            }
        }
    }
}
