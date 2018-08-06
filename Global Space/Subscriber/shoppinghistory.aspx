<%@ Page Title="" Language="C#" MasterPageFile="~/Subscriber/Subscriber.master" AutoEventWireup="true" CodeFile="shoppinghistory.aspx.cs" Inherits="Subscriber_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 100%">
        <tr><td bgcolor="#cccccc" 
                style="height: 18px; font-size: xx-large; font-family: 'Times New Roman',Times,serif; text-align: center; color: rgb(0, 0, 0);">
					<div style="background-color: #26656E">
						<center style="color: rgb(255, 255, 255)">Shopping History</center></div>
				</td>
        </tr >
        <tr><td></td></tr>
        <tr><td></td></tr>
        <tr><td align="center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Width="761px" AllowPaging="True" CellPadding="4" 
                     ForeColor="#333333" GridLines="None" 
                    PageSize="3" DataKeyNames="intprodid" 
                    Height="183px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Product Name">
                        <ItemTemplate>
                        <%#Eval("strprodname") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Quantity">
                        <ItemTemplate>
                        <%#Eval("intquantity") %>
                        </ItemTemplate></asp:TemplateField>

                        <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                        <%#Eval("intprice") %>
                        </ItemTemplate></asp:TemplateField>

                        <asp:TemplateField HeaderText="Amount">
                        <ItemTemplate>
                        <%#Eval("intamount") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Purchased Date">
                        <ItemTemplate>
                        <%#Eval("date") %>
                        </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                       <asp:LinkButton ID="lnk" runat="server" Text="delete" ForeColor="Black"></asp:LinkButton>
                        </ItemTemplate>
                       
                        </asp:TemplateField>
                       
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerSettings FirstPageText="First" LastPageText="Last" 
                        Mode="NextPreviousFirstLast" NextPageText="Next" PreviousPageText="Pre" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="Black" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
               
            </td>
        </tr>
        
        
        
    </table>
</asp:Content>

