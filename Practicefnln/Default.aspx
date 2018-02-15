<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" align="center">
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_fn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_ln" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Submitt" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
