<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="aboutus.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
<asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div style="width:800px;margin-left:197px;margin-top:7px">

    <%Response.WriteFile("~//HTML Pages//aboutus.htm"); %>
    </div>
</asp:Content>
