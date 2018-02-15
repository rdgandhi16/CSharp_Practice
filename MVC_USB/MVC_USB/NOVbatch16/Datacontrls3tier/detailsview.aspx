<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detailsview.aspx.cs" Inherits="detailsview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView align="center" AllowPaging="true" AutoGenerateRows="false" ID="DetailsView1"
            runat="server" Height="50px" Width="125px" OnPageIndexChanging="DetailsView1_PageIndexChanging"
            OnItemDeleting="DetailsView1_ItemDeleting" OnItemUpdating="DetailsView1_ItemUpdating"
            OnModeChanging="DetailsView1_ModeChanging" 
            oniteminserting="DetailsView1_ItemInserting">
            <Fields>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lbl_id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lbl_edit_id" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                   ID     <asp:TextBox runat="server" ID="txt_insert_id" />
                    </InsertItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lbl_fname" runat="server" Text='<%#Eval("fname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                      <asp:TextBox runat="server" ID="txt_fname" Text='<%#Eval("fname") %>' />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                     Fname     <asp:TextBox runat="server" ID="txt_insert_fn" />
                    </InsertItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lbl_lname" runat="server" Text='<%#Eval("lname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="txt_lname" Text='<%#Eval("lname") %>' />
                    </EditItemTemplate>
                     <InsertItemTemplate>
                     Lname   <asp:TextBox runat="server" ID="txt_insert_ln" />
                    </InsertItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowInsertButton="true" ShowCancelButton="true" ShowDeleteButton="true"
                    ShowEditButton="true" />
            </Fields>
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
