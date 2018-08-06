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

        if (Page.IsPostBack == false)
        {
            datab();
        }
    }
    protected void gd_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void datab()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcategory ", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gd.DataSource = ds;
        gd.DataBind();


    }
    protected void gd_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gd.EditIndex = e.NewEditIndex;
        datab();
    }
    protected void gd_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gd.EditIndex = -1;
        datab();
    }

    protected void gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Int32 i;
        i = Convert.ToInt32(((Label)(gd.Rows[e.RowIndex].FindControl("Label1"))).Text);
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("delete from tbcategory where intcategoryid=@id", con);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = i;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        datab();

    }
    protected void gd_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        Int32 i;
        string c; 
        i = Convert.ToInt32(((Label)(gd.Rows[e.RowIndex].FindControl("Label1"))).Text);
        c = ((TextBox)(gd.Rows[e.RowIndex].FindControl("txt"))).Text;

        obj.p_strcategoryname = c;
        obj.p_intcatlid = i;
        obj.updcatg();
        datab();
    }
    protected void but_Click(object sender, EventArgs e)
    {
        string c = txt.Text;
        obj.p_strcategoryname = c;
        obj.addcatg();
        datab();
    }
    protected void add_Click(object sender, EventArgs e)
    {

    }
    protected void cancel_Click(object sender, EventArgs e)
    {

    }
}