using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal.Pages
{
    public partial class Empresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaGrilla();
            }
        }
        private void CargaGrilla()
        {
            NEGEmpresa conEmp = new NEGEmpresa();
            Empresa empresa = new Empresa();

            gvEmpresa.DataSource = conEmp.ConsultaEmpresa(empresa);
            gvEmpresa.DataBind();
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
            NEGEmpresa conEmp = new NEGEmpresa();
            Empresa empresa = new Empresa();

            empresa.iRut = int.Parse(txtRut.Text.ToString());
            empresa.cDv = Digito(int.Parse(txtRut.Text));
            empresa.cNombre = txtNombre.Text.ToString();
            empresa.cDireccion = txtDireccion.Text.ToString();
            empresa.cTelefono = txtTelefono.Text.ToString();
            empresa.vCorreo = txtCorreo.Text.ToString();
            empresa.bVigencia = 1;

            if (conEmp.registrarEmpresa(empresa))
            {
                CargaGrilla();
                Response.Write("<script>alert('Registro Correcto!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registro Incorrecto!');</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtfechadesde) > Convert.ToDateTime(txtfechahasta))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }
                if (Convert.ToDateTime(txtfechahasta) > Convert.ToDateTime(txtfechadesde))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }

                NEGEmpresa conEmp = new NEGEmpresa();
                Empresa empresa = new Empresa();

                empresa.dFechaDesde = Convert.ToDateTime(txtfechadesde.ToString());
                empresa.dFechaHasta = Convert.ToDateTime(txtfechahasta.ToString());

                gvEmpresa.DataSource = conEmp.ReporteEmpresa(empresa);
                gvEmpresa.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }
        }
    }
}