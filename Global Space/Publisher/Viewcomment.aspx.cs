using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Publisher_Default : System.Web.UI.Page
{

    SqlConnection con =new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gridbind();
        }
    }

    private void gridbind()

    {
        Int32 userid=Convert.ToInt32(Session["uid"].ToString());
        
        SqlCommand cmd=new SqlCommand("Proc_pubviewcomment",con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@intuserid", SqlDbType.Int).Value = userid;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = new SqlCommand("Proc_delpubcomment", con);
        cmd.CommandType = CommandType.StoredProcedure;
        string cc = GridView1.DataKeys[e.RowIndex].Value.ToString();

        cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = Convert.ToInt32(cc);
        cmd.ExecuteNonQuery();
        con.Close();
        cmd.Dispose();
        gridbind();
    }
}