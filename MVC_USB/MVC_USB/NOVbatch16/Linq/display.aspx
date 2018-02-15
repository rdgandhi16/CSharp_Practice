<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display.aspx.cs" Inherits="display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:GridView AutoGenerateColumns="false" ID="GridView1"   runat="server" 
                onrowcancelingedit="GridView1_RowCancelingEdit" 
                onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                onrowupdating="GridView1_RowUpdating">
                <Columns>
               
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="id1" runat="server" Text='<%#Eval("id") %>'>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="fn" runat="server" Text='<%#Eval("fname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="fn1" runat="server" Text='<%#Eval("fname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="ln" runat="server" Text='<%#Eval("lname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="ln1" runat="server" Text='<%#Eval("lname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowCancelButton="true" ShowDeleteButton="true" ShowEditButton="true" />
                </Columns>
            </asp:GridView>
        </center>
    </div>
    </form>
</body>
</html>
