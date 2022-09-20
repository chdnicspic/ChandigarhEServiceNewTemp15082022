using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstFeeType
    {
        #region property
        public Int32 FeeCode { get; set; }
        public string FeeName { get; set; }
        #endregion


        public DataTable GetAllFeeType()
        {
            DataTable dt = new DataTable();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[0];
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllFeeType", prm);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return dt;
            }
            finally
            {
                dt.Dispose();
            }


        }
        public DBReturn InsertFeeType()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@FeeName", SqlDbType.VarChar, 50) { Value = FeeName };
            prm[1] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "mstInsertfeeType", prm);
            objReturn.ErrMessage = prm[1].Value.ToString();
            return objReturn;
        }
    }
}
