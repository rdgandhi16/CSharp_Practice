<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirmbutton.aspx.cs" Inherits="Confirmbutton" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    
        <table>
            <tr>
                <td>
                    Welcome to Ajax
                </td>
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click"></asp:Button>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Are you sure want to display" TargetControlID="Button1"></asp:ConfirmButtonExtender></td>
            </tr>
        </table>
    </center>
    </div>
    </form>
</body>
</html>
