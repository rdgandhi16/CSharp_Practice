<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AllcontrolCrud</title>
    <style type="text/css">
        .auto-style1 {
            width: 253px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <br />
            <br />
            <h1 align="center">Employee RegistrationForm</h1>
            <table border="1">
                <tr>
                    <td>Firstname:
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtFname" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Lastname:
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtLname" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender
                    </td>
                    <td class="auto-style1">
                        <asp:RadioButtonList RepeatDirection="Horizontal" ID="radioGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Department
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlDept" runat="server" Width="157px" Height="17px">
                            <asp:ListItem>---Select Department---</asp:ListItem>
                            <asp:ListItem>IT</asp:ListItem>
                            <asp:ListItem>HR</asp:ListItem>
                            <asp:ListItem>Retail</asp:ListItem>
                            <asp:ListItem>Maintanance</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Skills
                    </td>
                    <td class="auto-style1">
                        <asp:CheckBoxList ID="chkSkill" runat="server" Width="240px">
                            <asp:ListItem>Developer</asp:ListItem>
                            <asp:ListItem>PayRoll</asp:ListItem>
                            <asp:ListItem>Finance</asp:ListItem>
                            <asp:ListItem>Management</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>State
                    </td>
                    <td class="auto-style1">
                        <asp:ListBox ID="listState" align="center" runat="server" Width="124px">
                            <asp:ListItem>---Select State---</asp:ListItem>
                            <asp:ListItem>GA</asp:ListItem>
                            <asp:ListItem>NJ</asp:ListItem>
                            <asp:ListItem>NY</asp:ListItem>
                            <asp:ListItem>NC</asp:ListItem>
                            <asp:ListItem>MA</asp:ListItem>
                            <asp:ListItem>SC</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Empsubmit" runat="server" Text="Submit" OnClick="Empsubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
