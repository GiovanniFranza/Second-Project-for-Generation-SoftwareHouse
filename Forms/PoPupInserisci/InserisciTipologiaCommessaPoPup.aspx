﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciTipologiaCommessaPoPup.aspx.cs" Inherits="Forms_PoPupInserisci_InserisciTipologiaCommessaPoPup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox ID="txtCommessa" runat="server"></asp:TextBox>
            <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click"/>
        </div>
    </form>
</body>
</html>
