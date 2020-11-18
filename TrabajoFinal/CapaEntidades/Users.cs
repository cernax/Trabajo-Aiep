using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Users
    {
        public string user { get; set; }
        public string password { get; set; }
        public int rut { get; set; }
        public string dv { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string fecnacimiento { get; set; }
        public Users()
        {
            user = string.Empty;
            password = string.Empty;
            rut = 0;
            dv = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            correo = string.Empty;
            fecnacimiento = string.Empty;
        }
    }
}
