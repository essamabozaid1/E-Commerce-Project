<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Client.master" AutoEventWireup="true" CodeFile="ProductsShow.aspx.cs" Inherits="Client_ProductsShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {}
        .auto-style3 {
            width: 500px;
        }
        .auto-style4 {
            width: 500px;
            height: 20px;
        }
        .auto-style5 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:DataList ID="DataList1" runat="server" BackColor="White" DataKeyField="CategoryID" DataSourceID="SqlDataSource1" RepeatColumns="2" OnItemCommand="DataList1_ItemCommand">
              <ItemTemplate>
                  <table class="auto-style1" style="width: 80%; height: 100px">
                      <tr>
                          <td rowspan="2">
                              <asp:Image ID="Image1" runat="server" Height="100px" Width="72px" ImageUrl='<%# string.Format("~/Food/FoodImages/{0}-{1}.jpg",Eval("CategoryID"),Eval("FoodID")) %>' />
                          </td>
                          <td class="auto-style4">
                              <asp:Label ID="FoodName" runat="server" Text='<%# Eval("FoodName") %>' Font-Bold="True"></asp:Label>
                          </td>
                          <td class="auto-style5">
                              <asp:Label ID="FoodPrice" runat="server" Text='<%# Eval("FoodPrice") %>'></asp:Label>
                          </td>
                          <td class="auto-style5">
                              <asp:ImageButton runat="server" Width="20px" ID="BtnShop" Height="20px" ImageUrl="~/Images/shopping-cart-logo.svg.hi.png"/>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style3">
                              <asp:Label ID="Description" runat="server" Text='<%# Eval("Description") %>' Font-Size="Small"></asp:Label>
                          </td>
                          <td class="auto-style2" colspan="2">
                              <asp:Label ID="CategoryID" runat="server" Text='<%# Eval("CategoryID") %>' Visible="False"></asp:Label>
                              <asp:Label ID="FoodID" runat="server" Text='<%# Eval("FoodID") %>' Visible="False"></asp:Label>
                          </td>
                      </tr>
                  </table>
        </ItemTemplate>
      </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>" SelectCommand=""></asp:SqlDataSource>
    

</asp:Content>

