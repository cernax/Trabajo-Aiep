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
                    labels: ['Total'],
                    datasets: [{
                        label: 'Factuas',
                        backgroundColor: 'rgb(255, 99, 132)',
                        borderColor: 'rgb(255, 99, 132)',
                        data: [30, 20, 70, 0]
                    }]
                },{
                labels: ['Usuario'],
                datasets: [{
                    label: 'Factuas',
                    backgroundColor: 'rgb(255, 99, 132)',
                    borderColor: 'rgb(255, 99, 132)',
                    data: [30, 20, 70, 0]
                }]
                }

                // Configuration options go here
                options: {}
            });
        });
    </script>
    <div style="width:500px">
        <canvas id="myChart" ></canvas>
    </div>
</asp:Content>
