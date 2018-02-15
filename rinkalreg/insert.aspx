<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="insert" %>

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
    <table align="center" border="2">
        <tr>
            <td>
                First Name
            </td>
            <td colspan="2">
                <asp:TextBox ID="Text_fname" runat="server" Height="19px" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
           <td colspan="2">
               <asp:TextBox ID="Text_lname" runat="server" Height="20px" Width="205px"></asp:TextBox>
           </td>
        </tr>
        <tr>
            <td>
                Date & Time
            </td>
            <td>
                <asp:TextBox ID="TextBox1" TextMode="DateTime" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Calendar" />
                <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="MM/dd/yyyy" PopupButtonID="Button1" PopupPosition="BottomRight" TargetControlID="TextBox1"></asp:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td>
                Gender
            </td>
            <td colspan="2">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="90px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                Hobby
            </td>
            <td colspan="2">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Cricket</asp:ListItem>
                    <asp:ListItem>Hockey</asp:ListItem>
                    <asp:ListItem>FootBall</asp:ListItem>
                    <asp:ListItem>TableTenis</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>
                State
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList_state" AutoPostBack="true" runat="server" Width="210px" OnSelectedIndexChanged="DropDownList_state_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                City
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList_city" runat="server" Height="17px" Width="210px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Image
            </td>
            <td colspan="2" style="margin-left: 240px">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="3" rowspan="2" align="center" border="1">
                <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
        </div>
        </center>
    </form>
</body>
</html>
