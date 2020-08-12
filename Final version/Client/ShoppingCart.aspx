<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Client.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Client_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="Category ID" ReadOnly="True" />
            <asp:BoundField DataField="FoodID" HeaderText="Food ID" ReadOnly="True" />
            <asp:BoundField DataField="FoodName" HeaderText="Food Name" />
            <asp:BoundField DataField="FoodPrice" HeaderText="Food Price" ReadOnly="True" />
            <asp:TemplateField>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="99px" Width="106px" 
                        ImageUrl='<%# string.Format("../Food/FoodImages/{0}-{1}.jpg",Eval("CategoryID"),Eval("FoodID")) %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="Control" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
</asp:Content>

