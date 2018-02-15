<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Empdetail.aspx.cs" Inherits="Empdetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Cambria">
            <br />
            <br />
            <br />
            <h1 align="center"><u>Employee Detail</u></h1>
            <br />
            <div align="center">
                <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField HeaderText="EmployeeId">
                            <ItemTemplate>
                                <asp:Label ID="lblId" runat="server" Text='<%#Eval ("eid") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Employee Name">
                            <ItemTemplate>
                                <asp:Label ID="lblEname" runat="server" Text='<%#Eval ("Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Address">
                            <ItemTemplate>
                                <asp:Label ID="lbladd" runat="server" Text='<%#Eval ("Address") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="City">
                            <ItemTemplate>
                                <asp:Label ID="lblCity" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Department">
                            <ItemTemplate>
                                <asp:HiddenField ID="hdnDep" runat="server" Value='<%#Eval ("Departments") %>' />
                                <asp:Label ID="lblDep" runat="server" Text='<%#Eval ("Department") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Joininng Date">
                            <ItemTemplate>
                                <asp:Label ID="lblJdate" runat="server" Text='<%#Eval ("Joiningdate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Birth Date">
                            <ItemTemplate>
                                <asp:Label ID="lblBdate" runat="server" Text='<%#Eval ("Birthdate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Gender">
                            <ItemTemplate>
                                <asp:Label ID="lblGender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="IsActive">
                            <ItemTemplate>
                                <asp:Label ID="lblIsact" runat="server" Text='<%#Eval ("IsActive") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:ButtonField Text="Select" CommandName="Select" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
        <br />
        <table align="center" border="1">
            <tr>
                <td>
                    Eid
                </td>
                <td>
                    <asp:Label ID="lblEid" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Employee Name:
                </td>
                <td>
                    <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address:
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City
                </td>
                <td>
                    <asp:DropDownList ID="ddlCity" runat="server" Height="35px" Width="128px">
                        <asp:ListItem>---Select City---</asp:ListItem>
                        <asp:ListItem>Lawrenceville</asp:ListItem>
                        <asp:ListItem>Decatar</asp:ListItem>
                        <asp:ListItem>Norcross</asp:ListItem>
                        <asp:ListItem>Cumming</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Department
                </td>
                <td>
                    <asp:DropDownList ID="ddlDep" runat="server" Height="17px" Width="128px"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Joining Date
                </td>
                <td>
                    <asp:TextBox ID="txtJdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>BirthDate
                </td>
                <td>
                    <asp:TextBox ID="txtBdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Is Active
                </td>
                <td>
                    <asp:CheckBox ID="chkYes" runat="server" Text="YES" />
                    <asp:CheckBox ID="chkNo" runat="server" Text="NO" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
