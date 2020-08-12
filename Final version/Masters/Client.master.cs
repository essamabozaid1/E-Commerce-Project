using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Utility.ReadFromCookie("loginuser", "user") == null)
        {
            Response.Redirect("../login.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
