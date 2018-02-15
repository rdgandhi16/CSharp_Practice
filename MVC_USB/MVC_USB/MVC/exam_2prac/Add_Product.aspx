<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Product.aspx.cs" Inherits="Add_Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table border="1">
                <tr>
                    <td colspan="2" align="center">
                        Add Product
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Category:
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Name:
                    </td>
                    <td>
                        <asp:TextBox ID="P_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Price:
                    </td>
                    <td>
                        <asp:TextBox ID="p_price" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Quantity:
                    </td>
                    <td>
                        <asp:TextBox ID="p_qty" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Description:
                    </td>
                    <td>
                        <asp:TextBox ID="P_Desc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Product Image:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
