using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public int iRut { get; set; }
        public string cDv { get; set; }
        public string cNombres { get; set; }
        public string cApellidos { get; set; }
        public int Id_Ciudad { get; set; }
        public string cCiudad { get; set; }
        public int Id_Comuna { get; set; }
        public string cComuna { get; set; }
        public string cDireccion { get; set; }
        public string cTelefono { get; set; }
        public string vCorreo { get; set; }
        public DateTime dFechaNacimiento { get; set; }
        public int bVigencia { get; set; }
        public DateTime dFechaCreacion { get; set; }
        public DateTime dFechaDesde { get; set; }
        public DateTime dFechaHasta { get; set; }

        public Cliente()
        {
            Id_Cliente = 0;
            iRut = 0;
            cDv = string.Empty;
            cNombres = string.Empty;
            cApellidos = string.Empty;
            Id_Ciudad = 0;
            cCiudad = string.Empty;
            Id_Comuna = 0;
            cComuna = string.Empty;
            cDireccion = string.Empty;
            cTelefono = string.Empty;
            vCorreo = string.Empty;
            dFechaNacimiento = DateTime.Now;
            bVigencia = 0;
            dFechaCreacion = DateTime.Now;
            dFechaDesde = DateTime.Now;
            dFechaHasta = DateTime.Now;
        }       
    }
}
