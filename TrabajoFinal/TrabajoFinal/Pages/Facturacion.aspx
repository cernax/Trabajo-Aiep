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
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="TipoFactura" HeaderText="Tipo Factura" />
                <asp:BoundField DataField="Monto" HeaderText="Monto" />
                <asp:BoundField DataField="Producto" HeaderText="Producto" />
                <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
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
