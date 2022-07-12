using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }

        UTENTI u = new UTENTI();
        u.Email = email;
        u.Password = password;

        if (u.CheckOne(email, password))
        {
            Response.Redirect("Default2.aspx");
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Email non presente')", true);
            DisabilitazioneCampi();

        }

    }
    public void DisabilitazioneCampi()
    {
        btnLogin.Enabled = false;
        txtEmail.Text = "";
        txtPassword.Text = "";
        txtEmail.Enabled = false;
        txtPassword.Enabled = false;
    }


    protected void btnRegistrazione_Click(object sender, EventArgs e)
    {

    }
}