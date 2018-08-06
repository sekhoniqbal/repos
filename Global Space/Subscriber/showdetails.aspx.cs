using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Subscriber_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        //string pid;
        //string ses = Session["pid"].ToString();
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //con.Open();
        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "Proc_sltuser";
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = ses;
        //cmd.Connection = con;
        //SqlDataReader dr = cmd.ExecuteReader();
        //dr.Read();
        //userid = dr[0].ToString();
        //// Label2.Text = userid;
        //dr.Close();
        //Session["uid"] = userid;
        //Label2.Text = Session["uid"].ToString();
        datagrd();
    }
    private void datagrd()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbproduct", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DetailsView1.DataSource = ds;
        DetailsView1.DataBind();

    }


    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
}