<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="sitemap.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
<asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">

<p></p>
<b > <span style="font-size: x-large; color: #008080">&nbsp; Sitemap<br />
    </span></b>
&nbsp;<li class="list"><a href="home.aspx" onfocus="">Home</a></li>
     <li class="list"><a href="Aboutus.aspx">About Us</a></li>
    <li class="list"><a href="Contactus.aspx" >Contact Us</a></li>
    <li class="list"><a href="PrivacyPolicy.aspx" >Privacy Policy</a></li>

    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
    </form>
</asp:Content>

