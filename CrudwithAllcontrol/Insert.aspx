<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insert.aspx.cs" Inherits="Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <h2 align="center" border="1" style="width: 676px; margin-left: 293px;">All Control Registration Form</h2>
            <table align="center" border="1">
                <tr>
                    <td>FIRST NAME
                    </td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>LAST NAME
                    </td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        GENDER
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rdGender" BorderWidth="2" runat="server" Width="300px">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        STREAM
                    </td>
                    <td>
                        <asp:CheckBoxList ID="chStream" runat="server" BorderWidth="2" Width="300px">
                            <asp:ListItem>Science</asp:ListItem>
                            <asp:ListItem>Commerce</asp:ListItem>
                            <asp:ListItem>Arts</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        HOBBY
                    </td>
                    <td>
                        <asp:ListBox ID="lsHobby" runat="server" Width="300">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Soccer</asp:ListItem>
                            <asp:ListItem>Badminton</asp:ListItem>
                            <asp:ListItem>Table-Tennis</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        STATE
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlState" runat="server" Width="300px">
                            <asp:ListItem>GA</asp:ListItem>
                            <asp:ListItem>FL</asp:ListItem>
                            <asp:ListItem>CA</asp:ListItem>
                            <asp:ListItem>IN</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnInsert" runat="server" Text="SUBMIT" OnClick="btnInsert_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
