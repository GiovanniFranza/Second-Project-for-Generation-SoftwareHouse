<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaAziendaPoPup.aspx.cs" Inherits="Forms_PoPupModifica_ModificaAziendaPoPup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Modifica Azienda</p>
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtRegSociale" placeholder="Ragione Sociale" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPartitaIva" placeholder="Partita Iva" MaxLength="11" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" placeholder="Indirizzo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCap" placeholder="CAP" MaxLength="5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCitta" placeholder="Città" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtProvincia" placeholder="Provincia" MaxLength="2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnModifica" runat="server" Text="Inserisci" OnClick="btnModifica_Click" /><br />

        </div>
    </form>
</body>
</html>
