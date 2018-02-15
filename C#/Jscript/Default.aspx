<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function valid() {

            var str="";
            var fn = document.getElementById("fname");
            var ln = document.getElementById("lname");
            var gn = document.getElementById("gendertype");
            var pwd = document.getElementById("TextPwd");
            var cpwd = document.getElementById("TextCpwd");

            if (fn.value=="") {
                str = "Firstname is required..";
            }
            if (ln.value=="") {
                str = str+ "Lastname is required..";
            }
            if (gn.value==0) {
                str = str + "Select gender please";
            }
            if (pwd.value=="") {
                str=str+"Password is Mandatory.."
            }
            if (pwd.value!="" && cpwd.value=="") {
                str = str + "Please insert confirm password..";
            }
            if (pwd.value!=cpwd.value) {
                str = str + "Password is not match..";
            }
            if (str=="") {
                return true;
            }
            else {
                alert(str);
                return false;
            }
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <h1 align="center"> JavaScript Validation</h1>
            <table  align="center" border="1" style="width: 335px;background-color:aqua">
                <tr>
                    <td>Firstname:
                    </td>
                    <td><asp:TextBox ID="fname" runat="server" Width="241px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Lastname:</td>
                    <td><asp:TextBox ID="lname" runat="server" Width="241px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td>
                        <asp:DropDownList ID="gendertype" runat="server">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    </td>
                    <td>
                        <asp:TextBox ID="TextPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password
                    </td>
                    <td>
                        <asp:TextBox ID="TextCpwd" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="return valid();" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
