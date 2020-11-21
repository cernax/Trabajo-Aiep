<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TrabajoFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/Chart.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {
            debugger;
            var ctx = document.getElementById('myChart').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'bar',

                // The data for our dataset
                data: {
                    labels: ['Total', 'Usuario'],
                    datasets: [{
                        label: 'Cantidad de Factuas',
                        backgroundColor: 'rgb(255, 99, 132)',
                        borderColor: 'rgb(255, 99, 132)',
                        data: [<%= Session["cntUsuario"] %>, <%= Session["cntBase"] %>, <%= Session["Cntmaximo"] %>, 0]
                    }]
                },

                // Configuration options go here
                options: {}
            });
        });

        $(document).ready(function () {
            debugger;
            var ctx = document.getElementById('myChartMo').getContext('2d');
            var chart = new Chart(ctx, {
                // The type of chart we want to create
                type: 'bar',

                // The data for our dataset
                data: {
                    labels: ['Total', 'Usuario'],
                    datasets: [{
                        label: 'Monto de Factuas',
                        backgroundColor: 'Blue',
                        borderColor: 'Blue',
                        data: [<%= Session["MtoUsuario"] %>, <%= Session["MtoBase"] %>, <%= Session["Montomaximo"] %>, 0]
                    }]
                },

                // Configuration options go here
                options: {}
            });
        });
    </script>
    <br />
    <div>
        <h1>
            <asp:Label ID="lblNomUser" Text="" runat="server" />
        </h1>
    </div>
    <br />
    <div style="width: 500px">
        <canvas id="myChart"></canvas>
        <canvas id="myChartMo"></canvas>
    </div>
</asp:Content>
