<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-1.11.0.min.js" type="text/javascript"></script>
    <script src="jquery.bvalidator-yc.js" type="text/javascript"></script>
    <script src="jquery.bvalidator.js" type="text/javascript"></script>
    <link href="bvalidator.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('#form1').bValidator();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        FirstName:
        <asp:TextBox data-bvalidator="required" data-bvalidator-msg="FirstName Required"
            ID="TextBox1" runat="server"></asp:TextBox>
        Email:<asp:TextBox data-bvalidator="required,email" ID="TextBox2" runat="server">
    
        </asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
