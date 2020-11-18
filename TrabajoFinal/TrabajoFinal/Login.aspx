<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TrabajoFinal.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="styleLogin/logincss.css">
    <script type="text/javascript">
        $(document).ready(function () {
            document.getElementById("navhome").style.display = "none";
        });

        function home() {
            return window.location.href = "Default.aspx";
        }
    </script>
    <div class="wrapper fadeInDown">
        <div id="formContent">
            <div class="fadeIn first">
                <img src="https://mdbootstrap.com/img/Photos/Avatars/avatar-6.jpg " id="icon" alt="User Icon" />
            </div>
            <div>
                <asp:TextBox ID="txtuser" runat="server" CssClass="fadeIn second"></asp:TextBox>
                <asp:TextBox ID="txtpsw" runat="server" CssClass="fadeIn third" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" class="fadeIn fourth" Text="Log In" />
            </div>
            <div id="formFooter">
                <span>Registrate <a class="underlineHover" data-toggle="modal" data-target="#exampleModal">aquí</a></span>
            </div>
        </div>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Nuevo Usuario</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="col-lg-12">
                            <asp:Label ID="lblRut" runat="server" Text="Nombre Usaurio: "></asp:Label><br />
                            <asp:TextBox ID="txtnomuser" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblNombres" runat="server" Text="Clave: "></asp:Label><br />
                            <asp:TextBox ID="txtclave" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblApellidos" runat="server" Text="Rut:"></asp:Label><br />
                            <asp:TextBox ID="txtrut" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblDireccion" runat="server" Text="Nombre:"></asp:Label><br />
                            <asp:TextBox ID="txtnombre" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lblTelefono" runat="server" Text="Apellido:"></asp:Label><br />
                            <asp:TextBox ID="txtapellido" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="lBlCorreo" runat="server" Text="Correo:"></asp:Label><br />
                            <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-lg-12">
                            <asp:Label ID="Label1" runat="server" Text="Fecha de Nacimiento:"></asp:Label><br />
                            <asp:TextBox ID="txtfecnac" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>

                    </form>
                    <div class="modal-footer center">
                        <asp:Button ID="btnGrabar" CssClass="form-control btn-success" OnClick="btnGrabar_Click" runat="server" AutoPostBack="true" Text="Grabar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
