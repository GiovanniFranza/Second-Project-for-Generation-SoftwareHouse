using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniva_Click(object sender, EventArgs e)
    {


        string password=txtPassword.Text.Trim();
        string email=txtEmail.Text.Trim();

        MailMessage message=new MailMessage();
        SmtpClient client= new SmtpClient();

        int porta = 25;
        string host = "setsistemi.it";
        client.Credentials = new NetworkCredential(email, password);
        client.Host = host;
        client.Port = porta;
        message.Subject = "Mail di conferma registrazione";
        message.Body = "ciao";
        message.IsBodyHtml=true;
        message.From = new MailAddress("doita05@setsistemi.it");

        message.To.Add(new MailAddress("franzagiovanni95@gmail.com"));
        client.Send(message);


    }
}