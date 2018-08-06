///***********************************************************
///Author Name: Punamdeep Kaur 
///Creation Date: 16th September, 2009
///File Name: AppLib.cs			             Component Used: 
///Called From: All business layer classes
///Description: Configurartion File  
///Tables Accessed: N/A
///Program specs: Optima
///UTP doc:
///Tested By:
///***********************************************************************
///Modification History:
///Change No.   Changed By	Date	Version	Raised By/SRS No	Description 
///***********************************************************************




#region "Directives"
using System;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Net;

using System.IO;
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Collections;
using System.Text;
using System.Security.Cryptography;
//using WebSupergoo.ABCpdf7;
#endregion

/// <summary>   
/// Class Name:AppLib.cs
/// Functionality:AppLib.cs file consists of all the standard procedures to bind the 
/// controls i.e. the dropdown lists etc and the procedures that return the dataset 
/// or datatable after passing the procedure name and sqlparameters as parameter.
/// Note: 
public class AppLib
{
    /// <summary>
    /// Private, Protected and public variables
    /// </summary>

    #region "Variables"

    private static string str_LiveURL;

    #endregion

    /// <summary>
    /// Public Properties
    /// </summary>
    
    #region Public Properties
    public static string LiveURL
    {
        get { return HttpContext.Current.Request.ApplicationPath; }


    }
    #endregion


    /// <summary>
    /// Constructor
    /// </summary>

    #region "Constructor"
    public AppLib()
    {


    }
    #endregion

    /// <summary>
    /// To bind DropDownList with static numbers.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="intMinNumber">Minimum Number</param>
    /// <param name="intMaxNumber">Maximum Number</param>
    /// <param name="intDifference">Number to be incremented with.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>

    #region "BindDropDownListWithStaticNumbers"
    public static void BindDropDownListWithStaticNumbers(ref DropDownList ddlDropDownListNameToBind, int iMinNumber, int iMaxNumber, int iDifference, string strInitialText)
    {
        try
        {
            int icounter;
            int iIndex = 0;
            if (!(strInitialText == ""))
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                ddlDropDownListNameToBind.Items.Insert(iIndex, lstInitialItem);
                iIndex = 1;
            }
            icounter = iMinNumber;
            while (icounter <= iMaxNumber)
            {
                ListItem lstItem = new ListItem(Convert.ToString(icounter), Convert.ToString(icounter));
                ddlDropDownListNameToBind.Items.Insert(iIndex, lstItem);
                icounter = icounter + iDifference;
                System.Math.Min(System.Threading.Interlocked.Increment(ref iIndex), iIndex - 1);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// To bind DropDownList with static numbers for top records.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="intMinNumber">Minimum Number</param>
    /// <param name="intMaxNumber">Maximum Number</param>
    /// <param name="intDifference">Number to be incremented with.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>

    #region "BindDropDownListWithStaticNumbersForTopRecords"
    public static void BindDropDownListWithStaticNumbersForTopRecords(ref DropDownList ddlDropDownListNameToBind, int i32MinNumber, int i32MaxNumber, int i32Difference, string strInitialText)
    {

        try
        {
            int i32Counter;
            int i32Index = 0;
            if (!(strInitialText == ""))
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                ddlDropDownListNameToBind.Items.Insert(i32Index, lstInitialItem);
                i32Index = 1;
            }
            i32Counter = i32MinNumber;
            while (i32Counter <= i32MaxNumber)
            {
                ListItem lstItem = new ListItem(Convert.ToString(i32Counter), Convert.ToString(i32Counter));
                ddlDropDownListNameToBind.Items.Insert(i32Index, lstItem);
                i32Counter = i32Counter + i32Difference;
                System.Math.Min(System.Threading.Interlocked.Increment(ref i32Index), i32Index - 1);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// To Bind DropDownList with database query.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="strQuery">Query to ger data</param>
    /// <param name="strInitialText">Intitial Text</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>

    #region "BindDropDownListWithDatabaseQuery"
    public static void BindDropDownListWithDatabaseQuery(ref DropDownList ddlDropDownListNameToBind, string strQuery, string strInitialText, string strDataTextField, string strDataValueField)
    {
        try
        {
            SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.Text, strQuery);
            ddlDropDownListNameToBind.DataTextField = strDataTextField;
            ddlDropDownListNameToBind.DataValueField = strDataValueField;
            ddlDropDownListNameToBind.DataSource = drReader;
            ddlDropDownListNameToBind.DataBind();
            drReader.Close();
            drReader.Dispose();
            if (strInitialText.Trim() != "")
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /*Sub Header***********************************************************
    Function Name: BindDropDownList
    Functionality: This function will bind Dropdown list with the values returned by the datatable.
    Input: DropDownList,string,string,string,DataTable
    Output: 
    Note: Any Special comment
    *********************************************************************/   
    #region "BindDropDownList"
   
    public static void BindDropDownList(ref DropDownList ddlDropDownListNameToBind, string strInitialText, string strDataTextField, string strDataValueField, DataTable dsDataSetName)
    {
        ddlDropDownListNameToBind.DataTextField = strDataTextField;
        ddlDropDownListNameToBind.DataValueField = strDataValueField;
        ddlDropDownListNameToBind.DataSource = dsDataSetName;
        ddlDropDownListNameToBind.DataBind();

        if (strInitialText.Trim() != "")
        {
            ListItem lstInitialItem = new ListItem(strInitialText, "-1");
            ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
        }
    }
    #endregion

    /*Sub Header***********************************************************
    Function Name: BindDropDownList
    Functionality: This function will bind Dropdown list with the values returned by the dataset.
    Input: DropDownList,string,string,string,dataset
    Output: 
    Note: Any Special comment
    *********************************************************************/
    #region "BindDropDownList"

    public static void BindDropDownListWithDataSet(ref DropDownList ddlDropDownListNameToBind, string strInitialText, string strDataTextField, string strDataValueField, DataSet dsDataSetName)
    {
        ddlDropDownListNameToBind.DataTextField = strDataTextField;
        ddlDropDownListNameToBind.DataValueField = strDataValueField;
        ddlDropDownListNameToBind.DataSource = dsDataSetName;
        ddlDropDownListNameToBind.DataBind();

        if (strInitialText.Trim() != "")
        {
            ListItem lstInitialItem = new ListItem(strInitialText, "-1");
            ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
        }
    }
    #endregion


    /*Sub Header***********************************************************
    Function Name: BindDropDownList
    Functionality: This function will bind Dropdown list with the values returned by the datatable.
    Input: DropDownList,string,string,string,DataTable
    Output: 
    Note: Any Special comment
    *********************************************************************/
    #region "BindDropDownListWithoutInitialText"

    public static void BindDropDownListWithoutInitialText(ref DropDownList ddlDropDownListNameToBind,string strDataTextField, string strDataValueField, DataTable dsDataSetName)
    {
        ddlDropDownListNameToBind.DataTextField = strDataTextField;
        ddlDropDownListNameToBind.DataValueField = strDataValueField;
        ddlDropDownListNameToBind.DataSource = dsDataSetName;
        ddlDropDownListNameToBind.DataBind();
        
    }
    #endregion
    
    /// <summary>
    /// Return single integer value by executing stored proc with parameters
    /// </summary>
    /// <param name="ProcName">Name of the stored procedure</param>
    /// <param name="arrParam">array of Sql parameters</param>

    #region ExecuteScalar
    public static int ExecuteScalar(string ProcName, SqlParameter[] arrParam)
    {
        int Result;
        try
        {
            Result = Convert.ToInt32(SqlHelper.ExecuteScalar(AppConfig.GetConnectionString(), CommandType.StoredProcedure, ProcName, arrParam));
        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return Result;
    }
    #endregion


    /// <summary>
    /// Return single decimal value by executing stored proc with parameters
    /// </summary>
    /// <param name="ProcName">Name of the stored procedure</param>
    /// <param name="arrParam">array of Sql parameters</param>
     
    #region ExecuteScalarDec
    public static decimal ExecuteScalarDec(string ProcName, SqlParameter[] arrParam)
    {
        decimal Result;
        try
        {
            Result = Convert.ToDecimal(SqlHelper.ExecuteScalar(AppConfig.GetConnectionString(), CommandType.StoredProcedure, ProcName, arrParam));
        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return Result;
    }
    #endregion

    /// <summary>
    /// Return single string value by executing stored proc with parameters
    /// </summary>
    /// <param name="ProcName">Name of the stored procedure</param>
    /// <param name="arrParam">array of Sql parameters</param>

    #region ExecuteScalarString
    public static string ExecuteScalarString(string ProcName, SqlParameter[] arrParam)
    {
        string Result;
        try
        {
            Result = Convert.ToString(SqlHelper.ExecuteScalar(AppConfig.GetConnectionString(), CommandType.StoredProcedure, ProcName, arrParam));
        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return Result;
    }
    #endregion

    /// <summary>
    /// To Bind DropDownList with data retrieved from database stored procedure.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="strProcedureName">Name of the stored procedure to be executed.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>
    /// <param name="arrParam">Parameters to be passed to stored procedure.</param>

    #region "BindDropDownListWithDatabaseSP
    public static void BindDropDownListWithDatabaseSP(ref DropDownList ddlDropDownListNameToBind, string strProcedureName, string strInitialText, string strDataTextField, string strDataValueField, SqlParameter[] arrParam)
    {
        try
        {
            SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);
            ddlDropDownListNameToBind.DataTextField = strDataTextField;
            ddlDropDownListNameToBind.DataValueField = strDataValueField;
            ddlDropDownListNameToBind.DataSource = drReader;
            ddlDropDownListNameToBind.DataBind();
            drReader.Close();
            drReader.Dispose();
            if (strInitialText.Trim() != "")
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// To Bind DropDownList with data retrieved from database stored procedure and with initial value passed.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="strProcedureName">Name of the stored procedure to be executed.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>
    /// <param name="arrParam">Parameters to be passed to stored procedure.</param>
    /// <param name="iValue">Initial Value</param>

    #region "BindDropDownListWithDatabaseSPwithivalue
    public static void BindDropDownListWithDatabaseSPwihivalue(ref DropDownList ddlDropDownListNameToBind, string strProcedureName, string strInitialText, string strDataTextField, string strDataValueField, SqlParameter[] arrParam, string iValue)
    {
        try
        {
            SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);
            ddlDropDownListNameToBind.DataTextField = strDataTextField;
            ddlDropDownListNameToBind.DataValueField = strDataValueField;
            ddlDropDownListNameToBind.DataSource = drReader;
            ddlDropDownListNameToBind.DataBind();
            drReader.Close();
            drReader.Dispose();
            if (strInitialText.Trim() != "")
            {
                ListItem lstInitialItem = new ListItem(strInitialText, iValue);
                ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// To Bind ListBox with data retrieved from database stored procedure.
    /// </summary>
    /// <param name="lstListBoxNameToBind">Reference of the ListBox to bind.</param>
    /// <param name="strProcedureName">Name of the stored procedure to be executed.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>
    /// <param name="arrParam">Parameters to be passed to stored procedure.</param>

    #region "BindListBoxWithDatabaseSP"
    public static void BindListBoxWithDatabaseSP(ref ListBox lstListBoxNameToBind, string strProcedureName, string strInitialText, string strDataTextField, string strDataValueField, SqlParameter[] arrParam)
    {
        try
        {
            SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);
            lstListBoxNameToBind.DataTextField = strDataTextField;
            lstListBoxNameToBind.DataValueField = strDataValueField;
            lstListBoxNameToBind.DataSource = drReader;
            lstListBoxNameToBind.DataBind();
            drReader.Close();
            drReader.Dispose();
            if (strInitialText.Trim() != "")
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                lstListBoxNameToBind.Items.Insert(0, lstInitialItem);
            }
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion


    /// <summary>
    /// To Bind ListBox
    /// </summary>
    /// <param name="lstListBoxNameToBind">Reference of the ListBox to bind.</param>    
    /// <param name="strInitialText">Intial text like ---Select---</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>
    /// <param name="drReader">SqlDataReader</param>

    #region "BindListBox"
    public static void BindListBox(ref ListBox lstListBoxNameToBind, string strInitialText, string strDataTextField, string strDataValueField, DataTable dt)
    {
        try
        {
            if (dt != null)
            {
                //SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);
                lstListBoxNameToBind.DataTextField = strDataTextField;
                lstListBoxNameToBind.DataValueField = strDataValueField;
                lstListBoxNameToBind.DataSource = dt;
                lstListBoxNameToBind.DataBind();
                dt.Dispose();
                if (strInitialText.Trim() != "")
                {
                    ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                    lstListBoxNameToBind.Items.Insert(0, lstInitialItem);
                }
            }

        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// To Bind CheckboxList with data retrieved from database stored procedure.
    /// </summary>
    /// <param name="cblCheckboxListNameToBind">Reference of the CheckBoxlist to bind.</param>   
    /// <param name="strDataTextField">DataText field for CheckBoxlist</param>
    /// <param name="strDataValueField">DataValue field for CheckBoxlist</param>
    /// <param name="dsDataSetName">Dataset</param>
    

   #region "BindCheckBoxList"
   
    public static void BindCheckboxList(ref CheckBoxList cblCheckboxListNameToBind, string strDataTextField, string strDataValueField, DataTable dsDataSetName)
    {
        cblCheckboxListNameToBind.DataTextField = strDataTextField;
        cblCheckboxListNameToBind.DataValueField = strDataValueField;
        cblCheckboxListNameToBind.DataSource = dsDataSetName;
        cblCheckboxListNameToBind.DataBind();
    }
    #endregion

    /// <summary>
    /// To Bind DropDownList with data retrieved from database stored procedure with no parameters.
    /// </summary>
    /// <param name="ddlDropDownListNameToBind">Reference of the DropDownList to bind.</param>
    /// <param name="strProcedureName">Name of the stored procedure to be executed.</param>
    /// <param name="strInitialText">Intial text like ---Select---</param>
    /// <param name="strDataTextField">DataText field for DropDownList</param>
    /// <param name="strDataValueField">DataValue field for DropDownList</param>

    #region "BindDropDownListWithDatabaseSPNoParam"
    public static void BindDropDownListWithDatabaseSPNoParam(ref DropDownList ddlDropDownListNameToBind, string strProcedureName, string strInitialText, string strDataTextField, string strDataValueField)
    {
        try
        {
            SqlDataReader drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName);
            ddlDropDownListNameToBind.DataTextField = strDataTextField;
            ddlDropDownListNameToBind.DataValueField = strDataValueField;
            ddlDropDownListNameToBind.DataSource = drReader;
            ddlDropDownListNameToBind.DataBind();
            drReader.Close();
            drReader.Dispose();
            if (strInitialText.Trim() != "")
            {
                ListItem lstInitialItem = new ListItem(strInitialText, "-1");
                ddlDropDownListNameToBind.Items.Insert(0, lstInitialItem);
            }
        }

        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// Procedure to get website URL
    /// </summary>
    /// <returns>Website URL</returns>

    #region "GetBaseSiteUrl"
    public static string GetBaseSiteUrl()
    {
        return System.Configuration.ConfigurationManager.AppSettings["SitePath"].ToString();
    }
    #endregion

    /// <summary>
    /// Procedure to get SqlDataReader by query
    /// </summary>
    /// <param name="sQuery">Database query</param>
    /// <returns>SqlDataReader returned by query</returns>

    #region "GetDataReaderByQuery"
    public static SqlDataReader GetDataReaderByQuery(string sQuery)
    {

        SqlDataReader drReader;
        try
        {

            drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.Text, sQuery);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return drReader;
    }
    #endregion

    /// <summary>
    /// Procedure to get DataTable by query
    /// </summary>
    /// <param name="sQuery">Database query</param>
    /// <returns>DataTable returned by query</returns>

    #region "GetDataTableByQuery"
    public static DataTable GetDataTableByQuery(string sQuery)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.Text, sQuery);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return dsData.Tables[0];
    }
    #endregion

    /// <summary>
    /// Procedure to get execute query
    /// </summary>
    /// <param name="sQuery">Database query</param>

    #region "ExecuteNonQuery"
    public static void ExecuteByQuery(string sQuery)
    {
        try
        {

            SqlHelper.ExecuteNonQuery(AppConfig.GetConnectionString(), CommandType.Text, sQuery);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }

    }
    #endregion

    /// <summary>
    /// Procedure to get DataTable by stored procedure
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <returns>DataTable returned by stored procedure</returns>

    #region "GetDataTableBySP"
    public static DataTable GetDataTableBySP(string strProcedureName)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return dsData.Tables[0];
    }
    #endregion

    /// <summary>
    /// Procedure to get SqlDataReader by stored procedure with parameters.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>
    /// <returns>SqlDataReader returned by stored procedure</returns>

    #region "GetDataReaderBySP and parameter"
    public static SqlDataReader GetSqlDataReaderBySP(string strProcedureName, SqlParameter[] arrParam)
    {
        SqlDataReader drReader;
        try
        {

            drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);

        }
        catch (SqlException Ex)
        {

            throw Ex;
        }
        return drReader;
    }
    #endregion



    /// <summary>
    /// Procedure to get SqlDataReader by stored procedure without parameters.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <returns>SqlDataReader returned by stored procedure</returns>

    #region "GetDataReaderBySP and no parameter"
    public static SqlDataReader GetSqlDataReaderBySPNoParam(string strProcedureName)
    {
        SqlDataReader drReader;
        try
        {

            drReader = SqlHelper.ExecuteReader(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName);

        }
        catch (SqlException Ex)
        {

            throw Ex;
        }
        return drReader;
    }
    #endregion



    /// <summary>
    /// Procedure to get datatable by stored procedure with parameters.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>
    /// <returns>DataTable returned by stored procedure</returns>

    #region "GetDataTableBySP and parameter"
    public static DataTable GetDataTableBySP(string strProcedureName, SqlParameter[] arrParam)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);

        }
        catch (SqlException Ex)
        {

            throw Ex;
        }
        return dsData.Tables[0];
    }
    #endregion

    /// <summary>
    /// Procedure to get datatable by stored procedure with parameters.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>
    /// <returns>DataTable returned by stored procedure</returns>

    #region "GetDataSetBySP and parameter"
    public static DataSet GetDataSetBySP(string strProcedureName, SqlParameter[] arrParam)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);

        }
        catch (SqlException Ex)
        {

            throw Ex;
        }
        return dsData;
    }
    #endregion


    /// <summary>
    /// Procedure to get dataset by stored procedure without parameters.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <returns>DataSet returned by stored procedure</returns>

    #region "GetDataSetBySP and without parameter"
    public static DataSet GetDataSetBySPNoParam(string strProcedureName)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName);

        }
        catch (SqlException Ex)
        {

            throw Ex;
        }
        return dsData;
    }
    #endregion


    /// <summary>
    /// Procedure to get datatable by stored procedure with parameters with a serial number column added to the datatable.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>
    /// <returns>DataTable returned by stored procedure</returns>

    #region "Get DataTable with Serial Number"
    public static DataTable GetDataTableWithSno(string strProcedureName, SqlParameter[] arrParam)
    {
        DataSet dsData = new DataSet();
        try
        {

            dsData = SqlHelper.ExecuteDataset(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);
            //return ds.Tables[0];

            DataColumn dtCol;
            // Create column and add to the DataTable.
            dtCol = new DataColumn();
            dtCol.DataType = System.Type.GetType("System.Int32");
            dtCol.ColumnName = "SRN";
            dtCol.Caption = "SRN";
            // Add the column to the DataColumnCollection.
            dsData.Tables[0].Columns.Add(dtCol);
            //ADD incremented value in rows
            int intIncrement = 0;
            for (intIncrement = 0; intIncrement < dsData.Tables[0].Rows.Count; intIncrement++)
            {
                dsData.Tables[0].Rows[intIncrement][Convert.ToInt32(dsData.Tables[0].Columns.Count) - 1] = intIncrement + 1;
            }


        }
        catch (SqlException Ex)
        {
            throw Ex;
        }
        return dsData.Tables[0];
    }
    #endregion


    /// <summary>
    /// Procedure to get string returned by a stored procedure.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>
    /// <returns>String value returned by stored procedure</returns>

    #region "GetValueBySP and parameter and return an string"
    public static string GetValueBySP(string strProcedureName, SqlParameter[] arrParam)
    {

        try
        {

            return Convert.ToString(SqlHelper.ExecuteScalar(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam));

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }

    }
    #endregion

    /// <summary>
    /// Procedure to execute non-query.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>
    /// <param name="arrParam">Array of parameters</param>

    #region "ExecuteNonQuery"
    public static void ExecuteNonQueryBySP(string strProcedureName, SqlParameter[] arrParam)
    {

        try
        {

            SqlHelper.ExecuteNonQuery(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName, arrParam);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }

    }
    #endregion

    /// <summary>
    /// Procedure to execute non-queryno param.
    /// </summary>
    /// <param name="strProcedureName">Stored procedure name</param>    

    #region "ExecuteNonQuery"
    public static void ExecuteNonQueryBySPNoParam(string strProcedureName)
    {

        try
        {

            SqlHelper.ExecuteNonQuery(AppConfig.GetConnectionString(), CommandType.StoredProcedure, strProcedureName);

        }
        catch (SqlException Ex)
        {
            throw Ex;
        }

    }
    #endregion

    /// <summary>
    /// Procedure to get email template content.
    /// </summary>
    /// <param name="templateName">Name of the template</param>
    /// <returns>String consisting of email content.</returns>

    #region "GetEmailContent"
    public static string GetEmailContent(string templateName)
    {
        StreamReader strReader;
        try
        {
            strReader = File.OpenText(HttpContext.Current.Server.MapPath("../Include/") + templateName);
        }
        catch (Exception ex)
        {
            throw ex;
            //strReader = File.OpenText(HttpContext.Current.Server.MapPath("Include/") + templateName);
        }
        string mailContent = strReader.ReadToEnd();
        strReader.DiscardBufferedData();
        strReader.Close();
        return mailContent;
    }
    #endregion

    /// <summary>
    /// Procedure to send mail to a single receipent or in bulk.
    /// </summary>
    /// <param name="mailTo">Email address of receipent</param>
    /// <param name="emailSubject">Email subject</param>
    /// <param name="emailBody">Email body</param>
    /// <param name="mailFrom">Email Address of sender</param>

    #region "SendMailToUser"
    public static bool SendMailToUser(String mailTo, String emailSubject, String emailBody, String mailFrom)
    {
        try
        {
            SmtpClient SmtpMail = new SmtpClient();
            MailMessage myMail = new MailMessage();
            System.Text.Encoding myEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            myMail.SubjectEncoding = myEncoding;
            myMail.BodyEncoding = myEncoding;
            myMail.From = new MailAddress(mailFrom);
            myMail.To.Add(mailTo.ToString());
            myMail.Subject = emailSubject;
            myMail.Priority = MailPriority.High;
            myMail.IsBodyHtml = true;
            myMail.Body = emailBody;          
            SmtpMail.Host = AppConfig.GetSMTPserver();
            SmtpMail.Port = 25;
            SmtpMail.UseDefaultCredentials = true;
            //SmtpMail.Credentials = new NetworkCredential(AppConfig.GetSMTPUsername(), AppConfig.GetSMTPPassword());
            SmtpMail.Send(myMail);
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }
       
    }
    #endregion


    /// <summary>
    /// Method to send mail from Mail Server
    /// </summary>
    /// <param name="body">body of the email.</param>
    /// <param name="toadd">String address on which mail has to be sent.</param>
    /// <param name="fromadd">String address from which mail has been sent.</param>
    /// <param name="subject">String subject for mail.</param>
    /// <param name="attachment">String attachment path.</param>
    /// <returns>boolean in case success/failure.</returns>
    
    #region SendMail
    public static bool SendMail(string body, string toadd, string fromadd, string subject, string attachment)
    {
        string mailServerName = AppConfig.GetSMTPserver();
        try
        {
            //MailMessage represents the e-mail being sent
            using (MailMessage message = new MailMessage(fromadd, toadd, subject, body))
            {
                if (attachment != "")
                {
                    message.Attachments.Add(new Attachment(attachment));
                }
                
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                SmtpClient mailClient = new SmtpClient();
                mailClient.Host = mailServerName;
                mailClient.UseDefaultCredentials = true;
                mailClient.Send(message);

            }
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        //catch (Exception ex)
        //{

        //    return ex;
        //}
    }
    #endregion


    /// <summary>
    /// Procedure to send mail to a single receipent or in bulk.
    /// </summary>
    /// <param name="mailTo">Email address of receipent</param>
    /// <param name="emailSubject">Email subject</param>
    /// <param name="emailBody">Email body</param>
    /// <param name="mailFrom">Email Address of sender</param>
    /// <param name="CCMailTo">Email Address of Carbon Copy</param>
    
    #region "SendMailToUser"
    public static bool SendMailToUser(string mailTo, string emailSubject, string emailBody,
        string mailFrom, string CCMailTo)
    {
        try
        {
            SmtpClient SmtpMail = new SmtpClient();
            MailMessage myMail = new MailMessage();
            System.Text.Encoding myEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            myMail.SubjectEncoding = myEncoding;
            myMail.BodyEncoding = myEncoding;
            myMail.From = new MailAddress(mailFrom);
            myMail.To.Add(mailTo.ToString());
            if (CCMailTo != string.Empty)
            myMail.CC.Add(new MailAddress(CCMailTo));           
            myMail.Subject = emailSubject;
            myMail.Priority = MailPriority.High;
            myMail.IsBodyHtml = true;
        
            myMail.Body = emailBody;
            SmtpMail.Host = AppConfig.GetSMTPserver();
            SmtpMail.Port = 25;
            SmtpMail.Send(myMail);
            return true;
        }
        catch (SmtpException ex)
        {

            throw ex;
        }
        //catch (Exception ex)
        //{

        //    return ex;
        //}
    }
    #endregion


    /// <summary>
    /// Procedure to get theme based on current browser
    /// </summary>
    /// <param name="Browser">Name of browser</param>
    /// <returns>Theme</returns>

    #region "GetBrowserBasedTheme"
    public static string GetBrowserBasedTheme(string Browser)
    {
        if (Browser == "firefox" | Browser == "mozilla")
        {
            return "StudentThemeMozilla";
        }
        else if (Browser != "ie")
        {
            return "StudentThemeIE";
        }
        else
        {
            return "StudentThemeIE";
        }
    }

    #endregion

    /// <summary>
    /// Procedure to send mail to a single receipent or in bulk with attachment.
    /// </summary>
    /// <param name="mailTo">Email address of receipent</param>
    /// <param name="emailSubject">Email subject</param>
    /// <param name="emailBody">Email body</param>
    /// <param name="mailFrom">Email Address of sender</param>
    /// <param name="CCMailTo">Email Address of Carbon Copy</param>
    /// <param name="BCCMailTo">Email Address of Blind Carbon Copy</param>

    #region "SendMailToUser"
    public static bool SendMailToUser(string mailTo, string emailSubject, string emailBody,
        string mailFrom, string CCMailTo, string BCCMailTo, string strAttatchPath)
    {
        try
        {
            SmtpClient SmtpMail = new SmtpClient();
            MailMessage myMail = new MailMessage();
            System.Text.Encoding myEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            myMail.SubjectEncoding = myEncoding;
            myMail.BodyEncoding = myEncoding;
            myMail.From = new MailAddress(mailFrom);
            myMail.To.Add(mailTo.ToString());
            if (CCMailTo != string.Empty)
                myMail.CC.Add(new MailAddress(CCMailTo));
            if (BCCMailTo != string.Empty)
                myMail.Bcc.Add(new MailAddress(BCCMailTo));
            myMail.Subject = emailSubject;
            myMail.Priority = MailPriority.High;
            myMail.IsBodyHtml = true;
            myMail.Body = emailBody;

            myMail.Attachments.Add(new Attachment(strAttatchPath));
            SmtpMail.Host = AppConfig.GetSMTPserver();
            SmtpMail.Port = 25;
            SmtpMail.Send(myMail);
            return true;
        }
        catch (Exception ex)
        {

            throw ex;
        }
        //catch (Exception ex)
        //{

        //    return ex;
        //}
    }
    #endregion




    /// <summary>
    /// Procedure to check whether the variable passed is of decimal type  or not. 
    /// </summary>
    /// <param name="strValue">Parameter to be checked</param>
    /// <param name="isEmptyAllowed">Parameter for is the blank variable allowed</param>
    /// <returns>True/False</returns>

    #region "isDecimal"
    public static bool isDecimal(string strValue, bool boolIsEmptyAllowed)
    {
        if (strValue.ToString().Trim() == "")
        {
            return boolIsEmptyAllowed;
        }
        else
        {
            try
            {
                Convert.ToDecimal(strValue);
            }
            catch
            {
                return false;
            }
        }
        return true;
    }
    #endregion

    /// <summary>
    /// Procedure to check whether the variable passed is of Int32 type  or not. 
    /// </summary>
    /// <param name="strValue">Parameter to be checked</param>
    /// <returns>True/False</returns>

    #region "isInt32"
    public static bool isInt32(string strValue)
    {
        if (strValue.ToString().Trim() == "")
        {
            return true;
        }
        else
        {
            try
            {
                Convert.ToInt32(strValue);
            }
            catch
            {
                return false;
            }
        }
        return true;
    }
    #endregion

    /// <summary>
    /// Procedure to check whether the variable passed is of Int32 type  or not. 
    /// </summary>
    /// <param name="strValue">Parameter to be checked</param>
    /// <returns>True/False</returns>

    #region "isDateTime"
    public static bool isDateTime(string strValue)
    {
        if (strValue.ToString().Trim() == "")
        {
            return false;
        }
        else
        {
            try
            {
                Convert.ToDateTime(strValue);
            }
            catch
            {
                return false;
            }
        }
        return true;
    }
    #endregion

    /// <summary>
    /// Procedure to convert string value to Int32 datatype
    /// </summary>
    /// <param name="strValue">Parameter to be converted</param>
    /// <returns>value of type Int32</returns>

    #region "GetInt32"
    public static int GetInt32(string strValue)
    {
        if (strValue.ToString().Trim() == "")
        {
            return 0;
        }
        try
        {
            return Convert.ToInt32(strValue);
        }
        catch
        {
            return 0;
        }
    }
    #endregion

    /// <summary>
    /// Procedure to convert string value to DateTime datatype
    /// </summary>
    /// <param name="strValue">Parameter to be converted</param>
    /// <returns>value of type DateTime</returns>

    #region "GetDateTime"
    public static DateTime GetDateTime(string strValue)
    {
        if (strValue.ToString().Trim() == "")
        {
            return DateTime.Parse("01/01/2000");
        }
        try
        {
            return DateTime.Parse(strValue);
        }
        catch
        {
            return DateTime.Parse("01/01/2000");
        }
    }
    #endregion

    /// <summary>
    /// Procedure to write a file.
    /// </summary>
    /// <param name="strContent">Content to be written in the file</param>
    /// <param name="strFileName">Filename to be created</param>

    #region "WriteAFile"
    public static void WriteTestFile(string strContent, string strFileName)
    {
        StreamWriter sWriter;
        string strPath = HttpContext.Current.Server.MapPath(".") + "\\" + strFileName;
        try
        {
            sWriter = new StreamWriter(strPath, true);
            sWriter.WriteLine(strContent);
            sWriter.Close();
        }
        catch (Exception ex)
        {
            strPath = HttpContext.Current.Server.MapPath(".") + "\\Error.txt";
            sWriter = new StreamWriter(strPath, true);
            sWriter.WriteLine(DateTime.Now.ToString() + ":\\n" + ex.Message.ToString() + "\\n\\n");
            sWriter.Close();
        }
    }
    #endregion

    /// <summary>
    /// Procedure to get dashed string to be displayed on gridviews id the text exceeds the specified character count.
    /// </summary>
    /// <param name="lblControlName">Name of label on which the dashed string is to be displayed</param>
    /// <param name="strText">Text to be dashed</param>
    /// <param name="intMaxCharacterCount">Number of characters count after which dash is placed</param>
    /// <returns>Dashed string</returns>

    #region "GetDashedString On Label"
    public static string GetDashedString(ref Label lblControlName, string strText, int intMaxCharacterCount)
    {
        strText = strText.Trim();
        lblControlName.ToolTip = strText;
        if ((intMaxCharacterCount <= strText.Length))
        {
            return strText.Substring(0, intMaxCharacterCount) + "...";
        }
        else
        {
            return strText;
        }
    }

    #endregion

    /// <summary>
    /// Procedure to get dashed string to be displayed on gridviews id the text exceeds the specified character count.
    /// </summary>
    /// <param name="strText">Text to be dashed</param>
    /// <param name="intMaxCharacterCount">Number of characters count after which dash is placed</param>
    /// <returns>Dashed string</returns>

    #region "GetDashedString"
    public static string GetDashedString(string strText, int intMaxCharacterCount)
    {
        strText = strText.Trim();
        if ((intMaxCharacterCount <= strText.Length))
        {
            return strText.Substring(0, intMaxCharacterCount) + "...";
        }
        else
        {
            return strText;
        }
    }
    #endregion

    /// <summary>
    /// Procedure to convert 24 hour time into AM/PM
    /// </summary>
    /// <param name="intTime">Time to convert</param>
    /// <returns>Time converted to AM/PM</returns>
    /// 
    #region "GetAMPMtime"
    public static string GetAMPMtime(int intTime)
    {
        if (intTime > 12)
        {
            return intTime - 12 + ":00 PM";
        }
        if (intTime < 12 && intTime != 0)
        {
            return intTime + ":00 AM";
        }
        if (intTime == 0)
        {
            return "12:00 AM";
        }
        if (intTime == 12)
        {
            return "12:00 PM";
        }
        else
            return "";
    }
    #endregion
    /// <summary>
    /// Procedure to convert 24 hour time into AM/PM
    /// </summary>
    /// <param name="intTime">Time to convert</param>
    /// <returns>Time converted to AM/PM</returns>
    /// 
    #region "GetAMPMTimeConversion"
    public static string GetAMPMTimeConversion(string strTimeVal)
    {
        string strTime = "";
        string strHourVal = "";
        string strMinVal = "";
        if (strTimeVal != "0")
        {
            strHourVal = strTimeVal.Substring(0, 2);
            if (strHourVal.Substring(0, 1) == "0")
            {
                strHourVal = strTimeVal.Substring(1, 1);
            }
            strMinVal = strTimeVal.Substring(2, 2);
            strTime = strHourVal + ":" + strMinVal;
            if (Convert.ToInt32(strHourVal) > 12)
            {
                strTime = strTime + " PM";
            }
            else
            {
                strTime = strTime + " AM";
            }
        }
        return strTime.ToString();

    }
    #endregion
    /// <summary>
    /// Procedure to convert the string from Uppercase to Lowercase
    /// </summary>
    /// <param name="strKeyword">String to be converted</param>
    /// <returns>String converted to lowercase</returns>

    #region "ConverttoLower"
    public static string ConverttoLower(string strKeyword)
    {
        return strKeyword.ToLower();
    }
    #endregion

    /// <summary>
    /// Procedure to convert the string from 24 hour time zone
    /// </summary>
    /// <param name="strKeyword">String to be converted</param>
    /// <returns>Time converted to 24 Hour</returns>
    #region "Time Conversion"

    public static string TimeConversion(string strKeyword)
    {
        string strHour = strKeyword.Substring(0, strKeyword.IndexOf(":"));
        string strTime = strKeyword.Substring(strKeyword.IndexOf(":") + 4);
        string iMinute = strKeyword.Substring(strKeyword.IndexOf(":") + 1, strKeyword.IndexOf(" ") - 1);
        if (strTime == "PM" || strTime == "pm")
            strHour = Convert.ToString(Convert.ToInt32(strHour) + 12);
        else if (strTime == "AM" || strTime == "am")
        {
            if (Convert.ToInt32(strHour) < 10)
            { strHour = "0" + strHour; }
        }
        return strHour.ToString() + iMinute;
    }
    #endregion

    /// <summary>
    /// Procedure to calculate the TimeSpan.
    /// </summary>
    /// <param name="dtStartDateTime">Start Datetime</param>
    /// <param name="dtEndDateTime">End Datetime</param>
    /// <returns>Claculated TimeSpan</returns>

    #region "DATE TIME"
    private static System.TimeSpan GetTimeSpan(System.DateTime dtStartDateTime, System.DateTime dtEndDateTime)
    {
        /**TimeSpan Properties/Methods
            Add: Add another TimeSpan to it. 
            Days: Return the day portion of the TimeSpan value. 
            Duration: Retrieve the absolute value of the TimeSpan. 
            Hours: Return the hour portion of the TimeSpan value. 
            Milliseconds: Return the millisecond portion of the TimeSpan value. 
            Minutes: Return the minute portion of the TimeSpan value. 
            Negate: Retrieve the negated value of the current instance. 
            Seconds: Return the second portion of the TimeSpan value. 
            Subtract: Subtract another TimeSpan from it. 
            Ticks: Return the TimeSpan value as ticks. 
            TotalDays: Return the TimeSpan value as days. 
            TotalHours: Return the TimeSpan value as hours. 
            TotalMilliseconds: Return the TimeSpan value as milliseconds. 
            TotalMinutes: Return the TimeSpan value as minutes. 
            TotalSeconds: Return the TimeSpan value as seconds. 
        **/

        TimeSpan tsTimeSpan = new TimeSpan();
        tsTimeSpan = dtEndDateTime.Subtract(dtStartDateTime);
        return tsTimeSpan;
    }
    private static string GetTimeSpanDays(System.TimeSpan tsTimeSpan)
    {
        return tsTimeSpan.Days.ToString();
    }
    private static string GetTimeSpanHours(System.TimeSpan tsTimeSpan)
    {
        return tsTimeSpan.Hours.ToString();
    }
    private static string GetTimeSpanMinutes(System.TimeSpan tsTimeSpan)
    {
        return tsTimeSpan.Minutes.ToString();
    }
    private static string GetTimeSpanSeconds(System.TimeSpan tsTimeSpan)
    {
        return tsTimeSpan.Seconds.ToString();
    }
    private static string GetTimeSpanMilliseconds(System.TimeSpan tsTimeSpan)
    {
        return tsTimeSpan.Milliseconds.ToString();
    }
    #endregion

    /// <summary>
    /// Procedure to convert date format to "dd MMMM yyyy" format.
    /// </summary>
    /// <param name="strDate">Date to be converted</param>
    /// <returns>Converted date</returns>

    #region "convertDates to "dd MMMM yyyy" format"
    public static string convertDates(string strDate)
    {
        if (strDate == null || strDate == "")
            return "";
        else
            return Convert.ToDateTime(strDate).ToString("dd MMMM yyyy");

    }

    #endregion

    /// <summary>
    /// Procedure to convert date format to "dd/mm/yyyy" format.
    /// </summary>
    /// <param name="strDate">Date to be converted</param>
    /// <returns></returns>

    #region "convertDateFormat"
    public static string convertDateFormat(string strDate)
    {
        string[] str;
        string rSrdate;
        if (strDate == null || strDate == "")
            return "";
        else
            str = strDate.Split('/');
        rSrdate = str[1] + "/" + str[0] + "/" + str[2];
        return rSrdate;
    }

    #endregion

    /// <summary>
    /// Procedure to get fullname of user login and put that in session. 
    /// </summary>

    #region "getUserLoginFullName"
    //public static void getUserFullName()
    //{

    //    string strUserFullName;
    //    try
    //    {
    //        SqlParameter[] param = new SqlParameter[1];
    //        param[0] = new SqlParameter("@intUserId", Convert.ToInt32(HttpContext.Current.Session["UserId"]));
    //        strUserFullName = Convert.ToString(SqlHelper.ExecuteScalar(Configuration.GetConnectionString(), CommandType.StoredProcedure, "proc_getUserFullName", param));
    //        HttpContext.Current.Session["strUserFullName"] = strUserFullName;
    //    }
    //    catch (SqlException Ex)
    //    {
    //        throw Ex;
    //    }

    //}
    #endregion

        
    /// <summary>
    /// Procedure to convert first letter of string to uppercase  
    /// </summary>
    /// <param name="strName">String to be converted</param>
    /// <returns>Converted string with first letter in uppercase</returns>

    #region "convert string to first letter uppercase"
    public static string converttofirstuppercase(string strName)
    {
        if (strName != "")
        {
            string strFirst = strName.Substring(0, 1);
            string strSecond = strName.Substring(1, strName.Length - 1);
            strFirst = strFirst.ToUpper();
            return strFirst + strSecond;
        }
        else
            return "";
    }
    #endregion

    /// <summary>
    /// Getting a string that contains all Item's Text in With Comma Separated
    /// </summary>
    /// <param name="lstSource">Source ListBox</param>
    /// <returns>String</returns>
    #region Getting a string that contains all Item's Text in With Comma Separated
    public static string GetAllListBoxItemsCommaSeparated(ref ListBox lstSource)
    {
        try
        {
            if (lstSource.Items.Count > 0)
            {
                StringBuilder sbReturnedResult = new StringBuilder("");
                for (Int32 i32CountItems = 0; i32CountItems < lstSource.Items.Count; i32CountItems++)
                {
                    sbReturnedResult.Append(lstSource.Items[i32CountItems].Text);
                    sbReturnedResult.Append(",");
                }
                return sbReturnedResult.ToString().Substring(0, sbReturnedResult.Length - 1);
            }
            else
                return null;
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion
    /// <summary>
    /// Getting  SqlDataReader count
    /// </summary>
    /// <param name="drReader">Reference of SqlDataReader</param>
    /// <returns>Count of SqlDataReader</returns>
    #region "Getting  SqlDataReader count"
    public static int GetDataReaderCount(SqlDataReader drReader)
    {
        try
        {
            int iCount = 0;
            while (drReader.Read())
            {
                ++iCount;


            }
            return iCount;
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    #endregion

    /// <summary>
    /// Getting DateTime in format MM/DD/YYYY , HH:MM:SS
    /// </summary>
    /// <param name="par_strDate">Complete date</param>
    /// <returns>Date in string format</returns>
    #region "Getting DateTime in format MM/DD/YYYY , HH:MM:SS"
    public static string getGlobalDateTime(string par_strDate)
    {
        if (par_strDate != "")
        {
            DateTime dtDate = Convert.ToDateTime(par_strDate);
            string strReturnDate = dtDate.Month + "/" + dtDate.Day + "/" + dtDate.Year + " , " + dtDate.Hour + ":" + dtDate.Minute + " " + par_strDate.Substring(par_strDate.Length - 2, 2);
            return strReturnDate;
        }
        return "";
    }
    #endregion

    /// <summary>
    /// Getting DateTime in format MM/DD/YYYY
    /// </summary>
    /// <param name="par_strDate">Complete date</param>
    /// <returns>Date in string format</returns>
    #region "Getting DateTime in format MM/DD/YYYY"
    public static string getGlobalDateTimeSmall(string par_strDate)
    {
        if (par_strDate != "")
        {
            string date = AppLib.getGlobalDateTime(par_strDate.ToString());
            return date.Substring(0, date.IndexOf(","));
        }
        return "";
    }
    #endregion


    /// <summary>
    /// Function to clear/reset controls
    /// </summary>

    #region "ClearControls"
    public static void ClearControls(Page obj, string strContentHolder)
    {

        foreach (Control c in obj.Master.FindControl(strContentHolder).Controls)
        {
            if (c.GetType().ToString().Equals("System.Web.UI.WebControls.TextBox"))
            {
                TextBox t = (TextBox)c;
                t.Text = "";
            }
            if (c.GetType().ToString().Equals("System.Web.UI.WebControls.DropDownList"))
            {
                DropDownList ddl = (DropDownList)c;
                ddl.SelectedIndex = 0;
            }
            if (c.GetType().ToString().Equals("System.Web.UI.WebControls.CheckBox"))
            {
                CheckBox chk = (CheckBox)c;
                chk.Checked = false;
            }
            if (c.GetType().ToString().Equals("System.Web.UI.WebControls.CheckBoxList"))
            {
                CheckBoxList chkList = (CheckBoxList)c;
                for (int i = 0; i < chkList.Items.Count; i++)
                {
                    chkList.Items[i].Selected = false;
                }
            }
        }

    }

    #endregion

    #region File Upload For User Photo
    /*Sub Header***********************************************************
      Function Name: Upload File
      Functionality: This function will upload the file.
      Input: string location,string strGuid.
      Output: decimal
      Note: Any Special comment
      *********************************************************************/
    public static String UploadPDFFile(ref FileUpload fileUp, string location, String strGuid)
    {
        String strReturn = "";

        //if (fileUp.PostedFile.ContentLength <= 2 * 1024 * 1024)
        //{
        string fileName = fileUp.PostedFile.FileName.Substring(fileUp.PostedFile.FileName.LastIndexOf("\\") + 1);
        try
        {
            string path = HttpContext.Current.Server.MapPath(location) + "\\" + strGuid + "_" + fileName;
            fileUp.PostedFile.SaveAs(path);
            strReturn = strGuid;
        }
        catch (Exception ex)
        {
            throw ex;
            //strReturn = "-2";
        }
        //}
        //else
        //{
        //    intReturn = -1;
        //}

        return strReturn;
    }
    #endregion
    /// <summary>
    /// Procedure to Upload File 
    /// </summary>
    /// <param name="file">Name of Uploaded file</param>
    /// <param name="location">location of Uploaded file</param>
    /// <param name="id">ID of Uploaded file</param>
    /// <returns></returns>
    #region "UploadFile"
    public static int UploadFile(ref FileUpload fileUp, string location, string strFileName)
    {
        int intReturn = 0;

        //string fileName = fileUp.PostedFile.FileName.Substring(fileUp.PostedFile.FileName.LastIndexOf("\\") + 1);
        try
        {
            string path = HttpContext.Current.Server.MapPath(location) + "\\" + strFileName;
            fileUp.PostedFile.SaveAs(path);
            intReturn = 1;
        }
        catch
        {
            intReturn = -2;
        }

        return intReturn;
    }

    #endregion

    /// <summary>
    /// Procedure to check File Type
    /// </summary>
    /// <param name="file">Name of Uploaded file</param>
    /// <returns>Return True for valid files</returns>
    #region "CheckValidFile"
    public static bool CheckValidFile(ref FileUpload file)
    {
        try
        {
            if ((file.PostedFile.ContentType.ToLower() == "application/msword" || file.PostedFile.ContentType.ToLower() == "text/plain" || file.PostedFile.ContentType.ToLower() == "application/pdf" || file.PostedFile.ContentType.ToLower() == "image/gif" || file.PostedFile.ContentType.ToLower() == "image/jpeg" || file.PostedFile.ContentType.ToLower() == "image/jpg") && file.PostedFile.ContentLength <= 8 * 1024 * 1024)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }
    #endregion

        
  

    /// <summary>
    /// Check if a file is valid or not by extension
    /// </summary>
    /// <param name="ext">extension of the file.</param>
    
    #region validFile
    public static Boolean validFile(string ext)
    {
        if (ext == "doc" || ext == "xls" || ext == "txt" || ext == "pdf" || ext == "htm" || ext == "html" || ext == "ppt")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion


    /// <summary>
    /// download a particular file on client side.
    /// </summary>
    /// <param name="strFilename">Name of the file to be downloaded</param>
        
    #region DownloadFile
    public static void DownloadFile(string strFoldername, string strFilename)
    {
        FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(strFoldername + "\\" + strFilename));
        try
        {

            if (File.Exists(file.FullName) == true)
            {

                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearContent();
                if (strFilename.Substring(strFilename.LastIndexOf(".") + 1).ToLower() == "txt")
                {

                    HttpContext.Current.Response.ContentType = "text/plain";
                    HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
                }
                else if (strFilename.Substring(strFilename.LastIndexOf(".") + 1).ToLower() == "pdf")
                {
                    HttpContext.Current.Response.ContentType = "application/pdf";
                }
                else //strFilename.Substring(strFilename.LastIndexOf(".") + 1).ToLower() == "doc" || strFilename.Substring(strFilename.LastIndexOf(".") + 1).ToLower() == "dot"
                {
                    HttpContext.Current.Response.ContentType = "application/octet-stream";
                }
                HttpContext.Current.Response.AppendHeader("content-disposition", "attachment; filename=" + strFilename); // to download any file type                
                HttpContext.Current.Response.WriteFile(HttpContext.Current.Server.MapPath((strFoldername) + "\\" + strFilename));
                HttpContext.Current.Response.End();
              
            }
        }
        catch (Exception ex)
        {

            throw new Exception("Error occured while download file: " + ex.Message.ToString());
        }

    }
    #endregion


    /// <summary>
    /// This function will logout the user when session expires.
   /// </summary>  
    public static void LogOutonSessionExpireCient()
    {
        if (HttpContext.Current.Session == null || Convert.ToString(HttpContext.Current.Session["intClientId"]) == "" || Convert.ToInt32(HttpContext.Current.Session["UserRole"]) != 3)
        {
            //  UserLib.UsersManager.MakeUserOffline(AppLib.GetInt32(Session["UserID"].ToString()));
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
            //se=2 means successfull log out
            string strUrl = HttpContext.Current.Request.Url.ToString();
            strUrl = strUrl.Replace("&", "PLUS");
            HttpContext.Current.Response.Redirect(AppConfig.GetBaseSiteUrl() + "ClientLogin.aspx?RelUrl=" + strUrl);
        }
    }

    /// <summary>
    /// This function will logout the admin when session expires.
    /// </summary>  
    public static void LogOutonSessionExpireAdmin()
    {
        if (HttpContext.Current.Session == null || Convert.ToString(HttpContext.Current.Session["Username"]) == "" || Convert.ToInt32(HttpContext.Current.Session["UserRole"]) != 1)
        {
            //  UserLib.UsersManager.MakeUserOffline(AppLib.GetInt32(Session["UserID"].ToString()));
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
            //se=2 means successfull log out
            string strUrl = HttpContext.Current.Request.Url.ToString();
            strUrl = strUrl.Replace("&", "PLUS");
            HttpContext.Current.Response.Redirect(AppConfig.GetBaseSiteUrl() + "login.aspx?RelUrl=" + strUrl);
        }
    }


    /// <summary>
    /// This function will logout the admin when session expires.
    /// </summary>  
    public static void LogOutonSessionExpireDeptHead()
    {
        if (HttpContext.Current.Session == null || Convert.ToString(HttpContext.Current.Session["Username"]) == "" || Convert.ToInt32(HttpContext.Current.Session["UserRole"]) != 2)
        {
            //  UserLib.UsersManager.MakeUserOffline(AppLib.GetInt32(Session["UserID"].ToString()));
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
            //se=2 means successfull log out
            string strUrl = HttpContext.Current.Request.Url.ToString();
            strUrl = strUrl.Replace("&", "PLUS");
            HttpContext.Current.Response.Redirect(AppConfig.GetBaseSiteUrl() + "EmployeeLogin.aspx?RelUrl=" + strUrl);
        }
    }
    
    /*Sub Header***********************************************************
   Function Name: Encrypt
   Functionality: This function will upload files to location specified by concating id with the file.
                      
   Input: FileUpload,string,int
   Output: int
   Use format: href='<%# Eval("WebPage") + "?ServiceTypeID=" + HttpUtility.UrlEncode(BLL.CommonFunctions.Encrypt(Eval("ServiceTypeID").ToString()))
   Note: Any Special comment
   *********************************************************************/
    public static string Encrypt(string toEncrypt)
    {
        byte[] keyArray;
        byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        string key = ")(*&";

        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //Always release the resources and flush data of the Cryptographic service provide. Best Practice

        hashmd5.Clear();


        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //set the secret key for the tripleDES algorithm
        tdes.Key = keyArray;
        //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)
        tdes.Mode = CipherMode.ECB;
        //padding mode(if any extra byte added)

        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateEncryptor();
        //transform the specified region of bytes array to resultArray
        byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //Release resources held by TripleDes Encryptor
        tdes.Clear();
        //Return the encrypted data into unreadable string format
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }



    /*Sub Header***********************************************************
    Function Name: Decrypt
    Functionality: This function will Decrypt a string/URL
                          
    Input: String
    Output: int
    Note: Any Special comment
    *********************************************************************/
    public static string Decrypt(string cipherString)
    {
        byte[] keyArray;
        //get the byte code of the string

        byte[] toEncryptArray = Convert.FromBase64String(cipherString);

        string key = ")(*&";

        //if hashing was used get the hash code with regards to your key
        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //release any resource held by the MD5CryptoServiceProvider

        hashmd5.Clear();


        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //set the secret key for the tripleDES algorithm
        tdes.Key = keyArray;
        //mode of operation. there are other 4 modes. We choose ECB(Electronic code Book)

        tdes.Mode = CipherMode.ECB;
        //padding mode(if any extra byte added)
        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //Release resources held by TripleDes Encryptor                
        tdes.Clear();
        //return the Clear decrypted TEXT
        return UTF8Encoding.UTF8.GetString(resultArray);
    }

    /// <summary>
    /// Process to get formatted string i.e. convert all characters to X except last 4 characters of the string. 
    /// </summary>
    /// <param name="strText">Text to be formatted</param>    
    /// <returns>Formatted string(e.g.- XXXXXXXXX1234)</returns>

    #region "GetFormattedString"
    public static string GetFormattedString(string strText)
    {
        strText = strText.Trim();
        if (strText.Length > 4)
        {
            string strX = "";
            for (int i = 0; i < strText.Length - 4; i++)
            {
               strX = strX + "X";
            }
            strX = strX + strText.Substring(strText.Length - 4, 4);
            return strX;
        }
        else
        {
            return strText;
        }
    }
    #endregion


    /// <summary>
    /// This function returns the user type
    /// </summary>  
    public static string Role
    {
        get
        {
            if (HttpContext.Current.Session["UserRole"] != null && HttpContext.Current.Session["UserRole"].ToString() != "")
                if (Convert.ToInt32(HttpContext.Current.Session["UserRole"]) == Convert.ToInt32(UserRole.Admin))
                    return UserRole.Admin.ToString();
                else if (Convert.ToInt32(HttpContext.Current.Session["UserRole"]) == Convert.ToInt32(UserRole.Member))
                    return UserRole.Member.ToString();                
                else
                    return "";
            else
                return "";
        }
    }


    /// <summary>
    /// Use for redirection from one page to another.
    /// </summary>
    /// <param name="path">String path on which redirection has to occur.</param>
    /// <param name="secure">Boolean to specify whether the redirection should be secure.</param>
    public static void RedirectToPage(string path)
    {
        HttpContext.Current.Response.Redirect(AppConfig.GetBaseSiteUrl() + path);      
       
    }

    //get user Role
    public enum UserRole { Admin = 1, Member = 2};

    //Get User Id
    public static Int32 intUserId
    {
        get
        {
            if (HttpContext.Current.Session["intUserId"] != null && HttpContext.Current.Session["intUserId"].ToString() != "")
                return Convert.ToInt32(HttpContext.Current.Session["intUserId"]);
            else
                return 0;
        }
    }

    //get substring
    public static string SubStr(string str, int len)
    {
        if (str.Length > len)
        {
            int iCount = 0;

            str = str.Substring(0, len);
            if (str.LastIndexOf(" ") <= 0)
            {
                iCount = str.Length;
            }
            else
                iCount = str.LastIndexOf(" ");


            str = str.Substring(0, iCount);
            return str;
        }
        else
            return str;

    }

    #region Create Thumbnail
    public static string GetImagePath(string picname, int height, int width, string type)
    {
        string result = "";
        if (picname != "")
        {
            result = AppConfig.GetBaseSiteUrl() + "CreateThumbNail.aspx?Image=" + picname + "&Height=" + height + "&Width=" + width + "&Type=" + type;
        }
        else
        {
            //result = AppConfig.GetBaseSiteUrl() + "CreateThumbNail.aspx?Image=member_pic.gif" + "&Height=" + height + "&Width=" + width + "&Type=" + type;
                //AppConfig.GetBaseSiteUrl() + "Images/member_pic.gif";
        }
        return result;

    }
    #endregion


    #region GenerateHash

    public static string GenerateHash(string SourceText)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        byte[] byteArray = Encoding.ASCII.GetBytes(SourceText);

        byteArray = md5.ComputeHash(byteArray);

        string hashedValue = "";

        foreach (byte b in byteArray)
        {
            hashedValue += b.ToString("x2");
        }

        return hashedValue;
    }
    // public static string GenerateHash(string SourceText)
    //{
    //    //Create an encoding object to ensure the encoding standard for the source text 
    //    UnicodeEncoding Ue = new UnicodeEncoding();
    //    //Retrieve a byte array based on the source text 
    //    byte[] ByteSourceText = Ue.GetBytes(SourceText);
    //    //Instantiate an MD5 Provider object 
    //    MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
    //    byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
    //    //And convert it to String format for return 
    //    return Convert.ToBase64String(ByteHash);
    //}
    #endregion


    #region "BreakWord"
    public static string BreakWord(string strText, int intMaxCharacterCount)
    {
        strText = strText.Trim();
        if ((intMaxCharacterCount <= strText.Length))
        {
            int intIntervals = Convert.ToInt32(strText.Length / intMaxCharacterCount) + 1;
            int intStart = 0;
            int intEnd = intMaxCharacterCount;
            string strBrokenString = "";
            for (int i = 1; i <= intIntervals; i++)
            {
                if (intEnd > 0)
                {
                    strBrokenString = strBrokenString + "<br>" + strText.Substring(intStart, intEnd);
                }

                intStart = intStart + intMaxCharacterCount;
                if (i == intIntervals - 1)
                {
                    int intLastLength = Convert.ToInt32(strText.Length - ((intIntervals - 1) * intMaxCharacterCount));
                    intEnd = intLastLength;
                }
            }
            if (strBrokenString != "")
            {
                strBrokenString = strBrokenString.Substring(4, strBrokenString.Length - 4);
            }
            return strBrokenString;
        }
        else
        {
            return strText;
        }

    }
    #endregion
    //public static string CreatePdfDocument(string strURL, string strSaveinFolder, string strFileName)
    //{
    //    try
    //    {
    //        WebClient objRequest = new WebClient();
    //        string sPath = AppConfig.GetBaseSiteUrl();
    //        // sPath = sPath.Replace("https", "http");
    //        string Url = sPath + strURL;

    //        string SaveLocation = HttpContext.Current.Server.MapPath("~/UploadedFiles/" + strSaveinFolder + "/") + strFileName + ".pdf";
    //        if (File.Exists(SaveLocation))
    //            File.SetAttributes(SaveLocation, FileAttributes.Archive);

    //        Doc theDoc = new Doc();

    //        int id = theDoc.AddImageUrl(Url);
    //        while (true)
    //        {
    //            theDoc.FrameRect();
    //            if (!theDoc.Chainable(id))
    //                break;
    //            theDoc.Page = theDoc.AddPage();
    //            id = theDoc.AddImageToChain(id);
    //        }

    //        for (int i = 1; i <= theDoc.PageCount; i++)
    //        {
    //            theDoc.PageNumber = i;
    //            theDoc.Flatten();
    //        }



    //        theDoc.Save(SaveLocation);
    //        theDoc.Clear();
    //        theDoc.Dispose();



    //        return SaveLocation;

    //    }
    //    catch (Exception ex)
    //    {
    //        return "";
    //    }
    //}
    //public static string CreatePdfDocumentByHtml(string strhtml, string strSaveinFolder, string strFileName)
    //{
    //    string SaveLocation = HttpContext.Current.Server.MapPath("~\\UploadedFiles") + "\\" + strSaveinFolder + "\\" + strFileName + ".pdf";
    //    try
    //    {
    //        WebClient objRequest = new WebClient();
    //        //string sPath = AppConfig.GetBaseSiteUrl();
    //        //sPath = sPath.Replace("https", "http");
    //        //string Url = sPath + strURL;

    //        //string SaveLocation = HttpContext.Current.Server.MapPath("~/UploadedFiles/" + strSaveinFolder + "\\" + strFileName + ".pdf");

    //        if (File.Exists(SaveLocation))
    //        {
    //            File.SetAttributes(SaveLocation, FileAttributes.Archive);
    //        }

    //        Doc theDoc = new Doc();

    //        int id = theDoc.AddImageHtml(strhtml);
    //        while (true)
    //        {
    //            theDoc.FrameRect();
    //            if (!theDoc.Chainable(id))
    //                break;
    //            theDoc.Page = theDoc.AddPage();
    //            id = theDoc.AddImageToChain(id);
    //        }

    //        for (int i = 1; i <= theDoc.PageCount; i++)
    //        {
    //            theDoc.PageNumber = i;
    //            theDoc.Flatten();
    //        }



    //        theDoc.Save(SaveLocation);
    //        theDoc.Clear();
    //        theDoc.Dispose();



    //        return SaveLocation;

    //    }
    //    catch (Exception ex)
    //    {
    //        return SaveLocation;
    //    }
    }




