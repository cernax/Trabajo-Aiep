<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TrabajoFinal.Pages.Clientes" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br />
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li>
                <div>
                    <asp:Button ID="btnNuevo" OnClick="btnNuevo_Click" Text="Nuevo" runat="server" class="btn btn-success" data-toggle="modal" data-target="#exampleModal"/>
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModal" style="display:none">Nuevo</button>
                </div>
            </li>
            <li>
                <div style="width:400px"></div>
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
    <div class="container">
        <asp:GridView runat="server" ID="gvCliente"
            AutoGenerateColumns="False"
            EmptyDataText="No data available." ShowHeader="true"
            CssClass="table table-hover"
            HeaderStyle-CssClass="thead-dark"
            AllowPaging="True">            
            <Columns>                
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre Cliente" HeaderText="Nombre Cliente" />
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
                            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
                            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Password</label>
                            <input type="password" class="form-control" id="exampleInputPassword1">
                        </div>
                        <div class="form-group form-check">
                            <input type="checkbox" class="form-check-input" id="exampleCheck1">
                            <label class="form-check-label" for="exampleCheck1">Check me out</label>
                        </div>
                        <button type="submit" class="btn btn-primary">Submit</button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
