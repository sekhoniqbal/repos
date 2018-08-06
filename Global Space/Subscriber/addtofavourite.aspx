<%@ Page Title="" Language="C#" MasterPageFile="~/Subscriber/Subscriber.master" AutoEventWireup="true" CodeFile="addtofavourite.aspx.cs" Inherits="Subscriber_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="background-color:#55BECC; height:550px; border-color:Teal;margin-top:80px">
    <form id="form1" runat="server">

<table width="683px">
<tr>
				<td colspan="2" bgcolor="#cccccc" style="height: 18px; font-size: xx-large; font-family: 'Times New Roman',Times,serif; text-align: center; color: rgb(0, 0, 0);">
					<div style="background-color: #26656E">
						<center style="color: rgb(255, 255, 255)">My Favourite Products</center></div>
				</td>
			</tr>
            </table>
            <table style="margin-left:45px" cellspacing="10px">
           

<tr><td colspan="2"></td></tr>
<tr><td colspan="2" width="70px">  
    <asp:GridView ID="gd" runat="server" 
        AutoGenerateColumns="False" Width="580px" 
         onrowdeleting="gd_RowDeleting" 
        onselectedindexchanged="gd_SelectedIndexChanged" 
        DataKeyNames="strprodname">
    <Columns>
        <asp:TemplateField HeaderText="Product Name" ControlStyle-BackColor="white">
        <ItemTemplate>
        <%# Eval("strprodname") %>
        </ItemTemplate>

<ControlStyle BackColor="white"></ControlStyle>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Image">
        <ItemTemplate><%# Eval("strprodimg") %></ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
       
        <asp:TemplateField HeaderText="Description">
        <ItemTemplate><%# Eval("strproddesc") %></ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Catalog">
        <ItemTemplate><%# Eval("strcatalogname") %></ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>

          <asp:TemplateField HeaderText="Category">
        <ItemTemplate><%# Eval("strcategoryname") %></ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>

          <asp:TemplateField HeaderText="Price">
        <ItemTemplate><%# Eval("intprodprice") %></ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Actions">
        <ItemTemplate>
          
           <asp:LinkButton ID="lnk2" runat="server" Text="delete" CommandName="delete" ForeColor="Blue" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" ForeColor="White" />
            <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
    </asp:GridView></td></tr>
</table>
    </form></div>
</asp:Content>

