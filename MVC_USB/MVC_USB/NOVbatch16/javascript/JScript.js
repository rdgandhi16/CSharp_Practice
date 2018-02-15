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
                str = str + "Enter Firstname";
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
                    str = str + "Select Hobby";
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
                alert(str);
                return false;
            }


        }



    </script>