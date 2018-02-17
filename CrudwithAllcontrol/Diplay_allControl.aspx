<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Diplay_allControl.aspx.cs" Inherits="Diplay_allControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <br />
        <br />
        <h1 style="font:bolder"> List of All Register Student </h1>
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" BorderStyle="None" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:TemplateField HeaderText="Student ID">
                    <ItemTemplate>
                        <asp:Label ID="lblSid" runat="server" Text='<%# Eval ("Studentid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Firstname">
                    <ItemTemplate>
                        <asp:Label ID="lblFname" runat="server" Text='<%#Eval ("Firstname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Lastname">
                    <ItemTemplate>
                        <asp:Label ID="lnlLname" runat="server" Text='<%#Eval ("Lastname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stream">
                    <ItemTemplate>
                        <asp:Label ID="lblStream" runat="server" Text='<%#Eval ("Stream") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hobby">
                    <ItemTemplate>
                        <asp:Label ID="lblHobby" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label ID="lblState" runat="server" Text='<%#Eval ("State") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowCancelButton="true" ShowDeleteButton="true" ShowEditButton="true" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </center>
    </div>
    </form>
</body>
</html>
