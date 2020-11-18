using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;

namespace TrabajoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            var psw = txtpsw.Text;
            var user = txtuser.Text;
            string est;

            Users usr = new Users();
            usr.password = psw;
            usr.user = user;

            LoginVal consUser = new LoginVal();
            est = consUser.ConsultaUsuario(usr);

            if (est != string.Empty)
                Response.Redirect("https://localhost:44382/Default?NomUser=" + est);
            else
                Response.Redirect("https://localhost:44382/Login");
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.password = txtclave.Text;
            usr.user = txtnomuser.Text;
            usr.rut = int.Parse(txtrut.Text);
            usr.dv = Digito(int.Parse(txtrut.Text));
            usr.nombre = txtnombre.Text;
            usr.apellido = txtapellido.Text;
            usr.correo = txtCorreo.Text;
            string fecnac = string.Format("{0:yyyy-MM-dd}", txtfecnac.Text);
            usr.fecnacimiento = fecnac.Replace("/", "-") + " 00:00:00.000";
            LoginVal consUser = new LoginVal();
            if (consUser.registrarUsers(usr))
                Response.Redirect("https://localhost:44382/Login");

        }
    }
}