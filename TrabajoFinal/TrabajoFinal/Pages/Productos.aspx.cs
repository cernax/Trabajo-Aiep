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
    public partial class Productos : System.Web.UI.Page
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
            NEGProducto conPro = new NEGProducto();
            Producto producto = new Producto();

            gvProducto.DataSource = conPro.ConsultaProducto(producto);
            gvProducto.DataBind();
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            NEGProducto conPro = new NEGProducto();
            Producto producto = new Producto();

            producto.cNombre = txtNombre.Text.ToString();
            producto.iStock = int.Parse(txtStock.Text);
            producto.iValor = Convert.ToDecimal(txtValor.Text.ToString());
            producto.bVigencia = 1;

            if (conPro.registrarProducto(producto) == true)
            {
                CargaGrilla();
                Response.Write("<script>alert('Registro Correcto!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registro Incorrecto!');</script>");
            }
        }
    }
}