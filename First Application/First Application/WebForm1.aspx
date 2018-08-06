<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="First_Application.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="168px" BackColor="#FFCCCC"></asp:TextBox> &nbsp &nbsp 
        <asp:Button ID="Button1" runat="server" Text="Button" BackColor="#0066FF" OnClick="Button1_Click" />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="66px" OnClick="ImageButton1_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
