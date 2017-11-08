<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem1.aspx.cs" Inherits="MidtermExam.Problem1" %>

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
        <asp:Button ID="btnGetBankingData" runat="server" OnClick="btnGetBankingData_Click" Text="Get Banking Data" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:TextBox ID="txtBankingResults" runat="server" Height="100px" Width="309px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
