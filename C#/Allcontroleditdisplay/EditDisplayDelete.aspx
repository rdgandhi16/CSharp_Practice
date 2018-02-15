<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditDisplayDelete.aspx.cs" Inherits="EditDisplayDelete" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="font-family:Cambria;font-size:large">
        <br />
        <br />
        <h1> Employee Details</h1>
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("empid")  %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lbleditId" runat="server" Text='<%#Eval("empid")  %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblFname" runat="server" Text='<%#Eval ("firstname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblLname" runat="server" Text='<%#Eval ("lastname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%#Eval("gender") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="hdnGender" Value='<%#Eval("gender") %>' runat="server" />
                       <asp:RadioButtonList RepeatDirection="Horizontal" ID="radioGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </EditItemTemplate>
                </asp:TemplateField>               
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblDepartment" runat="server" Text='<%#Eval("department") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="hdnDept" Value='<%#Eval("department") %>' runat="server" />
                         <asp:DropDownList ID="ddlDept" runat="server" Width="157px" Height="17px">
                            <asp:ListItem>---Select Department---</asp:ListItem>
                            <asp:ListItem>IT</asp:ListItem>
                            <asp:ListItem>HR</asp:ListItem>
                            <asp:ListItem>Retail</asp:ListItem>
                            <asp:ListItem>Maintanance</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblSkills" runat="server" Text='<%#Eval ("skills") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="hdnSkill" Value='<%#Eval("skills") %>' runat="server" />
                        <asp:CheckBoxList ID="chkSkill" runat="server" Width="240px">
                            <asp:ListItem>Developer</asp:ListItem>
                            <asp:ListItem>PayRoll</asp:ListItem>
                            <asp:ListItem>Finance</asp:ListItem>
                            <asp:ListItem>Management</asp:ListItem>
                        </asp:CheckBoxList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" ShowCancelButton="true" ShowDeleteButton="true" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
