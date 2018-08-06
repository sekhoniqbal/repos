<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="manageadv.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<div style="margin-top:0px; background-color: #E4F8FF;width:680px;height:580px">
    <form id="form1" runat="server">

    
					<div style="background-color: #65AAC0">
						<center style="font-size: x-large" class="style3"> <strong>Manage Advertisement</strong></center>
                        </div>
			
           
                     <table style="margin-left:60px; width: 357px;">   <tr><td colspan="2"></td></tr>
<tr><td colspan="2"> <center>
    <asp:Button ID="but" runat="server" 
        Text="Add New Advertisement" onclick="but_Click" BackColor="#65AAC0"  /></center></td></tr>
<tr><td colspan="2"></td></tr>
<tr><td style="height: 26px; font-family: 'Times New Roman', Times, serif; font-size: medium; width: 116px;" >Choose Category :</td><td style="height: 26px">
    <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
        DataTextField="strcategoryname" DataValueField="intcategoryid">   
    </asp:DropDownList>
    </td></tr>
    <tr><td colspan="2"></td></tr>
<tr><td colspan="2" style="height: 10px"><center>
    <asp:Button ID="btnsearch" 
        runat="server" Text="Search" onclick="btnsearch_Click" 
        style="height: 26px" BackColor="#65AAC0"/></center></td></tr>
<tr><td colspan="2"></td></tr>
<tr><td colspan="2" width="70px">  
    <asp:GridView ID="gd" runat="server" 
        AutoGenerateColumns="False" Width="580px" 
        onrowcancelingedit="gd_RowCancelingEdit" onrowdeleting="gd_RowDeleting" 
        onrowediting="gd_RowEditing" 
        onselectedindexchanged="gd_SelectedIndexChanged" >
    <Columns>
        <asp:TemplateField HeaderText="Category" ControlStyle-BackColor="#FF0066">
        <ItemTemplate>
        <%# Eval("strcategoryname") %>
        </ItemTemplate>

<ControlStyle BackColor="#FF0066"></ControlStyle>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ProductName">
        <ItemTemplate><%# Eval("strproductname") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
       
        <asp:TemplateField HeaderText=" Location">
        <ItemTemplate><%# Eval("strlocation") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Image">
        <ItemTemplate><%# Eval("strimage") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Actions">
        <ItemTemplate>
            <asp:LinkButton ID="lnk1" runat="server" Text="edit" CommandName="edit" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
           <asp:LinkButton ID="lnk2" runat="server" Text="delete" CommandName="delete" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
    </asp:GridView></td></tr>
</table>
    </form></div>
</asp:Content>

