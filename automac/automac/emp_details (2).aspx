<%@ Page Language="C#" AutoEventWireup="true" CodeFile="emp_details.aspx.cs" Inherits="emp_details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/dept_details.aspx">Department Details</asp:HyperLink>
    <center>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="EID">
                        <ItemTemplate>
                            <asp:Label ID="eid" runat="server" Text='<%#Eval("eid") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="ename" runat="server" Text='<%#Eval("ename") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address">
                        <ItemTemplate>
                            <asp:Label ID="addr" runat="server" Text='<%#Eval("addr") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="city" runat="server" Text='<%#Eval("city") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Department">
                        <ItemTemplate>
                            <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("deptid") %>'/>
                            <asp:Label ID="dname" runat="server" Text='<%#Eval("deptname") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Joining Date">
                        <ItemTemplate>
                            <asp:Label ID="jdate" runat="server" Text='<%# Convert.ToDateTime(Eval("jdate")).ToString("d") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Birth Date">
                        <ItemTemplate>
                            <asp:Label ID="bdate" runat="server" Text='<%#Convert.ToDateTime(Eval("bdate")).ToShortDateString() %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="gen" runat="server" Text='<%#Eval("gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Is Active">
                        <ItemTemplate>

                            <asp:Label ID="isa" runat="server" Text='<%#Eval("isactive") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField Text="Select" CommandName="Select" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <br />
            <br />
            <table border="1">
                <tr>
                    <td>
                        Eid
                    </td>
                    <td>
                        <asp:Label ID="eid" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Employee Name
                    </td>
                    <td>
                        <asp:TextBox ID="ename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Address
                    </td>
                    <td>
                        <asp:TextBox ID="addr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        City
                    </td>
                    <td>
                        <asp:TextBox ID="city" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Department
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Joining Date
                    </td>
                    <td>
                        <asp:TextBox ID="jdate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Birth Date
                    </td>
                    <td>
                        <asp:TextBox ID="bdate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender
                    </td>
                    <td>
                        <asp:RadioButton ID="male" runat="server" GroupName="a" Text="Male" />
                        <asp:RadioButton ID="female" runat="server" GroupName="a" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Is Active?
                    </td>
                    <td>
                        <asp:CheckBox ID="yes" runat="server" Text="Yes" />
                        <asp:CheckBox ID="no" runat="server" Text="No" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </center>
    </form>
</body>
</html>
