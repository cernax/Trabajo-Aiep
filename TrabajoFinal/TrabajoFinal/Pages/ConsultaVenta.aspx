<%@ Page Title="ConsultaVenta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaVenta.aspx.cs" Inherits="TrabajoFinal.Pages.ConsultaVenta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <%--<li>
                    <div>
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModal">Nuevo</button>
                    </div>
                </li>--%>
                <li>
                    <div style="padding-left: 15px" class="align-middle">
                        <div class="input-group input-group-sm mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="inputGroup-sizing-sm">Mes Desde</span>
                            </div>
                            <input type="month" id="txtfechadesde" runat="server" step="1" min="2010-12" max="2099-12" class="form-control align-middle" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm" >
                         </div>
                    </div>
                </li>
                <li>
                    <div style="padding-left: 15px" class="align-middle">
                        <asp:Button ID="btnBuscar" name="btnBuscar" class="btn btn-primary" OnClick="btnBuscar_Click" runat="server" Text="Buscar" />                    
                    </div>
                </li>
            </ol>
        </nav>
    </div>
    <div class="container">
        <asp:GridView
            runat="server"
            ID="gvConsultaVenta"
            EmptyDataText="Sin Información"
            CssClass="table table-hover"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True"  ShowHeaderWhenEmpty="true"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="cNombreDoc" HeaderText="Tipo Documento" DataFormatString="{0:N0}" ReadOnly="true" />
                <asp:BoundField DataField="Id_NCorrelativo" HeaderText="N° Documento"  ReadOnly="true"/>
                <asp:BoundField DataField="dFechaDocumento" HeaderText="Fecha Documento" DataFormatString="{0:dd/MM/yyyy}"  ReadOnly="true"/>
                <asp:BoundField DataField="dFechaVigencia" HeaderText="Fecha Videncia" DataFormatString="{0:dd/MM/yyyy}"  ReadOnly="true"/>
                <asp:BoundField DataField="cNombreEmpresa" HeaderText="Nombre Ciudad" />
                <asp:BoundField DataField="cNombreCliente" HeaderText="Nombre Comuna" />
                <asp:BoundField DataField="cDireccion" HeaderText="Dirección" />
                <asp:BoundField DataField="cNombreFP" HeaderText="Forma de Pago" />
                <asp:BoundField DataField="iTotalNeto" HeaderText="Total Neto" />
                <asp:BoundField DataField="dTotalPorcentaje" HeaderText="% Descuento" />
                <asp:BoundField DataField="iTotalDescuento" HeaderText="Total Descuento" />
                <asp:BoundField DataField="iTotalIva" HeaderText="Total Iva" />                
                <asp:BoundField DataField="iTotalGeneral" HeaderText="Total General" />
                <asp:BoundField DataField="bEmitido" HeaderText="Emitida" />
                <asp:BoundField DataField="bVigencia" HeaderText="Vigente" />

            </Columns>
        </asp:GridView>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="exampleModalLabel">Nuevo Cliente</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>                       
                        <div class="form-group">
                            <label for="exampleInputEmail1">Email address</label>
                            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" hidden="hidden">
                             <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Password</label>
                            <input type="password" class="form-control" id="exampleInputPassword1" hidden="hidden">
                        </div>
                        <div class="form-group form-check">
                            <input type="checkbox" class="form-check-input" id="exampleCheck1" hidden="hidden">
                            <label class="form-check-label" for="exampleCheck1">Check me out</label>
                        </div>

                        <button type="submit" class="btn btn-success" runat="server" AutoPostBack="true" >Grabar</button>
                        <button type="reset" class="btn btn-primary">Limpiar</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
