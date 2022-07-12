using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
    public void CaricaGriglia()
    {
        TIPOLOGIECOMMESSA tcm = new TIPOLOGIECOMMESSA();
        griglia.DataSource = tcm.Select();
        griglia.DataBind();
    }


    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = griglia.SelectedRow;
        Session["id"] = row.Cells[1].Text;
    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
}