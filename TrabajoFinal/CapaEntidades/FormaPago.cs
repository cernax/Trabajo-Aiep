using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class FormaPago
    {
        public int Id_FormaPago { get; set; }
        public string cNombre { get; set; }
        public int bVigencia { get; set; }

        public FormaPago()
        {
            Id_FormaPago = 0;
            cNombre = string.Empty;
            bVigencia = 0;
        }
    }
}
