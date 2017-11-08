<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem3.aspx.cs" Inherits="MidtermExam.Problem3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblProblem3" runat="server" Text="Problem 3:"></asp:Label>
        <br />
    <div>
    
        <asp:Button ID="btnReadData" runat="server" OnClick="btnReadData_Click" Text="Read Data" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        Price &amp; Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Number<br />
        <asp:TextBox ID="txtPriceGender" runat="server" Height="111px" Width="202px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtItemNumber" runat="server" Height="108px" Width="187px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
