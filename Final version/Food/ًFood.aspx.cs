using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Food_Food : System.Web.UI.Page
{
    Food F = new Food();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
    protected void btnAddFood_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        btnAddUpdFood.Text = "Add Food Item";
    }
    protected void btnCancelAdd_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        txtFoodID.Text = txtFoodName.Text = txtPrice.Text = txtFoodDescription.Text = txtAvaQty.Text = "";
        lblAdd.Text = "";
    }
    protected void btnAddUpdFood_Click(object sender, EventArgs e)
    {
        if (btnAddUpdFood.Text=="Add Food Item")
        {
            lblAdd.Text = F.AddFood(Convert.ToInt16(DDCatID.SelectedValue), Convert.ToInt16(txtFoodID.Text), txtFoodName.Text
                , Convert.ToDouble(txtPrice.Text), Convert.ToInt16(txtAvaQty.Text), txtFoodDescription.Text);
        }
        else
        {
            lblAdd.Text = F.UpdateFood(Convert.ToInt16(DDCatID.SelectedValue), Convert.ToInt16(txtFoodID.Text), txtFoodName.Text
                , Convert.ToDouble(txtPrice.Text), Convert.ToInt16(txtAvaQty.Text), txtFoodDescription.Text);
        }
        if (FUP.HasFile)
        {
            FUP.SaveAs(Server.MapPath(string.Format("./FoodImages/{0}-{1}.jpg",DDCatID.SelectedValue,txtFoodID.Text)));
        }
        txtFoodID.Text = txtFoodName.Text = txtPrice.Text = txtFoodDescription.Text = txtAvaQty.Text = "";
    }

    protected void btnDeleteFood_Click(object sender, EventArgs e)
    {
        lblAllService.Text= F.DeleteFood(Convert.ToInt16(GridViewFood.SelectedRow.Cells[1].Text)
            , Convert.ToInt16(GridViewFood.SelectedRow.Cells[2].Text));
    }
    protected void GridViewFood_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnDeleteFood.Enabled= true;
        btnUpdateFood.Enabled = true;
    }
    protected void btnUpdateFood_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        txtFoodID.Text = GridViewFood.SelectedRow.Cells[2].Text;
        txtFoodName.Text = GridViewFood.SelectedRow.Cells[3].Text;
        txtPrice.Text = GridViewFood.SelectedRow.Cells[4].Text;
        txtAvaQty.Text = GridViewFood.SelectedRow.Cells[6].Text;
        txtFoodDescription.Text = GridViewFood.SelectedRow.Cells[7].Text;
        Img.ImageUrl = string.Format("./FoodImages/{0}-{1}.jpg",DDCatID.SelectedValue,txtFoodID.Text);
        btnAddUpdFood.Text = "Update Food Item";
        DDCatID.SelectedValue = GridViewFood.SelectedRow.Cells[1].Text;
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        DataTable TBL = new DataTable();
        TBL = F.Search(rbSearchField.SelectedValue, txtSearch.Text);
        if (TBL.Rows.Count > 0)
            GridViewFood.DataSource = TBL;
        else
            lblAllService.Text = "No records";

        GridViewFood.SelectedIndex = -1;
        btnDeleteFood.Enabled = false;
        btnUpdateFood.Enabled = false;
        GridViewFood.DataBind();
    }
}