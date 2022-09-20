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
     public class TempTraPensionForDisable : TempEntryGeneral
     {
         #region Properties
         public Int64 ServiceId { get; set; }
         public string TempApplicationNo { get; set; }
         public string ApplicantAge { get; set; }
         public string MarkOfIdentification { get; set; }
         public string HusbandName { get; set; }
         public string BelongToSC { get; set; }
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
         public string PermState { get; set; }
         public string PermTehsil { get; set; }
         public string PremVillage { get; set; }
         public string SourceOfmaintenance { get; set; }
         public string DisablityType { get; set; }
         public string DisablityExtent { get; set; }
         public decimal FamilyIncome { get; set; }
         public string OccupationBeforeDisablity { get; set; }
         public decimal MonthlyIncomeBeforeUnfit { get; set; }
         public string AnyGovtAssistance { get; set; }
         public string GovtAssistanceDetails { get; set; }
         public string AnyProperty { get; set; }
         public decimal MoveablePropertyValue { get; set; }
         public decimal AmountInvestedInGovt { get; set; }
         public decimal OtherSourceOfIncome { get; set; }
         public string AnyLoanAssistance { get; set; }
         public string LoanDetails { get; set; }
         public string RefPersonName1 { get; set; }
         public string RefPersonAddress { get; set; }
         public string RefPersonName2 { get; set; }
         public string RefPersonAddress2 { get; set; }
         public string TehsildarLetterNo { get; set; }
         public DateTime? TehsildarLetterDate { get; set; }
         public decimal TehsildarVerifiedIncome { get; set; }
         public byte[] ApplicantPhoto { get; set; }
         public string IsTempPermSameAddress { get; set; }
         public Int32 UserType { get; set; }
         public Int32 YearsStayInChandigarh { get; set; }

         #endregion


         public DBReturn InsertTempPensionForDisabled()
         {
             DBReturn objReturn = new DBReturn();
             try
             {

                 SqlParameter[] prm = new SqlParameter[55];
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
                 prm[27] = new SqlParameter("@MonthlyIncomeBeforeUnfit", SqlDbType.Decimal) { Value = MonthlyIncomeBeforeUnfit };


                 prm[28] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = AnyGovtAssistance };
                 prm[29] = new SqlParameter("@PensionAmount", SqlDbType.VarChar, 200) { Value = GovtAssistanceDetails };

                 prm[30] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                 prm[31] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveablePropertyValue };
                 prm[32] = new SqlParameter("@InvestmentInGovtSecurities", SqlDbType.Decimal) { Value = AmountInvestedInGovt };
                 prm[33] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = OtherSourceOfIncome };


                 //prm[31] = new SqlParameter("@RealBalanceDeposit", SqlDbType.Decimal) { Value = RealBalanceDeposit };
                 //prm[32] = new SqlParameter("@ImmoveablePropertyValue", SqlDbType.Decimal) { Value = ImmoveablePropertyValue };



                 prm[34] = new SqlParameter("@AnyLoan", SqlDbType.VarChar, 1) { Value = AnyLoanAssistance };
                 prm[35] = new SqlParameter("@LoanDetails", SqlDbType.VarChar, 100) { Value = LoanDetails };
                 //prm[37] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = AnyEarlierApply };
                 //prm[38] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierApplyDetail };


                 prm[36] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                 prm[37] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                 prm[38] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                 prm[39] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                 //prm[43] = new SqlParameter("@IsSpouseAlive", SqlDbType.VarChar, 1) { Value = IsSpouseAlive };
                 prm[40] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                 //prm[45] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                 prm[41] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                 prm[42] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                 prm[43] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                 prm[43].Direction = ParameterDirection.Output;
                 prm[44] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                 prm[44].Direction = ParameterDirection.Output;
                 prm[45] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                 prm[46] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };

                 //prm[51] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = MyFamilyDetail };
                 prm[47] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                 prm[48] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPermSameAddress };
                 prm[49] = new SqlParameter("@DisablityType", SqlDbType.VarChar, 50) { Value = DisablityType };
                 prm[50] = new SqlParameter("@DisablityExtent", SqlDbType.VarChar, 3) { Value = DisablityExtent };
                 prm[51] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsStayInChandigarh };
                 prm[52] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                 prm[53] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };
                 prm[54] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTempPensionForDisabled", prm);
                 objReturn.ErrMessage = prm[43].Value.ToString();
                 objReturn.ReturnCode = prm[44].Value.ToString();
                 return objReturn;

             }
             catch (Exception Ex)
             {
                 MyExceptionHandler.HandleException(Ex);
                 return objReturn;
             }
         }

         public DBReturn UpdateTempPensionForDisabled(string ImageUpdated)
         {
             DBReturn objReturn = new DBReturn();
             try
             {

                 SqlParameter[] prm = new SqlParameter[57];
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
                 prm[27] = new SqlParameter("@MonthlyIncomeBeforeUnfit", SqlDbType.Decimal) { Value = MonthlyIncomeBeforeUnfit };


                 prm[28] = new SqlParameter("@AnyPension", SqlDbType.VarChar, 1) { Value = AnyGovtAssistance };
                 prm[29] = new SqlParameter("@PensionAmount", SqlDbType.VarChar, 200) { Value = GovtAssistanceDetails };

                 prm[30] = new SqlParameter("@AnyProperty", SqlDbType.VarChar, 1) { Value = AnyProperty };
                 prm[31] = new SqlParameter("@MoveablePropertyValue", SqlDbType.Decimal) { Value = MoveablePropertyValue };
                 prm[32] = new SqlParameter("@InvestmentInGovtSecurities", SqlDbType.Decimal) { Value = AmountInvestedInGovt };
                 prm[33] = new SqlParameter("@OtherSourceIncome", SqlDbType.Decimal) { Value = OtherSourceOfIncome };


                 //prm[31] = new SqlParameter("@RealBalanceDeposit", SqlDbType.Decimal) { Value = RealBalanceDeposit };
                 //prm[32] = new SqlParameter("@ImmoveablePropertyValue", SqlDbType.Decimal) { Value = ImmoveablePropertyValue };



                 prm[34] = new SqlParameter("@AnyLoan", SqlDbType.VarChar, 1) { Value = AnyLoanAssistance };
                 prm[35] = new SqlParameter("@LoanDetails", SqlDbType.VarChar, 100) { Value = LoanDetails };
                 //prm[37] = new SqlParameter("@AnyEarlierApply", SqlDbType.VarChar, 1) { Value = AnyEarlierApply };
                 //prm[38] = new SqlParameter("@EarlierApplyDetail", SqlDbType.VarChar, 100) { Value = EarlierApplyDetail };


                 prm[36] = new SqlParameter("@RefPersonName1", SqlDbType.VarChar, 99) { Value = RefPersonName1 };
                 prm[37] = new SqlParameter("@RefPersonAddress", SqlDbType.VarChar, 200) { Value = RefPersonAddress };
                 prm[38] = new SqlParameter("@RefPersonName2", SqlDbType.VarChar, 99) { Value = RefPersonName2 };
                 prm[39] = new SqlParameter("@RefPersonAddress2", SqlDbType.VarChar, 200) { Value = RefPersonAddress2 };
                 //prm[43] = new SqlParameter("@IsSpouseAlive", SqlDbType.VarChar, 1) { Value = IsSpouseAlive };
                 prm[40] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                 //prm[45] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                 prm[41] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                 prm[42] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                 prm[43] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                 prm[43].Direction = ParameterDirection.Output;
                 prm[44] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                 prm[44].Direction = ParameterDirection.Output;
                 prm[45] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                 prm[46] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };

                 //prm[51] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = MyFamilyDetail };
                 prm[47] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                 prm[48] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPermSameAddress };
                 prm[49] = new SqlParameter("@DisablityType", SqlDbType.VarChar, 50) { Value = DisablityType };
                 prm[50] = new SqlParameter("@DisablityExtent", SqlDbType.VarChar, 3) { Value = DisablityExtent };
                 prm[51] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 prm[52] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                 prm[53] = new SqlParameter("@YearsInChandigarh", SqlDbType.Int) { Value = YearsStayInChandigarh };
                 prm[54] = new SqlParameter("@TehsildarDate", SqlDbType.DateTime) { Value = TehsildarLetterDate };
                 prm[55] = new SqlParameter("@TehsildarVerifiedIncome", SqlDbType.Decimal) { Value = TehsildarVerifiedIncome };
                 prm[56] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempPensionForDisabled", prm);
                 objReturn.ErrMessage = prm[43].Value.ToString();
                 objReturn.ReturnCode = prm[44].Value.ToString();
                 return objReturn;

             }
             catch (Exception Ex)
             {
                 MyExceptionHandler.HandleException(Ex);
                 return objReturn;
             }
         }
         public DataSet GetDataSetClubNotingsFordisabledpersion()
         {
             SqlParameter[] prm = new SqlParameter[1];
             prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };//in temp applicationNo here actual permanet application number come
             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsForpensiondisabledpersion", prm);
             DataTable dt = new DataTable();
             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 dt = ds.Tables[0];
             }
             return ds;
         }
     }
}
