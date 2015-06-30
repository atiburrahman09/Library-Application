<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryWebApp.UI.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="memberTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="showBorrowedBooksButton" runat="server" OnClick="showBorrowedBooksButton_Click" Text="Show Borrowed Books" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Borrowed BookList"></asp:Label>
        <asp:DropDownList ID="borrowedDropDownList" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:Button ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
