<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_ID" runat="server" Text='<%#Eval ("ID") %>'>  </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="Label_new_ID" runat="server" Text='<%#Eval ("ID") %>'>  </asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_fn" runat="server" Text='<%#Eval ("First Name") %>'>  </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="Text_fn" runat="server" Text='<%#Eval ("First Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_gn" runat="server" Text='<%#Eval ("Gender") %>'>  </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval ("Gender") %>' />
                            <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_hb" runat="server" Text='<%#Eval ("Hobby") %>'>  </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval ("Hobby") %>' />
                             <asp:CheckBoxList RepeatDirection="Horizontal" ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Hockey</asp:ListItem>
                        </asp:CheckBoxList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_sb" runat="server" Text='<%#Eval ("Subject") %>'>  </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField3" runat="server" Value='<%#Eval ("Subject") %>' />
                            <asp:ListBox SelectionMode="Multiple" ID="ListBox1" runat="server">
                            <asp:ListItem>Math</asp:ListItem>
                            <asp:ListItem>SCi</asp:ListItem>
                            <asp:ListItem>Guj</asp:ListItem>
                        </asp:ListBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_state" runat="server" Text='<%#Eval ("State") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField4" runat="server" Value='<%#Eval ("State") %>' />
                            <asp:DropDownList ID="DropDown_state" AutoPostBack="true" runat="server">
                        </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label_city" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField5" runat="server" Value='<%#Eval ("City") %>' />
                             <asp:DropDownList ID="DropDown_city" runat="server">
                        </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="50px" Width="50px" ImageUrl='<%#Eval ("Image") %>'  />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                <asp:CommandField ShowCancelButton="true" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
