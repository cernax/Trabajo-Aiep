using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoDoc
    {
        public int Id_TipoDoc { get; set; }
        public string cNombre { get; set; }
        public int bVigencia { get; set; }

        public TipoDoc()
        {
            Id_TipoDoc = 0;
            cNombre = string.Empty;
            bVigencia = 0;
        }
    }
}
