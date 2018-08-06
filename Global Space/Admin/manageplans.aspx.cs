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
           
            datagrd();
            Panel1.Visible = false;
        }       
    }
  
    private void datagrd()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbplan", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }


    

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string i;
        i = e.Keys[0].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("delete from tbplan where strusername=@un", con);
        cmd.Parameters.Add("@un", SqlDbType.VarChar, 50).Value = i;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        datagrd();
       
    }

    protected void but2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Planholderpub.aspx");
    }
    protected void but1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        datagrd();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        datagrd();
    }
}