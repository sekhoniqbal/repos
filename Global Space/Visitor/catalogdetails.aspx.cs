using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Visitor_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Datab();
           
        }
    }
    private void Datab()
    {
        Int32 d = catb();
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbproduct where intcatalogid=" + d, ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        dl.DataSource = ds;
        dl.DataBind();
    }
    public Int32 catb()
    {
        string s = Request.QueryString["catalogname"];
        SqlDataAdapter adp = new SqlDataAdapter("select intcatalogid from tbcatalog where strcatalogname= '" + s + "'", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        Int32 i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        return i;

    }
    

}