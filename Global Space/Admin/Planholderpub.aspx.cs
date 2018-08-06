using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using tadmin;
public partial class Admin_Default : System.Web.UI.Page
{
    clstadminfun obj = new clstadminfun();
    protected void Page_Load(object sender, EventArgs e)
    {
        datadrp();

    }
    private void datadrp()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbuser where introleid=2", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "--Select--");
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        

        string s = DropDownList1.SelectedItem.Text;
        gd.DataSource = obj.searchpln(s);
        gd.DataBind();
  
    }
}