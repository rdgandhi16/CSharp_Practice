<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 align="center">Log In Here</h2>
        <table align="center" cellpadding="10px">
            <tr>
                <td>
                    UserName:
                </td>
                <td>
                    <asp:TextBox runat="server" id="uname"/>
                </td>
            </tr><tr>
                <td>
                   Password:
                </td>
                <td>
                    <asp:TextBox runat="server" id="pwd"/>
                </td>
            </tr><tr>
                <td>
                   
                </td>
                <td>
                    <asp:Button Text="Log In" runat="server" ID="btn" onclick="btn_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
