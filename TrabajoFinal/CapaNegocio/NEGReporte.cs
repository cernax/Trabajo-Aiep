using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class NEGReporte
    {
        ConsultaReporte ConsReporte= new ConsultaReporte();
        public List<Reportes> ReporteVenta(Reportes venta)
        {
            if (venta == null)
            {
                return null;
            }
            else
            {
                return ConsReporte.ReporteVenta(venta);
            }
        }

        public List<Reportes> ReporteFactura(Reportes venta)
        {
            if (venta == null)
            {
                return null;
            }
            else
            {
                return ConsReporte.ReporteFactura(venta);
            }
        }
    }
}
