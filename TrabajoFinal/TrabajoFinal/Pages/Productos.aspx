<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TrabajoFinal.Pages.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br />
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li>
                <div>
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModal">Agregar</button>
                </div>
            </li>
            <li>
                <div style="padding-left: 15px" class="align-middle">
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="inputGroup-sizing-sm">Fecha Desde</span>
                        </div>
                        <input id="txtfechahasta" type="date" runat="server" class="form-control align-middle" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"/>
                    </div>
                </div>
            </li>
            <li>
                <div style="padding-left: 15px" class="align-middle">
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="inputGroup-sizing-sm">Fecha Hasta</span>
                        </div>                        
                        <input id="txtfechadesde" type="date" runat="server" class="form-control align-middle" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"/>
                    </div>
                </div>
            </li>
            <li>
                <div style="padding-left: 15px" class="align-middle">
                    <%--<button type="submit" onclick="" class="btn btn-primary">Buscar</button>--%>
                    <asp:Button ID="btnBuscar"  class="btn btn-primary" OnClick="btnBuscar_Click" runat="server" Text="Buscar" CausesValidation="False" />                    
                </div>
            </li>
        </ol>
    </nav>
    <div class="container">
        <asp:GridView runat="server" ID="gvProducto"
            AutoGenerateColumns="False"
            EmptyDataText="Sin Información" ShowHeader="true"
            CssClass="table table-hover"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True">            
            <Columns>                
                <asp:BoundField DataField="cNombre" HeaderText="Nombre Producto" />
                <asp:BoundField DataField="iStock" HeaderText="Stock" />
                <asp:BoundField DataField="iValor" HeaderText="Valor" DataFormatString = "{0:c}" />
                <asp:BoundField DataField="dFechaCreacion" HeaderText="Fecha Creación" DataFormatString="{0:dd/MM/yyyy}"  ReadOnly="true"/>
            </Columns>
        </asp:GridView>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="exampleModalLabel">Nuevo Producto</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                     <form method="POST">
                        <div class="col-lg-12">
                            <asp:Label ID="lblNombre" runat="server" Text="Ingrese Nombre:"></asp:Label><br />
                            <asp:TextBox ID="txtNombre" name="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblStock" runat="server" Text="Ingrese Stock:"></asp:Label><br />
                            <asp:TextBox ID="txtStock" name="txtStock" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtStock" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="Label1" runat="server" Text="Ingrese Valor:"></asp:Label><br />
                            <asp:TextBox ID="txtValor" name="txtValor" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtValor" ErrorMessage="Campo Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <%--<label for="exampleInputEmail1">Email address</label>--%>
                            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" hidden="hidden">
                            <%-- <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>--%>
                        </div>
                        <div class="form-group">
                            <%--<label for="exampleInputPassword1">Password</label>--%>
                            <input type="password" class="form-control" id="exampleInputPassword1" hidden="hidden">
                        </div>
                        <div class="form-group form-check">
                            <input type="checkbox" class="form-check-input" id="exampleCheck1" hidden="hidden">
                            <%--<label class="form-check-label" for="exampleCheck1">Check me out</label>--%>
                        </div>

                        <asp:Button ID="btnGrabar" CssClass="btn btn-success" OnClick="btnGrabar_Click" runat="server" AutoPostBack="true" Text="Grabar" />
                        <asp:Button ID="btnLimpiar" CssClass="btn btn-success" OnClick="btnLimpiar_Click" runat="server"  Text="Limpiar" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
