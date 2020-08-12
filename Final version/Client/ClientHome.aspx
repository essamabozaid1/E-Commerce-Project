<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Client.master" AutoEventWireup="true" CodeFile="ClientHome.aspx.cs" Inherits="Client_ClientHome" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server" >
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 616px;
        }
        .auto-style2 {
            height: 442px;
        }
        .auto-style3 {
            height: 126px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  


    <table class="auto-style1" >
        <tr>
            <td><p><a href="#" style=" color: #000000;">All Category</a></p></td>
        </tr>
        <tr>
            <td style="padding-left: 60px" class="auto-style3">
                <ul style="position: relative; margin-left: 15px;">
                    <asp:DataList ID="DataList1" runat="server" DataKeyField="CategoryID" DataSourceID="SqlDataSource1" ForeColor="#003366">
                        <ItemTemplate>
                            <li><a href="ProOfCat?CategoryID=<%# Eval("CategoryID") %>" style="color:#000000"><%# Eval("CategoryName") %></a></li>
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
                </ul>
            </td>
        </tr>
        <tr>
            <td><a href="#"></a>New Products</td>
        </tr>
        <tr style="height: 50px">
            <td class="auto-style2">
                <ul style="position: relative; margin-left: 15px;"">
                <asp:DataList ID="DataList2" runat="server" DataKeyField="CategoryID" DataSourceID="SqlDataSource2">
                    <ItemTemplate>
                        <li><a style="color:black" href="FoodDetials?FoodID=<%# Eval("FoodID")%> & CategoryID=<%# Eval("CategoryID") %>"><%# Eval("FoodName") %></a></li>
                    </ItemTemplate>
                </asp:DataList>

                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>" SelectCommand="SELECT Top 3 * FROM [Food] ORDER BY [WrittingTime] DESC"></asp:SqlDataSource>
                </ul>
            </td>
        </tr>
    </table>
  


</asp:Content>

