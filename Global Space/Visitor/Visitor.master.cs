using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Visitor_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           data_bind();
           data_bind2();
        }
    }
    private void data_bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select top 10* from tbcategory", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        datalist1.DataSource = ds;
        datalist1.DataBind();

    }
    private void data_bind2()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select top 10* from tbcatalog", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        datalist2.DataSource = ds;
        datalist2.DataBind();

    }


    protected void datalist1_SelectedIndexChanged(object sender, EventArgs e)
    {
       string  i = datalist1.SelectedValue.ToString();
        Response.Redirect("categories.aspx?categoryname="+ i);
    }
    protected void datalist2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string p = datalist2.SelectedValue.ToString();
        Response.Redirect("catalogdetails.aspx?catalogname=" + p);
    }
}
