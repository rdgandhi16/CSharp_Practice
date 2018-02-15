<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dept_details.aspx.cs" Inherits="dept_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/emp_details.aspx">Employee Details</asp:HyperLink>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" onselectedindexchanged="GridView1_SelectedIndexChanged" 
                >
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="id" runat="server" Text='<%#Eval("deptid") %>'></asp:Label>
                        </ItemTemplate>
                       
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Department Name">
                        <ItemTemplate>
                            <asp:Label ID="dname" runat="server" Text='<%#Eval("deptname") %>'></asp:Label>
                        </ItemTemplate>
                       
                    </asp:TemplateField>
                  <asp:ButtonField Text="Select" CommandName="Select" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <table border="1">
                <tr>
                    <td>
                        Department ID
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Department Name
                    </td>
                    <td>
                        <asp:TextBox ID="dname1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" Visible="false" />
                        <asp:Button ID="Button2" runat="server" Text="Update" Visible="false" 
                            onclick="Button2_Click" />

                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
