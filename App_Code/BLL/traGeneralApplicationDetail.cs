using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class traGeneralApplicationDetail
    {

        #region property
        public Int64 Id { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantLastName { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string ServiceCode { get; set; }
        public string subservicecode { get; set; }
        public string ApplicationYear { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicantFatherName { get; set; }
        public string AppliedBy { get; set; }
        public string AppliedByFatherName { get; set; }
        public string Authority { get; set; }
        public string ApplicantPremises { get; set; }
        public Int32 ApplicantLocalityId { get; set; }
        public string ApplicantLocality { get; set; }
        public Int32 ApplicantPinCode { get; set; }
        public Int64 ApplicationHeldWith { get; set; }
        public Int64 ApplicationPrevHeldWith { get; set; }
        public string NextLevel { get; set; }
        public string PreviousLevel { get; set; }
        public string CurrentLevel { get; set; }
        public string CurrentStatus { get; set; }
        public string ApplicationEnteredBy { get; set; }
        public DateTime? ApplicationTimeStamp { get; set; }
        public string DocumentUploadStatus { get; set; }
        public string FinalStatus { get; set; }
        public string Remarks { get; set; }
        public string CertificateNo { get; set; }
        public DateTime? CertificateDate { get; set; }
        public string ApplicantMobileNo { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantGender { get; set; }
        public Int32 ApplicantMaritalStatus { get; set; }
        public DateTime? ApplicantDOB { get; set; }
        public string ApplicationEncPath { get; set; }
        public Int64 ApplicationEncDataId { get; set; }
        public Int64 ApplicantAadharNo { get; set; }
        public Int32 District { get; set; }
        public Int32 State { get; set; }
        public Int32 Village { get; set; }
        public string oprcode { get; set; }
        public Int64 ApplicantId { get; set; }
        public string ReceiptNo { get; set; }
        public decimal GovtFee { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal ServiceCharges { get; set; }
        public Int32 pendingwithlevel { get; set; }
        public string pendingwith { get; set; }
        public string pendingwithlevelname { get; set; }
        public string pendingwithleveltype { get; set; }
        public Int32 ToLevel { get; set; }
        public string MarkTo { get; set; }
        public Int32 FromLevel { get; set; }
        public string MarkFrom { get; set; }

        public string UserDepartment { get; set; }
        public Int32 UserDesig { get; set; }
        public string OfficeCode { get; set; }
        #endregion

        #region Function

        public DataSet GetDashBoard()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = pendingwith };
            prm[1] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
            prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 20) { Value = ServiceCode };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
            prm[4] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 101) { Value = ApplicantName };
            prm[5] = new SqlParameter("@UserDepartment", SqlDbType.VarChar, 5) { Value = UserDepartment };
            prm[6] = new SqlParameter("@UserDesignation", SqlDbType.Int) { Value = UserDesig };
            //prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDashBoard", prm);

            return ds;

        }

        //public DataSet GetDashBoard()
        //{
        //    DataSet ds = new DataSet();
        //    DBReturn objReturn = new DBReturn();
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = pendingwith };
        //    prm[1] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
        //    //prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
        //    ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDashBoard", prm);
            
        //    return ds;

        //}



        public DataSet GetSamparkUserDailyRegister()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = oprcode };
            prm[1] = new SqlParameter("@ReportDate", SqlDbType.DateTime) { Value = ApplicationDate };
            prm[2] = new SqlParameter("@OfficeCode", SqlDbType.Char,5) { Value = OfficeCode };
           
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SamparkUserDailyRegister", prm);

            return ds;

        }

        #endregion

        public DataSet GetSamparkBoard()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = pendingwith };
            //prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetSamparkDashBoard", prm);

            return ds;
        }
	  public DataSet GetGeneratedCertificatebyDate()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Usercode", SqlDbType.VarChar, 15) { Value = oprcode };
            prm[1] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = ApplicationDate };
            prm[2] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = CertificateDate };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getGeneratedCertificatebyDate", prm);
            return ds;

        }
        public DataSet GetCurrentApplicationStatus()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetApplicationCurrentStatus", prm);

            return ds;

        }

        public DataSet GetGeneratedPensionOrderbyDate()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Usercode", SqlDbType.VarChar, 15) { Value = oprcode };
            prm[1] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = ApplicationDate };
            prm[2] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = CertificateDate };
            prm[3] = new SqlParameter("@servicecode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetGeneratedPensionOrderbyDate", prm);
            return ds;

        }
    }
}
