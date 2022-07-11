<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaTipologiaSpesePoPup.aspx.cs" Inherits="Forms_PoPupModifica_ModificaTipologiaSpesePoPup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTipologiaSpese" runat="server"></asp:TextBox>
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click"/>
        </div>
    </form>
</body>
</html>
