<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="MovieTicket.aspx.cs"
    Inherits="CachingPractical.MovieTicket" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Movie Ticket</title>
</head>

<body>
<form id="form1" runat="server">

    <h2>Movie Ticket Booking</h2>

    <asp:ListBox ID="ListBox1" runat="server">
        <asp:ListItem>IMAX</asp:ListItem>
        <asp:ListItem>PVR</asp:ListItem>
        <asp:ListItem>MOVIEMAX</asp:ListItem>
    </asp:ListBox>

    <br /><br />

    <asp:Button ID="btnOK" runat="server"
        Text="OK"
        OnClick="btnOK_Click" />

</form>
</body>
</html>