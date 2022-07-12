using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupInserisci_InserisciTipologiaSpesePoPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region Eventi
    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //Controlli Formali
        if (string.IsNullOrEmpty(txtTipologiaSpese.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        TIPOLOGIASPESA ts = new TIPOLOGIASPESA();
        string descrizione = txtTipologiaSpese.Text.Trim();

        //Verifico se esiste
        if (ts.CheckOne(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;
        }

        //Inserimento
        ts.Insert(descrizione);
    }

    #endregion Eventi
}