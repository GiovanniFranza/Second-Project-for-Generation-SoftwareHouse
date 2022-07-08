<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Email</h1>
            <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" placeholder="Password" runat="server"></asp:TextBox>
            <asp:Button ID="btnIniva" runat="server" Text="Spedisci" />
        </div>
    </form>
</body>
</html>
