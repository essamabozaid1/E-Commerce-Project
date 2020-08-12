﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Masters_Employee : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Utility.ReadFromCookie("loginEmployee", "Employee") == null)
        {
            Response.Redirect("../Employee/Emp-login.aspx");
        }
       

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Utility.RemoveCookie("loginEmployee");
        Response.Redirect("../Employee/Emp-login.aspx"); 
    }
}
