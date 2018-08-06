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
        if (Page.IsPostBack == false)
            datadrp();
        datagrd();
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
    private void datagrd()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbwebspace", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gd.DataSource = ds;
        gd.DataBind();

    }


    protected void btnsearch_Click(object sender, EventArgs e)
    {

        string s = DropDownList1.SelectedItem.Text;
        gd.DataSource = obj.searchspc(s);
        gd.DataBind();
    }

    protected void gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string i;
        i = e.Keys[0].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        SqlCommand cmd = new SqlCommand("delete from tbwebspace where strusername=@un", con);
        cmd.Parameters.Add("@un", SqlDbType.VarChar,50).Value = i;
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        datagrd();
        DropDownList1.SelectedIndex = 0;
    }
   
}