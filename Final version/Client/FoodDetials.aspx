<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Client.master" AutoEventWireup="true" CodeFile="FoodDetials.aspx.cs" Inherits="Client_FoodDetials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 235px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table class="auto-style1">
        <tr>
            <td class="auto-style2" rowspan="6">
                <asp:Image ID="Image1" runat="server" Height="173px" Width="195px" />
            </td>
            <td>CategoryID:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>FoodID:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>FoodName:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>FoodPrice:<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Quentity:<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Description:<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Images/shopping-cart-logo.svg.hi.png" Width="20px" />
            </td>
        </tr>
    </table>


</asp:Content>

