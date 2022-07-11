using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    #region Metodi
    public void CaricaGriglia()
    {
        TIPOLOGIASPESA ts = new TIPOLOGIASPESA();
        griglia.DataSource=ts.Select();
        griglia.DataBind();
    }

    #endregion Metodi

    #region Eventi
    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    #endregion Eventi
}