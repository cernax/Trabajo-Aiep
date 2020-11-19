using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGEmpresa
    {
        ConsultaEmpresa ConsEmp = new ConsultaEmpresa();

        public List<Empresa> ConsultaEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return null;
            }
            else
            {
                return ConsEmp.ConsutaEmpresa(empresa);
            }
        }
        public List<Empresa> BuscarEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return null;
            }
            else
            {
                return ConsEmp.BuscarEmpresa(empresa);
            }
        }
        public bool registrarEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return false;
            }
            else
            {
                return ConsEmp.registraEmpresa(empresa);
            }
        }
        public bool modificarEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return false;
            }
            else
            {
                return ConsEmp.modificarEmpresa(empresa);
            }
        }
        public bool eliminarEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return false;
            }
            else
            {
                return ConsEmp.eliminarEmpresa(empresa);
            }
        }
        public List<Empresa> ReporteEmpresa(Empresa empresa)
        {
            if (empresa == null)
            {
                return null;
            }
            else
            {
                return ConsEmp.ReporteEmpresa(empresa);
            }
        }
    }
}
