using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGCliente
    {
        ConsultaCliente ConsCli = new ConsultaCliente();

        public List<Cliente> ConsultaCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return null;
            }
            else
            {
                return ConsCli.ConsutaCliente(cliente);
            }
        }
        public List<Cliente> BuscarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return null;
            }
            else
            {
                return ConsCli.BuscarCliente(cliente);
            }
        }
        public bool registrarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return false;
            }
            else
            {
                return ConsCli.registraCliente(cliente);
            }
        }
        public bool modificarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return false;
            }
            else
            {
                return ConsCli.modificarCliente(cliente);
            }
        }
        public bool eliminarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return false;
            }
            else
            {
                return ConsCli.eliminarCliente(cliente);
            }
        }
        public List<Cliente> ReporteCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return null;
            }
            else
            {
                return ConsCli.ReporteCliente(cliente);
            }
        }
    }
}
