using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;

namespace TrabajoFinal.Pages
{
    public partial class ConsultaVenta : System.Web.UI.Page
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
            NEGVenta conVenta = new NEGVenta();
            Venta venta = new Venta();

            gvConsultaVenta.DataSource = conVenta.ReporteVenta(venta);
            gvConsultaVenta.DataBind();
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
                if (Convert.ToDateTime(txtfechahasta.Value) > Convert.ToDateTime(txtfechadesde.Value))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }

                NEGVenta conVenta = new NEGVenta();
                Venta venta = new Venta();

                venta.dFechaDesde = Convert.ToDateTime(txtfechadesde.Value.ToString());
                venta.dFechaHasta = Convert.ToDateTime(txtfechahasta.Value.ToString());

                gvConsultaVenta.DataSource = conVenta.ReporteVenta(venta);
                gvConsultaVenta.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }
        }
    }
}