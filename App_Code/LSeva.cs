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

    public class LSeva : IHttpHandler
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
                WriteResponse(ex.Message.ToString());
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
                    XmlNodeList urinodes = xmlDoc.GetElementsByTagName("URI");
                    for (int i = 0; i < urinodes.Count; i++)
                    {
                        URI = urinodes[i].InnerText;
                    }
                    XmlNodeList UDF1nodes = xmlDoc.GetElementsByTagName("UDF1");
                    for (int i = 0; i < UDF1nodes.Count; i++)
                    {
                        UDF1 = UDF1nodes[i].InnerText;
                    }



                    XmlNodeList UDF2nodes = xmlDoc.GetElementsByTagName("UDF2");
                    for (int i = 0; i < UDF2nodes.Count; i++)
                    {
                        UDF2 = UDF2nodes[i].InnerText;
                    }
                    XmlNodeList UDF3nodes = xmlDoc.GetElementsByTagName("UDF3");
                    for (int i = 0; i < UDF3nodes.Count; i++)
                    {
                        UDF3 = UDF3nodes[i].InnerText;
                    }
                    // FilePath = GetPDFFilePath(AppNo); //Method to fetch File Path
                    FilePath = GetPDFFilePath(URI, TransactionId, Convert.ToDateTime(TimeStamp), OrgId, xmlDoc.OuterXml.ToString(),LogID);
                    //FilePath = "";
                    if (FilePath != "")
                    {
                        //byte[] ByteDocContent = GetDocumentContent(FilePath);
                        //string Base64StringDocContent = Convert.ToBase64String(ByteDocContent);
                        Response = PullDOCResponse(1, 1, TransactionId, TimeStamp, FilePath, "", "", "");
                        
                    }
                    else
                    {
                        Response = PullDOCResponse(0, 0, TransactionId, TimeStamp, "HI Document not yet generated", "", "", "");
                    }
                    

                }
            }
            catch (Exception ex)
            {
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
        private static string PullDOCResponse(int StatusCode, int Status, string TransactionId, string TimeStamp, string DocContent, string UDF1, string UDF2, string UDF3)
        {
            string Response = string.Empty;
            try
            {
                Response = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" +
                             "<PullDocResponse xmlns:ns2='http://tempuri.org/'>" +
                               "<ResponseStatus  Status='" + Status + "' ts='" + TimeStamp + "' txn='" + TransactionId + "'>" + Status +
                               "</ResponseStatus>" +
                               "<DocDetails>" +
                                 "<docContent>" +
                                    DocContent +
                                 "</docContent>" +
                                 
                                 "<MetadataContent> </MetadataContent>" +
                               "</DocDetails>" +
                             "</PullDocResponse>";
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
        public static string GetPDFFilePath(string _URI,string RequestTXN,DateTime RequestTS,string ORGID,string Request,Int64 LogId)
        {



            string filepath = "";
            try
            {

                string con1 = "Data Source=10.144.0.66;Initial catalog=eDistrictchd;User Id=eDistrict_rw;Password=eD!f^#457@;";
                SqlParameter[] prm = new SqlParameter[7];
                prm[0] = new SqlParameter("@RequestTXN", SqlDbType.VarChar,50) { Value = RequestTXN };
                prm[1] = new SqlParameter("@RequestTS", SqlDbType.DateTime) { Value = RequestTS };
                prm[2] = new SqlParameter("@ORGID", SqlDbType.VarChar,50) { Value = ORGID };
                prm[3] = new SqlParameter("@RequestURI", SqlDbType.VarChar, 100) { Value = _URI };
                prm[4] = new SqlParameter("@Request", SqlDbType.VarChar, 4000) { Value = Request };
                prm[5] = new SqlParameter("@URi", SqlDbType.VarChar, 500) { Value = _URI };
                prm[6] = new SqlParameter("@Testvar", SqlDbType.VarChar, 4000) { Value = "Jalaj" };
                //prm[7] = new SqlParameter("@LogId", SqlDbType.VarChar, 50);
                //prm[7].Direction = ParameterDirection.Output;
                DataSet ds= SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPhysicalPath", prm);
                
                //LogId = Convert.ToInt64(prm[7].Value.ToString());
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    byte[] j = (byte[])ds.Tables[0].Rows[0]["DocContent"];
                    filepath = Convert.ToBase64String(j);
                }
                
               
                
            }
            catch (Exception Ex)
            {
                filepath = Ex.Message;

            }
            //if (filepath == "")
            //    filepath = @"C:\Backup\DLocker\P1.pdf";
            return filepath;
        }

       

    }
