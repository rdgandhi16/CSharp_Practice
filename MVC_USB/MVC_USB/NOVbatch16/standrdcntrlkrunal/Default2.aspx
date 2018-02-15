<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" runat="server">Tops</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:LinkButton Font-Underline="false" ID="LinkButton1" runat="server">Tech</asp:LinkButton>
        <img src="Chrysanthemum.jpg" height="100px" width="100px" />
        <asp:Image ID="Image1" ImageUrl="~/Tulips.jpg" Height="100px" Width="100px" AlternateText="abc"
            runat="server" />
        <asp:ImageButton ID="ImageButton1" ImageUrl="~/Desert.jpg" Height="50px" Width="70px"
            runat="server" OnClick="ImageButton1_Click" />
        <asp:Wizard style="margin-left:5em" ID="Wizard1" runat="server">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                    <asp:Image ID="Image2" ImageUrl="~/Tulips.jpg" Height="100px" Width="100px" AlternateText="abc"
                        runat="server" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                    <asp:Image ID="Image3" ImageUrl="~/Desert.jpg" Height="100px" Width="100px" AlternateText="abc"
                        runat="server" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 1">
                    <asp:Image ID="Image4" ImageUrl="~/Penguins.jpg" Height="100px" Width="100px" AlternateText="abc"
                        runat="server" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep4" runat="server" Title="Step 2">
                    <asp:Image ID="Image5" ImageUrl="~/Desert.jpg" Height="100px" Width="100px" AlternateText="abc"
                        runat="server" />
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
