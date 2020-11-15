using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal.Pages
{
    public partial class Facturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow row = dt.NewRow();
            dt.Columns.Add("ID");
            dt.Columns.Add("TipoFactura");
            dt.Columns.Add("Monto");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cliente");
            row["ID"] = 1;
            row["TipoFactura"] = "Factura";
            row["Monto"] = 50000;
            row["Producto"] = "Prod";
            row["Cliente"] = "Woller";
            dt.Rows.Add(row);

            gvFacturas.DataSource = dt;
            gvFacturas.DataBind();
        }
    }
}