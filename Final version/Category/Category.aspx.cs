using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Category_Category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;
        }
       
    }
    protected void btnAddCat_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        btnAddUpdCat.Text = "Add Category";
        Category Cat = new Category();
        txtCatID.Text = Cat.GenerateID_Category().ToString() ;
        txtCatName.Text = "";
        txtCatDescription.Text = "";
        
    }
    protected void BtnCancelAdd_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        lblAdd.Text = "";
        btnSearch_Click(sender, e);
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Category Cat = new Category();
        DataTable TBL = new DataTable();
        TBL=Cat.Search(rbSearchField.SelectedValue, txtSearch.Text);
        if (TBL.Rows.Count>0)
        {
            GridViewCat.DataSource = TBL;
        }
        else
        {
            lblAllService.Text = "No records";
                    
        }
       
        GridViewCat.SelectedIndex = -1;
        btnDeleteCat.Enabled = false;
        btnUpdateCat.Enabled = false;
        GridViewCat.DataBind();
    }
    protected void GridViewCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnDeleteCat.Enabled = true; 
        btnUpdateCat.Enabled = true;
    }
    protected void btnDeleteCat_Click(object sender, EventArgs e)
    {
        Category Cat = new Category();
        lblAllService.Text= Cat.DeleteCategory(Convert.ToInt16(GridViewCat.SelectedRow.Cells[1].Text));
        btnSearch_Click(sender, e);
    }
    protected void btnUpdateCat_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        txtCatID.Text = GridViewCat.SelectedRow.Cells[1].Text;
       
        txtCatName.Text = GridViewCat.SelectedRow.Cells[2].Text;
        txtCatDescription.Text = GridViewCat.SelectedRow.Cells[3].Text;
        btnAddUpdCat.Text = "Update Category";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Category Cat = new Category();
        if (btnAddUpdCat.Text == "Add Category")
        {
            
            lblAdd.Text = Cat.AddCategory(Convert.ToInt32(txtCatID.Text), txtCatName.Text, txtCatDescription.Text);

        }
        else if (btnAddUpdCat.Text == "Update Category")
        {
            lblAdd.Text = Cat.UpdateCategory(Convert.ToInt32(txtCatID.Text), txtCatName.Text, txtCatDescription.Text);
        }
        
    }
}