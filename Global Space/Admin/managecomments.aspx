<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="managecomments.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <div style="background-color:#E4F8FF; height:550px; border-color:Teal; margin-top:-2px">
    <form id="form1" runat="server">

<table width="683px">
<tr>
				<td colspan="2" bgcolor="#cccccc" style="height: 18px; font-size: x-large; font-family: 'Times New Roman',Times,serif; text-align: center; color: rgb(0, 0, 0);">
					<div style="background-color: #65AAC0;">
						<center><strong> Manage Comments </strong></center></div>
				</td>
			</tr>
            </table>
            <table style="margin-left:45px;margin-top:12px" cellspacing="10px">
<tr><td style="height: 26px; font-family: 'Times New Roman', Times, serif; font-size: medium; width: 116px;" >&nbsp;&nbsp; UserName :</td><td style="height: 26px">
    <asp:DropDownList ID="DropDownList1" runat="server" 
       
        DataTextField="strusername" DataValueField="strusername">   
    </asp:DropDownList>
    </td></tr>
<tr><td colspan="2" style="height: 10px"><center>
    <asp:Button ID="btnsearch" 
        runat="server" Text="Search" onclick="btnsearch_Click" 
        BackColor="#65AAC0" /></center></td></tr>
<tr><td colspan="2"></td></tr>
<tr><td colspan="2" width="70px">  
    <asp:GridView ID="gd" runat="server" 
        AutoGenerateColumns="False" Width="580px" 
         onrowdeleting="gd_RowDeleting" 
        DataKeyNames="strusername" 
        onselectedindexchanged="gd_SelectedIndexChanged" >
    <Columns>
        <asp:TemplateField HeaderText="User Name" ControlStyle-BackColor="#FF0066">
        <ItemTemplate>
        <%# Eval("strusername") %>
        </ItemTemplate>

<ControlStyle BackColor="#FF0066"></ControlStyle>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Product Name">
        <ItemTemplate><%# Eval("strprodname") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
       
        <asp:TemplateField HeaderText="Comments">
        <ItemTemplate><%# Eval("strcommentdesc") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>

          <asp:TemplateField HeaderText="Posted Date">
        <ItemTemplate><%# Eval("posteddate") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>


        <asp:TemplateField HeaderText="Actions">
        <ItemTemplate>
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

