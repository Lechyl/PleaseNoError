<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PleaseWork.aspx.cs" Inherits="PleaseNoError.PleaseWork"%>

<!DOCTYPE html>
<style>
    .ImageCenter{
    min-height: 150px;
    min-width: 150px;
    width:40%;
    margin-left: auto;
    margin-right: auto;
    text-align: center;
    display: table-cell;
    vertical-align: middle

    }
    .Center{
    min-width:200px;    
    text-align:center;
    display:block;
    vertical-align:middle;
    margin:0;
    
    
    
    }
    .body{
        background-color:gray
    }
    </style>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" Style="text-align:center">
                <asp:ListItem Text="Is It wednesday" Value="0" Selected="True"></asp:ListItem>
                <asp:ListItem Text="What is the current date?" Value="1" ></asp:ListItem>
                <asp:ListItem Text="Ze Tian Ji"  Value="2"></asp:ListItem>       
            </asp:DropDownList>
        </div>
        <asp:Label ID="Label1"  runat="server" CssClass="Center" Style="margin-top:50px; font-size:50px" Font-Bold="true" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" CssClass="Center" Style="font-size:40px;" Font-Bold="true" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" CssClass="Center" runat="server" Style="font-size:40px;" Font-Bold="true"  Text="Hiding" Visible="False"></asp:Label>
        </p>

        <asp:Image ID="Image2"  CssClass="ImageCenter" runat="server" Visible="False" ImageUrl="~/Anime.jpg" />

        <asp:Image ID="Image1"  CssClass="ImageCenter"  runat="server" Visible="false" ImageUrl="~/WednessAHH.png" />

    </form>
</body>
</html>
