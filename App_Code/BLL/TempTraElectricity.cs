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
    public class TempTraElectricity:TempEntryGeneral
    {
        #region Properties
        public Int64 ServiceId { get; set; }
        public string TempApplicationNo { get; set; }
        public string HusbandName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Purpose { get; set; }
        public string ApplicantType { get; set; }
        public Int32 LoadAppliedFor { get; set; }
        public string Occupation { get; set; }
        public string Designation { get; set; }
        public Int32 PhoneNumber { get; set; }
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
        public string IsTempPermSameAddress { get; set; }
        public string OfficePremises { get; set; }
        public string OfficeLocality { get; set; }
        public Int32 OfficePINCode { get; set; }
        public string OfficeDistrict { get; set; }
        public string OfficeState { get; set; }
        public string OfficeTehsil { get; set; }
        public string OfficeVillage { get; set; }
        public string IsNoticeRead { get; set; }
        public string IsProvisions { get; set; }
        public string IsPrevailingTariffRates { get; set; }
        public string IsProperCharges { get; set; }
        public string IsDepositSuchSecurity { get; set; }
        public string IsFraudulentDocument { get; set; }
        public string IsUndertake { get; set; }
        public byte[] ApplicantPhoto { get; set; }
        public Int32 UserType { get; set; }
        #endregion
        #region function

        public DBReturn InsertTempTraElectricity()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[49];
                prm[0] = new SqlParameter("@Category", SqlDbType.VarChar, 30) { Value = Category };
                prm[1] = new SqlParameter("@SubCategory", SqlDbType.VarChar, 30) { Value = SubCategory };
                prm[2] = new SqlParameter("@ApplicantType", SqlDbType.VarChar, 50) { Value = ApplicantType };
                prm[3] = new SqlParameter("@LoadAppliedFor", SqlDbType.Int) { Value =LoadAppliedFor };
                prm[4] = new SqlParameter("@ApplicantName", SqlDbType.VarChar,99) { Value =ApplicantName };
                prm[5] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[6] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[7] = new SqlParameter("@Designation", SqlDbType.VarChar, 50) { Value = Designation };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value =ApplicantEmail};
                prm[9] = new SqlParameter("@PhoneNumber", SqlDbType.Int) { Value =PhoneNumber  };
                prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar,10) { Value = ApplicantMobileNo };
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
                prm[23] = new SqlParameter("@IsTempPermSameAddress", SqlDbType.Char, 1) { Value = IsTempPermSameAddress };
                prm[24] = new SqlParameter("@OfficePremises", SqlDbType.VarChar, 60) { Value = OfficePremises };
                prm[25] = new SqlParameter("@OfficeLocality", SqlDbType.VarChar, 60) { Value = OfficeLocality };
                prm[26] = new SqlParameter("@OfficeTehsil", SqlDbType.VarChar, 50) { Value =OfficeTehsil};
                prm[27] = new SqlParameter("@OfficeDistrict", SqlDbType.VarChar, 50) { Value = OfficeDistrict };
                prm[28] = new SqlParameter("@OfficeState", SqlDbType.VarChar, 50) { Value = OfficeState };
                prm[29] = new SqlParameter("@OfficePINCode", SqlDbType.Int) { Value = OfficePINCode };
                prm[30] = new SqlParameter("@IsNoticeRead", SqlDbType.Char, 1) { Value = IsNoticeRead };
                prm[31] = new SqlParameter("@IsProvisions", SqlDbType.Char, 1) { Value = IsProvisions };
                prm[32] = new SqlParameter("@IsPrevailingTariffRates", SqlDbType.Char, 1) { Value = IsPrevailingTariffRates };
                prm[33] = new SqlParameter("@IsProperCharges", SqlDbType.Char, 1) { Value = IsProperCharges };
                prm[34] = new SqlParameter("@IsDepositSuchSecurity", SqlDbType.Char, 1) { Value = IsDepositSuchSecurity };
                prm[35] = new SqlParameter("@IsFraudulentDocument", SqlDbType.Char, 1) { Value = IsFraudulentDocument };
                prm[36] = new SqlParameter("@IsUndertake", SqlDbType.Char, 1) { Value = IsUndertake };
                prm[37] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[38] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[39] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[40] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[41] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[41].Direction = ParameterDirection.Output;
                prm[42] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[42].Direction = ParameterDirection.Output;
                prm[43] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[44] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[45] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[46] = new SqlParameter("@Purpose", SqlDbType.VarChar, 90) { Value = Purpose };
                prm[47] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[48] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTempTraElectricity", prm);
                objReturn.ErrMessage = prm[41].Value.ToString();
                objReturn.ReturnCode = prm[42].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }


        public DBReturn UpdateTempTraElectricity(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[51];
                prm[0] = new SqlParameter("@Category", SqlDbType.VarChar, 30) { Value = Category };
                prm[1] = new SqlParameter("@SubCategory", SqlDbType.VarChar, 30) { Value = SubCategory };
                prm[2] = new SqlParameter("@ApplicantType", SqlDbType.VarChar, 50) { Value = ApplicantType };
                prm[3] = new SqlParameter("@LoadAppliedFor", SqlDbType.Int) { Value = LoadAppliedFor };
                prm[4] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[5] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[6] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[7] = new SqlParameter("@Designation", SqlDbType.VarChar, 50) { Value = Designation };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@PhoneNumber", SqlDbType.Int) { Value = PhoneNumber };
                prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
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
                prm[23] = new SqlParameter("@IsTempPermSameAddress", SqlDbType.Char, 1) { Value = IsTempPermSameAddress };
                prm[24] = new SqlParameter("@OfficePremises", SqlDbType.VarChar, 60) { Value = OfficePremises };
                prm[25] = new SqlParameter("@OfficeLocality", SqlDbType.VarChar, 60) { Value = OfficeLocality };
                prm[26] = new SqlParameter("@OfficeTehsil", SqlDbType.VarChar, 50) { Value = OfficeTehsil };
                prm[27] = new SqlParameter("@OfficeDistrict", SqlDbType.VarChar, 50) { Value = OfficeDistrict };
                prm[28] = new SqlParameter("@OfficeState", SqlDbType.VarChar, 50) { Value = OfficeState };
                prm[29] = new SqlParameter("@OfficePINCode", SqlDbType.Int) { Value = OfficePINCode };
                prm[30] = new SqlParameter("@IsNoticeRead", SqlDbType.Char, 1) { Value = IsNoticeRead };
                prm[31] = new SqlParameter("@IsProvisions", SqlDbType.Char, 1) { Value = IsProvisions };
                prm[32] = new SqlParameter("@IsPrevailingTariffRates", SqlDbType.Char, 1) { Value = IsPrevailingTariffRates };
                prm[33] = new SqlParameter("@IsProperCharges", SqlDbType.Char, 1) { Value = IsProperCharges };
                prm[34] = new SqlParameter("@IsDepositSuchSecurity", SqlDbType.Char, 1) { Value = IsDepositSuchSecurity };
                prm[35] = new SqlParameter("@IsFraudulentDocument", SqlDbType.Char, 1) { Value = IsFraudulentDocument };
                prm[36] = new SqlParameter("@IsUndertake", SqlDbType.Char, 1) { Value = IsUndertake };
                prm[37] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[38] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[39] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[40] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[41] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[41].Direction = ParameterDirection.Output;
                prm[42] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[42].Direction = ParameterDirection.Output;
                prm[43] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[44] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[45] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[46] = new SqlParameter("@Purpose", SqlDbType.VarChar, 90) { Value = Purpose };
                prm[47] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[48] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[49] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[50] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraElectricity", prm);

                objReturn.ErrMessage = prm[41].Value.ToString();
                objReturn.ReturnCode = prm[42].Value.ToString();
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
