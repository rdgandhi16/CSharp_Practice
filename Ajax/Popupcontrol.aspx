<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Popupcontrol.aspx.cs" Inherits="Popupcontrol" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
        <style type="text/css">
            .modelBackground {

                background-color:aqua;
            }
            .modelpopup {
            background-color:blue;
            }

            
        </style>
    <center>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <table>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Openoppup"></asp:Button>
                    <asp:Panel ID="Panel1" runat="server" CssClass="modelBackground"> welcome to Ajax 
                        <br> </br>
                        <asp:Button ID="Ok" runat="server" Text="Ok"></asp:Button>
                    </asp:Panel>
                    <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="ModelBacjgroung" DropShadow="True" OkControlID="Ok" PopupControlID="Panel1" TargetControlID="Button1"></asp:ModalPopupExtender>
                </td>
            </tr>
        </table>
    </center>
    </div>
    </form>
</body>
</html>
