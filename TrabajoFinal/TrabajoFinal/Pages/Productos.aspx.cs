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
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtValor.Text = string.Empty;
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }        
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Convert.ToDateTime(txtfechadesde.Value) > Convert.ToDateTime(txtfechahasta.Value))
                //{
                //    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                //    return;
                //}
                if (Convert.ToDateTime(txtfechahasta.Value) > Convert.ToDateTime(txtfechadesde.Value))
                {
                    Response.Write("<script>alert('Fechas Invalidas!');</script>");
                    return;
                }

                NEGProducto conPro = new NEGProducto();
                Producto producto = new Producto();

                producto.dFechaDesde = Convert.ToDateTime(txtfechadesde.Value);
                producto.dFechaHasta = Convert.ToDateTime(txtfechahasta.Value);

                gvProducto.DataSource = conPro.ReporteProducto(producto);
                gvProducto.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}