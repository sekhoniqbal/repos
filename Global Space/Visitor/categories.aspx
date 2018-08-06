<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="categories.aspx.cs" Inherits="Visitor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="width:800px; margin-top:10px">
<div style="background-color:  #598891; font-size: x-large; width: 800px;">Categories</div>
<div >
<asp:DataList ID="dl" runat="server" RepeatColumns="4">
  <ItemTemplate>
        <asp:Image  ID="image1" ImageUrl='<%# "~//Productimages/"+ Eval("strprodimage") %>' Height="150px" Width="150px" runat="server"></asp:Image> 
       <%#Eval("strprodname") %><br />
             
        <b>Price in Rs.</b><%#Eval("intprodprice") %><br /><a href ='Detailproduct.aspx?proid=<%#Eval("intprodid") %>'>view detail </a>
        </ItemTemplate>

                </asp:DataList></div>
</div>

</asp:Content>

