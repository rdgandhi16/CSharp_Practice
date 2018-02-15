<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <table>
                <tr>
                    <td>
                        Firstname:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="fname" />
                    </td>
                </tr>
                <tr>
                    <td>
                        LastName:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="lname" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click"  />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
