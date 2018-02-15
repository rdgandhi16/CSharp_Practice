<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Regform.aspx.cs" Inherits="Regform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student_Reg</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <h1 align="center" style="font-family:Andalus"> Student's Registration Form</h1>
        <br />
        <br />
    <table align="center" border="1" style="font-family:Andalus">
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_fn" runat="server" Width="210px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_ln" runat="server" Width="210px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gender
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                State
            </td>
            <td>
                <asp:DropDownList ID="DropDownList_state" AutoPostBack="true" runat="server" Height="16px" Width="210px" OnSelectedIndexChanged="DropDownList_state_SelectedIndexChanged">                  
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                City
            </td>
            <td>
                <asp:DropDownList ID="DropDownList_city" runat="server" Width="210px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Hobby
            </td>
            <td>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="210px">
                    <asp:ListItem>Cricket</asp:ListItem>
                    <asp:ListItem>FootBall</asp:ListItem>
                    <asp:ListItem>Swimming</asp:ListItem>
                    <asp:ListItem>Travelling</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>
                Image
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Save" Width="92px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
