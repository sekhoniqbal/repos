using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using tUser;

public partial class Publisher_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        
       if (IsPostBack==false)
        {
            gridbind();
        }
       string userid = Session["uid"].ToString();
    }

   
    private void gridbind()
    {

        Int32 d = Convert.ToInt32 (Session["uid"]);
       
        SqlCommand cmd = new SqlCommand("Proc_selpubproduct", con);
        cmd.Parameters.Add("@intuserid", SqlDbType.Int).Value = d;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
        cmd.Dispose();

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        gridbind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
               
          con.Open();
        
           Int32 ss=Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
	       
	        SqlCommand cmd = new SqlCommand("Proc_delpubproduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = ss;            
	        cmd.ExecuteNonQuery();
	        con.Close();
            cmd.Dispose();
            gridbind();

            
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        gridbind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Int32 proid, price;
        string desc, name;

        proid = Convert.ToInt32(((Label)(GridView1.Rows[e.RowIndex].FindControl("l1"))).Text);
        price = Convert.ToInt32(((TextBox)(GridView1.Rows[e.RowIndex].FindControl("t3"))).Text);
        desc = ((TextBox)(GridView1.Rows[e.RowIndex].FindControl("t2"))).Text;
        name = ((TextBox)(GridView1.Rows[e.RowIndex].FindControl("t1"))).Text;
        con.Open();
        SqlCommand cmd = new SqlCommand("Proc_updateproduct",con);
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@intprodid",SqlDbType.Int).Value=proid;
        cmd.Parameters.Add("@intprodprice", SqlDbType.Int).Value = price;
        cmd.Parameters.Add("@strproddesc",SqlDbType.VarChar).Value=desc;
        cmd.Parameters.Add("@strprodname", SqlDbType.VarChar).Value = name;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        GridView1.EditIndex = -1;
        gridbind();
    }

  
  

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridbind();
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
   
}



