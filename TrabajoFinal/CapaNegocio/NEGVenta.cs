using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class NEGVenta
    {
        ConsultaVenta ConsVenta = new ConsultaVenta();
        public List<Venta> ReporteVenta(Venta venta)
        {
            if (venta == null)
            {
                return null;
            }
            else
            {
                return ConsVenta.ReporteVenta(venta);
            }
        }
    }
}
