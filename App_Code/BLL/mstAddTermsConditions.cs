using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstAddTermsConditions
    {
        public string Id;
        public string Eventname;
        public string EventCode;
        public string Termscondition;
        public string ConditionisActive;

        public DBReturn InsertTermsConditionDetail()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Id", SqlDbType.VarChar, 100) { Value = Id };
            prm[1] = new SqlParameter("@EventName", SqlDbType.VarChar, 100) { Value = Eventname };
            prm[2] = new SqlParameter("@EventCode", SqlDbType.VarChar, 1000) { Value = EventCode };
            prm[3] = new SqlParameter("@TermsCondition", SqlDbType.VarChar, 1000) { Value = Termscondition };
            prm[4] = new SqlParameter("@ConditionisActive", SqlDbType.Char, 1) { Value = ConditionisActive };
            prm[5] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[5].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "mstInsertTermsConditions", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            return objReturn;
        }
        public DataTable GetAllTermsConditions()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllTermsConditions", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
    }
     
}