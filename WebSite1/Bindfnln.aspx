<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bindfnln.aspx.cs" Inherits="Bindfnln" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="Roll No">
                    <ItemTemplate>
                       <asp:Label ID="Label_Id" runat="server" Text='<%#Eval ("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="First Name">
                       <ItemTemplate>
                       <asp:Label ID="Label_fn" runat="server" Text='<%#Eval ("First Name") %>'></asp:Label>
                       </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox_fn" runat="server" Text='<%#Eval ("First Name") %>'></asp:TextBox>
                    </EditItemTemplate>                 
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Last Name">
                    <ItemTemplate>
                       <asp:Label ID="Label_ln" runat="server" Text='<%#Eval ("Last Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox_ln" runat="server" Text='<%#Eval ("Last Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="true" ShowEditButton="true" ShowCancelButton="true" />
            </Columns>
        </asp:GridView>
    </center>
    </div>
    </form>
</body>
</html>
