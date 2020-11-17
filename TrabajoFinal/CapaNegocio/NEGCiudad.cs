using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGCiudad
    {
        ConsultaCiudad ConsCiu = new ConsultaCiudad();

        public List<Ciudad> ConsultaCiudad(Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return null;
            }
            else
            {
                return ConsCiu.ConsutaCiudad(ciudad);
            }
        }
        public List<Ciudad> BuscarCiudad(Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return null;
            }
            else
            {
                return ConsCiu.BuscarCiudad(ciudad);
            }
        }
        public bool registrarCiudad(Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return false;
            }
            else
            {
                return ConsCiu.registraCiudad(ciudad);
            }
        }
        public bool modificarCiudad(Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return false;
            }
            else
            {
                return ConsCiu.modificarCiudad(ciudad);
            }
        }
        public bool eliminarCiudad(Ciudad ciudad)
        {
            if (ciudad == null)
            {
                return false;
            }
            else
            {
                return ConsCiu.eliminarCiudad(ciudad);
            }
        }
    }
}
