using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EDistrictBL
{
    public class TempTraResidenceCertificate : TempEntryGeneral
    {
        #region Properties
        public Int64 ServiceId { get; set; }
        public string TempApplicationNo { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryFatherName { get; set; }
        public DateTime? BeneficiaryDOB { get; set; }
        public string BeneficiaryAge { get; set; }
        public string BeneficiaryGender { get; set; }
        public Int32 BeneficiaryMaritalStatus { get; set; }
        public string IsBeneficiaryApplicantAddressSame { get; set; }
        public string BeneficiaryPremises { get; set; }
        public string BeneficiaryLocality { get; set; }
        public Int32 BeneficiaryLocalityId { get; set; }
        public Int32 BeneficiaryPINCode { get; set; }
        public string BeneficiaryTehsil { get; set; }
        public string BeneficiaryDistrict { get; set; }
        public string BeneficiaryState { get; set; }
        public byte[] BeneficiaryPhoto { get; set; }
        public DateTime? ResidingChandigarhSince { get; set; }
        public string ResidingPeriodChandigarh { get; set; }
        public string Relationship { get; set; }
        public string PurposeCertificate { get; set; }
        public Int32 UserType { get; set; }
        #endregion


        #region function
        public DBReturn InsertTempTraResidenceCertificate()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[32];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[3] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = Relationship };
                prm[7] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                prm[8] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[9] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[10] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[11] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[12] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[13] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[14] = new SqlParameter("@BeneficiaryName", SqlDbType.VarChar, 99) { Value = BeneficiaryName };
                prm[15] = new SqlParameter("@BeneficiaryFatherName", SqlDbType.VarChar, 99) { Value = BeneficiaryFatherName };
                prm[16] = new SqlParameter("@BeneficiaryDOB", SqlDbType.DateTime) { Value = BeneficiaryDOB };
                prm[17] = new SqlParameter("@ABeneficiaryAge", SqlDbType.VarChar, 50) { Value = BeneficiaryAge };
                prm[18] = new SqlParameter("@BeneficiaryGender", SqlDbType.VarChar, 1) { Value = BeneficiaryGender };
                prm[19] = new SqlParameter("@BeneficiaryMaritalStatus", SqlDbType.Int) { Value = BeneficiaryMaritalStatus };
                prm[20] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                prm[21] = new SqlParameter("@ResidingChandigarhSince", SqlDbType.DateTime) { Value = ResidingChandigarhSince };
                prm[22] = new SqlParameter("@ResidingPeriodChandigarh", SqlDbType.VarChar, 50) { Value = ResidingPeriodChandigarh };
                prm[23] = new SqlParameter("@BeneficiaryPhoto", SqlDbType.Image) { Value = BeneficiaryPhoto };
                prm[24] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[28] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[29] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[30] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[30].Direction = ParameterDirection.Output;
                prm[31] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[31].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTempTraResidenceCertificate", prm);
                objReturn.ErrMessage = prm[30].Value.ToString();
                objReturn.ReturnCode = prm[31].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DBReturn UpdateTempTraResidenceCertificate(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[34];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[3] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = Relationship };
                prm[7] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                prm[8] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[9] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[10] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[11] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[12] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[13] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[14] = new SqlParameter("@BeneficiaryName", SqlDbType.VarChar, 99) { Value = BeneficiaryName };
                prm[15] = new SqlParameter("@BeneficiaryFatherName", SqlDbType.VarChar, 99) { Value = BeneficiaryFatherName };
                prm[16] = new SqlParameter("@BeneficiaryDOB", SqlDbType.DateTime) { Value = BeneficiaryDOB };
                prm[17] = new SqlParameter("@ABeneficiaryAge", SqlDbType.VarChar, 50) { Value = BeneficiaryAge };
                prm[18] = new SqlParameter("@BeneficiaryGender", SqlDbType.VarChar, 1) { Value = BeneficiaryGender };
                prm[19] = new SqlParameter("@BeneficiaryMaritalStatus", SqlDbType.Int) { Value = BeneficiaryMaritalStatus };
                prm[20] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                prm[21] = new SqlParameter("@ResidingChandigarhSince", SqlDbType.DateTime) { Value = ResidingChandigarhSince };
                prm[22] = new SqlParameter("@ResidingPeriodChandigarh", SqlDbType.VarChar, 50) { Value = ResidingPeriodChandigarh };
                prm[23] = new SqlParameter("@BeneficiaryPhoto", SqlDbType.Image) { Value = BeneficiaryPhoto };
                prm[24] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[28] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[29] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[30] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[30].Direction = ParameterDirection.Output;
                prm[31] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[31].Direction = ParameterDirection.Output; 
                prm[32] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[33] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraResidenceCertificate", prm);
                objReturn.ErrMessage = prm[30].Value.ToString();
                objReturn.ReturnCode = prm[31].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DataSet GetDataSetClubNotingsForResidence()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value =tempApplicationNo };//in temp applicationNo here actual permanet application number come
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsForResidence", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }

	public DBReturn UpdateTraResidenceCertificateMain(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[34];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[3] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = Relationship };
                prm[7] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                prm[8] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[9] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[10] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[11] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[12] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[13] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[14] = new SqlParameter("@BeneficiaryName", SqlDbType.VarChar, 99) { Value = BeneficiaryName };
                prm[15] = new SqlParameter("@BeneficiaryFatherName", SqlDbType.VarChar, 99) { Value = BeneficiaryFatherName };
                prm[16] = new SqlParameter("@BeneficiaryDOB", SqlDbType.DateTime) { Value = BeneficiaryDOB };
                prm[17] = new SqlParameter("@ABeneficiaryAge", SqlDbType.VarChar, 50) { Value = BeneficiaryAge };
                prm[18] = new SqlParameter("@BeneficiaryGender", SqlDbType.VarChar, 1) { Value = BeneficiaryGender };
                prm[19] = new SqlParameter("@BeneficiaryMaritalStatus", SqlDbType.Int) { Value = BeneficiaryMaritalStatus };
                prm[20] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                prm[21] = new SqlParameter("@ResidingChandigarhSince", SqlDbType.DateTime) { Value = ResidingChandigarhSince };
                prm[22] = new SqlParameter("@ResidingPeriodChandigarh", SqlDbType.VarChar, 50) { Value = ResidingPeriodChandigarh };
                prm[23] = new SqlParameter("@BeneficiaryPhoto", SqlDbType.Image) { Value = BeneficiaryPhoto };
                prm[24] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[28] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[29] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[30] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[30].Direction = ParameterDirection.Output;
                prm[31] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[31].Direction = ParameterDirection.Output;
                prm[32] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[33] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTraResidenceCertificateMain", prm);
                objReturn.ErrMessage = prm[30].Value.ToString();
                objReturn.ReturnCode = prm[31].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }

public DBReturn UpdateResidingDate()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[4];
                prm[0] = new SqlParameter("@ApplicantNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
                prm[1] = new SqlParameter("@ResidingDate", SqlDbType.DateTime) { Value = ResidingChandigarhSince };
                
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateResidenceCertificateResidingDate", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }

        #endregion
    }
}
