<%@ Page Title="Users" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosMant.aspx.cs" Inherits="TrabajoFinal.Pages.UsuariosMant" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <br />
    <link rel="stylesheet" href="styleLogin/logincss.css">
    <script type="text/javascript">
        function home() {
            return window.location.href = "Default.aspx";
        }
    </script>


    <div class="container">
        <nav aria-label="breadcrumb">
            <h3 class="modal-title" id="exampleModalLabel">Usuarios</h3>
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
    </div>
    <div class="container">
        <asp:GridView runat="server" ID="gvUsuario"
            AutoGenerateColumns="False"
            EmptyDataText="Sin Información."
            CssClass="table table-hover"  ShowHeaderWhenEmpty="True"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True"> 
            <Columns>                
                <asp:BoundField DataField="rut" HeaderText="Rut" />
                <asp:BoundField DataField="dv" HeaderText="Dv" />
                <asp:BoundField DataField="nombre" HeaderText="Nombres" />
                <asp:BoundField DataField="apellido" HeaderText="Apellidos" />
                <asp:BoundField DataField="user" HeaderText="Nombre Usuario" />
                <asp:BoundField DataField="nombreperfil" HeaderText="Nombre Perfil" />
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
                            <h5 class="modal-title" id="exampleModalLabel">Nuevo Usuario</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="container">
                                <div class="row">
                                    <form>
                                    <div class="col">
                                        <div class="form-group">
                                            <asp:Label ID="lblrut" runat="server" Text="Rut:"></asp:Label><br />
                                            <asp:TextBox ID="txtrut" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblnuser" runat="server" Text="Nombre Usuario: "></asp:Label><br />
                                            <asp:TextBox ID="txtnomuser" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>                                
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <asp:Label ID="lblnombre" runat="server" Text="Nombre:"></asp:Label><br />
                                            <asp:TextBox ID="txtnombre" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblclave" runat="server" Text="Clave: "></asp:Label><br />
                                            <asp:TextBox ID="txtclave" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <asp:Label ID="lblapellido" runat="server" Text="Apellido:"></asp:Label><br />
                                            <asp:TextBox ID="txtapellido" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblperfil" runat="server" Text="Perfil:"></asp:Label><br />
                                            <asp:DropDownList ID="ListaPerfil" CssClass="form-control" runat="server" AutoPostBack="false"></asp:DropDownList>
                                        </div>                                
                                    </div>
                                    <div class="col">
                                        <div class="form-group">
                                            <asp:Label ID="lblfecha" runat="server" Text="Fecha de Nacimiento:"></asp:Label><br />
                                            <asp:TextBox ID="txtfecnac" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label ID="lblcorreo" runat="server" Text="Correo:"></asp:Label><br />
                                            <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server"></asp:TextBox>
                                        </div>                                 
                                    </div>
                                        </form>
                                    <div class="container">
                                        <asp:GridView runat="server" ID="gvOpciones"
                                            AutoGenerateColumns="False"
                                            EmptyDataText="Sin Información."
                                            CssClass="table table-hover"  ShowHeaderWhenEmpty="True"
                                            HeaderStyle-CssClass="thead-dark"
                                            AllowPaging="True">
                                            <Columns>                
                                                <%--<asp:CheckBoxField HeaderText="Seleccionar" />--%>
                                                <asp:CheckBoxField DataField="sel" HeaderText="Seleccionar" SortExpression="Seleccionar" />
                                                <asp:BoundField DataField="cNombreOpciones" HeaderText="Opción" />
                                            </Columns>
                                            <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer center">
                                <asp:Button ID="btnGrabar" CssClass="form-control btn-success" OnClick="btnGrabar_Click" runat="server" AutoPostBack="true" Text="Grabar" />
                            </div>        
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
