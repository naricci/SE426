<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forecast.aspx.cs" Inherits="Lab3_AccessingWebServices.Forecast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Lab 3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblTitle" runat="server" Text="LAB 3:  Accessing Web Services" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPart1" runat="server" Text="Part 1:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date:  "></asp:Label>
        <br />
        <asp:Label ID="lblForecastDesc" runat="server" Text="Forecast:  "></asp:Label>
        <br />
        <br />
        Get Weather Forecast For Boston<br />
        <asp:Button ID="btnGetForecast" runat="server" Text="Get Forecast" />
    
    </div>
        <p>
            <asp:TextBox ID="txtOutput" runat="server" Height="325px" TextMode="MultiLine" Width="749px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
