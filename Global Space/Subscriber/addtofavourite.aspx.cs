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
        datagrd();
    }
    private void datagrd()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbfavproducts", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gd.DataSource = ds;
        gd.DataBind();

    }
    protected void gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string i;
        i = e.Keys[0].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("delete from tbfavproducts where strprodname=@name", con);
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = i;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        datagrd();
    }
    protected void gd_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}