<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainGallery.aspx.cs" Inherits="GalleryProject.MainGallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        div{
            color:floralwhite;
            font-size:25px;
            text-align:center;
            
        }
        body{
            margin:auto;
            background-color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p>
                 &nbsp;
            <asp:Label ID="Label2" runat="server" CssClass="auto-style1" Height="30px" Text="Welcome to the Sweet Gallery"></asp:Label>
        </p>
             <p>
                 All the digital artworks here were created in TouchDesigner by Aidan Sweet</p>
             <p>
                 Aidan is an third year undergraduate student studying Game Design and Interactive Media at the University of Montana</p>
        </div>
        
        <asp:PlaceHolder ID ="whatever" runat ="server" ></asp:PlaceHolder>
    &nbsp;</form>
    
</body>
</html>
