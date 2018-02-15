<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetail.aspx.cs" Inherits="Assignment_satyasir.AUTOMAC.EmployeeDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table align="center" border="1">
                <tr>
                    <td>EID
                    </td>
                    <td>
                        <asp:Label ID="Label_eid" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Employee Name
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_ename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        City
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_city" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Department
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Joining Date
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_joiningdate" TextMode="Date"  runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Birth Date
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox_dob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Is Active
                    </td>
                    <td>
                        <asp:CheckBox ID="Yes" runat="server" Text="Yes" />
                        <asp:CheckBox ID="No" runat="server" Text="No" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Submit"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
