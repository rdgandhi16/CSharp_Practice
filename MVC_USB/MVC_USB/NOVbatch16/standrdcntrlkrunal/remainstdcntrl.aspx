<%@ Page Language="C#" AutoEventWireup="true" CodeFile="remainstdcntrl.aspx.cs" Inherits="remainstdcntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- <asp:Label Text="" ID="lbl" runat="server" />
         <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
     <br />
        <asp:ListBox ID="ListBox1" SelectionMode="Multiple" runat="server">
            <asp:ListItem>.NET</asp:ListItem>
            <asp:ListItem>PHP</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button2" runat="server" Text="Submit" onclick="Button2_Click" />
        --%>
        <%--<asp:Panel ID="Panel1" runat="server">
            <h2 align="center">
                Login Here</h2>
            <table border="1" align="center" cellpadding="5">
                <tr>
                    <td>
                        Username:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button Text="Login" ID="btn" runat="server" />
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgot Password</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        
        <asp:Panel Visible="false" ID="Panel2" runat="server">
       
        <h2 align="center">Forgot Password</h2>
        <table border="1" align="center" cellpadding="5">
            <tr>
                <td>
                    Email:
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txt" />
                </td>
            </tr>
            <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" /></td></tr>
        </table>
         </asp:Panel>--%>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <img src="Desert.jpg" height="100px" width="100px" />
                <asp:Button ID="Button1" runat="server" Text="VIew1" onclick="Button1_Click" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <img src="Chrysanthemum.jpg" height="100px" width="100px" />
            
                <asp:Button ID="Button2" runat="server" Text="View2" onclick="Button2_Click" /></asp:View>
        </asp:MultiView>

    </div>
    </form>
</body>
</html>
