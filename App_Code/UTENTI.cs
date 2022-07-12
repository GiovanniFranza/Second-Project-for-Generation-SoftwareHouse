using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per UTENTI
/// </summary>
public class UTENTI
{
    #region Membri

    private int codiceUtente;
    private string tipologiaUtente;
    private int codicePersonale;
    private bool abilitato;
    private string email;
    private string password;
    private Random random;

    #endregion Membri

    #region Costruttore
    public UTENTI()
    {
    }

    #endregion Costruttore

    #region Proprietà

    public string Email
    {
        set { email = value; }
        get { return email; }
    }
    public string Password
    {
        set { password = value; }
        get { return password; }
    }

    #endregion Proprietà

    #region Metodi

    public bool CheckOne(string email, string password)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        cmd.CommandText = "UTENTI_CheckOne";
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@Password", password);

        dt = c.EseguiSpSelectParam(cmd);
        return dt.Rows.Count > 0;
    }

    public void CRUD(string email,string password)
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand(); 

        cmd.CommandText = "UTENTI_Insert";
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@Password", password);

        c.EseguiSpCmdParam(cmd);
    }

    public string PasswordRandom()
    {
        string password = "";
        random = new Random();
        int lenghtPassRand = 25;
        for (int x = 0; x < lenghtPassRand; x++)
        {
            int c = random.Next(48, 126);
            password += (char)c;
        }
        return password;
    }
    public bool ValidateEmail(string email)
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email);
        if (match.Success)
            return true;
        else
            return false;
    }

    #endregion Metodi

}