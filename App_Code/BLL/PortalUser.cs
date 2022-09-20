using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
   public class PortalUser
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
        #endregion
        #region Function
        public DataSet GetDashBoardForPortalUser()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@PortalUserCode", SqlDbType.VarChar, 15) { Value = pendingwith };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDashBoardForPortalUser", prm);

            return ds;

        }
        public DataSet GetProcessInfoForIncome()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForIncome", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetProcessInfoForCaste()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForCaste", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        #endregion
    }
}
