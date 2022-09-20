using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstDepartment
    {


        #region Properties
        public string deptCode { get; set; }
        public string deptname { get; set; }
        public string deptAddress { get; set; }
        public string deptPhone { get; set; }
        public string deptPhone1 { get; set; }
        public string deptPhone2 { get; set; }
        public DateTime? deptEntryDate { get; set; }
        public string deptIsActive { get; set; }
        #endregion




        #region Function


        public DataTable GetAllDepartment()
        {
            DataTable dt=new DataTable ();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds=SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllDepartment", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
            
        }


        public DBReturn InsertDepartment()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@deptname", SqlDbType.VarChar, 50) { Value = deptname };
            prm[1] = new SqlParameter("@deptAddress", SqlDbType.VarChar, 100) { Value = deptAddress };
            prm[2] = new SqlParameter("@deptPhone", SqlDbType.VarChar, 15) { Value = deptPhone };
            prm[3] = new SqlParameter("@deptPhone1", SqlDbType.VarChar, 15) { Value = deptPhone1 };
            prm[4] = new SqlParameter("@deptPhone2", SqlDbType.VarChar, 15) { Value = deptPhone2 };
            prm[5] = new SqlParameter("@deptIsActive", SqlDbType.Char, 1) { Value = deptIsActive };
            prm[6] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[6].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertDepartment", prm);
            objReturn.ErrMessage = prm[6].Value.ToString();
            return objReturn;
        }

        #endregion
    }
}
