<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<div style="margin-top:0px; background-color: #E4F8FF;width:680px;height:580px">
<form id="form1" runat="server">
<div style="background-color:#65AAC0; font-size: x-large; width: 675px">
   <center class="style3" style="font-family: t"> <b style="text-align: center">Change Password</b></center></div>
   <br />
   <center><table>
   <tr><td style="font-size: medium; font-family: 'Times New Roman', Times, serif; width:158px; height: 26px;">Old Password</td>
   <td style="height: 26px"><asp:TextBox ID="txtcpwd" runat="server"></asp:TextBox></td>
       <td style="width:182; height: 26px;"></td></tr>
   <tr><td style="height: 26px; font-size: medium; font-family: 'Times New Roman', Times, serif; width: 158px;">New Password</td>
       <td style="height: 26px"><asp:TextBox ID="txtnpwd" runat="server"></asp:TextBox></td>
       <td style="height: 26px"></td></tr>
   <tr><td style="height: 26px; font-size: medium; font-family: 'Times New Roman', Times, serif; width: 158px;">Confirm Password</td>
        <td style="height: 26px"><asp:TextBox ID="txtconpwd" runat="server"></asp:TextBox></td>
        <td><asp:CompareValidator ID="compare" runat="server" ControlToValidate="txtconpwd" 
           ControlToCompare="txtnpwd" ForeColor="red" 
           Font-Names="Times New Roman" Font-Size="Medium">* Password should be same</asp:CompareValidator>
        </td>
   </tr>
   <tr><td colspan="2" align="right" style="height: 26px; font-family:Times New Roman;color:Red; font-size:medium">
   <asp:Literal ID="literal1" runat="server" ></asp:Literal></td>    
   <td></td>
   </tr>
   </table></center>
   <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="btnchpwd" Text="Change Password" runat="server" BackColor="#65AAC0" 
           onclick="btnchpwd_Click"/>&nbsp;&nbsp;
           <asp:Button ID="btncancel" runat="server" Text="Cancel" Width="74px" BackColor="#65AAC0" /> 
   </div>
</form>
</div>
</asp:Content>

