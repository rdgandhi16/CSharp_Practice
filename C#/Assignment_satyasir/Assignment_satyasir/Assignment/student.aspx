<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Assignment_satyasir.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 95px; background-color:greenyellow;color:black" align="center"> 
            <br />
            <h5 style="font-family:Cambria; font-weight:bolder; font:italic;color:black" align="center">Assignment</h5>
        </div>
    <div margin:"1000px" style="height: 126px;color:transparent; border-color:black;background-color:aqua">        
        <br />
        <br />
    <h1 style="font-family:Cambria; font-weight:bolder; font:italic;color:black" align="center">
        Student Registration Form</h1>
        <h1 style="font-family:Cambria; font-weight:bolder; font:italic;color:black" align="center">
        &nbsp;<asp:Label ID="lblMessage" runat="server" ></asp:Label>
    </h1>
    </div>
        <div align="center" style="font-family:Cambria; color:black; background-color:darkorange">
            <br />
            <table border="1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" AssociatedControlID="Text_fname" Text="Label">First Name</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_fname" ViewStateMode="Disabled" runat="server" style="margin-left: 0px" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" AssociatedControlID="Text_lname" Text="Label">Last Name</asp:Label>                       
                    </td>
                    <td>
                        <asp:TextBox ID="Text_lname" ViewStateMode="Disabled" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" AssociatedControlID="RadioButtonList1" ViewStateMode="Disabled" runat="server" Text="">Gender</asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" AssociatedControlID="DropDownList1"  runat="server" Text="">Age</asp:Label>
                        Age
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" ViewStateMode="Disabled" runat="server" style="margin-left: 0px" Height="16px" Width="100px">
                            <asp:ListItem Value="0">Select Age</asp:ListItem>
                            <asp:ListItem Value="1">10</asp:ListItem>
                            <asp:ListItem Value="2">11</asp:ListItem>
                            <asp:ListItem Value="3">12</asp:ListItem>
                            <asp:ListItem Value="4">13</asp:ListItem>
                            <asp:ListItem Value="5">14</asp:ListItem>
                            <asp:ListItem Value="6">15</asp:ListItem>
                            <asp:ListItem Value="7">16</asp:ListItem>
                            <asp:ListItem Value="8">17</asp:ListItem>
                            <asp:ListItem Value="9">18</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" AssociatedControlID="Text_address" runat="server" Text="">Address</asp:Label>                        
                    </td>
                    <td>
                        <asp:TextBox ID="Text_address" ViewStateMode="Disabled" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" AssociatedControlID="DropDownList_state" Text="">State</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_state" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList_state_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" AssociatedControlID="DropDownList_city" Text="">City</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_city" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Image
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 0px" Width="300px" />
                    </td>
                </tr>                               
            </table>            
        </div>
        <div style="background-color:yellow; height: 55px;">
            <br />
            <table align="center">
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> </td>
                </tr>
            </table>
        </div>
        <div style="background-color:yellow; height: 208px;">
            <br />
            <br />
            <br />
            <table align="center">
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button2" runat="server" Text="HOME" OnClick="Button2_Click"/> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
