<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="catalogs.aspx.cs" Inherits="Visitor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
 <asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div style="width:800px">
<asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
            DataKeyField="strcatalogname" 
            onselectedindexchanged="DataList1_SelectedIndexChanged">       
        <ItemTemplate>
        <asp:LinkButton id="lnk" CommandName="Select" runat="server">
      <%-- <image src='<%# "Brandimages/"+Eval("strcatalogimg")%>' ></image>--%>
       <image src='<%# "Brandimages/"+Eval("strcatalogimg")%>' border="0" />
        </asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
    
     </div>
</asp:Content>

