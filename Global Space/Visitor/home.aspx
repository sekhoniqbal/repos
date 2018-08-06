<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Visitor_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="aj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
    <asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <script type="text/javascript" src="js/crawler.js"></script>

<script type="text/javascript">
    marqueeInit({
        uniqueid: 'mycrawler',
       style: {
           'padding': '2px',
            'width': '800px',
  //   'background': 'lightyellow',
//           'border': '1px solid #CC3300'
       },
        inc: 8, //speed - pixel increment for each iteration of this marquee's movement
        mouse: 'cursor driven', //mouseover behavior ('pause' 'cursor driven' or false)
        moveatleast: 4,
        neutral: 150,
        savedirection: true
    });
</script>

<div style="width:800px">
<table>
<tr><td colspan="3">
<div class="marquee" id="mycrawler" style="height:200px;width:800px">
 <asp:Datalist ID="datalist1" runat="server" RepeatDirection="Horizontal">
  <ItemTemplate>
  <asp:Image ID="img" runat="server" ImageUrl='<%#"~//Productimages/"+ Eval("strimage") %>' />
  </ItemTemplate>
  </asp:Datalist>
    </div>
    
 </td></tr>

 <tr>
 <td class="offer" style="height:250px; width:250px">
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <b><a href="#" style="color: #FFFFFF; font-family: 'Times New Roman', Times, serif; font-size: xx-large; width: 191px; margin-left: 0px;">Silver Plan</a></b>
 </td>

 <td class="offer" style="height:250px; width:250px">
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <b><a href="#" style="color: #FFFFFF; font-family: 'Times New Roman', Times, serif; font-size: xx-large; width: 191px; margin-left: 0px;">Golden Plan</a></b>
 </td>

 <td style="height: 18px">
     
         <div style="width:257px; height:186px; float:right; margin-left: 0px;background-color:Silver">
               <div style="background-color:#5A8A92; width:307;height:20px;text-align:center; font-size: medium;">
                <strong>Login</strong></div>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="108px"></asp:TextBox>
       <asp:Label ID="ltuname" runat="server"  ForeColor="#FF3300"></asp:Label> <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Username is Required.</asp:RequiredFieldValidator>
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="105px"></asp:TextBox>
        <asp:Label ID="ltpwd" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" 
            ForeColor="#FF3300">* Password is Required.</asp:RequiredFieldValidator>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#5A8A92" Height="27px" 
            Text="Login" Width="71px" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl="ForgotPassword.aspx">Forgot Password ?</asp:HyperLink>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not yet a member?&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="registration.aspx">Register Now</asp:HyperLink>
    </div>
   
 </td></tr>   
</table>
</div>  
 
</asp:Content>

