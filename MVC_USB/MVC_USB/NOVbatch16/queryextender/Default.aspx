<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        From:<asp:TextBox ID="from" runat="server"></asp:TextBox>
        To:<asp:TextBox ID="tofrom" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="fname" HeaderText="fname" ReadOnly="True" SortExpression="fname" />
                <asp:BoundField DataField="lname" HeaderText="lname" ReadOnly="True" SortExpression="lname" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext"
            EntityTypeName="" Select="new (id, fname, lname)" TableName="tbl_regs">
        </asp:LinqDataSource>
        <asp:QueryExtender ID="QueryExtender1" TargetControlID="LinqDataSource1" runat="server">
            <asp:OrderByExpression DataField="fname" Direction="Descending">
            </asp:OrderByExpression>
            <asp:RangeExpression DataField="id" MaxType="Exclusive" MinType="Inclusive">
                <asp:ControlParameter ControlID="from" />
                <asp:ControlParameter ControlID="tofrom" />
            </asp:RangeExpression>
        </asp:QueryExtender>
    </div>
    </form>
</body>
</html>
