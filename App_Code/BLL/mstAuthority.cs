using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstAuthority
    {
        #region Properties
        public string AuthCode { get; set; }
        public string ServiceCode { get; set; }
        public string OfficeCode { get; set; }
        public DateTime? AuthEntryDate { get; set; }
        public string AuthIsActive { get; set; }
   


        #endregion

        #region My_Function
        public DataTable GetAllAuthority()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllAuthority", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        #endregion



        public DataTable GetServiceAuthorityForoffice()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceAuthorityForoffice", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn InsertAuthority()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@AuthCode", SqlDbType.Char, 10) { Value = AuthCode };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.VarChar,8) { Value = ServiceCode };
            prm[2] = new SqlParameter("@OfficeCode", SqlDbType.Char,10) { Value = OfficeCode };
            prm[3] = new SqlParameter("@AuthIsActive", SqlDbType.Char,1) { Value = AuthIsActive };
            prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[4].Direction = ParameterDirection.Output;
         

            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertAuthority", prm);
            objReturn.ErrMessage = prm[4].Value.ToString();

            return objReturn;
        }
        public DataTable GetAllAuthorityDetail()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllAuthority", prm);
            if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
            {
                dt = ds.Tables[1];
            }
            return dt;

        }
	public DataTable GetServiceAuthorityForService()
        {
            DataTable dt = new DataTable();     
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 30) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceAuthorityForService", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
    }
     
}
