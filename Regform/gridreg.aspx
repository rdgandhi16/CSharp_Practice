<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gridreg.aspx.cs" Inherits="gridreg" %>

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
            <center>
            <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_ID" runat="server" Text='<%#Eval ("ID")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="FirstName">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_fn" runat="server" Text='<%#Eval ("Firstname")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="LastName">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_ln" runat="server" Text='<%#Eval ("Lastname")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_gn" runat="server" Text='<%#Eval ("Gender")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_Em" runat="server" Text='<%#Eval ("Email")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Password">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_pwd" runat="server" Text='<%#Eval ("Password")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Confirm Password">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_cpw" runat="server" Text='<%#Eval ("Confirm Password")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Class">
                        <ItemTemplate>
                            <asp:Label ID="lbl_cpw" runat="server" Text='<%#Eval ("Class")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Stream">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_strm" runat="server" Text='<%#Eval ("Stream")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Hobby">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_hb" runat="server" Text='<%#Eval ("Hobby")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                       <asp:TemplateField HeaderText="State">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_state" runat="server" Text='<%#Eval ("State")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="Lbl_ct" runat="server" Text='<%#Eval ("City")  %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                                       <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="Image1" ImageUrl='<%#Eval ("Image") %>' Height="50px" Width="50px" runat="server"></asp:Image>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" ShowCancelButton="true" />
                </Columns>
            </asp:GridView>
        </center>
        </div>
    </form>
</body>
</html>
