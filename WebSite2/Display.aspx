<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Display.aspx.cs" Inherits="Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" CellPadding="4" RowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
               <Columns>
                <asp:TemplateField HeaderText="Rollno">
                    <ItemTemplate>
                        <asp:Label ID="Label_rollno" runat="server" Text='<%#Eval ("Roll No") %>'></asp:Label>
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
                <asp:TemplateField HeaderText="Middle Name">
                    <ItemTemplate>
                        <asp:Label ID="Label_mn" runat="server" Text='<%#Eval ("Middle Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox_mn" runat="server" Text='<%#Eval ("Middle Name") %>'></asp:TextBox>
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
                <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label ID="Label_gn" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval ("Gender") %>'/>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Class">
                    <ItemTemplate>
                        <asp:Label ID="Label_class" runat="server" Text='<%#Eval ("Class") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="class" Value='<%#Eval ("Class") %>' runat="server" />
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="451px">
                    <asp:ListItem>I</asp:ListItem>
                    <asp:ListItem>II</asp:ListItem>
                    <asp:ListItem>III</asp:ListItem>
                    <asp:ListItem>IV</asp:ListItem>
                    <asp:ListItem>V</asp:ListItem>
                    <asp:ListItem>VI</asp:ListItem>
                    <asp:ListItem>VII</asp:ListItem>
                    <asp:ListItem>VIII</asp:ListItem>
                </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField>
                       <ItemTemplate>
                        <asp:Label ID="Label_hobby" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                    </ItemTemplate>
                       <EditItemTemplate>
                <asp:HiddenField ID="hobby" Value='<%#Eval ("Hobby") %>' runat="server"/>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Cricket</asp:ListItem>
                    <asp:ListItem>FootBall</asp:ListItem>
                    <asp:ListItem>Table Tennis</asp:ListItem>
                    <asp:ListItem>Swimming</asp:ListItem>
                    <asp:ListItem>Painting</asp:ListItem>
                    <asp:ListItem>Singing</asp:ListItem>
                </asp:CheckBoxList>
                       </EditItemTemplate>
                   </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="Label_city" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:HiddenField ID="city" Value='<%#Eval ("City") %>' runat="server" />
                    <asp:ListBox ID="ListBox1" runat="server">
                    <asp:ListItem>Chikhli</asp:ListItem>
                    <asp:ListItem>Bilimora</asp:ListItem>
                    <asp:ListItem>Pardi</asp:ListItem>
                    <asp:ListItem>Valsad</asp:ListItem>
                    <asp:ListItem>Navsari</asp:ListItem>
                </asp:ListBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" ShowCancelButton="true" ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>
