<%@ Page Title="" Language="C#" MasterPageFile="~/Publisher/publisher.master" AutoEventWireup="true" CodeFile="Changepassword.aspx.cs" Inherits="Publisher_Default2" Debug="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
  
<tr>
<td colspan="2"><div style="background-color:  #598891; font-size: x-large; width: 703px;">
   <center> <b style="text-align: center"><b>Change Password</b></center></div></td></tr>
      <tr><td style="font-size: medium; font-family: 'Times New Roman', Times, serif"><b>Old Password:</b></td><td><asp:TextBox ID="txtcpwd" runat="server"></asp:TextBox></td></tr>
   <tr><td style="height: 26px; font-size: medium; font-family: 'Times New Roman', Times, serif"><b>New Password:</b></td>
       <td style="height: 26px"><asp:TextBox ID="txtnpwd" runat="server"></asp:TextBox></td></tr>
   <tr><td style="height: 26px; font-size: medium; font-family: 'Times New Roman', Times, serif;"><b>Confirm Password:</b></td><td style="height: 26px"><asp:TextBox ID="txtconpwd" runat="server"></asp:TextBox></td></tr>
   <tr><td style="height: 26px" colspan="2"></td></tr>
   </table>
   <table>
   <tr><td><center><asp:Button ID="btnchpwd" Text="Change Password" runat="server" 
           onclick="btnchpwd_Click"/></center></td>&nbsp;&nbsp;
   <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="74px" /> &nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       </td>
   </tr>
   
</table>

</asp:Content>

