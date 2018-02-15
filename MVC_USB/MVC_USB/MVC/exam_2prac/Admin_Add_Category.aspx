<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Add_Category.aspx.cs"
    Inherits="Admin_Add_Category" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table border="1" align="center">
                <tr>
                    <td colspan="2">
                        Add Product Category
                    </td>
                </tr>
                <tr>
                    <td>
                        Category Name:
                    </td>
                    <td>
                        <asp:TextBox ID="cat_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
