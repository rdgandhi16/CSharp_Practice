<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">

        function valid() {

            var fn = document.getElementById("fname");
            var pass = document.getElementById("pass");
            var cpass = document.getElementById("cpass");
            var email = document.getElementById("email");
            var eid = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            var male = document.getElementById("male");
            var female = document.getElementById("female");

            var stream = document.getElementById("RadioButtonList1").getElementsByTagName("input");
            var cric = document.getElementById("cric");
            var foot = document.getElementById("foot");
            var other = document.getElementById("CheckBoxList1").getElementsByTagName("input");
            var state = document.getElementById("DropDownList1");
            var str = "";

            if (fn.value == "") {
                // str = str + "Enter Firstname";
               document.getElementById("fname").value="Enter";
             //   document.getElementById("fname").style.borderColor = "red";
             //   document.getElementById("f").style.backgroundColor = "red";
                return false;
            }

            if (pass.value == "") {
                str = str + "\t" + "Enter Password";
            }

            if (pass.value != cpass.value) {
                str = str + "Password Not match";
            }

            if (email.value == "") {
                str = str + "Enter Email..";
            }
            else {
                if (!email.value.match(eid)) {
                    str = str + "Inavlid Email.."

                }
            }

            if (male.checked == false) {
                if (female.checked == false) {
                    str = str + "Select Gender"
                }

            }
            var flag = false;
            for (var i = 0; i < stream.length; i++) {

                if (stream[i].checked) {
                    flag = true;
                }
            }
            if (flag==false) {
                str = str + "Select Stream";
            }

            if (cric.checked == false) {
                if (foot.checked==false) {
                    str = str + "Select Hobby"+"<br/>";
                }
           
            }

            var flag1 = false;
            for (var j = 0; j < other.length; j++) {
                if (other[j].checked) {
                    flag1 = true;
                }
            }
            if (flag1==false) {
                str = str + "Select Other..";
            }
            if (state.value == 0) {
                str = str + "select State..";

            }

            if (str == "") {
                return true;

            }
            else {
                //alert(str);
              //  document.getElementById("d").innerHTML = str;
              //  document.getElementById("d").style.color = "red";

                return false;
            }


        }



    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="d"></div>
        <center>
            <table border="1" width="500px">
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
