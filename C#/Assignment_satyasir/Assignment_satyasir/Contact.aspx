<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Assignment_satyasir.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br />
    <asp:Image ID="Image1" ImageUrl="~/Image/Aimployment-logo.jpg" Height="175px" Width="172px" runat="server" />
    <h2 style="font-family:Cambria">Contact Information.</h2>
    <address style="font-family:Cambria">
        5445 McGinnis Village Place<br />
        Suit-204, Alpharetta, GA-30005<br />
        <abbr title="Phone">P:</abbr>
        (404) 654-3737
    </address>

    <address style="font-family:'Cambria'">
        <strong>Support:</strong>   <a href="mailto:Support@example.com">archit@aimployment.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">pravin@aimployment.com</a>
    </address>
</asp:Content>
