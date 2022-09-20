using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml.Linq;
using System.Data.SqlClient;
using EDistrictBL;

    public class LSearch : IHttpHandler
    {
        bool IHttpHandler.IsReusable
        {
            get { throw new NotImplementedException(); }
        }

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
            try
            {
                string url = Convert.ToString(context.Request.Url);
                switch (context.Request.HttpMethod)
                {
                    case "POST":
                        PostData(context);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MyExceptionHandler.HandleException(ex);

            }

        }
        private void PostData(HttpContext context)
        {
            try
            {
                byte[] PullRequestByte = context.Request.BinaryRead(context.Request.ContentLength);
                string str = Encoding.UTF8.GetString(PullRequestByte);
                WriteResponse(PullDocument(str)); //Calling Meeseva method which inserts the input values and fetches meeseva document for given URI in desired format.
            }
            catch (Exception ex)
            {
                MyExceptionHandler.HandleException(ex);
            }
        }

        private static void WriteResponse(string strMessage)
        {
            HttpContext.Current.Response.Write(strMessage);
        }
        public static string PullDocument(string strxmlDoc)
        {
            string OrgId = string.Empty;
            string OrgPwd = string.Empty;
            string TransactionId = string.Empty;
            string TimeStamp = string.Empty;
            string KeyHash = string.Empty;
            string URI = string.Empty;
            string UDF1 = string.Empty;
            string UDF2 = string.Empty;
            string UDF3 = string.Empty;
            string Response = string.Empty;
            string FilePath = string.Empty;
            string DocType = string.Empty;
            string DOB= string.Empty;
            String CertNo = string.Empty;
            Int64 LogID = 0;
            string AppNo = string.Empty;
            DataTable dtURIDetails = new DataTable();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(strxmlDoc);
                XmlElement root = xmlDoc.DocumentElement;

                // Check to see if the element has a orgId attribute. 
                if (root.HasAttribute("orgId"))
                    OrgId = root.GetAttribute("orgId");
                if (root.HasAttribute("ts"))
                    TimeStamp = root.GetAttribute("ts");
                if (root.HasAttribute("txn"))
                    TransactionId = root.GetAttribute("txn");
                if (root.HasAttribute("keyhash"))
                    KeyHash = root.GetAttribute("keyhash");

                //if ((OrgId == "DigitalMeeseva"))
                if (true)
                {
                    string strXMLDoc = xmlDoc.OuterXml;
                    XDocument xmlDoc1 = XDocument.Parse(strXMLDoc);

                    //XmlNodeList xnodes = xmlDoc.GetElementsByTagName("DocDetails");
                    //for (int i = 0; i < xnodes.Count; i++)
                    //{
                    //    TransactionId = xnodes[i].Attributes["txn"].Value;
                    //}
                    XmlNodeList urinodes = xmlDoc.GetElementsByTagName("DocType");
                    for (int i = 0; i < urinodes.Count; i++)
                    {
                        DocType = urinodes[i].InnerText;
                    }
                    XmlNodeList UDF1nodes = xmlDoc.GetElementsByTagName("DOB");
                    for (int i = 0; i < UDF1nodes.Count; i++)
                    {
                        DOB = UDF1nodes[i].InnerText;
                    }

                    string[] j= DOB.Split('-');
                    DOB = j[2] + "-" + j[1] + "-" + j[0];

                    XmlNodeList UDF2nodes = xmlDoc.GetElementsByTagName("CERTNO");
                    for (int i = 0; i < UDF2nodes.Count; i++)
                    {
                        CertNo = UDF2nodes[i].InnerText;
                    }
                    XmlNodeList UDF3nodes = xmlDoc.GetElementsByTagName("UDF3");
                    for (int i = 0; i < UDF3nodes.Count; i++)
                    {
                        UDF3 = UDF3nodes[i].InnerText;
                    }
                    //FilePath = GetPDFFilePath(AppNo); //Method to fetch File Path
                    //Response = GetPDFFilePath(DocType, TransactionId, Convert.ToDateTime(TimeStamp), OrgId, xmlDoc.OuterXml.ToString(), DOB, CertNo);

                    DataSet ds = GetPDFFilePath(DocType, TransactionId, Convert.ToDateTime(TimeStamp), OrgId, xmlDoc.OuterXml.ToString(), Convert.ToDateTime(DOB), CertNo);
                    if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
                    {
                        byte[] ByteDocContent = (byte[])ds.Tables[0].Rows[0]["CertificateDoc"];//GetDocumentContent(ds.Tables[0].Rows[0]["PhysicalPath"].ToString()); //(byte[])ds.Tables[0].Rows[0]["DocContent"];//GetDocumentContent(FilePath);
                        string Base64StringDocContent = Convert.ToBase64String(ByteDocContent);
                        DOB=ds.Tables[0].Rows[0]["BeneficiaryDOB"].ToString();
                        CertNo = ds.Tables[0].Rows[0]["CertificateNo"].ToString();
                        URI = ds.Tables[0].Rows[0]["URI"].ToString();

                        Response = PullDOCResponse(1, 1, TransactionId, TimeStamp, Base64StringDocContent, DOB, CertNo, URI);

                    }
                    else
                    {
                        Response = PullDOCResponse(0, 0, TransactionId, TimeStamp, "HI Document not yet generated"+ DocType +" --"+ DOB + " ---" +CertNo, "", "", "");
                    }


                }
            }
            catch (Exception ex)
            {
                MyExceptionHandler.HandleException(ex);
                
                Response = PullDOCResponse(0, 0, TransactionId, TimeStamp, ex.Message, "", "", "");
            }
           

            finally
            {

            }
            return Response;
        }
        // Method to get Doc Content:
        public static byte[] GetDocumentContent(string Path)
        {
            try
            {
                FileStream stream = File.OpenRead(Path);
                byte[] fileBytes = new byte[stream.Length];
                stream.Read(fileBytes, 0, fileBytes.Length);
                stream.Close();
                return fileBytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Method to Pull Response:
        private static string PullDOCResponse(int StatusCode, int Status, string TransactionId, string TimeStamp, string DocContent, string DOB, string CertNo, string URI)
        {
            string Response = string.Empty;
            try
            {
                Response = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" +
                             "<PullURIResponse xmlns:ns2='http://tempuri.org/'>" +
                               "<ResponseStatus  Status='" + Status + "' ts='" + TimeStamp + "' txn='" + TransactionId + "'>" + Status + 
                               "</ResponseStatus>" +
                               "<DocDetails>" +
                                    "<URI>" + URI + "</URI>"+
                                    //"<DOB>" + DOB + "</DOB>" +
                                    //"<CERTNO>" + CertNo + "</CERTNO>" +
                                 "<docContent>" + DocContent + "</docContent>" +
                                "</DocDetails>" +
                             "</PullURIResponse>";
            }
            catch
            {
            }
            LogResponse(StatusCode, Status, TransactionId, TimeStamp);
            return Response;
        }

        private static void LogResponse(int StatusCode, int Status, string TransactionId, string TimeStamp)
        {

        }
        //"<UDF1>" + UDF1 + "</UDF1>" +
        //"<UDF2>" + UDF2 + "</UDF2>" +
        //"<UDF3>" + UDF3 + "</UDF3>" +
        //public static string GetPDFFilePath(string DocType, string RequestTXN, DateTime RequestTS, string ORGID, string Request, string DOB,String CertNo )
        //{



        //    string filepath = "";
        //    try
        //    {

        //        string con1 = "Data Source=10.144.0.9;Initial catalog=DigitalLocker;User Id=sa;Password=chandigarh$123;";
        //        SqlParameter[] prm = new SqlParameter[7];
        //        prm[0] = new SqlParameter("@RequestTXN", SqlDbType.VarChar, 50) { Value = RequestTXN };
        //        prm[1] = new SqlParameter("@RequestTS", SqlDbType.DateTime) { Value = RequestTS };
        //        prm[2] = new SqlParameter("@ORGID", SqlDbType.VarChar, 50) { Value = ORGID };
        //        prm[3] = new SqlParameter("@DocType", SqlDbType.VarChar, 50) { Value = DocType };
        //        prm[4] = new SqlParameter("@Request", SqlDbType.VarChar, 4000) { Value = Request };
        //        prm[5] = new SqlParameter("@DOB", SqlDbType.DateTime) { Value = Convert.ToDateTime(DOB) };
        //        prm[6] = new SqlParameter("@CertNo", SqlDbType.VarChar,50) { Value = CertNo };
                
        //        //prm[7] = new SqlParameter("@LogId", SqlDbType.VarChar, 50);
        //        //prm[7].Direction = ParameterDirection.Output;
        //        DataSet ds = SqlHelper.ExecuteDataset(con1, CommandType.StoredProcedure, "SearchRepository", prm);

        //        //LogId = Convert.ToInt64(prm[7].Value.ToString());
        //        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //        {
        //            filepath = ds.Tables[0].Rows[0]["PhysicalPath"].ToString();
        //        }



        //    }
        //    catch (Exception Ex)
        //    {
        //        filepath = Ex.Message;

        //    }
        //    //if (filepath == "")
        //    //    filepath = @"C:\Backup\DLocker\P1.pdf";
        //    return filepath;
        //}
        public static DataSet GetPDFFilePath(string DocType, string RequestTXN, DateTime RequestTS, string ORGID, string Request, DateTime DOB,string CertNo)
        {



            DataSet filepath = new DataSet();
            try
            {

                string con1 = "Data Source=10.144.0.66;Initial catalog=eDistrictchd;User Id=eDistrict_rw;Password=eD!f^#457@;";
                SqlParameter[] prm = new SqlParameter[7];
                prm[0] = new SqlParameter("@RequestTXN", SqlDbType.VarChar, 50) { Value = RequestTXN };
                prm[1] = new SqlParameter("@RequestTS", SqlDbType.DateTime) { Value = RequestTS };
                prm[2] = new SqlParameter("@ORGID", SqlDbType.VarChar, 50) { Value = ORGID };
                prm[3] = new SqlParameter("@DocType", SqlDbType.VarChar, 50) { Value = DocType };
                prm[4] = new SqlParameter("@Request", SqlDbType.VarChar, 4000) { Value = Request };
                prm[5] = new SqlParameter("@DOB", SqlDbType.DateTime) { Value = Convert.ToDateTime(DOB) };
                prm[6] = new SqlParameter("@CertNo", SqlDbType.VarChar, 50) { Value = CertNo };

                //prm[7] = new SqlParameter("@LogId", SqlDbType.VarChar, 50);
                //prm[7].Direction = ParameterDirection.Output;
                filepath = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SearchRepository", prm);



            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);

            }
            //if (filepath == "")
            //    filepath = @"C:\Backup\DLocker\P1.pdf";
            return filepath;
        }

    }



#region Test



//Response


//<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
//<PullURIResponse xmlns:ns2="http://tempuri.org/">
//<ResponseStatus Status="1" ts="2016-01-11T14:44:48+05:30"
//txn="1452503688">1</ResponseStatus>//1-Success //0-Failure
//<DocDetails>
//<DocType>INCER</DocType>
//<UID>123412341234</UID>
//<FullName>Sunil Kumar</FullName>
//<DOB>31-12-1990</DOB>
//<UDF1>13333</UDF1>
//<UDF2>2016</ UDF2>
//<URI>in.gov.dept.state-INCER-1234567</URI>
//<DocContent>Base64 encoded PDF file</DocContent>
//</DocDetails>
//</PullURIResponse>

#endregion