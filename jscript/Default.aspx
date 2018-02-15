<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function cansubmit() {
            var pw = document.getElementById("txtpwd");
            var cpwd = document.getElementById("cpwd");

            if (pw==cpwd) {
                return true;
            }
            else {
                alert("Password and confirmed password not match");
                return false;
            }
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Password:
            <input type="password" name="txtpwd" value="" /><br />
            Confirm Password:
            <input type="password" name="cpwd" value="" /><br />
            <input type="submit" name="txt" value="Submit" onsubmit="return cansubmit()"/>

        </div>
    </form>
</body>
</html>
