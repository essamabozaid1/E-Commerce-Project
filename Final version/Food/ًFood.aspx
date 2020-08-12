<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Employee.master" AutoEventWireup="true" CodeFile="ًFood.aspx.cs" Inherits="Food_Food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="AllFoodService" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style9" rowspan="2">
                                <asp:Label ID="Label1" runat="server" Text="Search By"></asp:Label>
                            </td>
                            <td style="text-align: center">
                                <asp:RadioButtonList ID="rbSearchField" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Value="CategoryID">Category Name</asp:ListItem>
                                    <asp:ListItem Value="FoodName">Food Name</asp:ListItem>
                                    <asp:ListItem Value="FoodPrice">Price</asp:ListItem>
                                    <asp:ListItem Value="AvailableQTY">Available Quantity</asp:ListItem>
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
                                <asp:Button ID="btnAddFood" runat="server" Text="New Food" OnClick="btnAddFood_Click" />
                                <asp:Button ID="btnUpdateFood" runat="server" Enabled="False"  Text="Edit Food" OnClick="btnUpdateFood_Click" />
                                <asp:Button ID="btnDeleteFood" runat="server" Enabled="False" Text="Delete Food" OnClick="btnDeleteFood_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                &nbsp;</td>
                            <td>
                                <asp:GridView ID="GridViewFood" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridViewFood_SelectedIndexChanged">
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
                <asp:View ID="AddUpdFood" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label10" runat="server" Text="CategoryID"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DDCatID" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryID" Width="230px">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rest %>" SelectCommand="SELECT [CategoryName], [CategoryID] FROM [Category]"></asp:SqlDataSource>
                            </td>
                            <td rowspan="7">

                                <asp:Image ID="Img" runat="server" Height="139px" Width="110px" />

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label5" runat="server" Text="Food ID"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFoodID" runat="server" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label6" runat="server" Text="Food Name"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFoodName" runat="server" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label8" runat="server" Text="Food Price"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtPrice" runat="server" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label9" runat="server" Text="Available Quentity"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtAvaQty" runat="server" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label7" runat="server" Text="Food Description"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtFoodDescription" runat="server" TextMode="MultiLine" Width="230px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label11" runat="server" Text="Image"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:FileUpload ID="FUP" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnAddUpdFood" runat="server" Text="Add Food Item" OnClick="btnAddUpdFood_Click" />
                                <asp:Button ID="btnCancelAdd" runat="server" Text="Cancel" OnClick="btnCancelAdd_Click" />
                            </td>
                            <td>

                                <asp:Label ID="lblAdd" runat="server"></asp:Label>

                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
</asp:Content>

