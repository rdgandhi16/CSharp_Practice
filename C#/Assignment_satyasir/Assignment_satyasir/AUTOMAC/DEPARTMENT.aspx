<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DEPARTMENT.aspx.cs" Inherits="Assignment_satyasir.AUTOMAC.DEPARTMENT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <br />
            <br />
            <h3 align="center">Department</h3>
            <br />
            <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="Label_id" runat="server" Text='<%# Eval("DEP_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DEPARTMENT">
                        <ItemTemplate>
                            <asp:Label ID="Label_dname" runat="server" Text='<%# Eval("DEPARTMENT") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField Text="select" CommandName="select" />
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
        </div>
        <br />
        <br />

        <div>
            <table align="center" border="1">
                <tr>
                    <td>
                        Department ID
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Department Name
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_dname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Save" Visible="false" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Update" Visible="false" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
