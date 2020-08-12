using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Utility.ReadFromCookie("loginuser", "user") != null)
        {
            Response.Redirect("./Client/Client-Homeaspx.aspx");
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Client c = new Client();
        if (c.login(txtUSRNAME.Text, txtPassword.Text) == true)
        {
            Utility.CreateCookie("loginuser", new string[] { "user" }, new string[] { txtUSRNAME.Text },ckRemember.Checked);
            Response.Redirect("./Client/Client-Homeaspx.aspx");
        }
        else
        {
            Label1.Text = "the username or the password is wrong";
        }

    }
}