<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addproduct.aspx.cs" Inherits="Addproduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <h2>Add Product</h2>
        <table>
            <tr>
                <td>
                    Product Name:
                </td>
                <td>
                    <asp:TextBox ID="pname" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    Product Price:
                </td>
                <td>
                    <asp:TextBox ID="pprice" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    Product Details:
                </td>
                <td>
                    <asp:TextBox ID="pdetail" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    Product Category:
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Mobile</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                    </asp:DropDownList>
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
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
