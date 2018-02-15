<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Session.aspx.cs" Inherits="Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="2" ALIGN="CENTER">
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox ID="Text_name" runat="server"></asp:TextBox>
            </td>
            <td>
                Surname
            </td>
            <td>
                <asp:TextBox ID="Text_surname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
            </td>
            <td ALIGN="CENTER">
                <asp:Button ID="Button2" runat="server" Text="ABANDON" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="CLEAR" OnClick="Button3_Click" />
            </td>
            <td ALIGN="CENTER">
                <asp:Button ID="Button4" runat="server" Text="REMOVE" OnClick="Button4_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
