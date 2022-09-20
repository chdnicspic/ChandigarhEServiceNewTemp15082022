using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
namespace EDistrictBL
{
    public class MyExceptionHandler
    {


        public static void HandleException(Exception Ex)
        {

            string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            string sErrorTime = sYear + sMonth + sDay;
            LogException(Ex, sLogFormat, sErrorTime);
        }

        private static void LogException(Exception Ex,string sLogFormat,string sErrorTime)
        {
            String SystemPath = HttpContext.Current.Server.MapPath("~/ElectricityBoard/ExceptionLog/ExceptionLog");
            StreamWriter sw = new StreamWriter(SystemPath + sErrorTime, true);
            sw.WriteLine("*************************************************************");
            sw.WriteLine(sLogFormat);
            sw.WriteLine("**************Exception Message******************************");
            sw.WriteLine(Ex.Message.ToString());
            sw.WriteLine(Ex.StackTrace.ToString());
            sw.WriteLine(Ex.Source.ToString());
            sw.WriteLine("Machine IP : " + HttpContext.Current.Request.UserHostAddress);
            sw.WriteLine("------------------------------------------------------------");

            sw.Flush();
            sw.Close();
 
        }
        public static void HandleException(string Ex)
	        {
	
	            string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
	            string sYear = DateTime.Now.Year.ToString();
	            string sMonth = DateTime.Now.Month.ToString();
	            string sDay = DateTime.Now.Day.ToString();
	            string sErrorTime = sYear + sMonth + sDay;
	            LogException(Ex, sLogFormat, sErrorTime);
	
	        }
	
	private static void LogException(string Ex, string sLogFormat, string sErrorTime)
	        {
	            String SystemPath = HttpContext.Current.Server.MapPath("~/ExceptionLog/ExceptionLog");
	            StreamWriter sw = new StreamWriter(SystemPath + sErrorTime, true);
	            sw.WriteLine("*************************************************************");
	            sw.WriteLine(sLogFormat);
	            sw.WriteLine("**************Exception Message******************************");
	            sw.WriteLine(Ex.ToString());
	            //sw.WriteLine(Ex.StackTrace.ToString());
	            //sw.WriteLine(Ex.Source.ToString());
	            sw.WriteLine("Machine IP : " + HttpContext.Current.Request.UserHostAddress);
	            sw.WriteLine("------------------------------------------------------------");
	
	            sw.Flush();
	            sw.Close();
	
        }

    }
}
