<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" align="center">
            <tr>
                <td>
                    Viewstate:
                </td>
                <td>
                    <asp:Label Text="" ID="lbl_view" runat="server" />
                    <asp:TextBox ID="txt_view" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="View" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    QueryString:
                </td>
                <td>
                    Fname:
                    <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                    Lname
                    <asp:TextBox ID="lname" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Send" OnClick="Button3_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Cookie:
                </td>
                <td>
                    <asp:Label ID="lbl_c" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txt_c" runat="server"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Text="ADD" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Text="View" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="Expire" OnClick="Button6_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Hiddeenfield:
                </td>
                <td>
                    <asp:Label ID="hd" runat="server" Text=""></asp:Label>
                    <asp:HiddenField ID="HiddenField1" Value="10" runat="server" />
                    <asp:Button ID="Button7" runat="server" Text="View" OnClick="Button7_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Session:
                </td>
                <td>
                    <asp:TextBox ID="txt_ses" runat="server"></asp:TextBox>
                    <asp:Button ID="Button8" runat="server" Text="ADD" onclick="Button8_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
