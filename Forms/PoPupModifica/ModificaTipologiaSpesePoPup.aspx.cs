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
        TIPOLOGIASPESA ts = new TIPOLOGIASPESA();//creo l'oggetto t di tipospesa
        DataTable dt = new DataTable();//creo l'oggetto datatable

        int codice = Convert.ToInt32(Session["id"]);//creo una variabile intera da passare al metodo Select

        dt = ts.Select(codice); 

        //di questo datatable prendimi alla riga X il contenuto di Y {MATRICE}
        txtTipologiaSpese.Text = dt.Rows[0]["Descrizione"].ToString();

    }

    #endregion Metodi

    #region Eventi
    protected void btnModifica_Click(object sender, EventArgs e)
    {
        int codiceTipoSpesa = int.Parse(Session["id"].ToString());
        string descrizione = txtTipologiaSpese.Text.Trim();
        txtTipologiaSpese.Text = descrizione;

        TIPOLOGIASPESA ts = new TIPOLOGIASPESA();

        //Controlli Formali
        if (string.IsNullOrEmpty(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        //CONTROLLO SE è PRESENTE O MENO
        if (ts.CheckOne(descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }
        
        //Update
        ts.Update(codiceTipoSpesa, descrizione);

    }

    #endregion Eventi

}