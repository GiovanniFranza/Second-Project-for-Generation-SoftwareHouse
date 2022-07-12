using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registrazione : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        UTENTI u = new UTENTI();
        u.Email=txtEmail.Text.Trim();

        string email = u.Email;
        u.ValidateEmail(email);

        u.Password=CRYPTA.Crypta(u.PasswordRandom());
        string password=u.Password;

        u.CRUD(email, password);

        MailMessage message = new MailMessage();
        SmtpClient client = new SmtpClient();

        int porta = 25;
        string host = "setsistemi.it";
        client.Credentials = new NetworkCredential(email, password);
        client.Host = host;
        client.Port = porta;
        message.Subject = "Mail di conferma registrazione";
        message.Body = "ciao";
        message.IsBodyHtml = true;
        message.From = new MailAddress("doita05@setsistemi.it");

        message.To.Add(new MailAddress("franzagiovanni95@gmail.com"));
        client.Send(message);
    }
}