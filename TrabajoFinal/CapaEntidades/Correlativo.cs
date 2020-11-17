using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Correlativo
    {
        public int Id_Correlativo { get; set; }
        public int Id_TipoDoc { get; set; }
        public int iNInicial { get; set; }
        public int iNFinal { get; set; }
        public int bVigencia { get; set; }

        public Correlativo()
        {
            Id_Correlativo = 0;
            Id_TipoDoc = 0;
            iNInicial = 0;
            iNFinal = 0;
            bVigencia = 0;
        }
    }
}
