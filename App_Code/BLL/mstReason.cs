using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
   public class mstReason
    {
        public string ReasonDesc;
        public string ServiceCode;
        public string IsActive;
        public DBReturn InsertReason()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
         
            prm[0] = new SqlParameter("@Reason", SqlDbType.NVarChar,800) { Value = ReasonDesc };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.NVarChar, 50) { Value = ServiceCode };
            prm[2] = new SqlParameter("@IsActive", SqlDbType.Char, 1) { Value = IsActive };
            prm[3] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[3].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "mstInsertReason", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            return objReturn;

        }
        public DataTable GetServiceCode()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceCode");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataTable GetAllReason()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllReasons", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DataTable GetReason()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.NVarChar, 50) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetReasonss", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
    }
}
