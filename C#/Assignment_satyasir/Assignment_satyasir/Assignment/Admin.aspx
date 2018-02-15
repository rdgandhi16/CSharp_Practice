<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Assignment_satyasir.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 95px; background-color:greenyellow;color:black" align="center"> 
            <br />
            <h5 style="font-family:Cambria; font-weight:bolder; font:italic;color:black" align="center">Admin Assignment</h5>
        </div>
    <div margin:"1000px" style="height: 126px;color:transparent; border-color:black;background-color:aqua">        
        <br />
        <br />
    <h1 style="font-family:Cambria; font-weight:bolder; font:italic;color:black" align="center">
        Student Registration Detail
    </h1>
    </div>
        <div align="center" style="font-family:Cambria; color:black; background-color:darkorange">
            <br />

            <center>
                <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sr.No">
                            <ItemTemplate>
                                <asp:Label ID="Label_id" runat="server" Text='<%#Eval ("Std_Id") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:Label ID="Label_edit_id" runat="server" Text='<%#Eval ("Std_Id") %>'></asp:Label>
                            </EditItemTemplate>                           
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="First Name">
                            <ItemTemplate>
                                <asp:Label ID="Label_fname" runat="server" Text='<%#Eval ("First Name")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox_fname" runat="server" Text='<%#Eval ("First Name")  %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Last Name">
                            <ItemTemplate>
                                <asp:Label id="label_lname" runat="server" Text='<%#Eval ("Last Name ") %>'> </asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox_lname" runat="server" Text='<%#Eval ("Last Name")  %>'></asp:TextBox>
                            </EditItemTemplate>                            
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Gender">
                            <ItemTemplate>
                                <asp:Label ID="Label_gender" runat="server" Text='<%#Eval ("Gender")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:HiddenField ID="HiddenField1" Value='<%#Eval ("Gender")  %>' runat="server"></asp:HiddenField>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Other</asp:ListItem>
                                </asp:RadioButtonList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Age">
                            <ItemTemplate>
                                <asp:Label ID="Label_age" runat="server" Text='<%#Eval ("Age")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField2" Value='<%#Eval ("Age")  %>' runat="server"></asp:HiddenField>
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
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Address">
                            <ItemTemplate>
                                <asp:Label ID="Label_add" runat="server" Text='<%#Eval ("Address")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="Text_address" ViewStateMode="Disabled" runat="server" Width="300px"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="State">
                            <ItemTemplate>
                                <asp:Label ID="Label_state" runat="server" Text='<%#Eval ("State")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:HiddenField ID="HiddenField3" Value='<%#Eval ("State")  %>' runat="server"></asp:HiddenField>
                                <asp:DropDownList ID="DropDownList_state" AutoPostBack="true" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="City">
                            <ItemTemplate>
                                <asp:Label ID="Label_city" runat="server" Text='<%#Eval ("City")  %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:HiddenField ID="HiddenField4" Value='<%#Eval ("City")  %>' runat="server"></asp:HiddenField>
                               <asp:DropDownList ID="DropDownList_city" runat="server"></asp:DropDownList>
                            </EditItemTemplate>                            
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Image">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" Height="50px" Width="50px" ImageUrl='<%# "~/im/"+ Eval("Pic")  %>'></asp:Image>
                            </ItemTemplate>
                            <EditItemTemplate>
                               <%--<asp:HiddenField ID="HiddenField5" runat="server" Value='<%#Eval ("Pic")  %>'></asp:HiddenField>--%>
                                <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 0px" Width="300px" />
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" ShowCancelButton="true" />                      
                    </Columns>                    
                </asp:GridView>
            </center>            
        </div>
        <div style="background-color:yellow; height: 427px;">
            <br />
            <table align="center">
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Click for Home Page" OnClick="Button1_Click"/> </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
