<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Watermark.aspx.cs" Inherits="Watermark" %>

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
            <h2 align="center"> Water Mark Demo </h2>
               <table>
                   <tr>
                       <td>
                           First Name
                       </td>
                       <td>
                           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                           <asp:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" WatermarkText="First Name" WatermarkCssClass="" Enabled="True" TargetControlID="TextBox1">
                           </asp:TextBoxWatermarkExtender>

                       </td>
                   </tr>
               </table>
        </center>
 
    </div>
    </form>
</body>
</html>
