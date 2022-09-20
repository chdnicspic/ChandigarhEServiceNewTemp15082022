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
    public class TempTraWidowDestitutePension : TempEntryGeneral
    {
        #region Myproperty
        public Int64 ServiceId { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicantAge { get; set; }
        public string MarkOfIdentification { get; set; }
        public string TempPremises { get; set; }
        public string TempLocality { get; set; }
        public Int32 TempPINCode { get; set; }
        public string TempDistrict { get; set; }
        public string TempState { get; set; }
        public string TempTehsil { get; set; }
        public string TempVillage { get; set; }
        public string PermPremises { get; set; }
        public string PermLocality { get; set; }
        public Int32 PermPINCode { get; set; }
        public string PermDistrict { get; set; }
        public string PermTehsil { get; set; }
        public string PermState { get; set; }
        public string PermVillage { get; set; }
        public string FatherName { get; set; }
        public string HusbandName { get; set; }
        public string ApplicantCategory { get; set; }
        public string IsWidowDestitute { get; set; }
        public DateTime? WHusbandDeathDate { get; set; }
        public string WHusbandProfession { get; set; }
        public string WSrcIncomeAfterDeath { get; set; }
        public string DHusbandProfession { get; set; }
        public string DIsHusbandMissing { get; set; }
        public DateTime? DHusbandMissingDate { get; set; }
        public string DIsHusbandDisabled { get; set; }
        public decimal FamilyIncome { get; set; }
        public string IsPensionGratuity { get; set; }
        public decimal PensionGratuityDetail { get; set; }
        public string IsEarlierAppliedForPension { get; set; }
        public string EarlierAppliedDetail { get; set; }
        public string AnyProperty { get; set; }
        public decimal MoveableProperty { get; set; }
        public decimal Immoveable { get; set; }
        public decimal IncomeFromOtherSource { get; set; }
        public string RefPersonName1 { get; set; }
        public string RefPersonAddress { get; set; }
        public string RefPersonName2 { get; set; }
        public string RefPersonAddress2 { get; set; }
        public string TehsildarLetterNo { get; set; }
        public DateTime? TehsildarLetterDate { get; set; }
        public decimal TehsildarVerifiedIncome { get; set; }
        public string PMOVerifiedAge { get; set; }
        public DateTime? PMOVerificationDate { get; set; }
        public string PMOReferenceNo { get; set; }
        public string BelongToSC { get; set; }
        public string ISTempPremAddressSame { get; set; }
        public byte[] ApplicantPhoto { get; set; }
        public Int32 YearsOfStayinChandigarh { get; set; }
        public string ProofOfAge { get; set; }

        public int UserType { get; set; }
        #endregion





        public DBReturn InsertTempWidowDestitutePension()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[61];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[2] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[3] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[5] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[8] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                prm[9] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[10] = new SqlParameter("@BelongToSC", SqlDbType.VarChar, 1) { Value = BelongToSC };
                prm[11] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[12] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[13] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[14] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[15] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[16] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[17] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[18] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[19] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[20] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[21] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[22] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[23] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = ISTempPremAddressSame };

                prm[24] = new SqlParameter("@IsWidoworDestitute", SqlDbType.VarChar, 1) { Value = IsWidowDestitute };
                prm[25] = new SqlParameter("@HusbandDeath", SqlDbType.DateTime) { Value = WHusbandDeathDate };
                prm[26] = new SqlParameter("@WHusbandOccupation", SqlDbType.VarChar, 50) { Value = WHusbandProfession };
                prm[27] = new SqlParameter("@WSourceOfmaintenanceafterDeath", SqlDbType.VarChar, 50) { Value = WSrcIncomeAfterDeath };

                prm[28] = new SqlParameter("@DHusbandOccupation", SqlDbType.VarChar, 50) { Value = DHusbandProfession };
                prm[29] = new SqlParameter("@DIsHusbandMissing", SqlDbType.VarChar, 1) { Value = DIsHusbandMissing };
                prm[30] = new SqlParameter("@DHusbandMissingDate", SqlDbType.DateTime) { Value = DHusbandMissingDate };
                prm[31] = new SqlParameter("@DHusbandanceDisabled", SqlDbType.VarChar, 1) { Value = DIsHusbandDisabled };
                prm[32] = new SqlParameter("@FamilyIncome", SqlDbType.Decimal) { Value = FamilyIncome };
                prm[33] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = IsPensionGratuity };
                prm[34] = new SqlParameter("@PensionAmount", SqlDbType.Decimal) { Value = PensionGratuityDetail };
                prm[35] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = IsEarlierAppliedForPension };
                prm[36] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierAppliedDetail };
                prm[37] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                prm[38] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveableProperty };
                prm[39] = new SqlParameter("@Immoveableproperty", SqlDbType.Decimal) { Value = Immoveable };
                prm[40] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = IncomeFromOtherSource };
                prm[41] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                prm[42] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                prm[43] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                prm[44] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                prm[45] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[46] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[47] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[48] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[49] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[49].Direction = ParameterDirection.Output;
                prm[50] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[50].Direction = ParameterDirection.Output;
                prm[51] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[52] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[53] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[54] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsOfStayinChandigarh };
                prm[55] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                prm[56] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };

                prm[57] = new SqlParameter("@PMOVerificationDate", SqlDbType.DateTime) { Value = PMOVerificationDate };
                prm[58] = new SqlParameter("@PMOVerifiedAge", SqlDbType.VarChar, 3) { Value = PMOVerifiedAge };
                prm[59] = new SqlParameter("@ProofofAge", SqlDbType.VarChar, 1) { Value = ProofOfAge };
                prm[60] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };



                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTempPensionForWidowDestitute", prm);
                objReturn.ErrMessage = prm[49].Value.ToString();
                objReturn.ReturnCode = prm[50].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }



        public DBReturn UpdateTempWidowDestitutePension(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[63];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[2] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[3] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[5] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[8] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                prm[9] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[10] = new SqlParameter("@BelongToSC", SqlDbType.VarChar, 1) { Value = BelongToSC };
                prm[11] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[12] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[13] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[14] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[15] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[16] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[17] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[18] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[19] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[20] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[21] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[22] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[23] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = ISTempPremAddressSame };

                prm[24] = new SqlParameter("@IsWidoworDestitute", SqlDbType.VarChar, 1) { Value = IsWidowDestitute };
                prm[25] = new SqlParameter("@HusbandDeath", SqlDbType.DateTime) { Value = WHusbandDeathDate };
                prm[26] = new SqlParameter("@WHusbandOccupation", SqlDbType.VarChar, 50) { Value = WHusbandProfession };
                prm[27] = new SqlParameter("@WSourceOfmaintenanceafterDeath", SqlDbType.VarChar, 50) { Value = WSrcIncomeAfterDeath };

                prm[28] = new SqlParameter("@DHusbandOccupation", SqlDbType.VarChar, 50) { Value = DHusbandProfession };
                prm[29] = new SqlParameter("@DIsHusbandMissing", SqlDbType.VarChar, 1) { Value = DIsHusbandMissing };
                prm[30] = new SqlParameter("@DHusbandMissingDate", SqlDbType.DateTime) { Value = DHusbandMissingDate };
                prm[31] = new SqlParameter("@DHusbandanceDisabled", SqlDbType.VarChar, 1) { Value = DIsHusbandDisabled };
                prm[32] = new SqlParameter("@FamilyIncome", SqlDbType.Decimal) { Value = FamilyIncome };
                prm[33] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = IsPensionGratuity };
                prm[34] = new SqlParameter("@PensionAmount", SqlDbType.Decimal) { Value = PensionGratuityDetail };
                prm[35] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = IsEarlierAppliedForPension };
                prm[36] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierAppliedDetail };
                prm[37] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                prm[38] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveableProperty };
                prm[39] = new SqlParameter("@Immoveableproperty", SqlDbType.Decimal) { Value = Immoveable };
                prm[40] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = IncomeFromOtherSource };
                prm[41] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                prm[42] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                prm[43] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                prm[44] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                prm[45] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[46] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[47] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[48] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[49] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[49].Direction = ParameterDirection.Output;
                prm[50] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[50].Direction = ParameterDirection.Output;
                prm[51] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[52] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[53] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[54] = new SqlParameter("@TempApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[55] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[56] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsOfStayinChandigarh };
                prm[57] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                prm[58] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };
                prm[59] = new SqlParameter("@PMOVerificationDate", SqlDbType.DateTime) { Value = PMOVerificationDate };
                prm[60] = new SqlParameter("@PMOVerifiedAge", SqlDbType.VarChar, 3) { Value = PMOVerifiedAge };
                prm[61] = new SqlParameter("@ProofofAge", SqlDbType.VarChar, 1) { Value = ProofOfAge };
                prm[62] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };




                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempPensionForWidowDestitute", prm);
                objReturn.ErrMessage = prm[49].Value.ToString();
                objReturn.ReturnCode = prm[50].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }

        public DataSet GetDataSetClubNotingsForwidowanddestitute()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };//in temp applicationNo here actual permanet application number come
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsForpensionwidowanddestitute", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
    }
}
