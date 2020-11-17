using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGComuna
    {
        ConsultaComuna ConsCom = new ConsultaComuna();

        public List<Comuna> ConsultaComuna(Comuna comuna)
        {
            if (comuna == null)
            {
                return null;
            }
            else
            {
                return ConsCom.ConsutaComuna(comuna);
            }
        }
        public List<Comuna> BuscarComuna(Comuna comuna)
        {
            if (comuna == null)
            {
                return null;
            }
            else
            {
                return ConsCom.BuscarComuna(comuna);
            }
        }
        public bool registrarComuna(Comuna comuna)
        {
            if (comuna == null)
            {
                return false;
            }
            else
            {
                return ConsCom.registraComuna(comuna);
            }
        }
        public bool modificarComuna(Comuna comuna)
        {
            if (comuna == null)
            {
                return false;
            }
            else
            {
                return ConsCom.modificarComuna(comuna);
            }
        }
        public bool eliminarComuna(Comuna comuna)
        {
            if (comuna == null)
            {
                return false;
            }
            else
            {
                return ConsCom.eliminarComuna(comuna);
            }
        }
    }
}
