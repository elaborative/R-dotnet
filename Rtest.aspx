<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Rtest.aspx.vb" Inherits="admin_Rtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       Name:<asp:Textbox ID="TxtName" runat="server" Text="Name" />
       Max:<asp:Textbox ID="TxtValue" runat="server" Text="100" />
       <asp:Button ID="BtnRefresh" runat="server" Text="Refresh" />
       <asp:Label ID="LblPlots" runat="server"></asp:Label>
    <div>
    </div>
    </form>
</body>
</html>
