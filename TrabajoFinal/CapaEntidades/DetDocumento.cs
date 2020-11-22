using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetDocumento
    {
        public int Id_Detalle { get; set; }
        public int Id_Documento { get; set; }
        public int Id_NCorrelativo { get; set; }
        public int Id_Producto { get; set; }
        public int iCantidad { get; set; }
        public decimal iTotalParcial { get; set; }
        public string nomprod { get; set; }
        public DetDocumento()
        {
            Id_Detalle = 0;
            Id_Documento = 0;
            Id_NCorrelativo = 0;
            Id_Producto = 0;
            iCantidad = 0;
            iTotalParcial = 0;
            nomprod = string.Empty;
        }
    }
}
