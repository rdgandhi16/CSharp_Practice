<%@ Page Language="C#" AutoEventWireup="true" CodeFile="threetier.aspx.cs" Inherits="threetier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
    <table align="center" border="2" style="width: 405px">
        <tr>
            <td>
                First Name
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox_fn" runat="server" Width="185px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox_ln" runat="server" Width="185px"></asp:TextBox>
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
                City
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Bilimora</asp:ListItem>
                    <asp:ListItem>Chikhli</asp:ListItem>
                    <asp:ListItem>Surat</asp:ListItem>
                    <asp:ListItem>Valsad</asp:ListItem>
                    <asp:ListItem>Surat</asp:ListItem>
                    <asp:ListItem>Pardi</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Pune</asp:ListItem>
                    <asp:ListItem>Danu</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Nagpur</asp:ListItem>
                    <asp:ListItem>Amritsar</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                State
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Maharastra</asp:ListItem>
                    <asp:ListItem>Punjab</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                </asp:DropDownList>
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
                    <asp:ListItem>Table Tennis</asp:ListItem>
                    <asp:ListItem>Carrom</asp:ListItem>
                    <asp:ListItem>Singing</asp:ListItem>
                    <asp:ListItem>Gymming</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>
                Image
            </td>
            <td class="auto-style1">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="198px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
            </center>
    </div>
    </form>
</body>
</html>
