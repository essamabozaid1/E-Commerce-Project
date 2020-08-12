<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Client.master" AutoEventWireup="true" CodeFile="Client-Homeaspx.aspx.cs" Inherits="Client_Client_Homeaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:300px;position:static;text-align:center;"  >

 
        <table class="auto-style1">
            <tr>
                <td>
                    <h1>ALL Categorys</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:DataList ID="DataList1" runat="server" DataKeyField="CategoryID" DataSourceID="SqlDataSource1" HorizontalAlign="Left">
                        
                       <ItemTemplate>
                           <a href="ProductsShow.aspx?CategoryID=<%# Eval("CategoryID") %>"style="color:#000000"><%# Eval("CategoryName") %></a>          
                            <br />
                        </ItemTemplate>
                       </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>"
                         SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <h1>ALL Menu</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                      <asp:DataList ID="DataList2" runat="server" DataKeyField="CategoryID" DataSourceID="SqlDataSource2" HorizontalAlign="Left">
                        
                       <ItemTemplate>
                           <a href="ProductsShow.aspx?CategoryID=<%# Eval("CategoryID")%>&FoodID=<%# Eval("FoodID") %>"  style="color:#000000"><%# Eval("FoodName") %></a>          
                            <br />
                        </ItemTemplate>
                       </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>"
                         SelectCommand="SELECT TOP 3 * FROM [Food] ORDER BY [WrittingTime] DESC"></asp:SqlDataSource>
                </td>
            </tr>
        </table>

 
      </div>
</asp:Content>

