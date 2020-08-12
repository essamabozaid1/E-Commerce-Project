using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_ClientAllService : System.Web.UI.Page
{
    Client C = new Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
       GridView1.DataSource= C.Search(RBField.SelectedValue, txtSearch.Text);
       
       GridView1.DataBind();
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int x = e.RowIndex;
        string user=GridView1.Rows[x].Cells[2].Text;
        C.Delete(user);
        btnSearch_Click(sender, e);
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        btnSearch_Click(sender, e);

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int x = e.RowIndex;
        C.Update(GridView1.Rows[x].Cells[2].Text,GridView1.Rows[x].Cells[3].Text,GridView1.Rows[x].Cells[4].Text,GridView1.Rows[x].Cells[5].Text
           , GridView1.Rows[x].Cells[6].Text, GridView1.Rows[x].Cells[7].Text, GridView1.Rows[x].Cells[8].Text);
        btnSearch_Click(sender, e);
    }
}