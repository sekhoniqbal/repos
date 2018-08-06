<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="Visitor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
<asp:SiteMapPath ID="sitemap1" runat="server">
    <CurrentNodeStyle Font-Bold="True" ForeColor="Black" />
    <NodeStyle Font-Bold="True" />
    <PathSeparatorStyle Font-Bold="True" />
    </asp:SiteMapPath>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
     
     <div style="width:800px;margin-left:197px;margin-top:7px;">
<div style="margin-left:40px">
   
    <table style="width: 100%">
        <tr>
            <td colspan="2" style="font-family:@Arial Unicode MS; font-size:16px">
              <center><b>Search</b></center>  </td>
        </tr>
        <tr>
            <td style="width: 371px">
                Select Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="130px" >
                   
                </asp:DropDownList>
            &nbsp;</td>
            <td>
                Select Catalog:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="130px" > 
                </asp:DropDownList>    
                
            </td>
        </tr>
        <tr>
            <td style="width: 371px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
            &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 371px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"  align="center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Panel ID="Panel1" runat="server">
                <tr>
            <td style="width: 371px">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 371px">
                Display Items:&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 371px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="740px">
                
        <ItemTemplate>
      <table ><tr><th>
        <asp:Image  ID="image1" ImageUrl='<%# "~//Productimages/"+ Eval("strprodimage") %>' Height="150px" Width="150px" runat="server"></asp:Image> </th></tr>
       <tr><th>
       <%#Eval("strprodname") %>
               </th>
        </tr>
        <th>
        <b>Price in Rs.</b><%#Eval("intprodprice") %></th></tr>
        <tr><th>
        <a href ='Detailproduct.aspx?proid=<%#Eval("intprodid") %>'> view detail </a>
        </th>
        </tr>
      </table>
        </ItemTemplate>

                </asp:DataList>
                <asp:Button ID="Button2" runat="server" Text="First" onclick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="Next" onclick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="Pre" onclick="Button4_Click" />
                <asp:Button ID="Button5" runat="server" Text="Last" onclick="Button5_Click" />
                </asp:Panel>
            </td>
        </tr>
    </table>
   
                
          
    </div>
</div>

     </div>
</asp:Content>

