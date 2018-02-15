<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ajaxtool.aspx.cs" Inherits="ajaxtool" %>

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
        
        <asp:TextBox runat="server" ID="txt" />
        <asp:CalendarExtender Format="dd/MMMM/yyyy" TargetControlID="txt" ID="CalendarExtender1" runat="server">
        </asp:CalendarExtender>
      

        <asp:TextBox runat="server" ID="TextBox1" />
        <asp:TextBoxWatermarkExtender  TargetControlID="TextBox1" WatermarkText="Enter Firstname" ID="TextBoxWatermarkExtender1" runat="server">
        </asp:TextBoxWatermarkExtender>
         </center>
    </div>
    </form>
</body>
</html>
