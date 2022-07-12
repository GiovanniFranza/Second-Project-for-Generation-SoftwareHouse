<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrazione.aspx.cs" Inherits="Registrazione" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
            <asp:Button ID="btnInvia" runat="server" Text="Continua" OnClick="btnInvia_Click" />
        </div>
    </form>
</body>
</html>
