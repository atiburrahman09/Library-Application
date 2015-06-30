﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookEntry.aspx.cs" Inherits="LibraryWebApp.UI.BookEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Publisher"></asp:Label>
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveBookButton" runat="server" Text="Save" OnClick="saveBookButton_Click" />
        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
