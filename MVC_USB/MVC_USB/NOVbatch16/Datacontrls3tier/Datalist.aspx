<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Datalist.aspx.cs" Inherits="Datalist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
            <asp:DataList ID="DataList1"  RepeatDirection="Horizontal" runat="server" 
                oncancelcommand="DataList1_CancelCommand" 
                ondeletecommand="DataList1_DeleteCommand" 
                oneditcommand="DataList1_EditCommand" 
                onupdatecommand="DataList1_UpdateCommand">
                <ItemTemplate>
                    <table border="1" cellpadding="10">
                        <tr>
                            <td>
                                Id:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("id") %>' ID="lbl_id" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Fname:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("fname") %>' ID="lbl_fname" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Lname:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("lname") %>' ID="lbl_lname" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit">Edit</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="delete">Delete</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <EditItemTemplate>
                      <table border="1" cellpadding="10">
                        <tr>
                            <td>
                                Id:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("id") %>' ID="lbl_edit_id" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Fname:
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("fname") %>'></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Lname:
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%#Eval("lname") %>'></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="LinkButton3" runat="server" CommandName="update">Update</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="cancel">Cancel</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </EditItemTemplate>
                
            </asp:DataList>
        
    </div>
    </form>
</body>
</html>
