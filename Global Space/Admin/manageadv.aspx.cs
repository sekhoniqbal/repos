using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using tadmin;

public partial class Admin_Default : System.Web.UI.Page
{
    clstadminfun obj = new clstadminfun();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        datadrp();
        datagrd();
    }
    protected void but_Click(object sender, EventArgs e)
    {
        Response.Redirect("addnewad.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void datadrp()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcategory", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "--Select--");
    }
    private void datagrd()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbadvertisement", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gd.DataSource = ds;
        gd.DataBind();
       
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string s = DropDownList1.SelectedItem.Text;
        gd.DataSource = obj.searchadv(s);
        gd.DataBind();
    }
    protected void gd_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("editadv.aspx");
    }
    protected void gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Int32 i;
        //i = Convert.ToInt32(((Label)(gd.Rows[e.RowIndex].FindControl("Label1"))).Text);
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //SqlCommand cmd = new SqlCommand("delete from tbcatalog where intcatalogid=@id", con);
        //cmd.Parameters.Add("@id", SqlDbType.Int).Value = i;
        //cmd.Connection = con;
        //con.Open();
        //cmd.ExecuteNonQuery();
        //cmd.Dispose();
        //datagrd();
    }
    protected void gd_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

        //gd.EditIndex = -1;
        //datagrd();
    }
    protected void gd_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}