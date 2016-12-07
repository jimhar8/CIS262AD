<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="IOT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 58px">
    
        <asp:Label ID="lblServerTime" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:DropDownList ID="ThingList" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="ThingList_SelectedIndexChanged">
            <asp:ListItem Value="0">Tablet</asp:ListItem>
            <asp:ListItem Value="1">PC</asp:ListItem>
            <asp:ListItem Value="2">Laptop</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="LabelType" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LabelAddress" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonPing" runat="server" Text="Ping" OnClick="ButtonPing_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ping Results:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="LabelResponse" runat="server"></asp:Label>
    </form>
</body>
</html>
