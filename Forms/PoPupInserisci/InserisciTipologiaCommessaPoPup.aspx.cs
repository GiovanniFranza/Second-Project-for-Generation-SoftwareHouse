using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupInserisci_InserisciTipologiaCommessaPoPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        //Controlli Formali
        if (string.IsNullOrEmpty(txtCommessa.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        TIPOLOGIECOMMESSA tcm = new TIPOLOGIECOMMESSA();

        string descrizione = txtCommessa.Text.Trim();

        //Verifico se esiste
        if (tcm.CheckOne(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }

        //Inserimento
        tcm.Insert(descrizione);
    }
}