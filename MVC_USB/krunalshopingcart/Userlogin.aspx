<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Userlogin.aspx.cs" Inherits="Userlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div align="center">
        <h2>User Log In</h2>
        <table>
            <tr>
                <td>
                    User Name:
                </td>
                <td>
                    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="password" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>

                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
