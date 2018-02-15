<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertcode.aspx.cs" Inherits="insertcode" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />

            <h1 align="center" border="2" style="font-family: Andalus">Sports Registration</h1>
            <br />
            <table style="font-family: Andalus" border="1" align="center">
                <tr>
                    <td>First Name
                    </td>
                    <td>
                        <asp:TextBox ID="Text_fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last Name
                    </td>
                    <td>
                        <asp:TextBox ID="Text_lname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Date and Time
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" SelectionMode="DayWeekMonth" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                        <asp:TextBox ID="TextBox_cal" runat="server"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td>Gender
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>State
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_state" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_City" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Sports
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>FootBall</asp:ListItem>
                            <asp:ListItem>TableTennis</asp:ListItem>
                            <asp:ListItem>badminton</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>Height
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Image
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
