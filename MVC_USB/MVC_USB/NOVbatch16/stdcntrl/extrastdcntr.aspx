<%@ Page Language="C#" AutoEventWireup="true" CodeFile="extrastdcntr.aspx.cs" Inherits="extrastdcntr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- <asp:AdRotator Width="100px" Height="500px" ID="AdRotator1" AdvertisementFile="~/XMLFile.xml" runat="server" />
        --%>
        <asp:Label ID="abc" runat="server" Text=""></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Cricket</asp:ListItem>
            <asp:ListItem>Football</asp:ListItem>
            <asp:ListItem>Hockey</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    <%-- <asp:Calendar ID="Calendar1" Height="100px" Width="100px" runat="server" 
        onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
    --%>
    <%--  <asp:ImageButton ID="ImageButton1" Height="70px" Width="120px" 
        ImageUrl="~/image/Hydrangeas.jpg" runat="server" onclick="ImageButton1_Click" />
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">LinkButton</asp:LinkButton>
    --%>
  <%--  <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" AutoPostBack="true"
        OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
        <asp:ListItem>Math</asp:ListItem>
        <asp:ListItem>Sci</asp:ListItem>
        <asp:ListItem>Guj</asp:ListItem>
    </asp:ListBox>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />

 --%>  
 
    <asp:Wizard ID="Wizard1" runat="server">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                <img src="image/Chrysanthemum.jpg" width="70px" height="70px" />
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                <img src="image/Hydrangeas.jpg" width="70px" height="70px" />
            </asp:WizardStep>
             <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 2">
                <img src="image/Hydrangeas.jpg" width="70px" height="70px" />
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
 
 
 
 
  </form>
</body>
</html>
