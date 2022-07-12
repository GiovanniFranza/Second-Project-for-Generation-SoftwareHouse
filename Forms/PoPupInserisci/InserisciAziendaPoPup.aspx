<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciAziendaPoPup.aspx.cs" Inherits="Forms_PoPupInserisci_InserisciAziendaPoPup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Inserisci l'azienda</p>
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtRegSociale" placeholder="Ragione Sociale" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPartitaIva" placeholder="Partita Iva" runat="server" MaxLength="11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" placeholder="Indirizzo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCap" placeholder="CAP" runat="server" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCitta" placeholder="Città" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtProvincia" placeholder="Provincia" runat="server" MaxLength="2"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" /><br />

        </div>
    </form>
</body>
</html>
