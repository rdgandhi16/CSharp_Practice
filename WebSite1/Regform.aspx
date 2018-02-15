<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Regform.aspx.cs" Inherits="Regform" %>

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
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="Text_fn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="Text_ln" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" style="height: 26px" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
