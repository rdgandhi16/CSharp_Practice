<%@ Page Language="C#" AutoEventWireup="true" CodeFile="otherstdcntrl.aspx.cs" Inherits="otherstdcntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" runat="server">HyperLink</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
   
        <asp:Image ID="Image1" Height="50px" Width="50px" ImageUrl="~/Chrysanthemum.jpg" runat="server" />

        <img src="Chrysanthemum.jpg" />
   
    </div>
    </form>
</body>
</html>
