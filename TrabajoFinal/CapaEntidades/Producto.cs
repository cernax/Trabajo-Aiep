using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string cNombre { get; set; }
        public int iStock { get; set; }
        public decimal iValor { get; set; }
        public int bVigencia { get; set; }

        public Producto()
        {
            Id_Producto = 0;
            cNombre = string.Empty;
            iStock = 0;
            iValor = 0;
            bVigencia = 0;
        }
    }
}
