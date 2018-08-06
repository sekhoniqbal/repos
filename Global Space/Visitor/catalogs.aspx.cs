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
            datab();    
       
    }
    private void datab()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcatalog", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
     
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string p = DataList1.SelectedValue.ToString();
        Response.Redirect("catalogdetails.aspx?catalogname=" + p);

    }
}