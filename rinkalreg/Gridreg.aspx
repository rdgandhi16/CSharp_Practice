<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gridreg.aspx.cs" Inherits="Gridreg" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Roll No">
                        <ItemTemplate>
                            <asp:Label ID="Label_rollno" runat="server" Text='<%#Eval ("Roll No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_fname" runat="server" Text='<%#Eval ("First Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="Text_fname" runat="server" Height="19px" Width="205px"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">
                        <ItemTemplate>
                            <asp:Label ID="Label_lname" runat="server" Text='<%#Eval ("Last Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="Text_lname" runat="server" Height="20px" Width="205px"></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date Time">
                        <ItemTemplate>
                            <asp:Label ID="Label_DateandTime" runat="server" Text='<%#Eval ("Date & Time") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField6" Value='<%#Eval ("Date & Time") %>' runat="server" />
                            <asp:TextBox ID="TextBox1" TextMode="DateTime" runat="server" Height="22px" Width="128px"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" Text="Calendar" />
                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="MM/dd/yyyy" PopupButtonID="Button1" PopupPosition="BottomRight" TargetControlID="TextBox1"></asp:CalendarExtender>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="Label_Gender" runat="server" Text='<%#Eval ("Gender") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField1" Value='<%#Eval ("Gender") %>' runat="server" />
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="90px">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hobby">
                        <ItemTemplate>
                            <asp:Label ID="Label_Hobby" runat="server" Text='<%#Eval ("Hobby") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField2" Value='<%#Eval ("Hobby") %>' runat="server" />
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                <asp:ListItem>Cricket</asp:ListItem>
                                <asp:ListItem>Hockey</asp:ListItem>
                                <asp:ListItem>FootBall</asp:ListItem>
                                <asp:ListItem>TableTenis</asp:ListItem>
                            </asp:CheckBoxList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State">
                        <ItemTemplate>
                            <asp:Label ID="Label_State" runat="server" Text='<%#Eval ("State") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField3" Value='<%#Eval ("State") %>' runat="server" />
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="210px">
                                <asp:ListItem>GJ</asp:ListItem>
                                <asp:ListItem>MH</asp:ListItem>
                                <asp:ListItem>PN</asp:ListItem>
                                <asp:ListItem>DN</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="Label_City" runat="server" Text='<%#Eval ("City") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField4" Value='<%#Eval ("City") %>' runat="server" />
                            <asp:DropDownList ID="DropDownList2" runat="server" Height="17px" Width="210px">
                                <asp:ListItem>Surat</asp:ListItem>
                                <asp:ListItem>Chikhli</asp:ListItem>
                                <asp:ListItem>Amrutsir</asp:ListItem>
                                <asp:ListItem>Mumbai</asp:ListItem>
                                <asp:ListItem>Patalia</asp:ListItem>
                                <asp:ListItem>Nagpur</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="Image1" Height="50px" Width="50px" ImageUrl='<%#Eval ("Image") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:HiddenField ID="HiddenField5" Value='<%#Eval ("Image") %>' runat="server" />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowCancelButton="true" ShowDeleteButton="true" ShowEditButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
