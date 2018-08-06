<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="managesubscribers.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <div style="background-color:#E4F8FF; height:575px; border-color:Teal; margin-top:-2px">
    <form id="form1" runat="server">
 <div style="margin-left:0px">
  
       <table style="width:673px; margin-right: 0px; height: 269px;" frame="box"  
           bgcolor="#E4F8FF"><tr><td style="width: 683px; "  hcolspan="2" valign="middle" align="center"> 
           <div style="background-color:#65AAC0; margin-left:-1px; width: 683px;  margin-top:-4px;font-size: x-large;">
               <span style="font-family: 'Times New Roman', Times, serif">
          <b> Manage Subscribers</b></span>
           </div></td></tr>
           <tr><td> <div style="overflow:scroll; width:650px">
               <asp:GridView ID="gd"  runat="server" datasource='<%# getsubid()%>' AutoGenerateColumns="False"   Height="193px" Width="683px"  >
               <Columns>
                   <asp:TemplateField HeaderText="SubscriberId">
                   <ItemTemplate> <center><%# Eval("intuserid")%></center></ItemTemplate>
                  <%-- <EditItemTemplate> <center><asp:Label ID="Label1" runat="server" Text='<%# getpubid()%>'></asp:Label></center></EditItemTemplate>--%>
                   <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                       <ItemStyle BackColor="#D2ECB9" Font-Bold="False" Font-Names="Times New Roman" 
                           Font-Size="Medium" HorizontalAlign="Center" />
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="SubscriberDetails">
                  <ItemTemplate>
                  <asp:GridView ID="gd2" runat="server" datasource='<%#getsubdata(Convert.ToInt32(Eval("intuserid"))) %>'   AutogenrateColumns= "false" width="23">
                  <Columns>
                  <asp:BoundField HeaderText="UserName" datafield="strusername" />
                  <asp:BoundField HeaderText="Password" datafield="strpassword" />
                  <asp:BoundField HeaderText="FirstName" datafield="strfirstname" />
                  <asp:BoundField HeaderText="LastName" datafield="strlastname" />
                  <asp:BoundField HeaderText="PermanentAddress" datafield="strpermaddr" />
                  <asp:BoundField HeaderText="CorrespondenceAddress" datafield="strcorresaddr" />
                  <asp:BoundField HeaderText="City" datafield="strcity" />
                  <asp:BoundField HeaderText="State" datafield="strstate" />
                  <asp:BoundField HeaderText="Country" datafield="strcountry" />
                  <asp:BoundField HeaderText="Contactnumber" datafield="strcontactnumber" />
                  <asp:BoundField HeaderText="Faxnumber" datafield="strfaxnumber" />
                  <asp:BoundField HeaderText="ContactEmail" datafield="strcontactemail" />
                  <asp:BoundField HeaderText="DOB" datafield="dtdob" />
                </Columns>
                </asp:GridView>
                 </ItemTemplate>

                   <EditItemTemplate>
                  <center> <asp:Label ID="Label2" runat="server" Text='<%#Eval("strcatalogname") %>'></asp:Label></center>
                  <div style="float: right; ">
                  <asp:LinkButton ID="lb2" runat="server" Text="delete" CommandName="delete" ForeColor="#009999" Font-Underline="True" Font-Italic="True"></asp:LinkButton>
                   <asp:LinkButton ID="lb3" runat="server" Text="cancel" CommandName="cancel" ForeColor="#009999" Font-Underline="True" Font-Italic="True"></asp:LinkButton></div>
                   </EditItemTemplate>
                   <HeaderStyle BackColor="#95D35A" Font-Bold="True" Font-Names="Times New Roman" 
                           Font-Size="Larger" HorizontalAlign="Center" />
                       <ItemStyle BackColor="#D2ECB9" Font-Bold="False" Font-Names="Times New Roman" 
                           Font-Size="Medium" HorizontalAlign="Center" />
                   </asp:TemplateField>
               </Columns>
               </asp:GridView></div>
    </td></tr></table> </form></div>
</asp:Content>

