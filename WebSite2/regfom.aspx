<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regfom.aspx.cs" Inherits="regfom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 231px;
        }
        .auto-style2 {
            width: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p align="center" style="font-family:Cambria;font-size:x-large";> Student Registration Form </p>
    <table align="center" border="2">
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_fn" runat="server"></asp:TextBox>
            </td>
            <td>
                Middle Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_mn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="TextBox_ln" runat="server"></asp:TextBox>
            </td>
            <td>
                Gender
            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                Class
            </td>
            <td colspan="4">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="451px">
                    <asp:ListItem>I</asp:ListItem>
                    <asp:ListItem>II</asp:ListItem>
                    <asp:ListItem>III</asp:ListItem>
                    <asp:ListItem>IV</asp:ListItem>
                    <asp:ListItem>V</asp:ListItem>
                    <asp:ListItem>VI</asp:ListItem>
                    <asp:ListItem>VII</asp:ListItem>
                    <asp:ListItem>VIII</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Hobby
            </td>
            <td colspan="4">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Cricket</asp:ListItem>
                    <asp:ListItem>FootBall</asp:ListItem>
                    <asp:ListItem>Table Tennis</asp:ListItem>
                    <asp:ListItem>Swimming</asp:ListItem>
                    <asp:ListItem>Painting</asp:ListItem>
                    <asp:ListItem>Singing</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>
                City
            </td>
            <td  colspan="4">
                <asp:ListBox ID="ListBox1" runat="server" Width="447px">
                    <asp:ListItem>Chikhli</asp:ListItem>
                    <asp:ListItem>Bilimora</asp:ListItem>
                    <asp:ListItem>Pardi</asp:ListItem>
                    <asp:ListItem>Valsad</asp:ListItem>
                    <asp:ListItem>Navsari</asp:ListItem>
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center" border="2">
                <asp:Button ID="Button1" runat="server" Text="Submitt" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
