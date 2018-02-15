<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 align="center"> Calendar Demo</h2>
        <br />
        <center>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <table>
            <tr>
                <td>
                    Enter Date
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="~/FB_IMG_1459668518252.jpg" Width="50px" />
                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" DaysModeTitleFormat="dd/mm/yyyy" Format="dd/mm/yyyy" PopupButtonID="ImageButton1" PopupPosition="BottomRight" TargetControlID="TextBox1"></asp:CalendarExtender>
                </td>
            </tr>
        </table>
            </center>
    </div>
    </form>
</body>
</html>
