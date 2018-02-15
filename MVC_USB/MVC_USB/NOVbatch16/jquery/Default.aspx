<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#Button2").click(function () {

                $("#Image1").hide(2000);
                return false;
            });

            $("#Button1").click(function () {

                $("#Image1").show(2000);
                return false;
            });

            $("#Button3").click(function () {

                $("#Image1").toggle(2000);
                return false;
            });


            $("#in").click(function () {

                $("#Image1").fadeIn(2000);
                return false;

            });
            $("#out").click(function () {

                $("#Image1").fadeout(2000);
                return false;

            });



        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:Button ID="Button2" runat="server" Text="HIDE" />
            <asp:Button ID="Button1" runat="server" Text="SHOW" />
            <asp:Button ID="Button4" runat="server" Text="Both" />
            <asp:Button ID="in" runat="server" Text="Fadein" />
            <asp:Button ID="out" runat="server" Text="fadeout" />

            <br />
            <asp:Image ID="Image1" ImageUrl="~/Tulips.jpg" runat="server" Height="300px" Width="300px" />
        </center>
    </div>
    </form>
</body>
</html>
