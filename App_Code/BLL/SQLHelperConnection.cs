using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDistrictBL
{
   public class SQLHelperConnection
    {
        public static string ConnStringDefault
        {
            get
            {
                
                return System.Configuration.ConfigurationManager.ConnectionStrings["ChandigarhEServicesEB"].ConnectionString.ToString();
            }

        }
    }
}
