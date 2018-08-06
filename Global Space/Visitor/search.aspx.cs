using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Visitor_Default : System.Web.UI.Page
{
    //static int i = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        // datalistbind();
        //if (i == 0)
        //    Panel1.Visible = false;
        //else
        //    Panel1.Visible = true;

        if (Page.IsPostBack == false)
        {
            // Panel1.Visible = false;
            //datalistbind();
            categorybind();
            catalogbind();
             pageb(1);
            //if (i == 0)
            //    Panel1.Visible = false;
            //else
            //    Panel1.Visible = true;

        }

         Label4.Text = "Page:  ";
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

    private void categorybind()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        //con.Open();
        //SqlCommand cmd = new SqlCommand("selcategory", con);
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcategory", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DataRow dr = dt.NewRow();
        dr["strcategoryname"] = "[select category]";
        dr["intcategoryid"] = -1;
        dt.Rows.InsertAt(dr, 0);
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "strcategoryname";
        DropDownList1.DataValueField = "intcategoryid";
        DropDownList1.DataBind();
    }

    private void catalogbind()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //con.ConnectionString =      //con.Open();
        // SqlCommand cmd = new SqlCommand("selcategory", con);
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbcatalog", con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DataRow dr = dt.NewRow();
        dr["strcatalogname"] = "[select catalog]";
        dr["intcatalogid"] = -1;
        dt.Rows.InsertAt(dr, 0);
        DropDownList2.DataSource = dt;
        DropDownList2.DataTextField = "strcatalogname";
        DropDownList2.DataValueField = "intcatalogid";
        DropDownList2.DataBind();

    }


    //private void datalistbind()
    //{

    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
    //    SqlCommand cmd = new SqlCommand();

    //    //if (ctgy > 1001 || catalog > 2001)
    //{
    //    i = 1;
    //}
    //else
    //{
    //    i = 0;
    //}
    //SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);



    //SqlCommand cmd = new SqlCommand();
    //cmd.CommandText = "Proc_search";
    //cmd.CommandType = CommandType.StoredProcedure;
    //cmd.Connection = con;
    //Int32 ctgy = Convert.ToInt32(DropDownList1.SelectedValue);
    //Int32 catalog = Convert.ToInt32(DropDownList2.SelectedValue);
    //cmd.Parameters.Add("@intcategoryid", SqlDbType.Int).Value = ctgy;
    //cmd.Parameters.Add("@intcatalogid", SqlDbType.Int).Value = catalog;
    //con.Open();
    //SqlDataReader dr = cmd.ExecuteReader();

    //DataList1.DataSource = dr;
    //DataList1.DataBind();


    // }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);



        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Proc_search";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        Int32 ctgy = Convert.ToInt32(DropDownList1.SelectedValue);
        Int32 catalog = Convert.ToInt32(DropDownList2.SelectedValue);
        cmd.Parameters.Add("@intcategoryid", SqlDbType.Int).Value = ctgy;
        cmd.Parameters.Add("@intcatalogid", SqlDbType.Int).Value = catalog;
        //if (ctgy > 1|| catalog > 10)
        //{
        //    Panel1.Visible = true;
        //}
        //else
        //{
        //    Panel1.Visible = false;
        //}
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);


        DataList1.DataSource = ds;
        DataList1.DataBind();

        // datalistbind();
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
}