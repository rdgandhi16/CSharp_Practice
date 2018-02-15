<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="ViewState" %>

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
            <td colspan="2" align="center">
             View State  
            </td>
        </tr>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:Label ID="Label_view" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox_fname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:Label ID="Label_view1" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="TextBox_lname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </td>
            <td align="center">
                <asp:Button ID="Button2" runat="server" Text="View" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
