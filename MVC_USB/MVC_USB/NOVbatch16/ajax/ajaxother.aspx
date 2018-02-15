<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ajaxother.aspx.cs" Inherits="ajaxother" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <center>
            <asp:TextBox runat="server" ID="color" />
            <asp:ColorPickerExtender TargetControlID="color" ID="ColorPickerExtender1" runat="server">
            </asp:ColorPickerExtender>
        </center>
        <asp:Panel ID="timer" runat="server" Width="250px" BackColor="White" ForeColor="DarkBlue"
            BorderWidth="2" BorderStyle="solid" BorderColor="DarkBlue" Style="z-index: 1;">
            <div style="width: 100%; height: 100%; vertical-align: middle; text-align: center;">
                <p>
                    Current Time:</p>
                <span id="currentTime" runat="server" style="font-size: xx-large; font-weight: bold;
                    line-height: 40px;" />
            </div>
        </asp:Panel>
        Notepad is a basic text-editing program and it's most commonly used to view or edit
        text files. A text file is a file type typically identified by the .txt file name
        extension.Notepad is a basic text-editing program and it's most commonly used to
        view or edit text files. A text file is a file type typically identified by the
        .txt file name extension.
        <asp:AlwaysVisibleControlExtender TargetControlID="timer" VerticalSide="Top" VerticalOffset="10"
            HorizontalSide="Right" HorizontalOffset="10" ScrollEffectDuration=".1" ID="AlwaysVisibleControlExtender1"
            runat="server">
        </asp:AlwaysVisibleControlExtender>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:PasswordStrength TargetControlID="TextBox1" DisplayPosition="RightSide" StrengthIndicatorType="BarIndicator"
            ID="PasswordStrength1" runat="server">
        </asp:PasswordStrength>
        <br />
        <br />
        <center>
            <asp:HyperLink ID="HyperLink1" NavigateUrl="#" runat="server">Login</asp:HyperLink>
            <asp:Panel ID="Panel1" runat="server">
                <table>
                    <tr>
                        <td>
                            Username:
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:PopupControlExtender Position="Bottom" TargetControlID="HyperLink1" PopupControlID="Panel1"
                ID="PopupControlExtender1" runat="server">
            </asp:PopupControlExtender>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>ABC</asp:ListItem>
                <asp:ListItem>TOPS</asp:ListItem>
                <asp:ListItem>Navsari</asp:ListItem>
            </asp:ListBox>
            <asp:ListSearchExtender TargetControlID="ListBox1" ID="ListSearchExtender1" runat="server">
            </asp:ListSearchExtender>
        </center>
    </div>
    </form>
</body>
</html>
