using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string parametro = Request.QueryString["NomUser"];
                lblNomUser.Text = "Bienvenido " + parametro;                
            }

            Grafico();
        }

        private void Grafico()
        {
            NEGGrafico conGra = new NEGGrafico();
            Grafico grafico = new Grafico();

            Session["cntUsuario"] = (Session["cntUsuario"] == null ? 0 : Session["cntUsuario"]);
            Session["MtoUsuario"] = (Session["MtoUsuario"] == null ? 0 : Session["MtoUsuario"]);

            Session["cntBase"] = 0;
            Session["MtoBase"] = 0;

            var Cantidad = conGra.ConsultaGraficoCnt(grafico);

            if (Cantidad != null)
            {
                if (Cantidad.Count > 0)
                {
                    Session["cntBase"] = conGra.ConsultaGraficoCnt(grafico).FirstOrDefault().Cantidad;

                    int Cnt = int.Parse(Session["cntUsuario"].ToString()) + int.Parse(Session["cntBase"].ToString());
                    Session["Cntmaximo"] = Cnt;
                }
                else
                {
                    Session["Cntmaximo"] = 10;
                }
            }
            else
            {
                Session["Cntmaximo"] = 10;
            }

            var Monto = conGra.ConsultaGraficoCnt(grafico);

            if (Monto != null)
            {
                if (Monto .Count> 0)
                {
                    Session["MtoBase"] = conGra.ConsultaGraficoMto(grafico).FirstOrDefault().Monto;

                    decimal Mto = int.Parse(Session["MtoUsuario"].ToString()) + int.Parse(Session["MtoBase"].ToString());
                    Session["Montomaximo"] = Mto;
                }
                else
                {
                    Session["Montomaximo"] = 1000;
                }
            }
            else
            {
                Session["Montomaximo"] = 1000;
            }
        }
    }
}