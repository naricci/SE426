<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem1.aspx.cs" Inherits="PracticeMidterm.Problem1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblProblem1" runat="server" Text="Problem 1:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFind" runat="server" Text="Find Players Who Weight At Least 250 lbs."></asp:Label>
        <br />
        <asp:Button ID="btnFindPlayers" runat="server" OnClick="btnFindPlayers_Click" Text="Find Players" />
        <br />
        <br />
        <asp:TextBox ID="txtPlayerOutput" runat="server" Height="146px" TextMode="MultiLine" Width="405px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
