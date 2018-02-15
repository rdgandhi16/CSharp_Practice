<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JqueryRG.aspx.cs" Inherits="JqueryRG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jquery</title>
    <script type="text/javascript">

        function valid() {


            var fn = document.getElementById("fname");
            var pwd = document.getElementById("pass");
            var cpw = document.getElementById("cpass");


            var str = "";

            if (fn.value == "") {
                str = "Please Select First Name...";                
            }
            if (pwd.value == "") {
                str = str + "Password is Mandatory...";
            }
            if (cpw!=pwd) {
                str=str+"password is not Same.."
            }

            if (str == "") {
                return true;
            }
            else {
                alert(str);
                return false;
            }

            //var fn = document.getElementById("fname");
            //var pwd = document.getElementById("pass");
            //var cpwd = document.getElementById("cpass");
            //var email = document.getElementById("email");
            //var eid = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            //var male = document.getElementById("male");
            //var female = document.getElementById("female");

            //var stream = document.getElementById("RadioButtonList1").getElementsByTagName("input");
            //var cric = document.getElementById("cric");
            //var foot = document.getElementById("foot");
            //var other = document.getElementById("CheckBoxList1").getElementsByTagName("inout");
            //var state = document.getElementById("DropDownList1");

            //var str = "";

            //if (fn.value=="") {
            //    str = "Enter your name please...";
            //    return false;
            //}
            //if (pwd.value == "") {
            //    str =str +"Enter Password Please..";
            //}
            //if (cpwd.value!=pwd.value) {
            //    str = "Password not matched please try again..";                
            //}
            //if (email.value=="") {
            //    str=str+"Enter Email Address.."
            //}
            //else {
            //    if (!email.value.match(eid)) {
            //        str = str + "Invalid Email address..";
            //    }
            //}
            //if (male.checked==false) {
            //    if (female.checked==false) {
            //        str=str+"Select Gender please";
            //    }
            //}
            //var flag = false;
            //for (var i = 0; i < stream.length; i++) {                
            //    if (stream[i].checked) {
            //        flag = true;
            //    }
            //}
            //if (flag==false) {
            //    str = str + "Select stream..";
            //}
            //if (cric.checked==false) {
            //    if (foot.checked==false) {
            //        str = str + "Select Hobby..";
            //    }
            //}
            //var flag1 = false;
            //for (var i = 0; i < other.length; i++) {
            //    if (other[i].checked) {
            //        str = str + "PLease select other..";
            //    }
            //}
            //if (str == "") {
            //    return true;
            //}
            //else {
            //    alert(str);
            //    return false;
            //}
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <table border="1">
                <tr>
                    <td >
                        FirstName:
                    </td>
                    <td id="f">
                 
                        <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password:
                    </td>
                    <td>
                        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Confirm Password:
                    </td>
                    <td>
                        <asp:TextBox ID="cpass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender:
                    </td>
                    <td>
                        <asp:RadioButton ID="male" runat="server" GroupName="a" Text="Male" />
                        <asp:RadioButton ID="female" runat="server" GroupName="a" Text="FeMale" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Stream:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Science</asp:ListItem>
                            <asp:ListItem>Arts</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hobby:
                    </td>
                    <td>
                        <asp:CheckBox ID="cric" runat="server" Text="Cricket" />
                        <asp:CheckBox ID="foot" runat="server" Text="Foot" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Other:
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Music</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        State:
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="0">Select State</asp:ListItem>
                            <asp:ListItem>Gujrat</asp:ListItem>
                            <asp:ListItem>MH</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClientClick="return valid()" />
                    </td>
                </tr>
            </table>
        </center>
        </div>
    </form>
</body>
</html>
