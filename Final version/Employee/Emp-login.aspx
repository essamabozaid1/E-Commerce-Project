<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Emp-login.aspx.cs" Inherits="Employee_Emp_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server">UserName</asp:Label>
        </td>
        <td>
    
        <asp:TextBox ID="txtUSRNAME" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server">Password</asp:Label>
        </td>
        <td>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="ckRemember" runat="server" Text="Remember Me" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
</table>

    </form>
</body>
</html>
