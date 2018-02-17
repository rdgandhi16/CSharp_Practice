<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Display_fnamelname.aspx.cs" Inherits="Display_fnamelname" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <center>
            <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%#Eval ("StudentId") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblEditId" runat="server" Text='<%#Eval ("StudentId") %>'></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">
                        <ItemTemplate>
                            <asp:Label ID="lblFname" runat="server" Text='<%#Eval ("Firstname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditFname" runat="server" Text='<%#Eval ("Firstname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Middle Name">
                        <ItemTemplate>
                            <asp:Label ID="lblMname" runat="server" Text='<%#Eval ("Middlename") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditMname" runat="server" Text='<%#Eval ("Middlename") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">
                        <ItemTemplate>
                            <asp:Label ID="lblLname" runat="server" Text='<%#Eval ("Lastname") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditLname" runat="server" Text='<%#Eval ("Lastname") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="lblGender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="hfGender" runat="server" Value='<%#Eval ("Gender") %>'></asp:HiddenField>
                            <asp:RadioButtonList ID="rdEditGender" runat="server" Width="264px">
                            <asp:ListItem>MALE</asp:ListItem>
                            <asp:ListItem>FEMALE</asp:ListItem>
                            <asp:ListItem>OTHER</asp:ListItem>
                        </asp:RadioButtonList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hobby">
                        <ItemTemplate>
                            <asp:Label ID="lblHobby" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="hfHobby" runat="server" Value='<%#Eval ("Hobby") %>'></asp:HiddenField>
                            <asp:CheckBoxList ID="chEditHobby" runat="server" Width="264px">
                            <asp:ListItem>CRICKET</asp:ListItem>
                            <asp:ListItem>FOOTBALL</asp:ListItem>
                            <asp:ListItem>SOCCER</asp:ListItem>
                            <asp:ListItem>BADMINTON</asp:ListItem>
                            <asp:ListItem>TABLE-TENNIS</asp:ListItem>
                        </asp:CheckBoxList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State">
                        <ItemTemplate>
                            <asp:Label ID="lblState" runat="server" Text='<%#Eval ("States") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="hfState" runat="server" Value='<%#Eval ("States") %>'></asp:HiddenField>
                            <asp:DropDownList ID="ddlEditState" runat="server" Width="264px">
                            <asp:ListItem>Georgia</asp:ListItem>
                            <asp:ListItem>Florida</asp:ListItem>
                            <asp:ListItem>California</asp:ListItem>
                            <asp:ListItem>Verginia</asp:ListItem>
                            <asp:ListItem>Illionoi</asp:ListItem>
                        </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowCancelButton="true" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </center>
        </div>
    </form>
</body>
</html>
