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
        string userid;
        string name;
        string ses = Session["ss"].ToString();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Proc_sltuser";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = ses;
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        userid = dr["intuserid"].ToString();
        name = dr["strfirstname"].ToString();
        dr.Close();
        Session["uid"] = userid;
        Session["uname"] = name;
        Label1.Text = Session["uid"].ToString();
        lb.Text = Session["uname"].ToString();  
    }
}