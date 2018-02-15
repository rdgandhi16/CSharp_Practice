<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bindview.aspx.cs" Inherits="Bindview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Roll NO">
                        <ItemTemplate>
                            <asp:Label ID="Label_id" runat="server" Text='<%#Eval ("Roll No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_fname" runat="server" Text='<%#Eval ("First Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="Text_fn" runat="server" Text='<%#Eval ("First Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_lname" runat="server" Text='<%#Eval ("Last Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="Text_ln" runat="server" Text='<%#Eval ("Last Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="Label_gender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval ("Gender") %>' />
                            <asp:RadioButtonList ID="RadioButtonList_gender" runat="server">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Other</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country">
                        <ItemTemplate>
                            <asp:Label ID="Label_Country" runat="server" Text='<%#Eval ("Country") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval ("Country") %>' />
                            <asp:DropDownList ID="DropDownList_country" runat="server" Height="17px" Width="146px">
                                <asp:ListItem>India</asp:ListItem>
                                <asp:ListItem>Nepal</asp:ListItem>
                                <asp:ListItem>Barma</asp:ListItem>
                                <asp:ListItem>Foreigner</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="Label_Ct" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField3" Value='<%#Eval ("City") %>' runat="server" />
                            <asp:ListBox ID="ListBox1" runat="server" Width="151px">
                                <asp:ListItem>Mumbai</asp:ListItem>
                                <asp:ListItem>Ahemdabad</asp:ListItem>
                                <asp:ListItem>Amruitsir</asp:ListItem>
                                <asp:ListItem>Bilimora</asp:ListItem>
                                <asp:ListItem>Chikhli</asp:ListItem>
                                <asp:ListItem>Pardi</asp:ListItem>
                            </asp:ListBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hobby">
                        <ItemTemplate>
                            <asp:Label ID="Label_hb" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField4" Value='<%#Eval ("Hobby") %>' runat="server" />
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>FootBall</asp:ListItem>
                            <asp:ListItem>TableTennis</asp:ListItem>
                            <asp:ListItem>Swimming</asp:ListItem>
                            <asp:ListItem>Reading</asp:ListItem>
                        </asp:CheckBoxList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowCancelButton="true" ShowDeleteButton="true" ShowEditButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
