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
                <asp:TextBox id="txtuser" runat="server" CssClass="fadeIn second"></asp:TextBox>
                <asp:TextBox id="txtpsw" runat="server" CssClass="fadeIn third" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" class="fadeIn fourth" Text="Log In" />
            </div>
            <div id="formFooter">
                <a class="underlineHover" href="">Forgot Password?</a>
            </div>
        </div>
    </div>
</asp:Content>
