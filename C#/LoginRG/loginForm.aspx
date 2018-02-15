<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginForm.aspx.cs" Inherits="loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="font-family: Cambria; font-size: large">
            <br />
            <br />
            
            <h1> User Login</h1>
            <br />
            <table border="1" style="width: 324px; margin-left: 0px">
                <tr>
                    <td>
                        Firstname:
                    </td>
                    <td>
                        <asp:TextBox ID="txtUname" runat="server" Width="214px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" TextMode="Password" runat="server" Width="213px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Sign-in" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server"><u>Forget Password</u></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
