using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Subscriber_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ss"] == null)
        {
            DataTable ord = new DataTable("order");
            DataColumn c = new DataColumn();
            c.ColumnName = "intorderid";
            c.DataType = Type.GetType("System.Int32");
            ord.Columns.Add(c);
            ord.Columns.Add(new DataColumn("strorderpn", Type.GetType("System.String")));
            ord.Columns.Add(new DataColumn("intorderpqty", Type.GetType("System.Int32")));
            ord.Columns.Add(new DataColumn("intorderprc", Type.GetType("System.Int32")));
            ord.Columns.Add(new DataColumn("intorderamt", Type.GetType("System.Int32")));

            ord.Columns[4].Expression = "intorderprc*intorderpqty";
            Session["ss"] = ord;

        }
        if (!Page.IsPostBack)
        {
            String st;
            st = "select * from tbproduct where intprodid="+ Request.QueryString["intprodid"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter(st, ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataRowView r = ds.Tables[0].DefaultView[0];
            DataTable tb = (DataTable)(Session["ss"]);
            DataRow r1 = tb.NewRow();
            r1[0] = Convert.ToInt32(r["intprodid"]);
            r1[1] = r["strprodname"].ToString();
            r1[2] = 1;
            r1[3] = Convert.ToInt32(r["intprodprice"]);
            tb.Rows.Add(r1);

            Label1.Text = tb.Compute("sum(intorderamt)", "").ToString();

            gd.DataSource = tb;
            gd.DataBind();
            grdbnd();
        }


    }
    private void grdbnd()
    {
        DataTable tb = (DataTable)(Session["ss"]);

        Label1.Text = tb.Compute("sum(intorderamt)", "").ToString();
        gd.DataSource = tb;
        gd.DataBind();

    }


    protected void gd_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gd.EditIndex = e.NewEditIndex;
        grdbnd();
    }
    protected void gd_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gd.EditIndex = -1;
        grdbnd();
    }
    protected void gd_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DataTable tb = (DataTable)(Session["ss"]);
        tb.Rows[e.RowIndex][2] = Convert.ToInt32(((TextBox)(gd.Rows[e.RowIndex].Cells[2].Controls[0])).Text);

        gd.EditIndex = -1;
        grdbnd();
    }
    protected void gd_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable tb = (DataTable)(Session["ss"]);
        tb.Rows.RemoveAt(e.RowIndex);
        grdbnd();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //DataTable tb = (DataTable)(Session["ss"]);
        //String st1 = Server.MapPath("abc.xml");
        //tb.WriteXml(st1);
        //Label2.Text = st1.ToString();
        //SqlDataAdapter adp = new SqlDataAdapter("select orderid,orderpn,orderpqty,orderprc,orderamt from order",ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //SqlCommandBuilder cb = new SqlCommandBuilder(adp);
        //DataSet ds1 = new DataSet();
        //adp.Fill(ds1);
        //ds1.ReadXml(st1);
        //adp.Update(ds1);

    }
}