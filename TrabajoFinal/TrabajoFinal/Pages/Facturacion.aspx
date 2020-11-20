<%@ Page Title="Factura" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="TrabajoFinal.Pages.Facturacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li>
                <div>
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModal">Nuevo</button>
                </div>
            </li>
            <li>
                <div style="width: 400px"></div>
            </li>
        </ol>
    </nav>
    <div class="container">
        <asp:GridView runat="server" ID="gvFacturas"
            AutoGenerateColumns="False"
            EmptyDataText="No data available." ShowHeader="true"
            CssClass="table table-hover"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="Id_Documento" HeaderText="ID" />
                <asp:BoundField DataField="tipdoc" HeaderText="Tipo Factura" />
                <asp:BoundField DataField="dFechaDocumento" HeaderText="Producto" />
                <asp:BoundField DataField="dFechaVigencia" HeaderText="Cliente" />
                <asp:BoundField DataField="nomemp" HeaderText="Cliente" />
                <asp:BoundField DataField="nomcli" HeaderText="Cliente" />
                <asp:BoundField DataField="formpago" HeaderText="Cliente" />
                <asp:BoundField DataField="iTotalNeto" HeaderText="Cliente" />
                <asp:BoundField DataField="dTotalPorcentaje" HeaderText="Cliente" />
                <asp:BoundField DataField="iTotalIva" HeaderText="Cliente" />
                <asp:BoundField DataField="iTotalDescuento" HeaderText="Cliente" />
                <asp:BoundField DataField="iTotalGeneral" HeaderText="Cliente" />
            </Columns>
        </asp:GridView>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="exampleModalLabel">Nueva Factura</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Tipo Documento</label>
                                    <asp:DropDownList ID="ddlTipoDoc" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputPassword1">Fecha Documento</label>
                                    <input type="date" class="form-control" id="fecdoc" runat="server">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputPassword1">Fecha Vigencia</label>
                                    <input type="date" class="form-control" id="fecvig" runat="server">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Nombre Empresa</label>
                                    <asp:DropDownList ID="ddlNomEmp" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Nombre Cliente</label>
                                    <asp:DropDownList ID="ddlNomCli" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Forma de Pago</label>
                                    <asp:DropDownList ID="ddlFormPago" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Total Neto</label>
                                    <input type="text" runat="server" class="form-control" id="txtTotalNeto">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Total Porcentaje</label>
                                    <input type="text" runat="server" class="form-control" id="txtTotalPorcentaje">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Total Iva</label>
                                    <input type="text" runat="server" class="form-control" id="txtTotalIva">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Total Descuento</label>
                                    <input type="text" runat="server" class="form-control" id="txtTotalDescuento">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Total General</label>
                                    <input type="text" runat="server" class="form-control" id="txtTotalGeneral">
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button Text="Guardar" runat="server" CssClass="btn btn-primary" ID="btnguardar" OnClick="btnguardar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
