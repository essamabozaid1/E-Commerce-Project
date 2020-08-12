<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Employee.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Category_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style5 {
            width: 117px;
        }
        .auto-style6 {
            height: 46px;
        }
        .auto-style7 {
            width: 293px;
        }
        .auto-style8 {
            height: 46px;
            width: 293px;
        }
        .auto-style9 {
            width: 237px;
        }
        .auto-style10 {
            height: 36px;
            width: 237px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="AllCategoryService" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style9" rowspan="2">
                                <asp:Label ID="Label1" runat="server" Text="Search By"></asp:Label>
                            </td>
                            <td style="text-align: center">
                                <asp:RadioButtonList ID="rbSearchField" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Value="CategoryID">Category ID</asp:ListItem>
                                    <asp:ListItem Value="CategoryName">Category Name</asp:ListItem>
                                    <asp:ListItem Value="CategoryDescription">Category Description</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10" style="text-align: left">
                                <asp:Label ID="lblAllService" runat="server" style="text-align:left; top: 228px; left: -1px;"></asp:Label>
                            </td>
                            <td class="auto-style3" style="text-align: right">
                                <asp:Button ID="btnAddCat" runat="server" OnClick="btnAddCat_Click" Text="New Category" />
                                <asp:Button ID="btnUpdateCat" runat="server" Enabled="False" OnClick="btnUpdateCat_Click" Text="Edit Category" />
                                <asp:Button ID="btnDeleteCat" runat="server" Enabled="False" OnClick="btnDeleteCat_Click" Text="Delete Category" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                &nbsp;</td>
                            <td>
                                <asp:GridView ID="GridViewCat" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridViewCat_SelectedIndexChanged">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:ButtonField CommandName="Select" HeaderText="Select" ShowHeader="True" Text="&gt;&gt;" />
                                    </Columns>
                                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                    <SortedDescendingHeaderStyle BackColor="#820000" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="AddCategory" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label5" runat="server" Text="Category ID"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCatID" runat="server" Width="230px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label6" runat="server" Text="Category Name"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCatName" runat="server" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label7" runat="server" Text="Category Description"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtCatDescription" runat="server" TextMode="MultiLine" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnAddUpdCat" runat="server" Text="Add Category" OnClick="Button1_Click" />
                                <asp:Button ID="btnCancelAdd" runat="server" OnClick="BtnCancelAdd_Click" Text="Cancel" />
                                <asp:Label ID="lblAdd" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

