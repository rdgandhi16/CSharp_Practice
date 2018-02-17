<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FnameLname.aspx.cs" Inherits="FnameLname" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 276px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />

            <h1 style="font: bolder" align="center">STUDENT REGISTRATION FORM </h1>
            <br />
            <br />

            <table align="center" border="1">
                <tr>
                    <td>FIRST NAME
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtFname" runat="server" Width="264px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>MIDDLE NAME
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtMname" runat="server" Width="264px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>LASTNAME
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtLname" runat="server" Width="264px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>GENDER
                    </td>
                    <td class="auto-style1">
                        <asp:RadioButtonList ID="rdGender" runat="server" Width="264px">
                            <asp:ListItem>MALE</asp:ListItem>
                            <asp:ListItem>FEMALE</asp:ListItem>
                            <asp:ListItem>OTHER</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>HOBBY
                    </td>
                    <td class="auto-style1">
                        <asp:CheckBoxList ID="chHobby" runat="server" Width="264px">
                            <asp:ListItem>CRICKET</asp:ListItem>
                            <asp:ListItem>FOOTBALL</asp:ListItem>
                            <asp:ListItem>SOCCER</asp:ListItem>
                            <asp:ListItem>BADMINTON</asp:ListItem>
                            <asp:ListItem>TABLE-TENNIS</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>STATE
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlState" runat="server" Width="264px">
                            <asp:ListItem>Georgia</asp:ListItem>
                            <asp:ListItem>Florida</asp:ListItem>
                            <asp:ListItem>California</asp:ListItem>
                            <asp:ListItem>Verginia</asp:ListItem>
                            <asp:ListItem>Illionoi</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" OnClick="btnSubmit_Click" Width="122px" Height="43px"></asp:Button>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
