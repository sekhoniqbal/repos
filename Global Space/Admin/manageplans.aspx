<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="manageplans.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <div style="background-color:#E4F8FF; height:575px; border-color:Teal; margin-top:-2px">
    <form id="form1" runat="server">
 <div style="margin-left:0px">
  
       <table style="width:673px; margin-right: 0px; height: 269px;" frame="box"  
           bgcolor="#E4F8FF"><tr><td style="width: 683px; "  colspan="2" valign="middle" align="center"> 
           <div style="background-color:#65AAC0; margin-left:-1px; width: 683px; height: 32px; margin-top:-4px;font-size: x-large;">
               <span class="style3">
          <strong> Manage Plans</strong></span>
           </div></td></tr>

                  
                        <tr><td><center><strong style="background-color: #95D35A">  PLANS</strong></center></td></tr>
                        <tr><td colspan="2"><asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="False" Width="580px" 
        onrowcancelingedit="GridView1_RowCancelingEdit" onrowdeleting="GridView1_RowDeleting" 
        onrowediting="GridView1_RowEditing" Height="124px" >
    <Columns>
        <asp:TemplateField HeaderText="Plan" ControlStyle-BackColor="#FF0066">
        <ItemTemplate>
        <%# Eval("strplanname") %>
        </ItemTemplate>

<ControlStyle BackColor="#FF0066"></ControlStyle>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Duration">
        <ItemTemplate><%# Eval("intduration") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
       
        <asp:TemplateField HeaderText="Product Count"> 
        <ItemTemplate><%# Eval("intproductcount") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Price">
        <ItemTemplate><%# Eval("strimage") %></ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Actions">
        <ItemTemplate>
            <asp:LinkButton ID="lnk1" runat="server" Text="edit" CommandName="edit" ForeColor="#95D35A"  Font-Underline="True" Font-Italic="True"></asp:LinkButton>
           <asp:LinkButton ID="lnk2" runat="server" Text="delete" CommandName="delete" ForeColor="#95D35A"  Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </ItemTemplate>

        <EditItemTemplate>
        <asp:LinkButton ID="lnk3" runat="server" Text="update" CommandName="update" ForeColor="#95D35A"  Font-Underline="True" Font-Italic="True"></asp:LinkButton>
           <asp:LinkButton ID="lnk4" runat="server" Text="cancel" CommandName="cancel" ForeColor="#95D35A"  Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </EditItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
    </asp:GridView>
                            &nbsp;</td></tr>
                 

              <tr><td colspan="2"><center>
                  <asp:Button ID="but1" runat="server"  
                      Text="Add new Plan" BackColor="#65AAC0" onclick="but1_Click"/>&nbsp;&nbsp;&nbsp;<asp:Button 
                      ID="but2" runat="server"  Text="Show list of Planholder Publishers" 
                      BackColor="#65AAC0" onclick="but2_Click" /></center></td></tr>

           <tr><td colspan="2">  </td></tr></table>
           <asp:Panel ID="Panel1" runat="server">
           <table>
           <tr><td>    Plan Name :</td><td><asp:TextBox ID="tbpln" runat="server"></asp:TextBox></td> </tr>
           <tr><td>    Duration :</td><td><asp:TextBox ID="tbdur" runat="server"></asp:TextBox></td> </tr>
           <tr><td>    Product count :</td><td><asp:TextBox ID="tbpc" runat="server"></asp:TextBox></td> </tr>
         <tr><td>    Price :</td><td><asp:TextBox ID="tbprc" runat="server"></asp:TextBox></td> </tr>     
            <tr><td colspan="2"><asp:Button ID="ad" runat="server" Text= " Add" 
                    BackColor="#65AAC0"  />   
            <asp:Button ID="can" runat="server" Text= " Cancel" BackColor="#65AAC0" />   
             </td> </tr>
           </table>
           </asp:Panel>
            </div></form></div>
</asp:Content>

