
<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="manageCMS.aspx.cs" Inherits="Admin_Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <div style="background-color:#E4F8FF; height:575px; border-color:Teal; margin-top:50px">
     <form id="form1" runat="server">
 <div style="background-color:#65AAC0; margin-left:-1px; width: 683px;  margin-top:-54px;font-size: x-large;">
       <center class="style3"> <strong> Manage CMS </strong></center>  
           </div><br/>
        <span style="font-family: 'Times New Roman', Times, serif; font-size: medium">Select Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       </span> 
       <asp:DropDownList ID="drp1" runat="server" 
           onselectedindexchanged="drp1_SelectedIndexChanged" AutoPostBack="True">
             
       </asp:DropDownList>
      
        <br /><br />
      <asp:TextBox ID="txt1" runat="server" class="ckeditor" TextMode="MultiLine"></asp:TextBox><br/>
      <center>
          <asp:Button ID="but" Text="Save" CommandName="Save" runat="server" 
              onclick="but_Click" Width="69px" BackColor="#65AAC0" /></center>
  
    </form></div>
</asp:Content>

