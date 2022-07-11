using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class TIPOLOGIECONTRATTI
{
    #region Membri
    
    public int codiceTipoContratto;
    public string descrizioneTipoContratto;

    #endregion Membri

    #region Costruttore  
    
    public TIPOLOGIECONTRATTI()
    {

    }

    #endregion Costruttore

    #region Proprietà
    public int Codice
    {
        set { codiceTipoContratto = value; }
        get { return codiceTipoContratto; }
    }

    public string Descrizione
    {
        set { descrizioneTipoContratto = value; }
        get { return descrizioneTipoContratto; }
    }

    #endregion Proprietà

    #region Metodi
    public bool CheckOne(int codice)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "TIPOLOGIECONTRATTI_CheckOne";
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", codice);
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    } 
    public void CRUD(string descrizione)
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.CommandText = "TIPOLOGIECONTRATTI_Insert";
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", descrizione);
        
        c.EseguiSpCmdParam(cmd);
    }
    public void CRUD(string descrizione, int codice)
    {
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoContratto", codice);
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", descrizione);

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
        SqlCommand cmd = new SqlCommand();
        CONNESSIONE c = new CONNESSIONE();

        cmd.Parameters.AddWithValue("@CodiceTipoContratto", codice);
        cmd.CommandText = "TIPOLOGIECONTRATTI_TEXTBOX";

        return c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi
}