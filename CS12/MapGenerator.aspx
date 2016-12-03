<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MapGenerator.aspx.cs" Inherits="MapGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 435px; top: 23px; position: absolute" Text="Map Generator"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 162px; top: 63px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 242px; top: 63px; position: absolute; width: 503px"></asp:TextBox>
        <asp:Button ID="btnGetMap" runat="server" OnClick="btnGetMap_Click" style="z-index: 1; left: 439px; top: 103px; position: absolute" Text="Get Map" />
        <asp:Image ID="imgMap" runat="server" style="z-index: 1; left: 212px; top: 166px; position: absolute; height: 320px; width: 540px" />
        <asp:Label ID="lblURL" runat="server" style="z-index: 1; left: 217px; top: 557px; position: absolute; height: 102px; width: 747px"></asp:Label>
    </form>
</body>
</html>
