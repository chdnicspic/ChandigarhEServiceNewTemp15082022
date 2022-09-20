using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class Report
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string DepartmentCode { get; set; }
        public string OfficeCode { get; set; }
        public string ServiceCode { get; set; }




        public DataTable GetDailyApplicationRegister()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@FromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[1] = new SqlParameter("@Todate", SqlDbType.DateTime) { Value = ToDate };
            prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 4000) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "rpt_GetDailyApplicationRegister", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
    }
}
