using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EDistrictBL
{
    public class DBReturn
    {
        public string ErrMessage { get; set; }
        public string ReturnCode { get; set; }
        public DataSet DataSet { get; set; }
        public DataTable DataTable { get; set; }
        public string ApplicationNo { get; set; }

    }
}
