<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <table border="1">
                <tr>
                    <td>
                        Firstname
                    </td>
                    <td>
                        <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Gender:
                    </td>
                    <td>
                        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hobby:
                    </td>
                    <td>
                        <asp:CheckBoxList RepeatDirection="Horizontal" ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Cricket</asp:ListItem>
                            <asp:ListItem>Football</asp:ListItem>
                            <asp:ListItem>Hockey</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Subject
                    </td>
                    <td>
                        <asp:ListBox SelectionMode="Multiple" ID="ListBox1" runat="server">
                            <asp:ListItem>Math</asp:ListItem>
                            <asp:ListItem>SCi</asp:ListItem>
                            <asp:ListItem>Guj</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        State:
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Gujrat</asp:ListItem>
                            <asp:ListItem>MH</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                     <tr>
                    <td>
                        Image:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                <td></td>
                    <td>
                        <asp:Button ID="btn_submit" runat="server" Text="Submit" 
                            onclick="btn_submit_Click" />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
