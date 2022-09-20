using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using EDistrictBL;

/// <summary>
/// Summary description for mstRASIntegration
/// </summary>
public class mstRASIntegration
{
    public string Mobile { get; set; }
    public string EmailId { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Registration_No { get; set; }
    public string City_Name { get; set; }
    public string Address { get; set; }
    public string addl_info { get; set; }
    
    
    
    public int DepartmentId { get; set; }
    public int ServiceId { get; set; }
    public string DepartmentName { get; set; }
    public string Servicename { get; set; }
    public int StateId { get; set; }
    public string ApiKey { get; set; }
    
    public string ServiceCode { get; set; }
    public string SubServiceCode { get; set; }


   
    public mstRASIntegration()
	{
        this.DepartmentId = 467;
        this.StateId = 6;
        this.ApiKey = "b5018d7d2619ce517c1d6c86e3aea69fc0fd3de9b46d12aae5a43663f3d17171";
	}

    public static Int32 GetRasServiceCode(string ServiceCode,string SubServiceCode)
    {
        Int32 ReturnRasServiceId=0;
        if (ServiceCode == "INCOMENW")
        {
            ReturnRasServiceId = 2297;
        }
        else if (ServiceCode == "LTBIRDTH")
        {
            if (SubServiceCode == "BIRTHHOS" || SubServiceCode == "BIRTHHOM")
                ReturnRasServiceId = 2298;
            else
                ReturnRasServiceId = 2299;
        }
        else if (ServiceCode == "CERTRESI")
        {
            ReturnRasServiceId = 2300;
        }
        else if (ServiceCode == "DEPECERT")
        {
            ReturnRasServiceId = 2301;
        }
        else if (ServiceCode == "SOLVCERT")
        {
            ReturnRasServiceId = 2302;
        }
        else if (ServiceCode == "SOUNDPER")
        {
            ReturnRasServiceId = 2303;
        }
        else if (ServiceCode == "SWIDCSNC")
        {
            ReturnRasServiceId = 2304;
        }
        else if (ServiceCode == "LEGLHEIR")
        {
            ReturnRasServiceId = 2305;
        }
        else if (ServiceCode == "SWPENDIS")
        {
            ReturnRasServiceId = 2306;
        }
        else if (ServiceCode == "SWPENOLD")
        {
            ReturnRasServiceId = 2307;
        }
        else if (ServiceCode == "SWPENWID")
        {
            ReturnRasServiceId = 2308;
        }

        return ReturnRasServiceId;


        
 
    }

    public string RASRequest(string ServiceCode,string Mobile,string EmailId,string ApplicationNo,String SubService)
    {
        try
        {

        
        //RemoteClass remotepost = new RemoteClass();
        //remotepost.Add("m", Mobile);
        //remotepost.Add("e", EmailId);
        //remotepost.Add("registration_no", ApplicationNo);
        //remotepost.Add("d", DepartmentId.ToString());
        ServiceId = GetRasServiceCode(ServiceCode, SubService);
        //remotepost.Add("s", ServiceId.ToString());
        //remotepost.Add("st", StateId.ToString());
        ////remotepost.Add("API Key", ApiKey);
        //remotepost.Url = "https://ras.gov.in/webservices/addFeedbackUserWithOauth";
        //remotepost.Post();



        HttpWebRequest req = null;
        HttpWebResponse res = null;
        
            req = (HttpWebRequest)WebRequest.Create("https://ras.gov.in/webservices/addFeedbackUserWithOaut");
            req.Method = "POST";
            req.ContentType = "application/xml; charset=utf-8";
            //req.Timeout = 30000; 
            req.Headers.Add("api_key", ApiKey);
            string prams = "m=" + Mobile + "&e=" + EmailId + "&registration_no=" + ApplicationNo + "&d=" + DepartmentId + "&s=" + ServiceId + "&st=" + StateId + "";

            //var xmlDoc = new XmlDocument { XmlResolver = null };
            //xmlDoc.Load(Server.MapPath("PostData.xml"));
            //string sXml = xmlDoc.InnerXml;
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(prams);
            req.ContentLength = bytes.Length;
            
        
        
            var sw = new StreamWriter(req.GetRequestStream());
            sw.Write(bytes);
            sw.Close();
            System.Net.WebResponse res1 = req.GetResponse();
            
            
            res = (HttpWebResponse)req.GetResponse();
            Stream responseStream = res.GetResponseStream();
            var streamReader = new StreamReader(responseStream);

            //Read the response into an xml document 
            string R = streamReader.ReadToEnd();


        }
        catch (Exception Ex)
        {
           
        }
        
        
        
        
        
        return "Ok";








    }

    public DBReturn UpdateRasStatus(string Error,String Code,string Message,Int64 RASID)
    {
DBReturn objReturn = new DBReturn();
try
        {

        
        SqlParameter[] prm = new SqlParameter[7];
        prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Registration_No };
        prm[1] = new SqlParameter("@Error", SqlDbType.VarChar, 30) { Value = Error };
        prm[2] = new SqlParameter("@Code", SqlDbType.VarChar, 30) { Value = Code };
        prm[3] = new SqlParameter("@Message", SqlDbType.VarChar, 100) { Value = Message };
        prm[4] = new SqlParameter("@RASID", SqlDbType.BigInt) { Value = RASID};
        prm[5] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        prm[5].Direction = ParameterDirection.Output;
        prm[6] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        prm[6].Direction = ParameterDirection.Output;

        DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateRasStatus", prm);
        objReturn.ErrMessage = prm[5].Value.ToString();
        objReturn.ReturnCode = prm[6].Value.ToString();
	}
	catch (Exception Ex)
        {
           MyExceptionHandler.HandleException(Ex);
        }

        return objReturn;
    }
}
