using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_FoodDetials : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Food F = new Food();
        if (Request.QueryString["CategoryID"] != null && Request.QueryString["FoodID"]!= null)
        {
            if (F.Find(Request.QueryString["CategoryID"].ToString(), Request.QueryString["FoodID"].ToString()))
            {
                Label1.Text = F.CategoryID.ToString();
                Label2.Text = F.FoodID.ToString();
                Label3.Text = F.FoodName;
                Label4.Text = F.FoodPrice.ToString();
                Label5.Text = F.AvailableQTY.ToString();
                TextBox2.Text = Label5.Text; // to make validation with text box quentity
                Label6.Text = F.Description;
                Image1.ImageUrl = string.Format("~/Food/FoodImages/{0}-{1}.jpg", F.CategoryID.ToString(), F.FoodID.ToString());
            }
        }  
    }
}