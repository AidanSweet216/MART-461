<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin2.aspx.cs" Inherits="GalleryProject.Admin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Insert New Video"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        Video ID<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Video Link<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
        
        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        <br />
        
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
