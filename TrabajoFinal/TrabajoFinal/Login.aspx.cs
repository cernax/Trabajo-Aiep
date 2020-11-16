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
    }
}