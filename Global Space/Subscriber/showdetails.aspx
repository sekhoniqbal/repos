<%@ Page Title="" Language="C#" MasterPageFile="~/Subscriber/Subscriber.master" AutoEventWireup="true" CodeFile="showdetails.aspx.cs" Inherits="Subscriber_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <form id="form1" runat="server">
    <table>
 <tr><td style="width: 164px">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"  
             Height="190px" Width="549px" 
            onpageindexchanging="DetailsView1_PageIndexChanging">
             
            <Fields>
            <asp:TemplateField>
            <ItemTemplate>
            <asp:Image ID="image" runat="server" ImageUrl='<%# "~//Productimages/"+ Eval("strprodimage") %>' />
            </ItemTemplate>
            <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                    Font-Size="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                    HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
               <asp:BoundField DataField="intprodid" HeaderText="Product Id" 
                    SortExpression="ProductId" >
                <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                    Font-Size="20px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    ForeColor="White" />
                <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                    HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="strprodname" HeaderText="ProductName" SortExpression="ProductName" >
                <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                    Font-Size="20px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    ForeColor="White" />
                <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                    HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="intprodprice" HeaderText="Price" SortExpression="Price" >
                <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                    Font-Size="20px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    ForeColor="White" />
                <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                    HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="strproddesc" HeaderText="Description" SortExpression="Desccription" >
                <HeaderStyle BackColor="#26656E" Font-Bold="True" Font-Names="Times New Roman" 
                    Font-Size="20px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    ForeColor="White" />
                <ItemStyle BackColor="#B1DEE4" Font-Names="Times New Roman" Font-Size="Large" 
                    HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:TemplateField >
                <ItemTemplate><a href="addtocart.aspx">
                    <asp:Image ID="ImageButton1" runat="server" CommandName="xyz" 
                        ImageUrl="images/images1.jpeg" /></a>
                </ItemTemplate>
            </asp:TemplateField>
            </Fields>
            
        </asp:DetailsView>

         
    </div>
    </td>
    
    </tr>
    </table>
    </form>
</asp:Content>

