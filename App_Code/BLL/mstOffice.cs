using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstOffice
    {
        #region Properties
        public string OfficeCode { get; set; }
        public string Officename { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficePhone { get; set; }
        public string OfficePhone1 { get; set; }
        public string OfficePhone2 { get; set; }
        public DateTime? OfficeEntryDate { get; set; }
        public string OfficeIsActive { get; set; }
        public string OfficeDeptCode { get; set; }
        public string ApplicationNo { get; set; }
        public string office { get; set; }
        public string officeparameter { get; set; }
        public string TimeInterval { get; set; }
	public DateTime? EndDate { get; set; }
        #endregion


        #region Function
	public DataTable CashSummaryForReportPrint()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@OOfficeCode", SqlDbType.NVarChar, 50) { Value = office };
            prm[1] = new SqlParameter("@ReceiptStartDate", SqlDbType.DateTime) { Value = OfficeEntryDate };
            prm[2] = new SqlParameter("@ReceiptEndDate", SqlDbType.DateTime) { Value = EndDate };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getCashSummaryForPrint", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DataTable GetAllOffice()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllOffices");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataTable GetOfficeForDepartment()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = OfficeDeptCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetOfficeForDepartment", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DataTable GetOfficeForNoticeDeptWise()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = OfficeDeptCode };
            prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeOfficeForDeptWise", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DataTable GetOfficeDetailforReceiptCashBook()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@office", SqlDbType.NVarChar, 50) { Value = office };
            prm[1] = new SqlParameter("@date", SqlDbType.DateTime) { Value = OfficeEntryDate };
            prm[2] = new SqlParameter("@officenameparameter", SqlDbType.NVarChar,50) { Value = officeparameter };
            prm[3] = new SqlParameter("@TimeInterval", SqlDbType.NVarChar, 50) { Value = TimeInterval };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getReceiptCashBook", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DBReturn InsertOffice()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@OfficeDeptCode", SqlDbType.Char,5) { Value = OfficeDeptCode };
            prm[1] = new SqlParameter("@Officename", SqlDbType.VarChar, 50) { Value = Officename };
            prm[2] = new SqlParameter("@OfficeAddress", SqlDbType.VarChar,50) { Value = OfficeAddress };
            prm[3] = new SqlParameter("@OfficePhone", SqlDbType.VarChar, 15) { Value = OfficePhone };
            prm[4] = new SqlParameter("@OfficePhone1", SqlDbType.VarChar, 15) { Value = OfficePhone1 };
            prm[5] = new SqlParameter("@OfficePhone2", SqlDbType.VarChar, 15) { Value = OfficePhone2 };
            prm[6] = new SqlParameter("@OfficeIsActive", SqlDbType.Char, 1) { Value = OfficeIsActive };
            prm[7] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[7].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertoffice", prm);
            objReturn.ErrMessage = prm[7].Value.ToString();
            return objReturn;
        }
	public DataTable CashSummary()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@OOfficeCode", SqlDbType.NVarChar, 50) { Value = office };
            prm[1] = new SqlParameter("@ReceiptStartDate", SqlDbType.DateTime) { Value = OfficeEntryDate };
            prm[2] = new SqlParameter("@ReceiptEndDate", SqlDbType.DateTime) { Value = EndDate };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getCashSummary", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
        public DataTable GetDashboardOffice()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "oFFICE_IN_WORKFLOW");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        #endregion

    }
}
