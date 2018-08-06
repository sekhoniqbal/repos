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
using System.Data.SqlClient;

namespace tadmin
{
    public class clstadmin
    {
        private int intadvid;
        private int intcatlid;
        private int intcatgid;
        private string strcatalogname;
        private string strcategoryname;
        private string strproductname;
        private string strimage;
        private string strlocation;
        private string strusername;
        private string stroldpassword;
        private string strnewpassword;
        private int intprice;
        private int duration;
        private string strplanname;
        private int intprodcount;
        private DateTime stdate;
        private DateTime endate;


        public int p_intadvid
        {
            get
            {
                return intadvid;
            }
            set
            {
                intadvid = value;
            }
        }
        public string p_strcategoryname
        {
            get
            {
                return strcategoryname;
            }
            set
            {
                strcategoryname = value;
            }
        }
        public string p_strcatalogname
        {
            get
            {
                return strcatalogname;
            }
            set
            {
                strcatalogname = value;
            }
        }
        public int p_intcatlid
        {
            get
            {
                return intcatlid;
            }
            set
            {
                intcatlid = value;
            }
        }
        public int p_intcatgid
        {
            get
            {
                return intcatgid;
            }
            set
            {
                intcatgid = value;
            }
        }
        public string p_strproductname
        {
            get
            {
                return strproductname;
            }
            set
            {
                strproductname = value;
            }
        }
        public string p_strimage
        {
            get
            {
                return strimage;
            }
            set
            {
                strimage = value;
            }
        }
        public string p_strlocation
        {
            get
            {
                return strlocation;
            }
            set
            {
                strlocation = value;
            }
        }

        public string p_strusername
        {
            get
            {
                return strusername;
            }
            set
            {
                strusername = value;
            }
        }

        public string p_stroldpassword
        {
            get
            {
                return stroldpassword;
            }
            set
            {
                stroldpassword = value;
            }
        }

        public string p_strnewpassword
        {
            get
            {
                return strnewpassword;
            }
            set
            {
                strnewpassword = value;
            }
        }

        public int p_intprice
        {
            get
            {
                return intprice;
            }
            set
            {
                intprice = value;
            }
        }

        public int p_intduration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        public DateTime p_stdate
        {
            get
            {
                return stdate;
            }
            set
            {
                stdate = value;
            }
        }
        public DateTime p_endate
        {
            get
            {
                return endate;
            }
            set
            {
                endate = value;
            }
        }
        public string p_planname
        {
            get
            {
                return strplanname;
            }
            set
            {
                strplanname = value;
            }
        }
        public int p_prodcount
        {
            get
            {
                return intprodcount;
            }
            set
            {
               intprodcount = value;
            }
        }


    }

    public class clstadminfun : clstadmin
    {
        public void addadv()
        {
            SqlParameter[] array = new SqlParameter[5];

            array[0] = new SqlParameter("@intadvid", p_intadvid);
            array[1] = new SqlParameter("@strcategoryname", p_strcategoryname);
            array[2] = new SqlParameter("@strproductname", p_strproductname);
            array[3] = new SqlParameter("@strimage", p_strimage);
            array[4] = new SqlParameter("@strlocation", p_strlocation);

            AppLib.ExecuteNonQueryBySP("Proc_insadv", array);
        }

        public void updadv()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@strproductname", p_strproductname);
            array[1] = new SqlParameter("@strlocation", p_strlocation);

            AppLib.ExecuteNonQueryBySP("Proc_updadv", array);
        }
        public SqlDataReader searchadv(string strcat)
        {
            SqlParameter[] array = new SqlParameter[1];
            array[0] = new SqlParameter("@strcat", strcat);
            SqlDataReader dr;
            dr = AppLib.GetSqlDataReaderBySP("Proc_searchadv", array);
            return dr;
        }

        public int chkpwdadv()
        {
            SqlParameter[] array = new SqlParameter[3];

            array[0] = new SqlParameter("@uname", p_strusername);
            array[1] = new SqlParameter("@opwd", p_stroldpassword);
            array[2] = new SqlParameter("@npwd", p_strnewpassword);
           return AppLib.ExecuteScalar("Proc_changepassword", array);
  
        }
        public SqlDataReader searchcmt(string strusn)
        {
            SqlParameter[] array = new SqlParameter[1];
            array[0] = new SqlParameter("@strusn", strusn);
            SqlDataReader dr;
            dr = AppLib.GetSqlDataReaderBySP("Proc_searchcmt", array);
            return dr;
        }

        public SqlDataReader searchspc(string strusn)
        {
            SqlParameter[] array = new SqlParameter[1];
            array[0] = new SqlParameter("@strusn", strusn);
            SqlDataReader dr;
            dr = AppLib.GetSqlDataReaderBySP("Proc_searchspc", array);
            return dr;
        }
        public SqlDataReader searchpln(string strusn)
        {
            SqlParameter[] array = new SqlParameter[1];
            array[0] = new SqlParameter("@strusn", strusn);
            SqlDataReader dr;
            dr = AppLib.GetSqlDataReaderBySP("Proc_searchpln", array);
            return dr;
        }

        public void addcatl()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@intcatalogid", p_intcatlid);
            array[1] = new SqlParameter("@strcatalogname", p_strcatalogname);
        
            AppLib.ExecuteNonQueryBySP("Proc_inscatl", array);
        }

        public void updcatl()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@intcatalogid", p_intcatlid);
            array[1] = new SqlParameter("@strcatalogname", p_strcatalogname);

            AppLib.ExecuteNonQueryBySP("Proc_updcatl", array);
        }
        public void addcatg()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@intcategoryid", p_intcatgid);
            array[1] = new SqlParameter("@strcategoryname", p_strcategoryname);

            AppLib.ExecuteNonQueryBySP("Proc_inscatl", array);
        }

        public void updcatg()
        {
            SqlParameter[] array = new SqlParameter[2];

            array[0] = new SqlParameter("@intcategoryid", p_intcatgid);
            array[1] = new SqlParameter("@strcategoryname", p_strcategoryname);

            AppLib.ExecuteNonQueryBySP("Proc_updcat", array);
        }

        
    }
}





