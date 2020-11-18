<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TrabajoFinal.Pages.Clientes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
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
                <li>
                    <div style="padding-left: 15px" class="align-middle">
                        <div class="input-group input-group-sm mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="inputGroup-sizing-sm">Fecha Desde</span>
                            </div>
                            <input type="date" class="form-control align-middle" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm">
                        </div>
                    </div>
                </li>
                <li>
                    <div style="padding-left: 15px" class="align-middle">
                        <div class="input-group input-group-sm mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text" id="inputGroup-sizing-sm">Fecha Hasta</span>
                            </div>
                            <input type="date" class="form-control align-middle" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm">
                        </div>
                    </div>
                </li>
                <li>
                    <div style="padding-left: 15px" class="align-middle">
                        <button type="button" class="btn btn-primary">Buscar</button>
                    </div>
                </li>
            </ol>
        </nav>
    </div>
    <div class="container">
        <asp:GridView
            runat="server"
            ID="gvCliente"
            EmptyDataText="Sin Información"
            CssClass="table table-hover"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True"
            OnRowEditing="gvCliente_RowEditing"
            OnPageIndexChanging="gvCliente_PageIndexChanging"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="iRut" HeaderText="Rut" DataFormatString="{0:N0}" ReadOnly="true" />
                <asp:BoundField DataField="cDv" HeaderText="Dgto"  ReadOnly="true"/>
                <asp:BoundField DataField="cNombres" HeaderText="Nombres Cliente" />
                <asp:BoundField DataField="cApellidos" HeaderText="Apellidos Cliente" />
                <asp:BoundField DataField="cCiudad" HeaderText="Nombre Ciudad" />
                <asp:BoundField DataField="cComuna" HeaderText="Nombre Comuna" />
                <asp:BoundField DataField="cDireccion" HeaderText="Dirección" />
                <asp:BoundField DataField="cTelefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="vCorreo" HeaderText="Correo" />
                <asp:BoundField DataField="dFechaNacimiento" HeaderText="Fecha Nacimiento" DataFormatString="{0:dd/MM/yyyy}"  ReadOnly="true"/>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text="Editar" runat="server" CommandName="Edit" CommandArgument="1"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton Text="Update" ID="ActRow" runat="server" OnClick="ActRow_Click" />
                        <asp:LinkButton Text="Cancel" ID="CancRow" runat="server" OnClick="CancRow_Click" />
                    </EditItemTemplate>
                </asp:TemplateField>
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
                        <div class="col-lg-12">
                            <asp:Label ID="lblRut" runat="server" Text="Ingrese Rut:"></asp:Label><br />
                            <asp:TextBox ID="txtRut" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblNombres" runat="server" Text="Ingrese Nombres:"></asp:Label><br />
                            <asp:TextBox ID="txtNombres" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblApellidos" runat="server" Text="Ingrese Apellidos:"></asp:Label><br />
                            <asp:TextBox ID="txtApellidos" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label><br />
                            <asp:DropDownList ID="ListaCiudad" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListaCiudad_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblComuna" runat="server" Text="Comua:"></asp:Label><br />
                            <asp:DropDownList ID="ListaComuna" CssClass="form-control" runat="server" AutoPostBack="false"></asp:DropDownList>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblDireccion" runat="server" Text="Dirección:"></asp:Label><br />
                            <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label><br />
                            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lBlCorreo" runat="server" Text="Correo:"></asp:Label><br />
                            <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblFechaNacimiento" runat="server" Text="Ingrese Fecha Nacimiento:"></asp:Label><br />
                            <asp:TextBox ID="txtFechaNacimiento" CssClass="form-control" TextMode="DateTime" runat="server"></asp:TextBox>
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

                        <%--<button type="submit" class="btn btn-success" runat="server" AutoPostBack="true" >Grabar</button>--%>
                        <asp:Button ID="btnGrabar" CssClass="form-control btn-success" OnClick="btnGrabar_Click" runat="server" AutoPostBack="true" Text="Grabar" />
                        <%--<button type="reset" class="btn btn-primary">Limpiar</button>--%>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
