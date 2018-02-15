<%@ Page Language="C#" AutoEventWireup="true" CodeFile="remaincntrl.aspx.cs" Inherits="remaincntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <%--  <asp:Panel ID="Panel1" runat="server">
        <div>
            <h2 align="center">
                Log In Here</h2>
            <table align="center" border="2" cellpadding="5">
                <tr>
                    <td>
                        Username:
                    </td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    </td>
                    <td>
                        <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" />
                        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Forgot password</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>

    <asp:Panel ID="Panel2" Visible="false" runat="server">
        <div>
            <h2 align="center">
                Forgot Password
            </h2>
            <table align="center" border="2" cellpadding="5">
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="email" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    --%>
    <table>
        <tr>
            <td>
                Image:
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>
                <asp:Button Text="Upload" ID="btn" runat="server" OnClick="btn_Click" />
            </td>
        </tr>
    </table>

    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/image/Hydrangeas.jpg" Height="50px" Width="50px"
                runat="server" />
            <asp:Button ID="Button1" runat="server" Text="View1" onclick="Button1_Click" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:Image ID="Image2" ImageUrl="~/image/Lighthouse.jpg" Height="50px" Width="50px"
                runat="server" />
            <asp:Button ID="Button2" runat="server" Text="View2" onclick="Button2_Click" />
        </asp:View>
    </asp:MultiView>
    </form>
</body>
</html>
