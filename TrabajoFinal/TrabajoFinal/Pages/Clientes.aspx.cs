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
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaGrilla();
                CargaCiudad();
            }
        }
        private void CargaGrilla()
        {
            NEGCliente conCli = new NEGCliente();
            Cliente cliente = new Cliente();

            gvCliente.DataSource = conCli.ConsultaCliente(cliente);
            gvCliente.DataBind();
        }
        private void CargaCiudad()
        {
            NEGCiudad conCiu = new NEGCiudad();
            Ciudad ciudad = new Ciudad();

            ListaComuna.Items.Clear();
            ListaComuna.Items.Insert(0, "- Seleccione Comuna -");

            ListaCiudad.Items.Clear();
            ListaCiudad.DataTextField = "cNombre";
            ListaCiudad.DataValueField = "Id_Ciudad";
            ListaCiudad.DataSource = conCiu.ConsultaCiudad(ciudad);
            ListaCiudad.DataBind();
            ListaCiudad.Items.Insert(0, "- Seleccione Ciudad -");
        }
        private void CargaComuna(int Ciudad)
        {
            NEGComuna conCom = new NEGComuna();
            Comuna comuna = new Comuna();

            comuna.Id_Ciudad = Ciudad;

            ListaComuna.Items.Clear();
            ListaComuna.DataTextField = "cNombre";
            ListaComuna.DataValueField = "Id_Comuna";
            ListaComuna.DataSource = conCom.BuscarComuna(comuna);
            ListaComuna.DataBind();
            ListaComuna.Items.Insert(0, "- Seleccione Comuna -");
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

        protected void gvCliente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCliente.EditIndex = e.NewEditIndex;
            CargaCiudad();
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            NEGCliente conCli = new NEGCliente();
            Cliente cliente = new Cliente();

            var rut = txtRut.Text.ToString();

            cliente.iRut = int.Parse(txtRut.Text.ToString());
            cliente.cDv = Digito(int.Parse(txtRut.Text));
            cliente.cNombres = txtNombres.Text.ToString();
            cliente.cApellidos = txtApellidos.Text.ToString();
            cliente.Id_Ciudad = int.Parse(ListaCiudad.SelectedValue.ToString());
            cliente.Id_Comuna = int.Parse(ListaComuna.SelectedValue.ToString());
            cliente.cDireccion = txtDireccion.Text.ToString();
            cliente.cTelefono = txtTelefono.Text.ToString();
            cliente.vCorreo = txtCorreo.Text.ToString(); 
            string fecnac = string.Format("{0:yyyy-MM-dd}", txtFechaNacimiento.Text);
            cliente.dFechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            cliente.bVigencia = 1;

            if (conCli.registrarCliente(cliente))
            {
                CargaGrilla();
                Response.Write("<script>alert('Registro Correcto!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registro Incorrecto!');</script>");
            }
        }

        protected void ListaCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaComuna(int.Parse(ListaCiudad.SelectedIndex.ToString()));
        }

        protected void CancRow_Click(object sender, EventArgs e)
        {
            gvCliente.EditIndex = -1;
            CargaCiudad();
        }

        protected void gvCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCliente.PageIndex = e.NewPageIndex;
            CargaCiudad();
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

                NEGCliente conCli = new NEGCliente();
                Cliente cliente = new Cliente();

                cliente.dFechaDesde = Convert.ToDateTime(txtfechadesde.ToString());
                cliente.dFechaHasta = Convert.ToDateTime(txtfechahasta.ToString());

                gvCliente.DataSource = conCli.ReporteCliente(cliente);
                gvCliente.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error de Sistema. Comuniquese con el administrador'" + ex.Message.ToString() + "</script>");
            }
        }
    }
}