<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" align="Center">
                <tr>
                    <td>Firstname
                    </td>
                    <td>
                        <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender:
                    </td>
                    <td>
                        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Hobby:
                    </td>
                    <td>
                        <asp:CheckBoxList RepeatDirection="Horizontal" ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Hockey</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>Subject
                    </td>
                    <td>
                        <asp:ListBox SelectionMode="Multiple" ID="ListBox1" runat="server">
                            <asp:ListItem>Math</asp:ListItem>
                            <asp:ListItem>SCi</asp:ListItem>
                            <asp:ListItem>Guj</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>State:
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_state" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDown_state_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>City
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_city" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Image:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
