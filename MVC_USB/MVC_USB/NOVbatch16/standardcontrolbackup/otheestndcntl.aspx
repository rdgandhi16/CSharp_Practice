<%@ Page Language="C#" AutoEventWireup="true" CodeFile="otheestndcntl.aspx.cs" Inherits="otheestndcntl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" AdvertisementFile="~/XMLFile.xml" Height="400px" Width="120px" runat="server" />
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <%--    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Cricket</asp:ListItem>
            <asp:ListItem>Football</asp:ListItem>
            <asp:ListItem>Hockey</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <asp:ImageButton Height="50px" Width="100px" ImageUrl="~/Lighthouse.jpg" ID="ImageButton1"
            runat="server" OnClick="ImageButton1_Click" />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">tops</asp:LinkButton>
        <br />
        <asp:ListBox ID="ListBox1" SelectionMode="Multiple" runat="server">
            <asp:ListItem>Math</asp:ListItem>
            <asp:ListItem>Sci</asp:ListItem>
            <asp:ListItem>Guj</asp:ListItem>
        </asp:ListBox><br />
        <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
        --%>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Wizard ID="Wizard1" runat="server">

            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                    <img src="Desert.jpg" height="150px" width="200px" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                    <img src="Hydrangeas.jpg" height="150px" width="200px" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
                    <img src="Desert.jpg" height="150px" width="200px" />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep4" runat="server" Title="Step 4">
                    <img src="Hydrangeas.jpg" height="150px" width="200px" />
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>

        <asp:Calendar Height="300px" Width="300px" ID="Calendar1" runat="server" 
            onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
    </div>
    </form>
</body>
</html>
