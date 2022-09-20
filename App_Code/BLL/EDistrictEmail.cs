using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace EDistrictBL
{
    public class EDistrictEmail
    {
        #region Properties
        public Int64 EmailLogId { get; set; }
        public string EmailSentTo { get; set; }
        public string EmailSentFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailContent { get; set; }
        public DateTime? EmailSentDate { get; set; }
        public string EmailPurpose { get; set; }

        public string  MobileNo { get; set; }
        public string SMS { get; set; }
        public string IPAddress { get; set; }
        #endregion

        #region Function

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
            prm[5] = new SqlParameter("@MessageMobile", SqlDbType.VarChar, 200) { Value = SMS };
            prm[6] = new SqlParameter("@MessageEmail", SqlDbType.VarChar, 2000) { Value = EmailContent };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "LOGEmailandSMS", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
       

        public Boolean sendEmail()
        {
            //Create the msg object to be sent
            MailMessage msg = new MailMessage();
            //Add your email address to the recipients
            msg.To.Add(EmailSentTo);
            //Configure the address we are sending the mail from
            MailAddress address = new MailAddress("xs2developertest@gmail.com");
            msg.From = address;
            //Append their name in the beginning of the subject
            msg.Subject = EmailSubject;
            msg.Body = EmailContent;
            msg.IsBodyHtml = false;
            
            //Configure an SmtpClient to send the mail.
            SmtpClient client = new SmtpClient("mail.gmail.com");
            client.EnableSsl = false; //only enable this if your provider requires it
            //Setup credentials to login to our sender email address ("UserName", "Password")
            NetworkCredential credentials = new NetworkCredential("xs2developertest@gmail.com","Admin#123");
            client.Credentials = credentials;
            //Send the msg
            Boolean retValue=false;
            try
            {
                client.Send(msg);
                retValue = true;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                retValue = false;
            }

            return retValue;
        }

        public string NewEmailMethod()
        {
            string resulttext;
            try
            {
                SmtpClient client = new SmtpClient("relay.nic.in", 25);
                MailMessage message = new MailMessage("websupport-chd@nic.in", EmailSentTo);
                message.Bcc.Add("websupport-chd@nic.in");
                //message.CC.Add(ConfigurationManager.AppSettings["CCc"].ToString());
                //message.CC.Add(ConfigurationManager.AppSettings["BCC"].ToString());
                //******************************************
                EmailContent = EmailContent + "";
                EmailContent = EmailContent + "<br /><br />------------------------------------<br />";
                EmailContent = EmailContent + "<font color='gray' face='Verdana' size='2'><br />eDISTRICT TEAM,<br />";
                //EmailContent = EmailContent + "Sector-17, Chandigarh (UT)<br />Phone : +91-172-2740708<br />Mail : websupport-chd@nic.in</font>";
                //******************************************
                message.Body = EmailContent;
                message.Subject = EmailSubject;
                client.Credentials = new System.Net.NetworkCredential("websupport-chd@nic.in", "Wifr*876%T");
                message.IsBodyHtml = true;
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

        #endregion


    }
}
