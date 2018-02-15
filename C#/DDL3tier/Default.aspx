<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <h1 align="center" style="font-family:'Freestyle Script'"> Select State and City</h1>
            <br />
            <br />
            <table style="font-family:'Freestyle Script';font-size:large" align="center" border="1">
                <tr>
                    <td>
                        State and City
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_state" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDown_state_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_city" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
