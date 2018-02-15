<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentsmarks.aspx.cs" Inherits="studentsmarks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" align="center">
    <tr>
        <td>
            Student Name
        </td>
        <td>
            <asp:TextBox ID="Text_name" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
            <td>
                Student Surname
            </td>
            <td>
                <asp:TextBox ID="Text_surname" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
                <td>
                    Class
                </td>
                <td>
                    <asp:TextBox ID="Text_Class" runat="server"></asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td>
                    Gender
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                     Result
                </td>
                <td>
                    <asp:TextBox ID="Text_Result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                </td>
            </tr>
            </table>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
               <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
               </td> 
                               <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
               </td> 
                               <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
               </td> 
                               <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
               </td> 
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
