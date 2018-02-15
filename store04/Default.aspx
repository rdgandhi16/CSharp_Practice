<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table style="font-family:'Arabic Typesetting'; font-size:x-large" align="center" border="1">
                <tr>
                    <td>
                        First Name
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox_fname" runat="server" Height="20px" Width="220px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td class="auto-style1">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hobby
                    </td>
                    <td class="auto-style1">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>FootBall</asp:ListItem>
                            <asp:ListItem>Badminton</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        State
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList_state" AutoPostBack="true" runat="server" Height="18px" Width="220px" OnSelectedIndexChanged="DropDownList_state_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        City
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList_city" runat="server" Height="16px" style="margin-right: 1px" Width="220px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Image
                    </td>
                    <td class="auto-style1">
                        <asp:FileUpload ID="FileUpload1"  runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
