<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="showproduct.aspx.cs" Inherits="showproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" >
        <ItemTemplate>
            <table>
                <tr>
                    <td>
                        <a href='<%# Eval("pid", "productdetail.aspx?id={0}" ) %>'>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("pimg") %>' Height="150px" Width="150px" />
                        </a>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("pname") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("pprice") %>'></asp:Label>
                    </td>
                </tr>
               
            </table>
            
        </ItemTemplate>
       
    </asp:DataList>
</asp:Content>

