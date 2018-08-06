<%@ Page Title="" Language="C#" MasterPageFile="~/Subscriber/Subscriber.master" AutoEventWireup="true" CodeFile="addtocart.aspx.cs" Inherits="Subscriber_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
    <table><tr><td>
    <asp:GridView ID="gd" runat="server" AutoGenerateColumns="False" 
        onrowcancelingedit="gd_RowCancelingEdit" 
        onrowdeleting="gd_RowDeleting" onrowediting="gd_RowEditing" 
        onrowupdating="gd_RowUpdating" DataKeyNames="intprodid" Width="460px">
        <Columns>
            <asp:BoundField DataField="intorderid" HeaderText="Pid" ReadOnly="True" >
            <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:BoundField DataField="strorderpn" HeaderText="Pname" ReadOnly="True" >
                 <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />            </asp:BoundField>

            <asp:BoundField DataField="intorderpqty" HeaderText="Quantity" >
                        <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:BoundField DataField="intorderprc" HeaderText="Price" ReadOnly="True" >
                        <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>


            <asp:BoundField DataField="intorderamt" HeaderText="Amount" ReadOnly="True" >
                        <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:TemplateField HeaderText="Actions">
            <HeaderStyle BackColor="#00BFBF" Font-Bold="True" Font-Names="Times New Roman" 
                Font-Size="X-Large" HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle BackColor="#C0E1E4" Font-Names="Times New Roman" Font-Size="Large" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemTemplate>
            <asp:LinkButton ID="lnk1"  Text="edit" CommandName="edit" runat="server" ForeColor="#009999" Font-Underline="True" Font-Italic="True" />
               <asp:LinkButton ID="lnk2"  Text="delete" CommandName="delete" runat="server" ForeColor="#009999" Font-Underline="True" Font-Italic="True" />       
           </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView></td></tr>
    <tr><td>
    <span style="background-color: #00BEBE">
    <span style="font-family: Tahoma; font-weight: bold; font-size: large">Total amount&nbsp; :</span><span 
        style="font-family: Tahoma; font-weight: bold; font-size: large; color: #FFFFFF">
    </span>
    <span style="font-family: Tahoma; font-weight: bold; font-size: large; color: #FFFFFF">&nbsp;&nbsp;&nbsp;
    </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>
    <br /></td></tr>
    <tr><td></td></tr>
    <tr><td>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Confirm Order" BackColor="#00BFBF" Width="157px" /></td></tr>
        </table>
    </form>
</asp:Content>

