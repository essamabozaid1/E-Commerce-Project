using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_ProductsShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string x=Request.QueryString["CategoryID"];
        string y = Request.QueryString["FoodID"];
        if(x!=null && y==null)
        {
            SqlDataSource1.SelectCommand = string.Format("SELECT * FROM [Food] WHERE CategoryID='{0}'", x);
        }
        else if(x!=null && y!=null)
        {
            SqlDataSource1.SelectCommand = string.Format("SELECT * FROM [Food] WHERE CategoryID='{0}' AND FoodID='{1}'", x, y);
        }
        else
        {
            SqlDataSource1.SelectCommand = "SELECT * FROM [Food] ";
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataTable tbl;
        if (Session["Shopping"] == null)
        {
            tbl = new DataTable();
            tbl.Columns.Add("CategoryID");
            tbl.Columns.Add("FoodID");
            tbl.Columns.Add("FoodName");
            tbl.Columns.Add("FoodPrice");
        }
        else
        {
            tbl =(DataTable) Session["Shopping"];
        }
        Session.Timeout = 120;
        DataRow row = tbl.NewRow();
        int index=e.Item.ItemIndex;
        row[0] =((Label) DataList1.Items[e.Item.ItemIndex].FindControl("CategoryID")).Text;
        row[1] = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("FoodID")).Text;
        row[2] = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("FoodName")).Text;
        row[3] = ((Label)DataList1.Items[e.Item.ItemIndex].FindControl("FoodPrice")).Text;
        tbl.Rows.Add(row);
        Session["Shopping"] = tbl;
        Response.Redirect("ProductsShow.aspx");
    }
}