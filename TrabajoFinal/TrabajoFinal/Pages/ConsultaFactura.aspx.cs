using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal.Pages
{
    public partial class ConsultaFactura : System.Web.UI.Page
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
            NEGReporte conVenta = new NEGReporte();
            Reportes venta = new Reportes();

            gvConsultaFactura.DataSource = conVenta.ReporteVenta(venta);
            gvConsultaFactura.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtfechadesde.Value) > Convert.ToDateTime(txtfechahasta.Value))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }
                if (Convert.ToDateTime(txtfechahasta.Value) < Convert.ToDateTime(txtfechadesde.Value))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }

                NEGReporte conVenta = new NEGReporte();
                Reportes venta = new Reportes();

                venta.dFechaDesde = Convert.ToDateTime(txtfechadesde.Value.ToString());
                venta.dFechaHasta = Convert.ToDateTime(txtfechahasta.Value.ToString());

                gvConsultaFactura.DataSource = conVenta.ReporteVenta(venta);
                gvConsultaFactura.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }
        }
    }
}