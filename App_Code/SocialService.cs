using EDistrictBL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for SocialService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class SocialService : System.Web.Services.WebService {

    public SocialService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
    public string GetApplicationStatus(string ApplicationNo,string CardNo)
    {
        string Returnss = "";
        CommonFunction cf = new CommonFunction();
        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        {
            //These headers are handling the "pre-flight" OPTIONS call sent by the browser
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }

        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmdAppStatus = new SqlCommand();
        SqlDataAdapter adp;
        DataTable dtAppStatus = new DataTable();
        using (SqlTransaction tr = con.BeginTransaction())
        {
            //string Dycrpt_ApplicationNo = ApplicationNo;//AES_Encrypt_Data.Decrypt(ApplicationNo);
            //ApplicationNo = ApplicationNo.Replace('_', '/');
            //CardNo = CardNo.Replace('_', '/');

            try
            {
                cmdAppStatus.CommandText = "GetSocialServiceData";
                cmdAppStatus.CommandType = CommandType.StoredProcedure;
                cmdAppStatus.Connection = con;
                cmdAppStatus.Parameters.AddWithValue("@Appno", ApplicationNo);
                cmdAppStatus.Parameters.AddWithValue("@CertificateNo", CardNo);
                //cmdAppStatus.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
                cmdAppStatus.Transaction = tr;
                adp = new SqlDataAdapter(cmdAppStatus);
                adp.Fill(dtAppStatus);
                if (dtAppStatus.Rows.Count > 0)
                {
                    Returnss = cf.DataTableToJSONWithJavaScriptSerializer(dtAppStatus);
                }
                else
                {
                    Returnss = new JavaScriptSerializer().Serialize("Record not found for the Details! Please Contact Administrator");
                }
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                Returnss = Ex.Message;
            }
            finally
            {
                con.Close();
            }
            return Returnss;
            //Context.Response.Write(Returnss);

        }

    }
    [WebMethod]
    [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
    public string ValidSeniorCitizenData(string CardNo)
    {
        string Returnss = "";
        CommonFunction cf = new CommonFunction();
        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        {
            //These headers are handling the "pre-flight" OPTIONS call sent by the browser
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }

        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmdAppStatus = new SqlCommand();
        SqlDataAdapter adp;
        DataTable dtAppStatus = new DataTable();
        using (SqlTransaction tr = con.BeginTransaction())
        {
            //string Dycrpt_ApplicationNo = ApplicationNo;//AES_Encrypt_Data.Decrypt(ApplicationNo);
            //ApplicationNo = ApplicationNo.Replace('_', '/');
            //CardNo = CardNo.Replace('_', '/');

            try
            {
                cmdAppStatus.CommandText = "GetSocialServiceDataExist";
                cmdAppStatus.CommandType = CommandType.StoredProcedure;
                cmdAppStatus.Connection = con;
                //cmdAppStatus.Parameters.AddWithValue("@Appno", ApplicationNo);
                cmdAppStatus.Parameters.AddWithValue("@CertificateNo", CardNo);
                //cmdAppStatus.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
                cmdAppStatus.Transaction = tr;
                adp = new SqlDataAdapter(cmdAppStatus);
                adp.Fill(dtAppStatus);
                if (dtAppStatus.Rows.Count > 0)
                {
                    bool s = true;
                    Returnss = cf.DataTableToJSONWithJavaScriptSerializer(dtAppStatus);
                    //Returnss = new JavaScriptSerializer().Serialize("YES");
                }
                else
                {
                    Returnss = new JavaScriptSerializer().Serialize("Record not found for the Details! Please Contact Administrator");
                    //Returnss = new JavaScriptSerializer().Serialize("NO");
                }
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                Returnss = Ex.Message;
            }
            finally
            {
                con.Close();
            }
            return Returnss;
            //Context.Response.Write(Returnss);

        }

    }

    [WebMethod]
    [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
    public string ValidSeniorCitizen(string CardNo)
    {
        string Returnss = "";
        CommonFunction cf = new CommonFunction();
        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        {
            //These headers are handling the "pre-flight" OPTIONS call sent by the browser
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }

        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmdAppStatus = new SqlCommand();
        SqlDataAdapter adp;
        DataTable dtAppStatus = new DataTable();
        using (SqlTransaction tr = con.BeginTransaction())
        {
            //string Dycrpt_ApplicationNo = ApplicationNo;//AES_Encrypt_Data.Decrypt(ApplicationNo);
            //ApplicationNo = ApplicationNo.Replace('_', '/');
            //CardNo = CardNo.Replace('_', '/');

            try
            {
                cmdAppStatus.CommandText = "GetSocialServiceDataExist";
                cmdAppStatus.CommandType = CommandType.StoredProcedure;
                cmdAppStatus.Connection = con;
                //cmdAppStatus.Parameters.AddWithValue("@Appno", ApplicationNo);
                cmdAppStatus.Parameters.AddWithValue("@CertificateNo", CardNo);
                //cmdAppStatus.Parameters.AddWithValue("@ApplicationNo", ApplicationNo);
                cmdAppStatus.Transaction = tr;
                adp = new SqlDataAdapter(cmdAppStatus);
                adp.Fill(dtAppStatus);
                if (dtAppStatus.Rows.Count > 0)
                {
                    bool s = true;
                    //Returnss = cf.DataTableToJSONWithJavaScriptSerializer(dtAppStatus);
                    Returnss = new JavaScriptSerializer().Serialize("YES");
                }
                else
                {
                    Returnss = new JavaScriptSerializer().Serialize("NO");
                }
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                Returnss = Ex.Message;
            }
            finally
            {
                con.Close();
            }
            return Returnss;
            //Context.Response.Write(Returnss);

        }

    }
    
}
