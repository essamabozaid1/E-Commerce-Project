<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Client Name"></asp:Label>
    
        <asp:TextBox ID="txtUSRNAME" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:CheckBox ID="ckRemember" runat="server" Text="Remember Me" />
        </p>
    </div>
        
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        
    </form>
</body>
</html>
