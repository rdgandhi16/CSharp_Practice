<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    Firstname
                </td>
                <td>
                    <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label Style="color: red" ID="lbl_lname" runat="server" Text="Lastname"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Gender:
                </td>
                <td>
                    <asp:RadioButton ID="rd_male" runat="server" GroupName="a" Text="Male" />
                    <asp:RadioButton ID="rd_female" runat="server" GroupName="a" Text="Female" />
                </td>
            </tr>
            <tr>
                <td>
                    Hobby:
                </td>
                <td>
                    <asp:CheckBox ID="chk_cric" runat="server" Text="Cricket" />
                    <asp:CheckBox ID="chk_foot" runat="server" Text="Football" />
                </td>
            </tr>
            <tr>
                <td>
                    Subject
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Math</asp:ListItem>
                        <asp:ListItem>SCi</asp:ListItem>
                        <asp:ListItem>Guj</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    State:
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Gujrat</asp:ListItem>
                        <asp:ListItem>MH</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_submit" runat="server" Text="Submit" 
                        onclick="btn_submit_Click" />
                </td>
            </tr>
        </table>
    </div>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
