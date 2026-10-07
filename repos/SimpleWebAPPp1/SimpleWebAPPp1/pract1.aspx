<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Pract1.aspx.cs"
    Inherits="SimpleWebAPPp1.Pract1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Personal Details</title>
</head>

<body>
<form id="form1" runat="server">

    <h3>Personal Details</h3>

    Name:
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox 

    <asp:RequiredFieldValidator
        ID="RequiredFieldValidator1"
        runat="server"
        ControlToValidate="txtname"
        ErrorMessage="*Required"
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <br /><br />

    Contact:
    <asp:TextBox ID="txtcontact" runat="server"></asp:TextBox>

    <br /><br />

    Location:
    <asp:DropDownList ID="lstlocation" runat="server">
        <asp:ListItem>Mumbai</asp:ListItem>
        <asp:ListItem>Thane</asp:ListItem>
        <asp:ListItem>Kalyan</asp:ListItem>
    </asp:DropDownList>

    <br /><br />

    Gender:
    <asp:RadioButton ID="male" runat="server"
        Text="Male" GroupName="Gender" />

    <asp:RadioButton ID="female" runat="server"
        Text="Female" GroupName="Gender" />

    <br /><br />

    Education:
    <asp:CheckBox ID="ssc" runat="server" Text="SSC" />
    <asp:CheckBox ID="hsc" runat="server" Text="HSC" />
    <asp:CheckBox ID="graduate" runat="server" Text="Graduate" />

    <br /><br />

    <asp:Button ID="Button1" runat="server"
        Text="Submit"
        OnClick="Button1_Click" />

</form>
</body>
</html>