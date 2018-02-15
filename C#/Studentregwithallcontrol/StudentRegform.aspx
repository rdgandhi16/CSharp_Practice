<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentRegform.aspx.cs" Inherits="StudentRegform" %>

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
            <h1 align="center"><b><u>Student Registration Form</u></b></h1>
            <br />
            <br />
            <table align="center" border="1">
                <tr>
                    <td>
                        Firstname:
                    </td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server" Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Lastname:
                    </td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server" Width="230px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender:
                    </td>
                    <td>
                        <asp:RadioButtonList ID="radioGender" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        State
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                ]<tr>
                    <td>
                        City
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList>
                    </td>
                 </tr>
                <tr>
                    <td>
                        Hobby
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Carrom</asp:ListItem>
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>TableTennis</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Department
                    </td>
                    <td>
                        <asp:RadioButtonList ID="radioDepartment" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem>Diploma</asp:ListItem>
                            <asp:ListItem>Bechlore</asp:ListItem>
                            <asp:ListItem>Master</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Image
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="stdRegbutton" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
