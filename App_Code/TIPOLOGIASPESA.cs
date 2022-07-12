using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class TIPOLOGIASPESA
{

    #region Membri

    private int codiceTipoSpesa;
    private string descrizioneTipoSpesa;

    #endregion Membri

    #region Costruttore
    public TIPOLOGIASPESA() { }

    #endregion Costruttore

    #region Proprietà
    public int Codice
    {
        private set { codiceTipoSpesa = value; }
        get { return codiceTipoSpesa; }
    }
    public string Descrizione
    {
        private set { descrizioneTipoSpesa = value; }
        get { return descrizioneTipoSpesa; }
    }

    #endregion Proprietà

    #region Metodi
    public void Insert(string descrizione)
    {
        this.Descrizione = descrizione;

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIESPESE_Insert";
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", Descrizione);

        c.EseguiSpCmdParam(cmd);
    }
    public void Update(int codiceTipoSpesa, string descrizione)
    {
        this.Codice = codiceTipoSpesa;
        this.Descrizione = descrizione;

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", Codice);
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", Descrizione);

        cmd.CommandText = "TIPOLOGIESPESE_Update";
        c.EseguiSpCmdParam(cmd);

    }
    public bool CheckOne(string descrizione)
    {
        this.Descrizione = descrizione;

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", Descrizione);
        cmd.CommandText = "TIPOLOGIESPESE_CheckOne";

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;

    }
    public DataTable Select()
    {

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIESPESE_SelectAll";
        return c.EseguiSpSelectParam(cmd);
    }
    public DataTable Select(int codice)
    {
        this.Codice = codice;

        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", Codice);
        cmd.CommandText = "TIPOLOGIESPESE_TEXTBOX";

        return dt = c.EseguiSpSelectParam(cmd);
    }

    #endregion Metodi

}