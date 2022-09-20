using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Security.Cryptography;

using System.Security.Cryptography.X509Certificates;
using System.Web.Mail;
using System.Globalization;
using System.Net.Security;
using System.Security.Policy;
using EDistrictBL;


    public class NICSMS
    {
        // Method for sending single SMS.
        public String SendSMS(String mobileNo, String message)
        {
            //----- below code added for SSL(https URL) and POST method call to the sms gateway    
            String responseFromServer = "";
            try
            {
                string createdURL = "";

                string KARTEST, dlt_entity_id;
                //KARTEST = "xxxxxx";
                KARTEST = "CHDCHB";
                dlt_entity_id = "1701160008248140110";

                createdURL = "https://smsgw.sms.gov.in/failsafe/HttpLink?username=chbops.otp&pin=Qwer@#123&message=" + message + "&mnumber=" + mobileNo + "&signature=" + KARTEST + "&dlt_entity_id=" + dlt_entity_id;
                HttpWebRequest request;
                //Support for SSL
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.DefaultConnectionLimit = 9999;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                    delegate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                                         System.Security.Cryptography.X509Certificates.X509Chain chain,
                                         System.Net.Security.SslPolicyErrors sslPolicyErrors)
                    {
                        return true;
                    };

                var rcvc = new RemoteCertificateValidationCallback(AcceptAllCertifications); //(sender, cert, chain, ssl) => true
                ServicePointManager.ServerCertificateValidationCallback = rcvc;
                request = (HttpWebRequest)WebRequest.Create(createdURL);
                request.Method = "POST";
                HttpWebResponse hwresponse = (HttpWebResponse)request.GetResponse();
                string ver = hwresponse.ProtocolVersion.ToString();
                StreamReader reader = new StreamReader(hwresponse.GetResponseStream());
                responseFromServer = reader.ReadToEnd();
                    WriteLog1(responseFromServer);
                    MyExceptionHandler.HandleException(responseFromServer);   
                WriteLog1(createdURL);
                reader.Close();
            }
            catch (Exception ex1)
            {
                WriteLog(ex1);
            }
            return responseFromServer;
        }


        public static bool AcceptAllCertifications(object sender, X509Certificate certification, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) == SslPolicyErrors.RemoteCertificateChainErrors))
            {
                return true;
            }
            else if (((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) == SslPolicyErrors.RemoteCertificateNameMismatch))
            {
                Zone z = default(Zone);
                z = Zone.CreateFromUrl(((HttpWebRequest)sender).RequestUri.ToString());
                if ((z.SecurityZone == System.Security.SecurityZone.Intranet | z.SecurityZone == System.Security.SecurityZone.MyComputer))
                {
                    return true;
                }
                return true;
            }
            else
            {
                return true;
            }
            //return true;
        }
        /// <summary>
        /// Method to get Encrypted the password 
        /// </summary>
        /// <param name="password"> password as String"

        protected String encryptedPasswod(String password)
        {
            byte[] encPwd = Encoding.UTF8.GetBytes(password);
            //static byte[] pwd = new byte[encPwd.Length];
            HashAlgorithm sha1 = HashAlgorithm.Create("SHA1");
            byte[] pp = sha1.ComputeHash(encPwd);
            // static string result = System.Text.Encoding.UTF8.GetString(pp);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in pp)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();

        }

        /// <summary>
        /// Method to Generate hash code  
        /// </summary>
        /// <param name="secure_key">your last generated Secure_key 

        protected String hashGenerator(String Username, String sender_id, String message, String secure_key)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Username).Append(sender_id).Append(message).Append(secure_key);
            byte[] genkey = Encoding.UTF8.GetBytes(sb.ToString());
            //static byte[] pwd = new byte[encPwd.Length];
            HashAlgorithm sha1 = HashAlgorithm.Create("SHA512");
            byte[] sec_key = sha1.ComputeHash(genkey);

            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < sec_key.Length; i++)
            {
                sb1.Append(sec_key[i].ToString("x2"));
            }
            return sb1.ToString();
        }

        public static void WriteLog(Exception logMessage)
        {
            try
            {
                string path = "~/ExceptionLog/SMSLOG" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".txt";
                if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
                {
                    File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();
                }
                using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
                {
                    w.WriteLine("\r\nLog Entry : ");
                    w.WriteLine("{0}", DateTime.Now.ToString(CultureInfo.InvariantCulture));
                    string err = "Error in: " + System.Web.HttpContext.Current.Request.Url.ToString() + ".Error Message:" + logMessage;
                    w.WriteLine(err);
                    w.WriteLine("__________________________");
                    w.Flush();
                    w.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void WriteLog1(string logMessage)
        {
            try
            {
                string path = "~/ExceptionLog/SMSLOG" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".txt";
                if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
                {
                    File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();
                }
                using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
                {
                    w.WriteLine("\r\nLog Entry : ");
                    w.WriteLine("{0}", DateTime.Now.ToString(CultureInfo.InvariantCulture));
                    string err = "Error in: " + System.Web.HttpContext.Current.Request.Url.ToString() + ".   Error Message:" + logMessage;
                    w.WriteLine(err);
                    w.WriteLine("__________________________");
                    w.Flush();
                    w.Close();
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex);
            }
        }
    }
