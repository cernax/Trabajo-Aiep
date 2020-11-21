using System;
using CapaEntidades;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEGGrafico
    {
        ConsultaGrafico ConsGra = new ConsultaGrafico();

        public List<Grafico> ConsultaGraficoCnt(Grafico grafico)
        {
            if (grafico == null)
            {
                return null;
            }
            else
            {
                return ConsGra.ConsutaGraficoCnt(grafico);
            }
        }

        public List<Grafico> ConsultaGraficoMto(Grafico grafico)
        {
            if (grafico == null)
            {
                return null;
            }
            else
            {
                return ConsGra.ConsutaGraficoMto(grafico);
            }
        }
    }
}
