<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jqvalid.aspx.cs" Inherits="jqvalid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#Button1").click(function () {

                var fn = $("#fname").val();
                var pass = $("#pass").val();
                var cpass = $("#cpass").val();
                var email = $("#email").val();
                var eid = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

                var s = $('input[type=radio][name=RadioButtonList1]')

                var str = "";
                if (fn == "") {
                    str = str + "Enter Fname..";
//                  //  $("#fname").css("border-color", "RED");
//                    $("#fname").val("Enter Fname");

                    return false;

                }
                if (pass == "") {
                    str = str + "Enter Password..";

                }

                if (pass != cpass) {
                    str = str + "Password MISmatched..";

                }


                if (email == "") {
                    str = str + "Enter Email..";

                }
                else {
                    if (!email.match(eid)) {
                        str = str + "Invalid EMail....";

                    }
                }

                if ($("#male:checked").length == 0) {
                    if ($("#female:checked").length == 0) {
                        str = str + "select gender....";

                    }

                }

                var flag = false;

                for (var i = 0; i < s.length; i++) {

                    if (s[i].checked) {
                        flag = true;
                        break;
                    }
                }

                if (flag == false) {
                    str = str + "Select stream....";
                }


                if (str == "") {
                    return true;

                }
                else {
                    //  alert(str);
                    return false;
                }

            });



        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table border="1" width="500px">
                <tr>
                    <td>
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
                            <asp:ListItem>Select State</asp:ListItem>
                            <asp:ListItem>Gujrat</asp:ListItem>
                            <asp:ListItem>MH</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
