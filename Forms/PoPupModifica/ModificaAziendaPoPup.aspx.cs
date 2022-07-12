using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_PoPupModifica_ModificaAziendaPoPup : System.Web.UI.Page
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
        AZIENDE a = new AZIENDE();//creo l'oggetto t di tipospesa
        DataTable dt = new DataTable();//creo l'oggetto datatable

        int codice = Convert.ToInt32(Session["id"]);//creo una variabile intera da passare al metodo Select

        //prendo la procedura
        //mi restituisce un data table
        dt = a.Select(codice);

        //di questo datatable prendimi alla riga X il contenuto di Y {MATRICE}
        txtRegSociale.Text = dt.Rows[0]["Ragione Sociale"].ToString();
        txtPartitaIva.Text = dt.Rows[0]["Partita IVA"].ToString();
        txtIndirizzo.Text = dt.Rows[0]["Indirizzo"].ToString();
        txtCap.Text = dt.Rows[0]["Cap"].ToString();
        txtCitta.Text = dt.Rows[0]["Citta"].ToString();
        txtProvincia.Text = dt.Rows[0]["Provincia"].ToString();

    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        int codiceAzienda = Convert.ToInt32(Session["id"]);
        string regSociale = txtRegSociale.Text.Trim();
        string pIva = txtPartitaIva.Text.Trim();
        string indirizzo = txtIndirizzo.Text.Trim();
        string citta = txtCitta.Text.Trim();
        string cap = txtCap.Text.Trim();
        string provincia = txtProvincia.Text.Trim();

        AZIENDE a = new AZIENDE();

        //Controlli Formali
        if (string.IsNullOrEmpty(regSociale)|| string.IsNullOrEmpty(pIva)||
            string.IsNullOrEmpty(indirizzo)|| string.IsNullOrEmpty(citta)||
            string.IsNullOrEmpty(cap)|| string.IsNullOrEmpty(provincia))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        //CONTROLLO SE è PRESENTE O MENO
        if (a.CheckOne(pIva))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dato già presente')", true);
            return;

        }

        //Update
        a.Update(codiceAzienda, regSociale,pIva,indirizzo,citta,cap,provincia);

    }
}