<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookies.aspx.cs" Inherits="Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="2">
                <tr>
                    <td colspan="2" align="center">Cookies
                    </td>
                </tr>
                <tr>
                    <td>First Name
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                       </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                        </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button2" runat="server" Text="VIEW" OnClick="Button2_Click" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button3" runat="server" Text="EXPIRE" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
