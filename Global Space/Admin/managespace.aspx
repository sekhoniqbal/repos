<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="managespace.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<div style="background-color:#E4F8FF; height:575px; border-color:Teal; margin-top:-2px">
    <form id="form1" runat="server">
 <div style="margin-left:0px">
  
       <table style="width:673px; margin-right: 0px; height: 269px;" frame="box"  
           bgcolor="#E4F8FF"><tr><td style="width: 683px; "  colspan="2" valign="middle" align="center"> 
           <div style="background-color:#65AAC0; margin-left:-1px; width: 683px;  margin-top:-4px;font-size: x-large;">
               <span style="font-family: 'Times New Roman', Times, serif">
          <b> Manage Space</b></span>
           </div></td></tr>

           <tr><td colspan="2" ></td></tr>

<tr><td style="height: 26px; font-family: 'Times New Roman', Times, serif; font-size: medium; width: 116px;" >Select&nbsp; Publisher :</td><td style="height: 26px">
    <asp:DropDownList ID="DropDownList1" runat="server" 
     DataTextField="strfirstname" DataValueField="strfirstname" >   
    </asp:DropDownList>
    </td></tr>
    <tr><td colspan="2"></td></tr>
<tr><td colspan="2" style="height: 10px"><center>
    <asp:Button ID="btnsearch" 
        runat="server" Text="Search" onclick="btnsearch_Click" 
        style="height: 26px" BackColor="#65AAC0"/></center></td></tr>
<tr><td colspan="2"></td></tr>
           <tr><td colspan="2"> <div>
               <asp:GridView ID="gd"  runat="server" AutoGenerateColumns="False" 
                   Height="193px" Width="683px"       onrowdeleting="gd_RowDeleting" 
                   DataKeyNames="strusername"   >
               <Columns>
                   <asp:TemplateField HeaderText="User Name">
                   <ItemTemplate><center> <%#Eval("strusername") %></center>
                   </ItemTemplate>
                    <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                       <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>


                    <asp:TemplateField HeaderText="Price">
                  <ItemTemplate>
                 <center> <%#Eval("intprice") %></center>
                 </ItemTemplate>
                 <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                 <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="Start Date">
                  <ItemTemplate>
                 <center> <%#Eval("startdate") %></center>
                 </ItemTemplate>
                 <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                 <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>


                    <asp:TemplateField HeaderText="Duration">
                  <ItemTemplate>
                 <center> <%#Eval("strduration") %></center>
                 </ItemTemplate>
                 <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                 <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>


                    <asp:TemplateField HeaderText="End Date">
                  <ItemTemplate>
                 <center> <%#Eval("enddate") %></center>
                 </ItemTemplate>
                 <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                 <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                           HorizontalAlign="Center" />
                   </asp:TemplateField>


                   <asp:TemplateField HeaderText="Actions">
                   <ItemTemplate>
          
           <asp:LinkButton ID="lnk2" runat="server" Text="delete" CommandName="delete" ForeColor="#95D35A" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
        </ItemTemplate>
            <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="Larger" HorizontalAlign="Center" />
            <ItemStyle BackColor="#D2ECB9" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" />
                   </asp:TemplateField>
               </Columns>
               </asp:GridView></div>
    </td></tr></table> </div></form></div>

</asp:Content>

