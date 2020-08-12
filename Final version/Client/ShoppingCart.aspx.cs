using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            RefreshPage();
    }
    private void RefreshPage()
    {
        GridView1.DataSource = (DataTable)Session["Shopping"];
        GridView1.DataBind();
        double total = 0;
        for (int x = 0; x < GridView1.Rows.Count; x++)
        {
            total += Convert.ToDouble(GridView1.Rows[x].Cells[3].Text);
        }
        Label1.Text = total.ToString();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable tbl;
        if (Session["Shopping"] != null)
        {
            tbl =(DataTable) Session["Shopping"];
            int index = e.RowIndex;
            tbl.Rows[e.RowIndex].Delete();
            Session["Shopping"] = (DataTable)tbl;
            RefreshPage();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        RefreshPage();
        GridView1.DataBind();
    }



    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        RefreshPage();
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string NewVal = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
        //deh hya ele 5ltny 23ml referesh method 3shan page load bt7ml e2wl w btdy3 el qema ele ktbta
        // fe el text box
        if (Session["Shopping"] != null)
        {
            DataTable tbl =(DataTable) Session["Shopping"];
            tbl.Rows[e.RowIndex][2] = NewVal;
            Session["shopping"] = tbl;
            GridView1.EditIndex = -1;
            RefreshPage();
        }
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        if(Request.Cookies["loginuser"]!=null && Session["Shopping"]!=null)
        {
            DataTable tbl=(DataTable) Session["Shopping"];
            Order O = new Order();
            OrderDetails OD = new OrderDetails();
            O.AddOrder(Utility.ReadFromCookie("loginuser", "user").ToString(),0);
            OD.OrderID = O.OrderID;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                OD.CategoryID=Convert.ToInt16(tbl.Rows[i][0]);
                OD.FoodID =Convert.ToInt16( tbl.Rows[i][1]);
                OD.Quentity = 1;
                OD.SellPrice = Convert.ToDouble(tbl.Rows[i][3]);
                OD.Discount = 0;
                OD.Add();
            }
        }
    }
}