using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using EDistrictBL;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

/// <summary>
/// Summary description for SMS
/// </summary>
public class SMS
{



    public const string PasswordChanged = "1307161656992506166";
    public const string ApplicationRecieved = "1307161656997470691";
    public const string OTP = "1307161657000850017";
    public const string VerificationCode = "1307161657011277918";
    public const string Registration = "1307161657016929843";
    public const string CertificateGeneration = "1307161657024011316";
    public const string MISCSMS = "1307161657029065448";
public const string DELAYSMS = "1307162987315405353";

    public Int64 EmailLogId { get; set; }
    public string EmailSentTo { get; set; }
    public string EmailSentFrom { get; set; }
    public string EmailSubject { get; set; }
    public string EmailContent { get; set; }
    public DateTime? EmailSentDate { get; set; }
    public string EmailPurpose { get; set; }

    public string MobileNo { get; set; }
    public string SMSContent { get; set; }
    public string IPAddress { get; set; }



    // Method for sending single SMS.

    public String SendSMS(String mobileNo, String message, String templateid)
    {

        string username, password, senderid, secureKey;
        username = "CHDIT-EDISTRICT";
        password = "eDi5tr1ct$3213";
        senderid = "ESMPRK";
        secureKey = "da6e0a34-f351-4793-aaf6-50ecd5feb3c4";


        //Latest Generated Secure Key
        Stream dataStream;

        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //forcing .Net framework to use TLSv1.2

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://msdgweb.mgov.gov.in/esms/sendsmsrequestDLT");
        request.ProtocolVersion = HttpVersion.Version10;
        request.KeepAlive = false;
        request.ServicePoint.ConnectionLimit = 1;

        //((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 5.0; Windows 98; DigExt)";

        request.Method = "POST";

        System.Net.ServicePointManager.CertificatePolicy = new MyPolicy();

        String encryptedPassword = encryptedPasswod(password);
        String NewsecureKey = hashGenerator(username.Trim(), senderid.Trim(), message.Trim(), secureKey.Trim());
        String smsservicetype = "singlemsg"; //For single message.

        String query = "username=" + HttpUtility.UrlEncode(username.Trim()) +
            "&password=" + HttpUtility.UrlEncode(encryptedPassword) +

            "&smsservicetype=" + HttpUtility.UrlEncode(smsservicetype) +

            "&content=" + HttpUtility.UrlEncode(message.Trim()) +

            "&mobileno=" + HttpUtility.UrlEncode(mobileNo) +

            "&senderid=" + HttpUtility.UrlEncode(senderid.Trim()) +
          "&key=" + HttpUtility.UrlEncode(NewsecureKey.Trim()) +
          "&templateid=" + HttpUtility.UrlEncode(templateid.Trim());



        byte[] byteArray = Encoding.ASCII.GetBytes(query);

        request.ContentType = "application/x-www-form-urlencoded";

        request.ContentLength = byteArray.Length;



        dataStream = request.GetRequestStream();

        dataStream.Write(byteArray, 0, byteArray.Length);

        dataStream.Close();

        WebResponse response = request.GetResponse();

        String Status = ((HttpWebResponse)response).StatusDescription;

        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        String responseFromServer = reader.ReadToEnd();

        reader.Close();

        dataStream.Close();

        response.Close();
        return responseFromServer;

    }
    /// <summary>
    /// Method for sending OTP MSG.
    /// </summary>
    /// <param name="username"> Registered user name
    /// <param name="password"> Valid login password
    /// <param name="senderid">Sender ID 
    /// <param name="mobileNo"> valid single  Mobile Number 
    /// <param name="message">Message Content 
    /// <param name="secureKey">Department generate key by login to services portal
    /// <param name="templateid">templateid unique for each template message content

    // Method for sending OTP MSG.

    public String sendOTP(String mobileNo, String message, String templateid)
    {


        string username, password, senderid, secureKey;
        username = "CHDIT-EDISTRICT";
        password = "eDi5tr1ct$3213";
        senderid = "ESMPRK";
        secureKey = "da6e0a34-f351-4793-aaf6-50ecd5feb3c4";

        Stream dataStream;

        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //forcing .Net framework to use TLSv1.2

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://msdgweb.mgov.gov.in/esms/sendsmsrequestDLT");
        request.ProtocolVersion = HttpVersion.Version10;
        request.KeepAlive = false;
        request.ServicePoint.ConnectionLimit = 1;

        //((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 5.0; Windows 98; DigExt)";

        request.Method = "POST";
        System.Net.ServicePointManager.CertificatePolicy = new MyPolicy();

        String encryptedPassword = encryptedPasswod(password);
        String key = hashGenerator(username.Trim(), senderid.Trim(), message.Trim(), secureKey.Trim());

        String smsservicetype = "otpmsg"; //For OTP message.

        String query = "username=" + HttpUtility.UrlEncode(username.Trim()) +
            "&password=" + HttpUtility.UrlEncode(encryptedPassword) +

            "&smsservicetype=" + HttpUtility.UrlEncode(smsservicetype) +

            "&content=" + HttpUtility.UrlEncode(message.Trim()) +

            "&mobileno=" + HttpUtility.UrlEncode(mobileNo) +

            "&senderid=" + HttpUtility.UrlEncode(senderid.Trim()) +
          "&key=" + HttpUtility.UrlEncode(key.Trim()) +
    "&templateid=" + HttpUtility.UrlEncode(templateid.Trim());



        byte[] byteArray = Encoding.ASCII.GetBytes(query);

        request.ContentType = "application/x-www-form-urlencoded";

        request.ContentLength = byteArray.Length;



        dataStream = request.GetRequestStream();

        dataStream.Write(byteArray, 0, byteArray.Length);

        dataStream.Close();

        WebResponse response = request.GetResponse();

        String Status = ((HttpWebResponse)response).StatusDescription;

        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        String responseFromServer = reader.ReadToEnd();

        reader.Close();

        dataStream.Close();

        response.Close();
        return responseFromServer;

    }


      public String SendSMSOLD( String mobileNo, String message)
    {
        string username, password, senderid, secureKey;
        username = "CHDIT-EDISTRICT";
        password = "eDi5tr1ct$3213";
        senderid = "ESMPRK";
        secureKey = "da6e0a34-f351-4793-aaf6-50ecd5feb3c4";

        //Latest Generated Secure Key
        Stream dataStream;
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://msdgweb.mgov.gov.in/esms/sendsmsrequest");
        request.ProtocolVersion = HttpVersion.Version10;
        request.KeepAlive = false;
        request.ServicePoint.ConnectionLimit = 1;

        //((HttpWebRequest)request).UserAgent = ".NET Framework Example Client";
        ((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 5.0; Windows 98; DigExt)";

        request.Method = "POST";
        
        System.Net.ServicePointManager.CertificatePolicy = new MyPolicy();
        String encryptedPassword = encryptedPasswod(password);
        String NewsecureKey = hashGenerator(username.ToString().Trim(), senderid.ToString().Trim(), message.ToString().Trim(), secureKey.ToString().Trim());
        String smsservicetype = "singlemsg"; //For single message.

        String query = "username=" + HttpUtility.UrlEncode(username) +
            "&password=" + HttpUtility.UrlEncode(encryptedPassword) +

            "&smsservicetype=" + HttpUtility.UrlEncode(smsservicetype) +

            "&content=" + HttpUtility.UrlEncode(message) +

            "&mobileno=" + HttpUtility.UrlEncode(mobileNo) +

            "&senderid=" + HttpUtility.UrlEncode(senderid) +
          "&key=" + HttpUtility.UrlEncode(NewsecureKey);



        byte[] byteArray = Encoding.ASCII.GetBytes(query);

        request.ContentType = "application/x-www-form-urlencoded";

        request.ContentLength = byteArray.Length;



        dataStream = request.GetRequestStream();

        dataStream.Write(byteArray, 0, byteArray.Length);

        dataStream.Close();

        WebResponse response = request.GetResponse();

        String Status = ((HttpWebResponse)response).StatusDescription;

        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        String responseFromServer = reader.ReadToEnd();

        reader.Close();

        dataStream.Close();

        response.Close();
        return responseFromServer;

    }

    public DBReturn LOGSmsEmail()
    {
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[7];
        prm[0] = new SqlParameter("@EmailTo", SqlDbType.VarChar, 50) { Value = EmailSentTo };
        prm[1] = new SqlParameter("@MobileTO", SqlDbType.VarChar, 10) { Value = MobileNo };
        prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        prm[2].Direction = ParameterDirection.Output;
        prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        prm[3].Direction = ParameterDirection.Output;
        prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
        prm[5] = new SqlParameter("@MessageMobile", SqlDbType.VarChar, 200) { Value = SMSContent };
        prm[6] = new SqlParameter("@MessageEmail", SqlDbType.VarChar, 2000) { Value = EmailContent };
        SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "LOGEmailandSMS", prm);
        objReturn.ErrMessage = prm[2].Value.ToString();
        objReturn.ReturnCode = prm[3].Value.ToString();
        return objReturn;
    }

    public string NewEmailMethod()
    {
        string resulttext;
        try
        {
            SmtpClient client = new SmtpClient("relay.nic.in", 25);
            MailMessage message = new MailMessage("websupport-chd@nic.in", EmailSentTo);
            message.Bcc.Add("websupport-chd@nic.in");
            EmailContent = EmailContent + "";
            EmailContent = EmailContent + "<br /><br />------------------------------------<br />";
            EmailContent = EmailContent + "<font color='gray' face='Verdana' size='2'><br />eDISTRICT TEAM,<br />";
            message.Body = EmailContent;
            message.Subject = EmailSubject;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("websupport-chd@nic.in", "Wifr*876%T");
            message.IsBodyHtml = true;
	    client.EnableSsl = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(message);
            resulttext = "OK";

        }
        catch (Exception Ex)
        {
            resulttext = "NOT OK";
            MyExceptionHandler.HandleException(Ex);
        }
        return resulttext;
    }

    public Boolean sendEmail()
    {
        bool retValue = false;
        try
        {
            System.Web.Mail.MailMessage myMail = new System.Web.Mail.MailMessage();

            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", "mail.nic.in");
            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", "2");

            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "websupport-chd@nic.in");
            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "Wifr*876%T");
            myMail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
            myMail.From = "websupport-chd@nic.in";
            myMail.To = EmailSentTo;

            myMail.Subject = EmailSubject;

            //EmailContent = EmailContent + "<br /><br />------------------------------------<br /><br />";
            //EmailContent = EmailContent + "Regards,<br /><br />Help Desk,<br />Network & Data Center <br />NATIONAL INFORMATICS CENTER,<br />";
            //EmailContent = EmailContent + "Room No.- ***, 2nd Floor<br />***********<br />Sector-17, Chandigarh (UT)<br />Phone : +91-172-*******<br />Mail : *****d@nic.in";
            myMail.Body = EmailContent;

            myMail.BodyFormat = System.Web.Mail.MailFormat.Html;
            System.Web.Mail.SmtpMail.SmtpServer = "mail.nic.in:465";
            System.Web.Mail.SmtpMail.Send(myMail);

            retValue = true;
        }
        catch (Exception ex)
        {
            retValue = false;
        }

        return retValue;
    }

    public string SendSMS_old(string mobilenumber, string msg)
    {
        string s = "";
        try
        {
           String smsservicetype = "singlemsg";
           HttpWebRequest request;
           request = (HttpWebRequest)WebRequest.Create("http://msdgweb.mgov.gov.in/esms/sendsmsrequest");
           request.ProtocolVersion = HttpVersion.Version10;
	   request.KeepAlive = false;
	   request.ServicePoint.ConnectionLimit = 1;
           ((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 5.0; Windows 98;DigExt)";
           request.Method = "POST";
           //For single message.
           String query = "username=" + HttpUtility.UrlEncode("CHDIT-EDISTRICT") +
           "&password=" + HttpUtility.UrlEncode("eDi5tr1ct$321") + "&smsservicetype=" + HttpUtility.UrlEncode(smsservicetype) + "&content=" + HttpUtility.UrlEncode(msg) + "&mobileno=" + HttpUtility.UrlEncode(mobilenumber) + "&senderid=" + HttpUtility.UrlEncode("ESMPRK");
           byte[] byteArray = Encoding.ASCII.GetBytes(query);
           request.ContentType = "application/x-www-form-urlencoded";
           request.ContentLength = byteArray.Length;
           Stream dataStream = request.GetRequestStream();
           dataStream.Write(byteArray, 0, byteArray.Length);
           dataStream.Close();
           WebResponse response = request.GetResponse();
           String Status = ((HttpWebResponse)response).StatusDescription;
           dataStream = response.GetResponseStream();
           StreamReader reader = new StreamReader(dataStream);
           string responseFromServer = reader.ReadToEnd();
           reader.Close();
           dataStream.Close();
           response.Close();
            s = "OK";
            

        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
        }
        return s;
    }
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
}

class MyPolicy : ICertificatePolicy
 {

     public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)

     {

         return true;

     }

 }
