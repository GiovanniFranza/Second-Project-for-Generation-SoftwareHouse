using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupModifica_ModificaTipologiaContratto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdateTextBox();
        }
    }

    public void UpdateTextBox()
    {
        TIPOLOGIECONTRATTI tc = new TIPOLOGIECONTRATTI();//creo l'oggetto t di tipospesa
        DataTable dt = new DataTable();//creo l'oggetto datatable

        int codice = Convert.ToInt32(Session["id"]);//creo una variabile intera da passare al metodo Select

        //prendo la procedura
        //mi restituisce un data table
        dt = tc.Select(codice);

        //di questo datatable prendimi alla riga X il contenuto di Y {MATRICE}
        txtTipologiaSpese.Text = dt.Rows[0]["Descrizione"].ToString();

    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        int codiceContratto = Convert.ToInt32(Session["id"]);
        string descrizione = txtTipologiaSpese.Text;

        TIPOLOGIECONTRATTI tc = new TIPOLOGIECONTRATTI();

        //Controlli Formali
        if (string.IsNullOrEmpty(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        //CONTROLLO SE è PRESENTE O MENO
        if (tc.CheckOne(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }

        //Update
        tc.Update(codiceContratto,descrizione);

    }
}