<%@ Page Title="" Language="C#" MasterPageFile="~/Publisher/publisher.master" AutoEventWireup="true" CodeFile="Uploadproducts.aspx.cs" Inherits="Publisher_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
   <tr style="width:655px;">
      <td colspan="4" bgcolor="#cccccc" style="height: 18px; font-size: xx-large; font-family: 'Times New Roman',Times,serif; text-align: center; color: rgb(0, 0, 0);">
					<div style="background-color: #26656E">
						<center style="color: rgb(255, 255, 255)">Upload Products</center></div>
				</td>
			</tr>
   
   <tr style="width:655px;">
       <td colspan="4">
           <asp:Literal ID="Literal1" runat="server"></asp:Literal>
       </td></tr>
   
   
   <tr style="width:655px;">
       <td style="height: 27px; width: 200px; font-size:medium"><center>Select Category</center></td>
   
   
       <td style="height: 27px; width: 194px;">
           <asp:DropDownList ID="drpcategory" runat="server" Height="16px" Width="156px" 
               DataSourceID="SqlDataSource1" DataTextField="strcategoryname" 
               DataValueField="intcategoryid">
           </asp:DropDownList>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
               ConnectionString="Data Source=TTC-PC\SQLEXPRESS;Initial Catalog=db_onlinecatalogspace;Integrated Security=True" 
               ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [tbcategory]">
           </asp:SqlDataSource>
       </td>
   
   
       <td style="height: 27px; width: 184px; font-size:medium"><center>Select Catalog</center></td>
   
   
       <td style="height: 27px; width: 265px;">
           <asp:DropDownList ID="drpcatalog" runat="server" Height="16px" Width="156px" 
               DataSourceID="SqlDataSource2" DataTextField="strcatalogname" 
               DataValueField="intcatalogid">
           </asp:DropDownList>       
           <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
               ConnectionString="Data Source=TTC-PC\SQLEXPRESS;Initial Catalog=db_onlinecatalogspace;Integrated Security=True" 
               ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [tbcatalog]">
           </asp:SqlDataSource>
       </td></tr>
   
   
   <tr style="width:655px;">
       <td colspan="2"  align="right">&nbsp;</td>
   
   
       <td colspan="2" style="height: 27px">&nbsp;</td>
   
   
   
   
   
   <tr style="width:655px;">
       <td colspan="2" style="font-size:medium; text-align:center">&nbsp; Product Name</td>
   
   
       <td colspan="2">
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       </td>
   
   
   <tr style="width:655px;">
       <td colspan="4">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="2" style="height: 27px;font-size:medium;text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Description</td>
   
   
       <td colspan="2" rowspan="3">
           <asp:TextBox ID="TextBox2" runat="server" Height="68px" Width="177px" 
               TextMode="MultiLine"></asp:TextBox>
       </td>
   
   
   <tr style="width:655px;">
       <td colspan="2">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="2">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="4">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="2" style="font-size:medium;text-align:center">&nbsp; Product Price</td>
   
   
       <td colspan="2">
           <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
       </td>
   
   
   <tr style="width:655px;">
       <td colspan="4">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="2" style="font-size:medium ; text-align:center">&nbsp;&nbsp; Product Image</td>
   
   
       <td colspan="2">
&nbsp;&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" />
           &nbsp;
       </td>
   
   
   <tr style="width:655px;">
       <td colspan="2">&nbsp;</td>
   
   
       <td colspan="2">&nbsp;</td>
   
   
   <tr style="width:655px;">
       <td colspan="4"><center> 
           <asp:Button ID="Button3" runat="server" Text="Save" Height="21px" 
               Width="62px" onclick="Button3_Click" />
           <asp:Button ID="Button4" runat="server" Text="Cancel" Height="21px" 
               Width="62px" />
           <asp:Button ID="Button5" runat="server" Text="Reset" Height="21px" 
               Width="62px" />
           </center>
       </td>
   
   
   <tr style="width:655px;">
       <td colspan="2">&nbsp;</td>
   
   
       <td colspan="2">&nbsp;</td>
   
   
   </table>
   
</asp:Content>

