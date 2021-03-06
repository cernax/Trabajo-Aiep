﻿using CapaEntidades;
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
            NEGReporte conVenta = new NEGReporte();
            Reportes venta = new Reportes();

            gvConsultaVenta.DataSource = conVenta.ReporteVenta(venta);
            gvConsultaVenta.DataBind();
        }
        
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                NEGReporte conVenta = new NEGReporte();
                Reportes venta = new Reportes();

                venta.dFechaDesde = Convert.ToDateTime(txtfechadesde.Value.ToString());

                var mes = venta.dFechaDesde.Month;
                var ano = venta.dFechaDesde.Year;

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