<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BlueGreenButton.aspx.cs" Inherits="BlueGreenButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/image/blue.png" Width="130px" Height="25px" OnClick="ImageButton1_Click" />

<%--        <script type="text/javascript">
            function changeimageonmouseover() {
                document.getElementById("ImageButton1").src = "/imgae/green.jpg";
            }
            function changeimageonmouseout() {
                document.getElementById("ImageButton1").src = "/image/blue.png";
            }
        </script> --%>
    </div>
    </form>
</body>
</html>
