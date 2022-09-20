using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstDesignation
    {
        #region Property
        public Int32 DesigCode { get; set; }
        public string DesigName { get; set; }
        public DateTime? DesigEntryDate { get; set; }
        public string DesigisActive { get; set; }
        public string DesigUpdatedBy { get; set; }
        public DateTime? DesigUpdatedDate { get; set; }
        #endregion

        #region Function


        public DataTable GetAllDesignation()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllDesignation", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }

        public DBReturn InsertDesignation()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@DesigName", SqlDbType.VarChar, 50) { Value = DesigName };
            prm[1] = new SqlParameter("@DesigUpdatedBy", SqlDbType.VarChar, 15) { Value = DesigUpdatedBy };
            prm[2] = new SqlParameter("@DesigisActive", SqlDbType.Char, 1) { Value = DesigisActive };
            prm[3] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[3].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertDesignation", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            return objReturn;
        }

        #endregion
    }
}
