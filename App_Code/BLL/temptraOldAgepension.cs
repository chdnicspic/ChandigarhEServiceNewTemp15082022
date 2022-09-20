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
    public class temptraOldAgepension : TempEntryGeneral
    {
        #region properties
        public Int64 ServiceId { get; set; }

        public string ApplicantAge { get; set; }
        public string MarkOfIdentification { get; set; }
        public string TempPremises { get; set; }
        public string TempLocality { get; set; }
        public Int32 TempPINCode { get; set; }
        public string TempDistrict { get; set; }
        public string TempState { get; set; }
        public string TempTehsil { get; set; }
        public string PermPremises { get; set; }
        public string PermLocality { get; set; }
        public Int32 PermPINCode { get; set; }
        public string PermDistrict { get; set; }
        public string PermState { get; set; }
        public string PermTehsil { get; set; }
        public string SourceOfmaintenance { get; set; }
        public decimal FamilyIncome { get; set; }
        public string BelongToSC { get; set; }
        public string OccupationBeforeDisablity { get; set; }
        public string ParticularsOfIncome { get; set; }
        public string AnyPension { get; set; }
        public string AnyProperty { get; set; }
        public decimal MoveablePropertyValue { get; set; }
        public decimal RealBalanceDeposit { get; set; }
        public decimal ImmoveablePropertyValue { get; set; }
        public decimal InvestmentInGovtSecurities { get; set; }
        public decimal OtherSourceIncome { get; set; }
        public string AnyLoan { get; set; }
        public string LoanDetails { get; set; }
        public string AnyEarlierApply { get; set; }
        public string EarlierApplyDetail { get; set; }
        public string RefPersonName1 { get; set; }
        public string RefPersonAddress { get; set; }
        public string RefPersonName2 { get; set; }
        public string RefPersonAddress2 { get; set; }
        public string IsSpouseAlive { get; set; }
        public string TehsildarLetterNo { get; set; }
        public DateTime? TehsildarLetterDate { get; set; }
        public decimal TehsildarVerifiedIncome { get; set; }
        public string PMOVerifiedAge { get; set; }
        public DateTime? PMOVerificationDate { get; set; }
        public string PMOReferenceNo { get; set; }
        public byte[] ApplicantPhoto { get; set; }
        public string IsTempPremAddressSame { get; set; }
        public int YearsOfStayinChandigarh { get; set; }
        public string ProofOfAge { get; set; }
        public int UserType { get; set; }
        public DataTable MyFamilyDetail { get; set; }
        public decimal PensionAmount { get; set; }
        public string UserCode { get; set; }
        public string ServiceName { get; set; }




        #endregion
        public DBReturn InsertTempOldAgePension()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[61];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[2] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[3] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[4] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[5] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[6] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[7] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[8] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[9] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                prm[10] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[11] = new SqlParameter("@BelongToSC", SqlDbType.VarChar, 1) { Value = BelongToSC };
                prm[12] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[13] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[14] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[15] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[16] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[17] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[18] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[19] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[20] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[21] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[22] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[23] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[24] = new SqlParameter("@SourceOfmaintenance", SqlDbType.VarChar, 100) { Value = SourceOfmaintenance };
                prm[25] = new SqlParameter("@FamilyIncome", SqlDbType.Decimal) { Value = FamilyIncome };
                prm[26] = new SqlParameter("@OccupationBeforeDisablity", SqlDbType.VarChar, 50) { Value = OccupationBeforeDisablity };
                prm[27] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = AnyPension };
                prm[28] = new SqlParameter("@PensionAmount", SqlDbType.Decimal) { Value = PensionAmount };
                prm[29] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                prm[30] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveablePropertyValue };
                prm[31] = new SqlParameter("@RealBalanceDeposit", SqlDbType.Decimal) { Value = RealBalanceDeposit };
                prm[32] = new SqlParameter("@ImmoveablePropertyValue", SqlDbType.Decimal) { Value = ImmoveablePropertyValue };
                prm[33] = new SqlParameter("@InvestmentInGovtSecurities", SqlDbType.Decimal) { Value = InvestmentInGovtSecurities };
                prm[34] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = OtherSourceIncome };

                prm[35] = new SqlParameter("@AnyLoan", SqlDbType.VarChar, 1) { Value = AnyLoan };
                prm[36] = new SqlParameter("@LoanDetails", SqlDbType.VarChar, 100) { Value = LoanDetails };
                prm[37] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = AnyEarlierApply };
                prm[38] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierApplyDetail };


                prm[39] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                prm[40] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                prm[41] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                prm[42] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                prm[43] = new SqlParameter("@IsSpouseAlive", SqlDbType.VarChar, 1) { Value = IsSpouseAlive };
                prm[44] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                //prm[45] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[45] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[46] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[47] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[47].Direction = ParameterDirection.Output;
                prm[48] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[48].Direction = ParameterDirection.Output;
                prm[49] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[50] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };

                prm[51] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = MyFamilyDetail };
                prm[52] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[53] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPremAddressSame };
                prm[54] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsOfStayinChandigarh };
                prm[55] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                prm[56] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };
                prm[57] = new SqlParameter("@PMOVerificationDate", SqlDbType.DateTime) { Value = PMOVerificationDate };
                prm[58] = new SqlParameter("@PMOVerifiedAge", SqlDbType.VarChar, 3) { Value = PMOVerifiedAge };
                prm[59] = new SqlParameter("@ProofofAge", SqlDbType.VarChar, 1) { Value = ProofOfAge };
                prm[60] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTempOldAgePension", prm);
                objReturn.ErrMessage = prm[47].Value.ToString();
                objReturn.ReturnCode = prm[48].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }

        }
        public DBReturn UpdateTempOldAgepension(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[63];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[2] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[3] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[4] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[5] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[6] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[7] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[8] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[9] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                prm[10] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[11] = new SqlParameter("@BelongToSC", SqlDbType.VarChar, 1) { Value = BelongToSC };
                prm[12] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[13] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[14] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[15] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[16] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[17] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[18] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[19] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[20] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[21] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[22] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[23] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[24] = new SqlParameter("@SourceOfmaintenance", SqlDbType.VarChar, 100) { Value = SourceOfmaintenance };
                prm[25] = new SqlParameter("@FamilyIncome", SqlDbType.Decimal) { Value = FamilyIncome };
                prm[26] = new SqlParameter("@OccupationBeforeDisablity", SqlDbType.VarChar, 50) { Value = OccupationBeforeDisablity };
                prm[27] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = AnyPension };
                prm[28] = new SqlParameter("@PensionAmount", SqlDbType.Decimal) { Value = PensionAmount };

                prm[29] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                prm[30] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveablePropertyValue };
                prm[31] = new SqlParameter("@RealBalanceDeposit", SqlDbType.Decimal) { Value = RealBalanceDeposit };
                prm[32] = new SqlParameter("@ImmoveablePropertyValue", SqlDbType.Decimal) { Value = ImmoveablePropertyValue };
                prm[33] = new SqlParameter("@InvestmentInGovtSecurities", SqlDbType.Decimal) { Value = InvestmentInGovtSecurities };
                prm[34] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = OtherSourceIncome };

                prm[35] = new SqlParameter("@AnyLoan", SqlDbType.VarChar, 1) { Value = AnyLoan };
                prm[36] = new SqlParameter("@LoanDetails", SqlDbType.VarChar, 100) { Value = LoanDetails };
                prm[37] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = AnyEarlierApply };
                prm[38] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierApplyDetail };


                prm[39] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                prm[40] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                prm[41] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                prm[42] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                prm[43] = new SqlParameter("@IsSpouseAlive", SqlDbType.VarChar, 1) { Value = IsSpouseAlive };
                prm[44] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                //prm[45] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[45] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[46] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[47] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[47].Direction = ParameterDirection.Output;
                prm[48] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[48].Direction = ParameterDirection.Output;
                prm[49] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[50] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };

                prm[51] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = MyFamilyDetail };
                prm[52] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[53] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPremAddressSame };
                prm[54] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[55] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[56] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsOfStayinChandigarh };
                prm[57] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                prm[58] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };
                prm[59] = new SqlParameter("@PMOVerificationDate", SqlDbType.DateTime) { Value = PMOVerificationDate };
                prm[60] = new SqlParameter("@PMOVerifiedAge", SqlDbType.VarChar, 3) { Value = PMOVerifiedAge };
                prm[61] = new SqlParameter("@ProofofAge", SqlDbType.VarChar, 1) { Value = ProofOfAge };
                prm[62] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempOldAgePension", prm);
                objReturn.ErrMessage = prm[47].Value.ToString();
                objReturn.ReturnCode = prm[48].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DataSet GetDataSetClubNotingsForoldagepension()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };//in temp applicationNo here actual permanet application number come
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsForoldagepension", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
        public DataSet GetOldAgePensionFamilyDetails()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];

                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetOldAgePensionFamilyDetails", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }
        }
        public DataSet GetPensionAmount()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPensionAmount", prm);
                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DBReturn UpdatePensionAmount()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[6];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ServiceName", SqlDbType.VarChar, 50) { Value = ServiceName };
                prm[2] = new SqlParameter("@PensionAmount", SqlDbType.Decimal) { Value = PensionAmount };
                prm[3] = new SqlParameter("@UserCode", SqlDbType.VarChar, 50) { Value = UserCode };
                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdatePensionAmount", prm);
                objReturn.ErrMessage = prm[4].Value.ToString();
                objReturn.ReturnCode = prm[5].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
    }
}
