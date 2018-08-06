<%@ Control Language="C#" AutoEventWireup="true" CodeFile="brandsadv.ascx.cs" Inherits="Visitor_brandsadv" %>
 <script type="text/javascript" src="js/crawler.js"></script>
 <script type="text/javascript">
    marqueeInit({
        uniqueid: 'mycrawler3',
        style: {
            'padding': '2px',
            'width': '1003px',
            //'height': '180px'
        },
        inc: 5, //speed - pixel increment for each iteration of this marquee's movement
        mouse: 'cursor driven', //mouseover behavior ('pause' 'cursor driven' or false)
        moveatleast: 2,
        neutral: 150,
        savedirection: true
    });
</script>
 <div class="marquee" id="mycrawler3" style="width:1003px;border:0">

  <asp:Repeater ID="repeater1" runat="server" >
  <ItemTemplate>
  <asp:Image ID="img" runat="server" ImageUrl='<%#"Brandimages/"+ Eval("strcatalogimg") %>' Width="80px" />
  </ItemTemplate>
  </asp:Repeater>
    </div>