﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaTipologiaCommessa.aspx.cs" Inherits="Forms_PoPupModifica_ModificaTipologiaCommessa" %>

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
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click"/>
        </div>
    </form>
</body>
</html>