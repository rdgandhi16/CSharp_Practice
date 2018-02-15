<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStrin.aspx.cs" Inherits="QueryStrin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" border="1">
        <tr>
            <td colspan="2">
                Query String
            </td>
        </tr>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_fname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_lname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" style="height: 26px" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
