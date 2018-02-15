<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
                <td>
                    Firstname:
                </td>
                <td>
                    <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="LastName:"></asp:Label>
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
            <tr>
            <td>Subject:</td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>.Net</asp:ListItem>
                <asp:ListItem>PHP</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                </asp:ListBox>
            </td></tr>
            <tr>
                <td>
                    State:
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>---Select---</asp:ListItem>
                        <asp:ListItem>Gujrat</asp:ListItem>
                        <asp:ListItem>MH</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button Text="SUBMIT" ID="btn_sub" runat="server" onclick="btn_sub_Click" />
                  
                </td>
            </tr>
        </table>
        <asp:Label ID="lbl_fname" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_lname" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_gen" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_hb" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_sub" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_st" runat="server" Text=""></asp:Label>
       
    </div>
    </form>
</body>
</html>
