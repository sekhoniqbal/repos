using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using tUser;
public partial class Visitor_Default : System.Web.UI.Page
{
    clstuserfun obj = new clstuserfun();
    private string proid
    {
        get
        {
            if (Request.QueryString["proid"] != null)
            {
                return Request.QueryString["proid"] as string;
            }
            else
                return string.Empty;
        }

    }


    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        detail2();
        detail();
        if (!IsPostBack)
        {
            //detail();

            //Int32 ss;
            //ss = Convert.ToInt32(Request.QueryString["proid"]);
            //Label1.Text = proid;
        }
    }
    private void detail()
    {

        SqlCommand cmd = new SqlCommand("Proc_viewdetail", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Connection = con;
        cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = Convert.ToInt32(proid);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        Repeater1.DataSource = dr;
        Repeater1.DataBind();

        dr.Close();
        con.Close();
    }
    private void detail2()
    {

        SqlCommand cmd = new SqlCommand("Proc_viewdetail", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Connection = con;
        cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = Convert.ToInt32(proid);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        Repeater2.DataSource = ds;
        Repeater2.DataBind();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        string uid = Session["uid"].ToString();
        string name = Session["uname"].ToString();
        string uname = Session["ss"].ToString();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Proc_selprodcomment";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@intprodid", SqlDbType.Int).Value = Convert.ToInt32(proid);
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        string prodname = dr["strprodname"].ToString();
        string image = dr["strprodimage"].ToString();
        Int32 userid = Convert.ToInt32(dr["intuserid"]);
        dr.Close();

        obj.p_intprodid = Convert.ToInt32(proid);
        obj.p_strcommentdesc = TextBox1.Text;
        obj.p_posteddate = DateTime.Now.ToString();
        obj.p_strfirstname = name;
        obj.p_strusername = uname;
        obj.p_strprodimg = image;
        obj.p_strprodname = prodname;
        obj.p_intuserid = userid;
        obj.funcomment();
        TextBox1.Text = "";
    }

    
}