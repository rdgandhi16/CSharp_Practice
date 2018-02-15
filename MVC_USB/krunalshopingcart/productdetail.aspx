<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="productdetail.aspx.cs" Inherits="productdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DetailsView1" AutoGenerateRows="false" runat="server" Height="50px" Width="125px">
        <Fields>
             <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="pid" runat="server" Text='<%#Eval("pid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Product Name">
                <ItemTemplate>
                    <asp:Label ID="pname" runat="server" Text='<%#Eval("pname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <asp:Label ID="pprice" runat="server" Text='<%#Eval("pprice") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Product Details">
                <ItemTemplate>
                    <asp:Label ID="pdetail" runat="server" Text='<%#Eval("pdetail") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Category">
                <ItemTemplate>
                    <asp:Label ID="pcat" runat="server" Text='<%#Eval("pcategory") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("pimg") %>' Height="150px" Width="150px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Fields>
    </asp:DetailsView>
    <asp:Button ID="Button1" runat="server" Text="Add to Cart" />
</asp:Content>

