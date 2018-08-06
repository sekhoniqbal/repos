<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="addnewad.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
 <div style="margin-top:0px; background-color: #E4F8FF;width:680px;height:580px">
    <form id="form1" runat="server">
<div style="background-color: #65AAC0">
						<center style="font-size: x-large" class="style3"> <strong>Add New Advertisement</strong></center>
                        </div>
                     <table style="margin-left:60px; width: 357px;">   <tr><td colspan="2"></td></tr>
                        <tr><td></td></tr>

<tr><td> Category : </td><td> <asp:DropDownList ID="drp" runat="server"  
        onselectedindexchanged="drp_SelectedIndexChanged"  
        DataTextField="strcategoryname" DataValueField="intcategoryid" 
        AutoPostBack="True" >
    </asp:DropDownList></td></tr>
    <tr><td>Product Name :</td>
    <td><asp:DropDownList ID="drp2" runat="server" DataTextField="strprodname" 
            DataValueField="intprodid" AutoPostBack="True" 
            onselectedindexchanged="drp2_SelectedIndexChanged">
        
        </asp:DropDownList></td>
    </tr>
    <tr><td> Image :</td><td><asp:Image ID="img" runat="server"  /></td></tr>
    <tr><td> Location :</td><td>
        <asp:RadioButtonList ID="rdloc" runat="server" 
            RepeatColumns="2" Width="178px">
        <asp:ListItem>Top</asp:ListItem>
        <asp:ListItem>Bottom</asp:ListItem>
        </asp:RadioButtonList></td></tr>
        <tr><td></td></tr>


        <tr><td colspan="2"> <center>
            <asp:Button ID="butsave" runat="server" Text="Save" 
                Width="53px" onclick="butsave_Click" />&nbsp;&nbsp;<asp:Button 
                ID="butcancel" runat="server" 
                Text="Cancel" Width="54px" onclick="butcancel_Click" /></center></td></tr>
            </table></form></div>
</asp:Content>

