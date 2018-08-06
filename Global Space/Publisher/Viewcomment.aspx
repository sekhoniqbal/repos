<%@ Page Title="" Language="C#" Debug="true"  MasterPageFile="~/Publisher/publisher.master" AutoEventWireup="true" CodeFile="Viewcomment.aspx.cs" Inherits="Publisher_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style=" background-color:Gray; font-size:larger; font-family:@Arial Unicode MS;">
                <center><b>View comments</b></center></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    <tr>
            <td  ><center>
                &nbsp;
                <asp:GridView ID="GridView1" runat="server"   AutoGenerateColumns="False" 
            CellPadding="4" GridLines="None" 
             Width="647px" onrowdeleting="GridView1_RowDeleting" DataKeyNames="intprodid" 
                    ForeColor="#333333" >
              
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Posted By" >
                
                <ItemTemplate >
                <%#Eval("strname")%>
                </ItemTemplate>              
                </asp:TemplateField>  
             <%--  <asp:TemplateField HeaderText="Product ID" >
                
                <ItemTemplate >
                <%#Eval("intprodid")%>
                </ItemTemplate>    
                </asp:TemplateField>
           --%>    <asp:TemplateField HeaderText="Image" >
                
                <ItemTemplate >
               <asp:Image ID="jj" runat="server" ImageUrl='<%#Eval("strprodimage")%>' Height="60px" Width="60px" />
                </ItemTemplate>    
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Product Name" >
                
                <ItemTemplate >
                <%#Eval("strprodname")%>
                </ItemTemplate>               
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="Comment" >
              
                <ItemTemplate>
                <ItemStyle Width="500px" />
                <%#Eval("strcommentdesc") %><%--<br /><b>Price:</b><%#Eval("bookprice") %><br /><b>Author:</b><%#Eval("bookauthor") %><br /><b>Publisher:</b><%#Eval("bookpublisher") %><br /><asp:LinkButton ID="jj" Text="Edit" CommandName="edit" runat="server" />
          --%>      </ItemTemplate>
              </asp:TemplateField>
                <asp:TemplateField HeaderText="Posted Date">
                <ItemTemplate>
                <%#Eval("posteddate") %>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />

            
        </asp:GridView>
        
        </center>
    
         &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

