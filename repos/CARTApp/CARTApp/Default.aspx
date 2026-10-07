<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="CARTApp.Default" %>

<form id="form1" runat="server">

<h2>Products</h2>

<asp:GridView ID="ProductGridView" runat="server"
    AutoGenerateColumns="False" DataKeyNames="ID">

<Columns>

<asp:BoundField DataField="ID" HeaderText="ID" />
<asp:BoundField DataField="Name" HeaderText="Product" />
<asp:BoundField DataField="Price" HeaderText="Price" />

<asp:TemplateField HeaderText="Action">
<ItemTemplate>
<asp:Button ID="Add" runat="server"
    Text="Add to Cart"
    OnClick="Add_Click" />
</ItemTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView>

<h2>Shopping Cart</h2>

<asp:ListView ID="CartList" runat="server">
<ItemTemplate>

<%# Eval("Name") %> -
₹<%# Eval("Price") %>

<asp:Button ID="Remove" runat="server"
    Text="Remove"
    CommandArgument='<%# Eval("ID") %>'
    OnClick="Remove_Click" />

<br /><br />

</ItemTemplate>
</asp:ListView>

<asp:Label ID="Message" runat="server" ForeColor="Red" />

</form>