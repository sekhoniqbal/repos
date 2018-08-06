<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="editadv.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<div style="margin-top:0px; background-color: #E4F8FF;width:680px;height:580px">
<form id="fm" runat="server">

                        <div style="background-color: #65AAC0">
						<center style="font-size: x-large" class="style3"> <strong>Edit Advertisement</strong></center>
                        </div>
                     <table style="margin-left:60px; width: 357px;">   <tr><td colspan="2"></td></tr>

<tr><td style="width:138px; font-family: 'Times New Roman', Times, serif; font-size: medium;"> Category : </td><td> 
    <asp:Label ID="lbcat" runat="server" CssClass="style2"></asp:Label></td></tr>
    <tr><td style="font-family: 'Times New Roman', Times, serif; font-size: medium">Product Name :</td>
    <td><asp:Label ID="lbprd" runat="server" CssClass="style2"></asp:Label></td>
    </tr>
    <tr><td style="font-family: 'Times New Roman', Times, serif; font-size: medium"> Image :</td><td>
        <asp:Label ID="lbimg" runat="server" CssClass="style2"  ></asp:Label></td></tr>
    <tr><td style="font-family: 'Times New Roman', Times, serif; font-size: medium"> Location :</td><td><asp:RadioButtonList ID="rdloc" runat="server" 
            RepeatColumns="2" Width="87px">
        <asp:ListItem>Top</asp:ListItem>
        <asp:ListItem>Bottom</asp:ListItem>
        </asp:RadioButtonList></td></tr>
        <tr><td></td></tr>


        <tr><td colspan="2"> <center>
            <asp:Button ID="butupdate" runat="server" Text="Update" 
                Width="63px" onclick="butupdate_Click" />&nbsp;&nbsp;<asp:Button 
                ID="butcancel" runat="server" 
                Text="Cancel" Width="56px" onclick="butcancel_Click" /></center></td></tr>
            </table></form></div>
</asp:Content>

