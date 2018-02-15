<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <table>
            <tr>
                <td>
                    Firstname:
                </td>
                <td>
                    <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Lastname:
                </td>
                <td>
                    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
                    <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="lname" runat="server">
                    </asp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
