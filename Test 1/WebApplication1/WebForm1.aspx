<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            font-size: xx-large;
        }
        .auto-style5 {
            font-size: xx-large;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            
        }
        body{
            background-image:url(C:\Users\sweet\Documents\GitHub\MART-461\WebApplication1\Images\missoula.jfif);
        }
        
    </style>
</head>
<body style="height: 545px">
    <form id="form1" runat="server">
        <div style="height: 66px; text-align: center">
            <h1 class="auto-style1">YMCA Log In</h1>
            <hr />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" CssClass="auto-style2" Height="35px" OnTextChanged="TextBox1_TextChanged" Width="175px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Date of Birth:"></asp:Label>
        </p>
        <p style="height: 47px">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Month</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Day</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Year</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="height: 47px">
            <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Password:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style7" Height="35px" Width="175px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#FF9900" BorderColor="#33CCFF" BorderStyle="Outset" CssClass="auto-style6" EnableTheming="True" Height="54px" OnClick="Button1_Click" Text="Log In" Width="139px" />
        </p>
    </form>
</body>
</html>
