using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Publisher_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        gridbind();
    }

    private void gridbind()
    {
        Int32 userid = Convert.ToInt32(Session["uid"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("Proc_selprodhistory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@intuserid", SqlDbType.Int).Value = userid;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
        cmd.Dispose();


    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Int32 prodid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        con.Open();
        SqlCommand cmd = new SqlCommand("Proc_delprodhistory", con);
        cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = prodid;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        con.Close();
        cmd.Dispose();
        gridbind();
    }


}