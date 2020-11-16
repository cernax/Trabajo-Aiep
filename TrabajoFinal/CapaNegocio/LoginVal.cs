using CapaEntidades;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LoginVal
    {
        public string ConsultaUsuario(Users usuario)
        {
            if (usuario == null)
            {
                return string.Empty;
            }
            else
            {
                ConsultaUsers ConsUsr = new ConsultaUsers();
                return ConsUsr.ConsutaLogin(usuario);
            }
        }
    }
}
