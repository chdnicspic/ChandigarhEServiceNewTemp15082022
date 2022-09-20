using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class dashBoard
    {
        #region MyProperties
        public string OfficeCode { get; set; }
        public string Officename { get; set; }
        public string serviceCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string applicationStatus { get; set; }
        public string ApplicationNo { get; set; }
        #endregion

        public DataSet DashBoardMainGrid()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@officeCode", SqlDbType.VarChar, 30) { Value = OfficeCode };
            prm[1] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = serviceCode };
            prm[2] = new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[3] = new SqlParameter("@todate", SqlDbType.DateTime) { Value = ToDate };
            prm[4] = new SqlParameter("@returnCode", SqlDbType.Int);
            prm[4].Direction = ParameterDirection.Output;

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "DashBoardMain", prm);

            return ds;
        }

        public DataSet DashBoardSecondLevelGrid()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 30) { Value = OfficeCode };
            prm[1] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = serviceCode };
            prm[2] = new SqlParameter("@ApplicationStatus", SqlDbType.VarChar, 800) { Value = applicationStatus };
            prm[3] = new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[4] = new SqlParameter("@todate", SqlDbType.DateTime) { Value = ToDate };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "dashBoardSecondLevel", prm);

            return ds;
        }

        public DataSet DashBoardAppTransaction()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ApplicationTransactions", prm);

            return ds;
        }
        public DataSet DashBoardUserwisePendency()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 30) { Value = OfficeCode };
            prm[1] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = serviceCode };
            prm[2] = new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = FromDate };
            prm[3] = new SqlParameter("@todate", SqlDbType.DateTime) { Value = ToDate };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UserwisePendingApplications", prm);

            return ds;
        }
    }
}
