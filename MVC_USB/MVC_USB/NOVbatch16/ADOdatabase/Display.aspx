<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView align="center" AllowPaging="true" AutoGenerateColumns="false" ID="GridView1"
            runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging"
            PageSize="3" OnRowEditing="GridView1_RowEditing" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowupdating="GridView1_RowUpdating" 
            onrowdeleting="GridView1_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lbl_id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lbl_edit_id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Firstname">
                    <ItemTemplate>
                        <asp:Label ID="lbl_fnmae" runat="server" Text='<%#Eval("fname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_fnamenew" runat="server" Text='<%#Eval("fname") %>' ></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Lastname">
                    <ItemTemplate>
                        <asp:Label ID="lbl_lname" runat="server" Text='<%#Eval("lname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_lnamenew" runat="server" Text='<%#Eval("lname") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" ShowCancelButton="true" />
            </Columns>
          
        </asp:GridView>
    </div>
    </form>
</body>
</html>
