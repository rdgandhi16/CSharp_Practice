<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ajaxtrial.aspx.cs" Inherits="Ajaxtrial" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:TextBox ID="TextBox1" TextMode="Password" runat="server"></asp:TextBox>
        <asp:PasswordStrength ID="PasswordStrength1" runat="server" HelpHandlePosition="RightSide" MinimumLowerCaseCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="8" TargetControlID="TextBox1"></asp:PasswordStrength>


    </center>
    </div>
    </form>
</body>
</html>
