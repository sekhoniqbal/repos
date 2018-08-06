<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="forgotpassword.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
<asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
<div style="width:802px; margin-left:197px;margin-top:7px; background-color: #DCD2D2">
<table style="width: 692px">
<tr>
<td colspan="2"><div style="background-color:  #598891; font-size: x-large; width: 703px;">
   <center> <b style="text-align: center">Forgot Password</b></center></div></td></tr>
   <tr><td colspan=2></td></tr>
   <tr><td colspan="2" style="font-size: medium; font-family: 'Times New Roman', Times, serif"> 
   <h4>If You forgot your password then enter your username(email id) that you use for Global Space Account</h4></td></tr>
   <tr><center><td  colspan="2" style="font-size: medium; font-family: 'Times New Roman', Times, serif"><center>Enetr your Email Id:&nbsp;&nbsp;&nbsp;&nbsp;
   
       <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
      </center> </td></tr>
   <tr><td colspan="2"></td></tr>
   <tr><td ><center><asp:Button ID="btnsubmit" runat="server" Text="Submit" 
           onclick="btnsubmit_Click" /></center></td>
           <td><asp:Literal ID="literal1" runat="server"></asp:Literal></td></tr>
</table>
</div>
    </form>
</asp:Content>

