<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberEntry.aspx.cs" Inherits="LibraryWebApp.UI.MemberEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Number"></asp:Label>
        <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="memberSaveButton" runat="server" Text="Save" OnClick="memberSaveButton_Click" />
        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
