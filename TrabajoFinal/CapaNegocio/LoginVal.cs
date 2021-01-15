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
        ConsultaUsers ConsUsr = new ConsultaUsers();
        public string ConsultaUsuario(Users usuario)
        {
            if (usuario == null)
            {
                return string.Empty;
            }
            else
            {
                return ConsUsr.ConsutaLogin(usuario);
            }
        }
        public bool registrarUsers(Users usuario)
        {
            if (usuario == null)
            {
                return false;
            }
            else
            {
                return ConsUsr.registraUsuario(usuario);
            }
        }
        public List<Users> BuscaUsuario(Users users)
        {
            if (users == null)
            {
                return null;
            }
            else
            {
                return ConsUsr.BuscaUsuario(users);
            }
        }
        public List<Users> BuscaPerfil(Users users)
        {
            if (users == null)
            {
                return null;
            }
            else
            {
                return ConsUsr.BuscaPerfil(users);
            }
        }
        public List<Users> ListaOpciones(Users users)
        {
            if (users == null)
            {
                return null;
            }
            else
            {
                return ConsUsr.ListaOpciones(users);
            }
        }
    }
}
