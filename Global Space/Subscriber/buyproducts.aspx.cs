using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Subscriber_Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            datadrp();
            datadrp2();
            pageb(1);
        }
        
        Label4.Text = "Page:  ";
    }
    private void datadrp()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcategory", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "--Select--");
    }
    private void datadrp2()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcatalog", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "--Select--");
    }
    private void pageb(Int32 pno)
    {
        Int32 nor, repcol;
        nor = Convert.ToInt32(DropDownList3.SelectedValue);
        if (nor <= 4)
        {
            repcol = nor;
        }
        else
        {
            repcol = Convert.ToInt32(nor / 2);
        }
        DataList1.RepeatColumns = repcol;


        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "paging";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@pagenumber", SqlDbType.Int).Value = pno;
        cmd.Parameters.Add("@pagesize", SqlDbType.Int).Value = nor;
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        Int32 tot = Convert.ToInt32(dr[0]);
        Label1.Text = pno.ToString();
        Label2.Text = "off";
        Label3.Text = Convert.ToInt32(tot / nor).ToString();
        if (dr.NextResult())
        {
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }

    }
    private void datalistbind()
    {

        string ctgy = DropDownList1.SelectedValue;
        string catalog = DropDownList2.SelectedValue;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "Proc_search";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@intcategoryid", SqlDbType.Int).Value = Convert.ToInt32(ctgy);
        cmd.Parameters.Add("@intcatalogid", SqlDbType.Int).Value = Convert.ToInt32(catalog);
        SqlDataReader dr = cmd.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        datalistbind();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        pageb(1);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        pageb(1);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        pageb(Convert.ToInt32(Label1.Text) + 1);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        pageb(Convert.ToInt32(Label1.Text) - 1);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        pageb(Convert.ToInt32(Label3.Text));
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i= Convert.ToInt32(DataList1.DataKeys[0]);

        Session["pid"] = i;
    }
    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        
    }

}