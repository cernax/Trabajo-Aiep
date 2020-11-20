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
            }
        }
        private void CargaGrilla()
        {
            NEGDocumento conCli = new NEGDocumento();
            Documento doc = new Documento();

            gvFacturas.DataSource = conCli.ConsultaDocumento(doc); 
            gvFacturas.DataBind();
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


            if (doc.registrarDocumento(docval))
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