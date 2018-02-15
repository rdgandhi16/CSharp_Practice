<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <br />
        <br />
        <h1> Welcome to RG Page</h1>
        <asp:Label ID="lblLogin" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sign-Out" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
