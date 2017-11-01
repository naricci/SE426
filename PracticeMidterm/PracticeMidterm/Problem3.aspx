<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem3.aspx.cs" Inherits="PracticeMidterm.Problem3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblProblem3" runat="server" Text="Problem 3"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnDisplayFoodData" runat="server" OnClick="btnDisplayFoodData_Click" Text="Grab Food Data" Width="243px" />
        <br />
        <br />
        <asp:Label ID="lblPart1" runat="server" Text="Name &amp; Calorie Count:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPart1Output" runat="server" Height="175px" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPart2" runat="server" Text="Names of Meats:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPart2Output" runat="server" Height="175px" Width="241px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
