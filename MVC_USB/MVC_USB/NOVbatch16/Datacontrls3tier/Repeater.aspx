<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Repeater.aspx.cs" Inherits="Repeater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:Repeater   ID="Repeater1" runat="server">
                <ItemTemplate>
                    <table>
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
                                Firstname:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("fname") %>' ID="lbl_fn" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                LastName:
                            </td>
                            <td>
                                <asp:Label Text='<%#Eval("lname") %>' ID="lbl_ln" runat="server" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
        </center>
    </div>
    </form>
</body>
</html>
