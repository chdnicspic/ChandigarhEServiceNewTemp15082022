using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/// <summary>
/// Summary description for newDashboard
/// </summary>
/// 

namespace EDistrictBL
{
    
    public class newDashboard
    {
        #region Properties
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ServiceCode { get; set; }
        public int Flag { get; set; }
        public string strFlag { get; set; }
        public string Authority { get; set; }

        #endregion
        public newDashboard()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet Getlevel1Dashboard()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@FromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNewDashboardlevel1", prm);
            return ds;

        }
        public DataSet GetAuthorityWiseDelaylist()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@FromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[3] = new SqlParameter("@Flag", SqlDbType.Int) { Value = Flag };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "AuthorityWiseDelaylist", prm);
            return ds;

        }
        public DataSet Getlevel1()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            //prm[0] = new SqlParameter("@FromDate", SqlDbType.DateTime) { Value = FromDate };
            //prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            //prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Getlevel1", prm);
            return ds;

        }
        public DataSet GetLevel2Board()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Flag", SqlDbType.Char,1) { Value = strFlag };
            //prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            //prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetLevel2Board", prm);
            return ds;

        }


        public DataSet GetLevel3Board()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Flag", SqlDbType.Char, 1) { Value = strFlag };
            prm[1] = new SqlParameter("@Service", SqlDbType.VarChar,50 ) { Value = ServiceCode };
            //prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            //prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetLevel3Board", prm);
            return ds;
        }
        public DataSet GetLevel4Board()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Flag", SqlDbType.Char, 1) { Value = strFlag };
            prm[1] = new SqlParameter("@Service", SqlDbType.VarChar, 50) { Value = ServiceCode };
            prm[2] = new SqlParameter("@Authority", SqlDbType.VarChar, 50) { Value = Authority };
            //prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
            //prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetLevel4Board", prm);
            return ds;
        }
        public System.Data.DataSet GetServiceProcessAnalysis()
	        {
	            DataTable dt = new DataTable();
	            DBReturn objReturn = new DBReturn();
	            SqlParameter[] prm = new SqlParameter[3];
	            //prm[0] = new SqlParameter("@Flag", SqlDbType.Char, 1) { Value = strFlag };
	            //prm[1] = new SqlParameter("@Service", SqlDbType.VarChar, 50) { Value = ServiceCode };
	            //prm[2] = new SqlParameter("@Authority", SqlDbType.VarChar, 50) { Value = Authority };
	            //prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
	            //prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceProcessAnalysisRTS", prm);
	            return ds;
        }

    }
}