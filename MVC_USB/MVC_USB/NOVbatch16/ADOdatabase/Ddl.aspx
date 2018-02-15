<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ddl.aspx.cs" Inherits="Ddl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
                <td>
                    <asp:DropDownList AutoPostBack="true" ID="state" runat="server" 
                        onselectedindexchanged="state_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="city" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
