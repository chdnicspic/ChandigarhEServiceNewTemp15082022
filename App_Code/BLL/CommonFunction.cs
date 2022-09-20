using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EDistrictBL
{
    public class CommonFunction
    {
        public string md5(string sPassword)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(sPassword);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }


        public string GenerateRandomString(int length)
        {
            //It will generate string with combination of small,capital letters and numbers
            char[] charArr = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@*$#^&-".ToCharArray();
            string randomString = string.Empty;
            Random objRandom = new Random();
            for (int i = 0; i < length; i++)
            {
                //Don't Allow Repetation of Characters
                int x = objRandom.Next(1, charArr.Length);
                if (!randomString.Contains(charArr.GetValue(x).ToString()))
                    randomString += charArr.GetValue(x);
                else
                    i--;
            }
            return randomString;
        }


        public DateTime GetDateAsMMDDYYYY(string Date)
        {

            string[] myDate = Date.Split('/');
            DateTime RetDate = new DateTime(Convert.ToInt32(myDate[2]), Convert.ToInt32(myDate[1]), Convert.ToInt32(myDate[0]));
            return RetDate;
        }

        public string CalculateAge(DateTime Dob)
        {
            try
            {


                DateTime Now = DateTime.Now;
                int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
                DateTime PastYearDate = Dob.AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (PastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (PastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
                int Hours = Now.Subtract(PastYearDate).Hours;
                int Minutes = Now.Subtract(PastYearDate).Minutes;
                int Seconds = Now.Subtract(PastYearDate).Seconds;
                return String.Format("{0} Year(s) {1} Month(s) {2} Day(s) ",
                                    Years, Months, Days);//{3} Hour(s) {4} Second(s), Hours, Seconds
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return "";
            }
        }
        public string DataTableToJSONWithJavaScriptSerializer(DataTable table)
	        {
	            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
	            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
	            Dictionary<string, object> childRow;
	            foreach (DataRow row in table.Rows)
	            {
	                childRow = new Dictionary<string, object>();
	                foreach (DataColumn col in table.Columns)
	                {
	                    childRow.Add(col.ColumnName, row[col]);
	                }
	                parentRow.Add(childRow);
	            }
	            return jsSerializer.Serialize(parentRow);
        }

        public string Calculateyearfromdate(DateTime Dob)
        {
            try
            {


                DateTime Now = DateTime.Now;
                int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
                DateTime PastYearDate = Dob.AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (PastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (PastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
                int Hours = Now.Subtract(PastYearDate).Hours;
                int Minutes = Now.Subtract(PastYearDate).Minutes;
                int Seconds = Now.Subtract(PastYearDate).Seconds;
                return String.Format("{0}",
                                    Years);//{3} Hour(s) {4} Second(s), Hours, Seconds
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return "";
            }
        }

    }
}
