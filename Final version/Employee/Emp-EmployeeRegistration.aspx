<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Employee.master" AutoEventWireup="true" CodeFile="Emp-EmployeeRegistration.aspx.cs" Inherits="Emp_EmployeeRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 69px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="GeneralClient" runat="server">
                    <asp:ImageButton ID="Addclient" runat="server" ImageAlign="Middle" ImageUrl="~/Images/STAFF add.png" OnClick="Addclient_Click" />
                    <asp:ImageButton ID="EditClient" runat="server" ImageAlign="Middle" ImageUrl="~/Images/STAFF search.png" OnClick="EditClient_Click" />
                </asp:View>
                <asp:View ID="AddEmployee" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td><span>EmployeeName </span></td>
                            <td>
                                <asp:TextBox ID="Usrtxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Password </span></td>
                            <td>
                                <asp:TextBox ID="Passtxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Full Name</span></td>
                            <td>
                                <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Gender </span></td>
                            <td>
                                <asp:RadioButtonList ID="genderRB" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem Selected="True" Value="M">Male</asp:ListItem>
                                    <asp:ListItem Value="F">Female</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Address </span></td>
                            <td>
                                <asp:TextBox ID="Addresstxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Phone </span></td>
                            <td>
                                <asp:TextBox ID="Phonetxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td><span>Email </span></td>
                            <td>
                                <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2"></td>
                            <td class="auto-style2">
                                <asp:Button ID="RegistBTN" runat="server" OnClick="RegistBTN_Click" style="height: 29px" Text="Regist" />
                            </td>
                            <td class="auto-style2">
                                <asp:Label ID="txtmsg" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="EditEmployee" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="text-align: center;">
                                <asp:RadioButtonList ID="RBTSearch" runat="server" ForeColor="Black" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                    <asp:ListItem>EmployeeName</asp:ListItem>
                                    <asp:ListItem>Phone</asp:ListItem>
                                    <asp:ListItem Value="FullName">Name</asp:ListItem>
                                    <asp:ListItem>EmployeeID</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center;">
                                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="81px" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <asp:Button ID="btnDelete" runat="server" Enabled="False" OnClick="btnDelete_Click" Text="Delete" />
                                <asp:Button ID="btnEdit" runat="server" Enabled="False" OnClick="btnEdit_Click1" Text="Edit" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center;">
                                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select" ShowHeader="True" Text="&gt;&gt;" />
                                    </Columns>
                                    <EditRowStyle BackColor="#7C6F57" />
                                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#E3EAEB" />
                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </asp:View>
            </asp:MultiView>
        </ContentTemplate>

    </asp:UpdatePanel>

</asp:Content>

