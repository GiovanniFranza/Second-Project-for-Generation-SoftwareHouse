using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class AZIENDE
{
    #region Membri
    private int codiceAzienda;
    private string ragioneSociale;
    private string partitaIva;
    private string indirizzo;
    private string citta;
    private string cap;
    private string provincia;

    #endregion Membri

    #region Costruttore
    public AZIENDE()
    {
    }

    #endregion Costruttore

    #region Proprietà
    public int CodiceAzienda
    {
        set { codiceAzienda = value; }
        get { return codiceAzienda; }
    }
    public string RagioneSociale
    {
        set { ragioneSociale = value; }
        get { return ragioneSociale; }
    }
    public string PartitaIva
    {
        set
        {
            if (value.Length < 11)
            {
                return;
            }
            else
            {
                partitaIva = value;
            }
        }

        get { return partitaIva; }
    }
    public string Indirizzo
    {
        set { indirizzo = value; }
        get { return indirizzo; }
    }
    public string Citta
    {
        set { citta = value; }
        get { return citta; }
    }
    public string Cap
    {
        set
        {
            if (value.Length < 5)
            {
                return;
            }
            else
            {
                cap = value;
            }
        }
        get { return cap; }
    }
    public string Provincia
    {
        set
        {
            if (value.Length < 2)
            {
                return;
            }
            else
            {
                provincia = value;
            }
        }
        get { return provincia; }
    }

    #endregion Proprietà

    #region Metodi

    public bool CheckOne(string pIva)
    {
        this.PartitaIva = pIva;

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
        cmd.CommandText = "AZIENDE_CheckOne";

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    }
    public void Insert(string ragSociale, string pIva, string indirizzo, string citta, string cap, string provincia)
    {
        this.RagioneSociale = ragSociale;
        this.PartitaIva = pIva;
        this.Indirizzo = indirizzo;
        this.Citta = citta;
        this.Cap = cap;
        this.Provincia = provincia;


        if (Validazione(PartitaIva, Cap, Provincia) == false)
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            cmd.CommandText = "AZIENDE_Insert";
            c.EseguiSpCmdParam(cmd);
        }
        else
        {
            return;
        }
    }
    public void Update(int codice, string ragSociale, string pIva, string indirizzo, string citta, string cap, string provincia)
    {
        this.CodiceAzienda = codice;
        this.RagioneSociale = ragSociale;
        this.PartitaIva = pIva;
        this.Indirizzo = indirizzo;
        this.Citta = citta;
        this.Cap = cap;
        this.Provincia = provincia;

        if (Validazione(PartitaIva, Cap, Provincia) == false)
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            cmd.CommandText = "AZIENDE_Update";
            c.EseguiSpCmdParam(cmd);
        }
        else
        {
            return;
        }
    }
    public DataTable Select()
    {

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "AZIENDE_SelectAll";
        return c.EseguiSpSelectParam(cmd);
    }
    public DataTable Select(int codice)
    {
        this.CodiceAzienda = codice;

        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
        cmd.CommandText = "AZIENDE_TEXTBOX";

        return dt = c.EseguiSpSelectParam(cmd);
    }
    private bool Validazione(string pIva, string cap, string provincia)
    {
        if (string.IsNullOrEmpty(pIva) || string.IsNullOrEmpty(cap) || string.IsNullOrEmpty(provincia))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

#endregion Metodi