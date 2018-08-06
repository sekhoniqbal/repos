<%@ Page Title="" Language="C#" debug="true" MasterPageFile="~/Publisher/publisher.master" AutoEventWireup="true" CodeFile="Manageproducts.aspx.cs" Inherits="Publisher_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style=" text-align:center; background-color:Gray; font-size:20px">
                Manage Products</td>
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
            <td align="right">
                <a href ="Uploadproducts.aspx">Upload Products</a></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:GridView ID="GridView1" runat="server"  CellPadding="4" ForeColor="#333333" 
                    GridLines="None" Width="588px" AutoGenerateColumns="False" 
                    onrowcancelingedit="GridView1_RowCancelingEdit" 
                    onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating" 
                    DataKeyNames="intprodid" AllowPaging="True" PageSize="5" 
                    onpageindexchanging="GridView1_PageIndexChanging"  >
                  
                    <%--<PagerTemplate>
                    <asp:label id="MessageLabel" forecolor="Blue" text="Select a page:" runat="server"/>
                    <asp:label id="Label1" forecolor="Blue" text="Select a page:" runat="server"/>

                     <asp:dropdownlist id="PageDropDownList" autopostback="true" runat="server" OnSelectedIndexChanged="PageDropDownList_SelectedIndexChanged"></asp:dropdownlist>
                    <asp:label id="CurrentPageLabel" forecolor="Blue" runat="server"/>
                    </PagerTemplate>--%>
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Product ID">
                        <ItemTemplate>
                       <center> <%# Eval("intprodid") %></center>
                       
                        </ItemTemplate>
                        <EditItemTemplate>
                        <asp:Label ID="l1" Text='<%# Eval("intprodid") %>' runat="server"></asp:Label>
                        </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Product Name">
                        <ItemTemplate>
                        <%# Eval("strprodname") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="t1" Text='<%#Eval("strprodname") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Product Description">
                        <ItemTemplate> 
                        <%# Eval("strproddesc") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="t2" Text='<%#Eval("strproddesc") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                        <%# Eval("intprodprice") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                        <asp:TextBox ID="t3" Text='<%#Eval("intprodprice") %>' runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Image">
                        <ItemTemplate>
                        <asp:Image ID="dd"  ImageUrl= '<%# "~//Productimages/"+Eval("strprodimage") %>' Height="50px" Width="50px"  runat="server"/>
                        </ItemTemplate>
                         
                        </asp:TemplateField>
                        
                        <asp:CommandField ShowEditButton="true" />
                        <asp:CommandField ShowDeleteButton="true" />
                        
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                   <%--<PagerStyle  ForeColor="blue"  BackColor="LightGray"/>
                    <PagerTemplate>
                         <table width="100%">
                         <tr>
                         <td style="width:70%">
                         <asp:Label ID="MessageLabel" ForeColor="Blue" Text="select a page:" runat="server"></asp:Label>
                         <asp:DropDownList ID="PageDropdownList" AutoPostBack="true" runat="server">
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         </asp:DropDownList>
                         </td>
                         <td style="width:70%; text-align:right">
                         <asp:Label ID="CurrentPageLabel" ForeColor="Blue" runat="server"></asp:Label>
                         </td>
                         </tr>
                         </table>
                          </PagerTemplate>--%>
                   <%--  <asp:dropdownlist id="PageDropDownList" autopostback="true" runat="server" ></asp:dropdownlist>
                    <asp:label id="CurrentPageLabel" forecolor="Blue" runat="server"/>
                    </PagerTemplate>--%>
                   <%-- <PagerTemplate>
                   Select A Page:<asp:Label ID="lbl" runat="server"></asp:Label>
                   <asp:DropDownList ID="a" runat="server" OnSelectedIndexChanged="a_SelectedIndexChanged"></asp:DropDownList>
                    </PagerTemplate>
                    --%>
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
    </table>
</asp:Content>

