using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
            getd();
    }
   
    private void getd( )
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbuser ", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gd.DataSource = ds;
        gd.DataBind();

    }
    public DataSet getpubdata(Int32 pid)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbuser where introleid= 2 and intuserid="+ pid.ToString(), ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }
    public DataSet getpubid()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbuser where introleid=  2 " , ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }
}