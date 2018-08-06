<%@ Page Title="" Language="C#" MasterPageFile="~/Subscriber/Subscriber.master" AutoEventWireup="true" CodeFile="buyproducts.aspx.cs" Inherits="Subscriber_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
     <div style="width:800px;margin-top:7px">
<div style="margin-left:100px; overflow:auto">
   <div style="width:650px;height:227px;margin-top:300px">
    <table style="width:100%;background-color:#55BECC">
        <tr>
            <td colspan="2" 
                style="font-family:#009999; font-size:16px; font-family: '@Arial Unicode MS'">
              <center><b>Search</b></center>  </td>
        </tr>
        <tr>
            <td style="width: 371px">
                Select Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="130px" 
                    DataTextField="strcategoryname" 
                    DataValueField="intcategoryid" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
               
            </td>
            <td>
                Select Catalog:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="130px" 
                    DataTextField="strcatalogname" 
                    DataValueField="intcatalogid">
                </asp:DropDownList>
               
            </td>
        </tr>
        <tr>
            <td style="width: 371px; height: 30px" align="right">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
            </td>
            <td style="height: 30px">
                </td>
        </tr>
        <tr>
            <td style="width: 371px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
      
        <tr>
            <td style="width: 371px">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 371px">
                Display Items:&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 371px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
 
        </table></div><br />
        <table>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
                    DataKeyField="intprodid" oneditcommand="DataList1_EditCommand" 
                    onselectedindexchanged="DataList1_SelectedIndexChanged">
                
        <ItemTemplate>
      <table><tr><th>
        <asp:Image  ID="image1" ImageUrl='<%# "~//Productimages/"+Eval("strprodimage") %>' Height="150px" Width="150px" runat="server"></asp:Image> </th></tr>
       <tr><th>
        <%#Eval("strprodname") %>
        </th>
        </tr>
        <th>
        <b>Price in Rs.</b><%# Eval("intprodprice") %></th></tr>
        <tr><th>
        <asp:LinkButton ID="l1"  Text=" view detail"  runat="server" PostBackUrl="~/Subscriber/showdetails.aspx"></asp:LinkButton></b>
        </th>
        </tr>
      </table>
        </ItemTemplate>

                </asp:DataList>
                <asp:Button ID="Button2" runat="server" Text="First" onclick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="Next" onclick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="Pre" onclick="Button4_Click" />
                <asp:Button ID="Button5" runat="server" Text="Last" onclick="Button5_Click" />
            </td></table>
        </tr>
    </table>
   
    </div>
</div>
     </form>
</asp:Content>

