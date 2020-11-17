using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ciudad
    {
        public int Id_Ciudad { get; set; }
        public string cNombre { get; set; }
        public int bVigencia { get; set; }

        public Ciudad()
        {
            Id_Ciudad = 0;
            cNombre = string.Empty;
            bVigencia = 0;
        }
    }
}
