using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupInserisci_InserisciAziendaPoPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        AZIENDE a = new AZIENDE();

        if(string.IsNullOrEmpty(txtRegSociale.Text)||
            string.IsNullOrEmpty(txtPartitaIva.Text)||
            string.IsNullOrEmpty(txtIndirizzo.Text)||
            string.IsNullOrEmpty(txtCitta.Text)||
            string.IsNullOrEmpty(txtCap.Text)||
            string.IsNullOrEmpty(txtProvincia.Text))
        { 
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }
        
        string regSociale = txtRegSociale.Text.Trim();
        string pIva = txtPartitaIva.Text.Trim();
        string indirizzo = txtIndirizzo.Text.Trim();
        string citta = txtCitta.Text.Trim();
        string cap= txtCap.Text.Trim();
        string provincia= txtProvincia.Text.Trim();


        if (a.CheckOne(pIva))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;
        }

        a.Insert(regSociale,pIva,indirizzo,citta,cap,provincia);

    }
}