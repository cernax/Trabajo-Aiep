using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGProducto
    {
        ConsultaProducto ConsPro = new ConsultaProducto();

        public List<Producto> ConsultaProducto(Producto producto)
        {
            if (producto == null)
            {
                return null;
            }
            else
            {                
                return ConsPro.ConsutaProducto(producto);
            }
        }
        public List<Producto> BuscarProducto(Producto producto)
        {
            if (producto == null)
            {
                return null;
            }
            else
            {
                return ConsPro.BuscarProducto(producto);
            }
        }
        public bool registrarProducto(Producto producto)
        {
            if (producto == null)
            {
                return false;
            }
            else
            {
                return ConsPro.registraProducto(producto);
            }
        }
        public bool modificarProducto(Producto producto)
        {
            if (producto == null)
            {
                return false;
            }
            else
            {
                return ConsPro.modificarProducto(producto);
            }
        }
        public bool eliminarProducto(Producto producto)
        {
            if (producto == null)
            {
                return false;
            }
            else
            {
                return ConsPro.eliminarProducto(producto);
            }
        }

        public List<Producto> ReporteProducto(Producto producto)
        {
            if (producto == null)
            {
                return null;
            }
            else
            {
                return ConsPro.ReporteProducto(producto);
            }
        }
    }
}
