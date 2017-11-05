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
        Get Weather Forecast For Boston<br />
        <asp:Button ID="btnGetForecast" runat="server" Text="Get Forecast" OnClick="btnGetForecast_Click" />
    
    </div>
        <p>
            <asp:TextBox ID="txtWeatherOutput" runat="server" Height="358px" TextMode="MultiLine" Width="942px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblPart2" runat="server" Text="Part 2:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblZipCode" runat="server" Text="Enter Zip Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnGetCitiesForZip" runat="server" OnClick="btnGetCitiesForZip_Click" Text="Get Cities For Zip" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGetCitiesNearZip" runat="server" OnClick="btnGetCitiesNearZip_Click" Text="Get Cities Nearby Zip" />
        </p>
        <p>
            <asp:TextBox ID="txtCityResults" runat="server" Height="314px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
