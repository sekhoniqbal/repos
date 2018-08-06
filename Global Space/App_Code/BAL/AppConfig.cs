using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for AppConfig
/// </summary>
public class AppConfig
{
	public AppConfig()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }

    public static string GetSMTPserver()
    {
        return ConfigurationManager.AppSettings["strSMTPIP"].ToString();
    }

    public static string GetBaseSiteUrl()
    {
        return ConfigurationManager.AppSettings["strBaseSiteUrl"].ToString();
    }
}
