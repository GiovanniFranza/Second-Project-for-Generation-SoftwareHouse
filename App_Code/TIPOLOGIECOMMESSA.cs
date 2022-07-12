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
        set { codiceTipoCommessa = value; }
        get { return codiceTipoCommessa; }
    }

    public string Descrizione
    {
        set { descrizioneTipoCommessa = value; }
        get { return descrizioneTipoCommessa; }
    }

    #endregion Proprietà

    #region Metodi
    public bool CheckOne(string descrizione)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.CommandText = "TIPOLOGIECOMMESSE_CheckOne";
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", descrizione);

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    }
    public void CRUD(string descrizione)
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECOMMESSE_Insert";
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", descrizione);

        c.EseguiSpCmdParam(cmd);
    }
    public void CRUD(int codice, string descrizione)
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", codice);
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", descrizione);

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
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", codice);
        cmd.CommandText = "TIPOLOGIECOMMESSE_TEXTBOX";

        return c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi
}