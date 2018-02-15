<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stndcntrl.aspx.cs" Inherits="stndcntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" Height="100px" Width="100px" ImageUrl="~/Desert.jpg" runat="server"
            AlternateText="abc" />
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" runat="server">Tops</asp:HyperLink>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
