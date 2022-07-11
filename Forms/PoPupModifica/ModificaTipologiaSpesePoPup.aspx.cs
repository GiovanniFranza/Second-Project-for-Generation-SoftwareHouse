using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupModifica_ModificaTipologiaSpesePoPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdateTextBox();
        }
    }

    #region Metodi
    public void UpdateTextBox()
    {
        TIPOLOGIASPESA tc = new TIPOLOGIASPESA();//creo l'oggetto t di tipospesa
        DataTable dt = new DataTable();//creo l'oggetto datatable

        //a l'oggetto t al membro codTipoSpesa gli assegno il codice recuperato
        tc.Codice = Convert.ToInt32(Session["id"]);

        int codice = tc.Codice;//creo una variabile intera da passare al metodo Select

        //prendo la procedura
        //mi restituisce un data table
        dt = tc.Select(codice); 

        //di questo datatable prendimi alla riga X il contenuto di Y {MATRICE}
        txtTipologiaSpese.Text = dt.Rows[0]["descrizione"].ToString();

    }

    #endregion Metodi

    #region Eventi
    protected void btnModifica_Click(object sender, EventArgs e)
    {
        int codiceTipoSpesa = int.Parse(Session["id"].ToString());
        string descrizone = txtTipologiaSpese.Text.Trim();
        txtTipologiaSpese.Text = descrizone;

        TIPOLOGIASPESA ts= new TIPOLOGIASPESA();
        
        ts.Codice = codiceTipoSpesa;
        ts.Descrizione = descrizone;

        //Controlli Formali
        if (string.IsNullOrEmpty(descrizone))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        //CONTROLLO SE è PRESENTE O MENO
        if (ts.CheckOne(descrizone))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }
        
        //Update
        ts.CRUD(codiceTipoSpesa, descrizone);

    }

    #endregion Eventi

}