using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Documento
    {
        public int Id_Documento { get; set; }
        public int Id_TipoDoc { get; set; }
        public int Id_NCorrelativo { get; set; }
        public DateTime? dFechaDocumento { get; set; }
        public DateTime? dFechaVigencia { get; set; }
        public int Id_Empresa { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_FormaPago { get; set; }
        public decimal iTotalNeto { get; set; }
        public decimal dTotalPorcentaje { get; set; }
        public decimal iTotalIva { get; set; }
        public decimal iTotalDescuento { get; set; }
        public decimal iTotalGeneral { get; set; }
        public int bEmitido { get; set; }
        public int bVigencia { get; set; }
        public string tipdoc { get; set; }
        public string nomemp { get; set; }
        public string nomcli { get; set; }
        public string formpago { get; set; }

        public Documento()
        {
            Id_Documento = 0;
            Id_NCorrelativo = 0;
            dFechaDocumento = null;
            dFechaVigencia = null;
            Id_Empresa = 0;
            Id_Cliente = 0;
            Id_FormaPago = 0;
            iTotalNeto = 0;
            dTotalPorcentaje = 0;
            iTotalIva = 0;
            iTotalDescuento = 0;
            iTotalGeneral = 0;
            bEmitido = 0;
            bVigencia = 0;
            tipdoc = string.Empty;
            nomemp = string.Empty;
            nomcli = string.Empty;
            formpago = string.Empty;
        }
    }
}
