using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupInserisci_InserisciTipologiaContrattiPoPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        //Controlli Formali
        if (string.IsNullOrEmpty(txtTipContr.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        TIPOLOGIECONTRATTI tc = new TIPOLOGIECONTRATTI();

        string descrizione = txtTipContr.Text.Trim();
        tc.Descrizione = descrizione;

        //Verifico se esiste
        if (tc.CheckOne(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }

        //Inserimento
        tc.CRUD(descrizione);
    }
}