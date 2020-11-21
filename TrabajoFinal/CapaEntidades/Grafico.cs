using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Grafico
    {
        public int Cantidad { get; set; }
        public int Monto { get; set; }
        
        public Grafico()
        {
            Cantidad = 0;
            Monto = 0;
        }
    }
}

