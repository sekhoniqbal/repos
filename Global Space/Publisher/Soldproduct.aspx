<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/Publisher/publisher.master" AutoEventWireup="true" CodeFile="Soldproduct.aspx.cs" Inherits="Publisher_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table style="width: 100%">
        <tr>
            <td colspan="2" align="center" style="font-size:large; font-family:@Arial Unicode MS; background-color:Silver">
                <b>Sold Product History</b></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Width="714px" AllowPaging="True" CellPadding="4" 
                     ForeColor="#333333" GridLines="None" 
                    PageSize="3" DataKeyNames="intprodid" 
                    onrowdeleting="GridView1_RowDeleting"
                 >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                     <asp:TemplateField HeaderText="Serial No." >
                        <ItemTemplate>
                        <%#Eval("serialnumber") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Product ID" >
                        <ItemTemplate>
                        <%#Eval("intprodid") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Product Name">
                        <ItemTemplate>
                        <%#Eval("strprodname") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Subscriber Name">
                        <ItemTemplate>
                        <%#Eval("strfirstname") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                        <%#Eval("strusername") %>
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
                        <asp:TemplateField HeaderText="Sold Date">
                        <ItemTemplate>
                        <%#Eval("date") %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowDeleteButton="true" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerSettings FirstPageText="First" LastPageText="Last" 
                        Mode="NextPreviousFirstLast" NextPageText="Next" PreviousPageText="Pre" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
               
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>

