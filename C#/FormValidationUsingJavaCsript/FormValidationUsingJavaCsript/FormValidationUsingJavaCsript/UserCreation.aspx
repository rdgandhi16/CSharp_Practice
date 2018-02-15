<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title></title>
    <script src="UserValidation.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
 
    <br /><br />
       <p style="font-size: large; color: #800000">Article by vithal wadje</p>
    <div>  
      <table>      
		  <tr>
            <td>Name</td>
           
            <td>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
            </td>           
          </tr>
          <tr>
            <td>Email Id</td>
           
            <td>
            <asp:TextBox ID="txtmail" runat="server" ></asp:TextBox>
            </td>
            
          </tr>
           <tr>
            <td>Gender</td>
           
            <td>
            <asp:DropDownList ID="ddlType" runat="server" >
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="2">Female</asp:ListItem>
                </asp:DropDownList>
            </td>
            
          </tr>
		  <tr>
            <td>Password</td>
           
            <td>
            <asp:TextBox ID="txtPass1" runat="server" TextMode="Password"  ></asp:TextBox>
                        
            </td>
            
          </tr>
		  <tr>
            <td >Confirm Password</td>
           
            <td>
             <asp:TextBox ID="txtPass2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            
          </tr>
          <tr>
          <td>
          </td>
          <td>
          	
          <asp:Button ID="btnSave" runat="server"  Text="Create" 
                 OnClientClick="return userValid();" onclick="btnSave_Click"/>
                 <asp:Button ID="Button1" runat="server" Text="Reset"/>
     
          </td>
          </tr>
         
        </table>
         
     </div>
      </form>
</body>
</html>
