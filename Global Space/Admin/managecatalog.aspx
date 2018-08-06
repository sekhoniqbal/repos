<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="managecatalog.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <div style="background-color:#E4F8FF; height:575px; border-color:Teal; margin-top:-2px">
    <form id="form1" runat="server">
 <div style="margin-left:0px">
  
       <table style="width:673px; margin-right: 0px; height: 269px;" frame="box"  
           bgcolor="#E4F8FF"><tr><td style="width: 683px; "  colspan="2" valign="middle" align="center"> 
           <div style="background-color:#65AAC0; margin-left:-1px; width: 683px;  margin-top:-4px;font-size: x-large;">
               <span style="font-family: 'Times New Roman', Times, serif">
          <b> Manage Catalogs</b></span>
           </div></td></tr>

            <tr><td colspan="2"></td></tr>
            <tr><td colspan="2"></td></tr>
           <tr><td  colspan="2"> 
  <center>  <asp:Button ID="but" runat="server" 
        Text="Add New Catalog"  BackColor="#65AAC0" ForeColor="Black" onclick="but_Click"  /></center>
             <center>  <asp:Panel ID="Panel1" runat="server">
               <table>
               <tr><td colspan="2"></td></tr>
               <tr><td>   Catalog Name:</td>
              
               <td><asp:TextBox ID="txt" runat="server"></asp:TextBox></td></tr>
                <tr><td colspan="2"></td></tr>
               <tr><td><asp:Button ID="add" runat="server" Text="add" Width="75px" 
                       BackColor="#65AAC0" onclick="add_Click" /></td>
               <td><asp:Button ID="cancel" runat="server" Text="cancel" Width="75px" 
                       BackColor="#65AAC0" onclick="cancel_Click" /></td>
               </tr>
               </table>
            
               </asp:Panel></center>
               </td></tr>


             <tr><td colspan="2"></td></tr>
           <tr><td> <div>
               <asp:GridView ID="gd"  runat="server" AutoGenerateColumns="False" 
                   Height="193px" Width="683px"      onrowediting="gd_RowEditing"  
                   onrowdeleting="gd_RowDeleting"   onrowcancelingedit="gd_RowCancelingEdit" 
                   onselectedindexchanged="gd_SelectedIndexChanged" OnRowUpdating="gd_RowUpdating" >
               <Columns>
                   <asp:TemplateField HeaderText="Catalog Id">
                   <ItemTemplate><center> <%#Eval("intcatalogid") %></center>
                  

                   </ItemTemplate>
                   <EditItemTemplate> <center><asp:Label ID="Label1" runat="server" Text='<%#Eval("intcatalogid") %>'></asp:Label></center></EditItemTemplate>
                       <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                       <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Catalog Name">
                  <ItemTemplate>
                 <center> <%#Eval("strcatalogname") %></center>
                 </ItemTemplate>
                   <EditItemTemplate>
                  <center> <asp:TextBox ID="txt" runat="server" Text='<%#Eval("strcatalogname") %>'></asp:TextBox></center>
                 </EditItemTemplate>
                   <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                       <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="Actions">
                   <ItemTemplate>
            <asp:LinkButton ID="lnk1" runat="server" Text="edit" CommandName="edit" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
           <asp:LinkButton ID="lnk2" runat="server" Text="delete" CommandName="delete" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </ItemTemplate>
        <EditItemTemplate>
       <asp:LinkButton ID="lb2" runat="server" Text="update" CommandName="update" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
                   <asp:LinkButton ID="lb3" runat="server" Text="cancel" CommandName="cancel" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </EditItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
                   </asp:TemplateField>
               </Columns>
               </asp:GridView></div>
    </td></tr></table> </div></form></div>
</asp:Content>

