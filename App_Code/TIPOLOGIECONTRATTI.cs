using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class TIPOLOGIECONTRATTI
{
    #region Membri
    
    private int codiceTipoContratto;
    private string descrizioneTipoContratto;

    #endregion Membri

    #region Costruttore   
    public TIPOLOGIECONTRATTI()
    {

    }

    #endregion Costruttore

    #region Proprietà
    public int Codice
    {
        private set { codiceTipoContratto = value; }
        get { return codiceTipoContratto; }
    }

    public string Descrizione
    {
        private set { descrizioneTipoContratto = value; }
        get { return descrizioneTipoContratto; }
    }

    #endregion Proprietà

    #region Metodi
    public bool CheckOne(string descrizione)
    {
        this.Descrizione = descrizione;
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();

        cmd.CommandText = "TIPOLOGIECONTRATTI_CheckOne";
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", Descrizione);
        
        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    } 
    public void Insert(string descrizione)
    {
        this.Descrizione = descrizione;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECONTRATTI_Insert";
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", Descrizione);
        
        c.EseguiSpCmdParam(cmd);
    }
    public void Update(int codice,string descrizione)
    {
        this.Descrizione = descrizione;
        this.Codice = codice;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoContratto", Codice);
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", Descrizione);

        cmd.CommandText = "TIPOLOGIECONTRATTI_Update";
        c.EseguiSpCmdParam(cmd);
    }
    public DataTable Select()
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECONTRATTI_SelectAll";
        return c.EseguiSpSelectParam(cmd);
    }
    public DataTable Select(int codice)
    {
        this.Codice = codice;

        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoContratto", Codice);
        cmd.CommandText = "TIPOLOGIECONTRATTI_TEXTBOX";

        return c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi
}