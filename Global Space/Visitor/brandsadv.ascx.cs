using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Visitor_brandsadv : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           rep_bind();
        }
    }
    private void rep_bind()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select strcatalogimg from tbcatalog", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        repeater1.DataSource = ds;
        repeater1.DataBind();
    }
}