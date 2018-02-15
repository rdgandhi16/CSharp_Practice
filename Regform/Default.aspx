<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 55px;
        }
        .auto-style2 {
            width: 218px;
        }
        .auto-style3 {
            height: 55px;
            width: 218px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />

            <h1 align="center" style="font-family:Calibri"> Student Registration Form</h1>
            <table align="Center" border="1" style="font-family: Calibri">
                <tr>
                    <td>First Name
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Text_fn" runat="server" Width="208px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Text_ln" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="200px">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Text_Email" runat="server" Width="213px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Text_pwd" runat="server" Width="213px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="Text_cpwd" runat="server" Width="213px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Calendar
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" SelectionMode="DayWeekMonth" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>
                        Class
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>---Select Class---</asp:ListItem>
                            <asp:ListItem>XI</asp:ListItem>
                            <asp:ListItem>XII</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        Stream
                    </td>
                    <td class="auto-style3">
                        <asp:ListBox ID="ListBox1" runat="server">
                            <asp:ListItem>Science</asp:ListItem>
                            <asp:ListItem>Commerce</asp:ListItem>
                            <asp:ListItem>Arts</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hobby
                    </td>
                    <td class="auto-style2">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="213px">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Table-Tennis</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        State
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dd_state" AutoPostBack="true"  runat="server" Width="228px" OnSelectedIndexChanged="dd_state_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        City
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="dd_city" runat="server" Width="229px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Image
                    </td>
                    <td class="auto-style2">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
