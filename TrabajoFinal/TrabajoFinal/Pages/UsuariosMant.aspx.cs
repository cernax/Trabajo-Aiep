using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;

namespace TrabajoFinal.Pages
{
    public partial class UsuariosMant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaGrilla();
            CargaPerfil(0);
        }
        private void CargaGrilla()
        {
            LoginVal Use = new LoginVal();
            Users usuarios = new Users();

            gvUsuario.DataSource = Use.BuscaUsuario(usuarios);
            gvUsuario.DataBind();

            gvOpciones.DataSource = Use.ListaOpciones(usuarios);
            gvOpciones.DataBind();

        }
        private void CargaPerfil(int user)
        {
            LoginVal Use = new LoginVal();
            Users usuario = new Users();

            ListaPerfil.Items.Clear();
            ListaPerfil.DataTextField = "nombreperfil";
            ListaPerfil.DataValueField = "id_perfil";

            ListaPerfil.DataSource = Use.BuscaPerfil(usuario);
            ListaPerfil.DataBind();
            ListaPerfil.Items.Insert(0, "- Seleccione Perfil -");

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