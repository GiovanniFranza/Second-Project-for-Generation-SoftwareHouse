using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public class CONNESSIONE
{
    //Dichiarazione dei membri della classe
    //Instanza di un oggetto della classe sqlConn
    //Questi membri hanno vita finchè vive la classe
    public SqlConnection conn = new SqlConnection();

    #region Costruttore
    public CONNESSIONE() 
    {
        //Connessione al DB tramite WebConfig
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["SOFTHOUSEConnectionString"].ConnectionString;  
    }

    #endregion Costruttore

    public void EseguiSpCmdParam(SqlCommand cmd)
    {
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    //Metodo per vedere i Dati
    public DataTable EseguiSpSelectParam(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;
        DA.Fill(dt);
        return dt;
    }
}