<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ModificaTipologiaContratti.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#popup').click(function () {

                var url = this.href;
                var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe').appendTo('body');

                dialog.dialog({
                    modal: true,
                    title: 'Inserisci',
                    resizable: false,
                    with: '400px',
                    show: {
                        effect: "explode",
                        duration: 1000
                    },
                    hide: {
                        effect: "explode",
                        duration: 1000
                    },
                    overlay: { opacity: 0.9, backgroun: 'black' },

                    open: function (type, data) { $(this).parent().appendTo('form'); }


                });

                return false;
            });

        });
    </script>
    <a href="Forms/PoPupModifica/ModificaTipologiaContratti.aspx" id="popup" class="btnPopup">Modifica</a>
    <asp:GridView ID="griglia" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="griglia_SelectedIndexChanged"></asp:GridView>
    <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" OnClick="btnAggiorna_Click" />


</asp:Content>

