using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class TIPOLOGIECOMMESSA
{
    #region Membri

    private int codiceTipoCommessa;
    private string descrizioneTipoCommessa;

    #endregion Membri

    #region Costruttore
    public TIPOLOGIECOMMESSA()
    {

    }

    #endregion Costruttore

    #region Proprietà
    public int Codice
    {
        private set { codiceTipoCommessa = value; }
        get { return codiceTipoCommessa; }
    }

    public string Descrizione
    {
        private set { descrizioneTipoCommessa = value; }
        get { return descrizioneTipoCommessa; }
    }

    #endregion Proprietà

    #region Metodi
    public bool CheckOne(string descrizione)
    {
        this.Descrizione = descrizione;

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.CommandText = "TIPOLOGIECOMMESSE_CheckOne";
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", Descrizione);

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    }
    public void Insert(string descrizione)
    {
        this.Descrizione = descrizione;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECOMMESSE_Insert";
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", Descrizione);

        c.EseguiSpCmdParam(cmd);
    }
    public void Update(int codice, string descrizione)
    {
        this.Descrizione = descrizione;
        this.Codice = codice;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", Codice);
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", Descrizione);

        cmd.CommandText = "TIPOLOGIECOMMESSE_Update";
        c.EseguiSpCmdParam(cmd);
    }
    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECOMMESSE_SelectAll";
        return c.EseguiSpSelectParam(cmd);
    }
    public DataTable Select(int codice)
    {
        this.Codice = codice;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", Codice);
        cmd.CommandText = "TIPOLOGIECOMMESSE_TEXTBOX";

        return c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi
}