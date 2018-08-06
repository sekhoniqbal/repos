<%@ Page Title="" Language="C#" MasterPageFile="~/Visitor/Visitor.master" AutoEventWireup="true" CodeFile="detailproduct.aspx.cs" Inherits="Visitor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentplaceholder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
   
     <div style="width:800px;margin-left:197px;margin-top:7px;">
<div style="margin-left:40px">
   
   
   
                
          
    <table style="width: 100%">
        <tr>
            <td align="center" 
                style="background-color:Teal; font-family:@Arial Unicode MS; font-size:20px;" 
                colspan="2">
                Product Details</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 329px">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>                
               <asp:Image ID="ll"  ImageUrl='<%# "~//Productimages/"+ Eval("strprodimage") %>' Height="150" Width="150"  runat="server"/>
               </ItemTemplate>
               </asp:Repeater>    
            </td>
            <td style="width: 426px">
            <table>
            <tr><td>
            <table>
                <asp:Repeater ID="Repeater2" runat="server">
                 
                 
                <ItemTemplate>
                <tr><td>Product ID:<%#Eval("intprodid") %></td></tr>
                
                <tr><td>Name:<%#Eval("strprodname") %></td></tr>
             
                <tr><td>Description:<%#Eval("strproddesc") %></td></tr>
               
                <tr><td>Price:<%#Eval("intprodprice") %></td></tr>
              
                
                </ItemTemplate>
                </asp:Repeater>
                </table>
                </td>
               </tr>
                
                 </table>
            </td>
        </tr>
        <tr>
            <td colspan="2"></td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                <asp:Button ID="Button3" runat="server" Text="Add To Cart" />
&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Buy It Now" />
            </td>
        </tr>
        <tr>
            <td colspan="2" >
                

                <asp:Button ID="Button1" runat="server" Text="Add To Favourite" Width="133px" />

            </td>
        </tr>
        <tr>
            <td colspan="2" >
                <br />
                Post a Comment:<br />
                <asp:Panel ID="Panel1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" Height="59px" Width="251px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Post" Height="19px" 
                        Width="50px" onclick="Button2_Click" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="2" >
                &nbsp;</td>
        </tr>
    </table>
   
   
   
                
          
    </div>
</div>

     </div>

</asp:Content>

