using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_Emp_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Utility.ReadFromCookie("loginEmployee", "Employee") != null)
        {
            Response.Redirect("Emp-Home.aspx");
        }
        else if (Utility.ReadFromCookie("loginAdmin", "Admin") != null)
        {
            Response.Redirect("../admin/Admin-Home.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Employee Emp = new Employee();
        if (Emp.login(txtUSRNAME.Text, txtPassword.Text) == true)
        {
            #region Admin
            if (txtUSRNAME.Text.ToLower() == "admin") // el 2wel mn 8er el if w el else deh 
            {
                Utility.CreateCookie("loginAdmin", new string[] { "Admin" }, new string[] { txtUSRNAME.Text }, ckRemember.Checked);
                Response.Redirect("../admin/Admin-Home.aspx");
            }
            else
            {
                Utility.CreateCookie("loginEmployee", new string[] { "Employee" }, new string[] { txtUSRNAME.Text }, ckRemember.Checked);
                Response.Redirect("./Emp-Home.aspx");
            }
            #endregion
            //Utility.CreateCookie("loginEmployee", new string[] { "Employee" }, new string[] { txtUSRNAME.Text }, ckRemember.Checked);
        }
        else
        {
            Label1.Text = "the username or the password is wrong";
        }
    }
}