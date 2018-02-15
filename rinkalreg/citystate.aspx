<%@ Page Language="C#" AutoEventWireup="true" CodeFile="citystate.aspx.cs" Inherits="citystate" %>

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
            <br />
            <h1 align="center" style="font-family: 'Freestyle Script'; font-style: italic">DropDown For state and city</h1>
            <table align="center" border="1">
                <tr>
                    <td>Select State and City
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_state" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDown_state_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDown_city" AutoPostBack="true" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
