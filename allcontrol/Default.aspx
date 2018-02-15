<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Allcontrol</title>
    <style type="text/css">
        .auto-style1 {
            width: 152px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="1">
                <tr>
                    <td>First Name
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Text_fname" runat="server" Width="146px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Text_lname" runat="server" Width="145px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender
                    </td>
                    <td class="auto-style1">
                        <asp:RadioButtonList ID="RadioButtonList_gender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Country
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList_country" runat="server" Height="17px" Width="146px">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>Nepal</asp:ListItem>
                            <asp:ListItem>Barma</asp:ListItem>
                            <asp:ListItem>Foreigner</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City
                    </td>
                    <td class="auto-style1">
                        <asp:ListBox ID="ListBox1" runat="server" Width="151px">
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Ahemdabad</asp:ListItem>
                            <asp:ListItem>Amruitsir</asp:ListItem>
                            <asp:ListItem>Bilimora</asp:ListItem>
                            <asp:ListItem>Chikhli</asp:ListItem>
                            <asp:ListItem>Pardi</asp:ListItem>
                        </asp:ListBox>
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
                            <asp:ListItem>TableTennis</asp:ListItem>
                            <asp:ListItem>Swimming</asp:ListItem>
                            <asp:ListItem>Reading</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </td>
                </tr>                
            </table>
        </div>
    </form>
</body>
</html>
