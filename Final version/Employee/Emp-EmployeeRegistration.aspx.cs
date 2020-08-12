using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Emp_EmployeeRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;
        }
     
    }
    protected void Addclient_Click(object sender, ImageClickEventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void EditClient_Click(object sender, ImageClickEventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;

    }
    protected void RegistBTN_Click(object sender, EventArgs e)
    {
        Employee E = new Employee();
        if (RegistBTN.Text == "Regist")
        {
            txtmsg.Text = E.Register(Usrtxt.Text, Passtxt.Text, Nametxt.Text, genderRB.SelectedValue, Addresstxt.Text,
                                Phonetxt.Text, Emailtxt.Text);
        }else if(RegistBTN.Text=="Save")
        {
            int ID= Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
           txtmsg.Text= E.Update(ID, Usrtxt.Text, Passtxt.Text, Nametxt.Text, genderRB.SelectedValue, Addresstxt.Text,
                                Phonetxt.Text, Emailtxt.Text);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)//search button
    {
        Employee Emp = new Employee();
        GridView1.DataSource = Emp.Search(RBTSearch.SelectedValue, txtSearch.Text);
        GridView1.DataBind();
        GridView1.SelectedIndex = -1;   // 3shan lma yrg3 yl8y el selected value lma ydos select tany
        btnEdit.Enabled = false;   // 3shan lma ados search tany yrg3 el zrayer false
        btnDelete.Enabled = false;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnDelete.Enabled = true;
        btnEdit.Enabled = true;
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Employee Emp = new Employee();
        Emp.Delete(GridView1.SelectedRow.Cells[2].Text); //3shan ydelete the by employeeName  
    }
    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        Usrtxt.Text = GridView1.SelectedRow.Cells[2].Text;
        Usrtxt.ReadOnly=true;
        Passtxt.Text = GridView1.SelectedRow.Cells[3].Text;
        Nametxt.Text = GridView1.SelectedRow.Cells[4].Text;
        if (GridView1.SelectedRow.Cells[5].Text == "M")
            genderRB.SelectedValue = "M";
        else
            genderRB.SelectedValue = "F";
        Addresstxt.Text = GridView1.SelectedRow.Cells[6].Text;
        Phonetxt.Text = GridView1.SelectedRow.Cells[7].Text;
        Emailtxt.Text = GridView1.SelectedRow.Cells[8].Text;
        RegistBTN.Text = "Save";
        MultiView1.ActiveViewIndex = 1;    
    }
}