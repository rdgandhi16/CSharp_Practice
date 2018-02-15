<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display.aspx.cs" Inherits="display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>        <asp:GridView AutoGenerateColumns="false" ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing"
            OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelid" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="Labeledid" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelfn" runat="server" Text='<%#Eval("fname") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxfn" runat="server" Text='<%#Eval("fname") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelgn" runat="server" Text='<%#Eval("gender") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="HiddenField1" Value='<%#Eval("gender") %>' runat="server" />
                        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelhb" runat="server" Text='<%#Eval("hobby") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="HiddenField2" Value='<%#Eval("hobby") %>' runat="server" />
                        <asp:CheckBoxList RepeatDirection="Horizontal" ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Hockey</asp:ListItem>
                        </asp:CheckBoxList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelsb" runat="server" Text='<%#Eval("subject") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="HiddenField3" Value='<%#Eval("subject") %>' runat="server" />
                        <asp:ListBox SelectionMode="Multiple" ID="ListBox1" runat="server">
                            <asp:ListItem>Math</asp:ListItem>
                            <asp:ListItem>SCi</asp:ListItem>
                            <asp:ListItem>Guj</asp:ListItem>
                        </asp:ListBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Labelst" runat="server" Text='<%#Eval("state") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="HiddenField4" Value='<%#Eval("state") %>' runat="server" />
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Gujrat</asp:ListItem>
                            <asp:ListItem>MH</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="Image1" Height="50px" Width="50px" ImageUrl='<%#Eval("image") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
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
