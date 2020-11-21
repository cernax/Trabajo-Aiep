using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            if (!IsPostBack)
            {
                CargaGrilla();
                CargaTipoDoc();
                CargaEmpresa();
                CargaCliente();
                CargaFormaPago();
                CargaProducto();
                fecdoc.Value = DateTime.Now.ToString("yyyy-MM-dd");
                fecvig.Value = DateTime.Today.AddDays(30).ToString("yyyy-MM-dd");
            }
        }
        private void CargaGrilla()
        {
            NEGDocumento conCli = new NEGDocumento();
            Documento doc = new Documento();

            gvFacturas.DataSource = conCli.ConsultaDocumento(doc);
            gvFacturas.DataBind();
        }
        private void CargaProducto()
        {
            NEGProducto negprod = new NEGProducto();
            Producto prod = new Producto();

            Session["tbProd"] = negprod.ConsultaProducto(prod);

            //int valor = Session["tbProd"];

            ddlproducto.Items.Clear();
            ddlproducto.DataTextField = "cNombre";
            ddlproducto.DataValueField = "Id_Producto";
            ddlproducto.DataSource = Session["tbProd"];
            ddlproducto.DataBind();
            ddlproducto.Items.Insert(0, "- Seleccione -");
        }
        private void CargaEmpresa()
        {
            NEGEmpresa negempresa = new NEGEmpresa();
            Empresa emp = new Empresa();


            ddlNomEmp.Items.Clear();
            ddlNomEmp.DataTextField = "cNombre";
            ddlNomEmp.DataValueField = "Id_Empresa";
            ddlNomEmp.DataSource = negempresa.ConsultaEmpresa(emp);
            ddlNomEmp.DataBind();
            ddlNomEmp.Items.Insert(0, "- Seleccione -");
        }
        private void CargaCliente()
        {
            NEGCliente negcliente = new NEGCliente();
            Cliente cli = new Cliente();


            ddlNomCli.Items.Clear();
            ddlNomCli.DataTextField = "cNombres";
            ddlNomCli.DataValueField = "Id_Cliente";
            ddlNomCli.DataSource = negcliente.ConsultaCliente(cli);
            ddlNomCli.DataBind();
            ddlNomCli.Items.Insert(0, "- Seleccione -");
        }
        private void CargaFormaPago()
        {
            NEGFormaPago negformpago = new NEGFormaPago();
            FormaPago formpago = new FormaPago();


            ddlFormPago.Items.Clear();
            ddlFormPago.DataTextField = "cNombre";
            ddlFormPago.DataValueField = "Id_FormaPago";
            ddlFormPago.DataSource = negformpago.ConsultaFormaPago(formpago);
            ddlFormPago.DataBind();
            ddlFormPago.Items.Insert(0, "- Seleccione -");
        }
        private void CargaTipoDoc()
        {
            NEGTipoDoc negtipodoc = new NEGTipoDoc();
            TipoDoc tipodoc = new TipoDoc();

            ddlTipoDoc.Items.Clear();
            ddlTipoDoc.DataTextField = "cNombre";
            ddlTipoDoc.DataValueField = "Id_TipoDoc";
            ddlTipoDoc.DataSource = negtipodoc.ConsultaTipoDoc(tipodoc);
            ddlTipoDoc.DataBind();
            ddlTipoDoc.Items.Insert(0, "- Seleccione -");

            ddlTipoDoc.SelectedIndex = 1;
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            int nomemp = int.Parse(ddlNomEmp.SelectedValue);
            int nomcli = int.Parse(ddlNomCli.SelectedValue);
            int forpago = int.Parse(ddlFormPago.SelectedValue);
            int tipdoc = int.Parse(ddlTipoDoc.SelectedValue);
            int totalneto = int.Parse(txtTotalNeto.Value);
            int totalporcentaje = int.Parse(txtTotalPorcentaje.Value);
            int totaliva = int.Parse(txtTotalIva.Value);
            int totaldescuento = int.Parse(txtTotalDescuento.Value);
            int totalgeneral = int.Parse(txtTotalGeneral.Value);

            NEGDocumento doc = new NEGDocumento();
            Documento docval = new Documento();

            docval.Id_Empresa = int.Parse(ddlNomEmp.SelectedValue);
            docval.Id_Cliente = int.Parse(ddlNomCli.SelectedValue);
            docval.Id_FormaPago = int.Parse(ddlFormPago.SelectedValue);
            docval.Id_TipoDoc = int.Parse(ddlTipoDoc.SelectedValue);
            docval.iTotalNeto = int.Parse(txtTotalNeto.Value);
            docval.dTotalPorcentaje = int.Parse(txtTotalPorcentaje.Value);
            docval.iTotalIva = int.Parse(txtTotalIva.Value);
            docval.iTotalDescuento = int.Parse(txtTotalDescuento.Value);
            docval.iTotalGeneral = int.Parse(txtTotalGeneral.Value);
            string fecdocs = string.Format("{0:yyyy-MM-dd}", fecdoc.Value);
            string fecvigs = string.Format("{0:yyyy-MM-dd}", fecvig.Value);
            docval.dFechaDocumento = fecdocs;
            docval.dFechaVigencia = fecvigs;

            Session["cntUsuario"] = int.Parse(Session["cntUsuario"].ToString()) + 1;


            if (ddlNomEmp.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe selecionar Empresa');</script>");
                return;
            }
            if (ddlNomCli.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe selecionar Cliente');</script>");
                return;
            }
            if (ddlFormPago.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe selecionar Forma de pago');</script>");
                return;
            }
            //if (detalle.Count == 0)
            //{
            //    Response.Write("<script>alert('Debe Agregar detalle al documeno');</script>");
            //    return;
            //}
            else if (doc.registrarDocumento(docval))
            {
                CargaGrilla();
                Response.Write("<script>alert('Registro Correcto!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registro Incorrecto!');</script>");
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {

            if (ddlproducto.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe selecionar Empresa');</script>");
                return;
            }
            if (int.Parse(txtTotal.Value.Replace(".","")) == 0)
            {
                Response.Write("<script>alert('Debe Ingresar cantidad de productos');</script>");
                return;
            }
            else
            {
                List<Producto> lista = new List<Producto>();

                Producto agregar = new Producto();

                agregar.Id_Producto = int.Parse(ddlproducto.SelectedIndex.ToString());
                agregar.cNombre = ddlproducto.SelectedItem.Text.Trim();
                agregar.iValor = int.Parse(Session["valorprod"].ToString().Replace(".", ""));

                lista.Add(agregar);

                gvdetFact.DataSource = lista;
                gvdetFact.DataBind();

                txtTotalNeto.Value = (int.Parse(txtTotalNeto.Value.Replace(".", "")) + int.Parse(txtTotal.Value.Replace(".",""))).ToString("N0");

                double iva = double.Parse(ConfigurationManager.AppSettings.Get("IVA").ToString());
                double neto = double.Parse(txtTotalNeto.Value);
                double valor = (neto * iva) / 100;
                double general = (neto - valor);

                txtTotalIva.Value = valor.ToString("N0");
                txtTotalGeneral.Value = general.ToString("N0");
            }
        }

        protected void ddlproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlproducto.SelectedIndex != 0)
            {
                NEGProducto negprod = new NEGProducto();
                Producto prod = new Producto();
                prod.Id_Producto = ddlproducto.SelectedIndex;
                List<Producto> prodselect = negprod.BuscarProducto(prod);

                foreach (var i in prodselect)
                {
                    txtTotal.Value = int.Parse(i.iValor.ToString()).ToString("N0");
                    Session["valorprod"] = txtTotal.Value;
                }
                txtCant.Text = "1";
            }
            else
            {
                txtCant.Text = "0";
                txtTotal.Value = "";
            }
        }

        protected void txtCant_TextChanged(object sender, EventArgs e)
        {
            if (txtCant.Text != "" || txtCant.Text != "0")
            {
                txtTotal.Value = (int.Parse(txtTotal.Value.Replace(".","")) * int.Parse(txtCant.Text)).ToString("N0");
            }
        }
    }
}