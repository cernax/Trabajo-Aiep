using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empresa
    {
        public int Id_Empresa { get; set; }
        public int iRut { get; set; }
        public string cDv { get; set; }
        public string cNombre { get; set; }
        public string cDireccion { get; set; }
        public string cTelefono { get; set; }
        public string vCorreo { get; set; }
        public int bVigencia { get; set; }
        public DateTime dFechaCreacion { get; set; }
        public DateTime dFechaDesde { get; set; }
        public DateTime dFechaHasta { get; set; }
        public Empresa()
        {
            iRut = 0;
            cDv = string.Empty;
            cNombre = string.Empty;
            cDireccion = string.Empty;
            cTelefono = string.Empty;
            vCorreo = string.Empty;
            bVigencia = 0;
            dFechaCreacion = DateTime.Now;
            dFechaDesde = DateTime.Now;
            dFechaHasta = DateTime.Now;
        }
    }
}
