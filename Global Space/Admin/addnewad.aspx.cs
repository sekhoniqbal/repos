using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tadmin;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Default : System.Web.UI.Page
{
     clstadminfun obj  = new clstadminfun();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        datadrp();
    }
    protected void butsave_Click(object sender, EventArgs e)
    {
        obj.p_strcategoryname= drp.SelectedItem.Text;
        obj.p_strproductname = drp2.SelectedItem.Text;
        obj.p_strlocation= rdloc.SelectedValue;
        obj.p_strimage = img.ImageUrl;
        obj.addadv();
    }
    protected void drp_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbproduct where intcategoryid="+drp.SelectedValue ,ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        drp2.DataSource = ds;
        drp2.DataBind();
        drp2.Items.Insert(0, "--select product--");
    }

    private void datadrp()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcategory", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        drp.DataSource = ds;
        drp.DataBind();
        drp.Items.Insert(0,"--select category--");
    }
   
    protected void drp2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select strprodimage from tbproduct where intprodid="+ Convert.ToInt32(drp2.SelectedValue), ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        img.ImageUrl = ds.Tables[0].Rows[0][0].ToString();
       // ltimg.DataBind();
        
    }
    protected void butcancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("manageadv.aspx");
    }
}