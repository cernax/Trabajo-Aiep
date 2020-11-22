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
            EmptyDataText="Sin Información."
            CssClass="table table-hover"  ShowHeaderWhenEmpty="True"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="Id_Documento" HeaderText="ID" />
                <asp:BoundField DataField="tipdoc" HeaderText="Tipo Factura" />
                <asp:BoundField DataField="dFechaDocumento" HeaderText="Producto" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField DataField="dFechaVigencia" HeaderText="Fecha Vigencia" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="nomemp" HeaderText="Nombre Empresa" />
                <asp:BoundField DataField="nomcli" HeaderText="Nombre Cliente" />
                <asp:BoundField DataField="formpago" HeaderText="Forma de Pago" />
                <asp:BoundField DataField="iTotalNeto" HeaderText="Total Neto"  DataFormatString = "{0:c}" />
                <asp:BoundField DataField="dTotalPorcentaje" HeaderText="Total Porcentaje"  DataFormatString = "{0:c}" />
                <asp:BoundField DataField="iTotalIva" HeaderText="Total Iva"  DataFormatString = "{0:c}" />
                <asp:BoundField DataField="iTotalDescuento" HeaderText="Total Descuento"  DataFormatString = "{0:c}" />
                <asp:BoundField DataField="iTotalGeneral" HeaderText="Total General"  DataFormatString = "{0:c}" />                
                <asp:ButtonField ButtonType="Button" Text="Emitir" ControlStyle-CssClass="btn btn-primary" />
                <asp:ButtonField ButtonType="Button" Text="Anular" ControlStyle-CssClass="btn btn-danger"/>
            </Columns>

<HeaderStyle CssClass="thead-dark"></HeaderStyle>
        </asp:GridView>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-xl modal-dialog-centered">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
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
                                            <asp:DropDownList ID="ddlTipoDoc" class="form-control" runat="server" disabled="disabled"></asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Nombre Cliente</label>
                                            <asp:DropDownList ID="ddlNomCli" class="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Fecha Documento</label>
                                            <input type="date" class="form-control" id="fecdoc" runat="server" disabled="disabled">
                                        </div>
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Forma de Pago</label>
                                            <asp:DropDownList ID="ddlFormPago" class="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Fecha Vigencia</label>
                                            <input type="date" class="form-control" id="fecvig" runat="server" disabled="disabled">
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Nombre Empresa</label>
                                            <asp:DropDownList ID="ddlNomEmp" class="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr />
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <br />
                                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-success" ID="btnagregar" OnClick="btnagregar_Click" />
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Producto</label>
                                            <asp:DropDownList ID="ddlproducto" class="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlproducto_SelectedIndexChanged"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Cantidad</label>
                                            <asp:TextBox runat="server" class="form-control" ID="txtCant" value="0" Style="text-align: right" OnTextChanged="txtCant_TextChanged" AutoPostBack="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotal" disabled style="text-align: right">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <asp:GridView runat="server" ID="gvdetFact"
                                AutoGenerateColumns="False"
                                EmptyDataText="Sin Información." ShowHeader="true"
                                CssClass="table table-hover" ShowHeaderWhenEmpty="true"
                                HeaderStyle-CssClass="thead-dark"
                                AllowPaging="True">
                                <Columns>
                                    <asp:BoundField DataField="Id_Producto" HeaderText="ID" />
                                    <asp:BoundField DataField="nomprod" HeaderText="Producto" />
                                    <asp:BoundField DataField="iCantidad" HeaderText="Cantiodad" />
                                    <asp:BoundField DataField="iTotalParcial" HeaderText="Valor"  DataFormatString = "{0:c}" />
                                </Columns>
                            </asp:GridView>
                            <hr />
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total Neto</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotalNeto" value="0" disabled="disabled" Style="text-align: right" >
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total Porcentaje</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotalPorcentaje" value="0" disabled="disabled" Style="text-align: right" >
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total Descuento</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotalDescuento" value="0" disabled="disabled" Style="text-align: right" >
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total Iva</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotalIva" value="0" disabled="disabled" Style="text-align: right" >
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <label for="exampleInputEmail1">Total General</label>
                                            <input type="text" runat="server" class="form-control" id="txtTotalGeneral" value="0" disabled="disabled" Style="text-align: right" >
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <asp:Button Text="Guardar" runat="server" CssClass="btn btn-primary" ID="btnguardar" OnClick="btnguardar_Click" />
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
