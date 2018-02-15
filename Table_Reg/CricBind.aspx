<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CricBind.aspx.cs" Inherits="CricBind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center" border="1" style="font-family: Andalus">Registration Table </h1>
            <br />
            <br />

            <asp:GridView ID="GridView1" Align="Center" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="Label_srno" runat="server" Text='<%#Eval ("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_fname" runat="server" Text='<%#Eval("First Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_lname" runat="server" Text='<%#Eval ("Last Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="Label_Gender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="Label_city" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State">
                        <ItemTemplate>
                            <asp:Label ID="Label_state" runat="server" Text='<%#Eval ("State") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hobby">
                        <ItemTemplate>
                            <asp:Label ID="Label_hobby" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="Image1" Height="50px" Width="50px" ImageUrl='<%#Eval ("Image") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
