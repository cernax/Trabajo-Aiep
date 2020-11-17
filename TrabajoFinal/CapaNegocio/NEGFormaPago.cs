using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGFormaPago
    {
        ConsultaFormaPago ConsFP = new ConsultaFormaPago();

        public List<FormaPago> ConsultaFormaPago(FormaPago formaPago)
        {
            if (formaPago == null)
            {
                return null;
            }
            else
            {
                return ConsFP.ConsutaFormaPago(formaPago);
            }
        }
        public List<FormaPago> BuscarFormaPago(FormaPago formaPago)
        {
            if (formaPago == null)
            {
                return null;
            }
            else
            {
                return ConsFP.BuscarFormaPago(formaPago);
            }
        }
        public bool registrarFormaPago(FormaPago formaPago)
        {
            if (formaPago == null)
            {
                return false;
            }
            else
            {
                return ConsFP.registraFormaPago(formaPago);
            }
        }
        public bool modificarFormaPago(FormaPago formaPago)
        {
            if (formaPago == null)
            {
                return false;
            }
            else
            {
                return ConsFP.modificarFormaPago(formaPago);
            }
        }
        public bool eliminarFormaPago(FormaPago formaPago)
        {
            if (formaPago == null)
            {
                return false;
            }
            else
            {
                return ConsFP.eliminarFormaPago(formaPago);
            }
        }
    }
}
