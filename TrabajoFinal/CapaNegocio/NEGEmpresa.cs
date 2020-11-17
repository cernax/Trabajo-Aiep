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

        public List<Empresa> ConsultaProducto(Empresa empresa)
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
        public List<Empresa> BuscarProducto(Empresa empresa)
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
        public bool registrarProducto(Empresa empresa)
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
        public bool modificarProducto(Empresa empresa)
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
        public bool eliminarProducto(Empresa empresa)
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
    }
}
