<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ze Tian Ji.aspx.cs" Inherits="PleaseNoError.Ze_Tian_Ji" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:DropDownList ID="DDL1" runat="server" OnSelectedIndexChanged="DDL1_SelectedIndexChanged" AutoPostBack="true" Style="text-align:center">
                <asp:ListItem Selected="True" Value="0">Ze Tian Ji</asp:ListItem>
                <asp:ListItem Value="1">Is is wednesday</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="PlayerScreen" runat="server" BorderStyle="Solid" Height="266px" ReadOnly="True" TextMode="MultiLine" Width="293px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="ID_1">Fists</asp:ListItem>
            </asp:DropDownList>
        </div>
        <p style="margin-left: 120px">
            <asp:Button ID="Button_A" runat="server" OnClick="Button_A_Click" Text="Button_A" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_C" runat="server" OnClick="Button_C_Click" Text="Button_C" />
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="Button_B" runat="server" OnClick="Button_B_Click" Text="Button_B" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_D" runat="server" OnClick="Button_D_Click" Text="Button_D" />
        </p>
    </form>
</body>
</html>
