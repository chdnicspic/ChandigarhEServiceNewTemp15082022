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
   public class TempTraBusPass:TempEntryGeneral
    {
        #region Properties
        public Int64 ServiceId { get; set; }
        public string TempApplicationNo { get; set; }
        public string ApplicantAge { get; set; }
        public string Occupation { get; set; }
        public string BusPassCategory { get; set; }
        public string BusPassSamparkCenter { get; set; }
        public string BusPassPassengerCategory { get; set; }
        public string Nature { get; set; }
        public string DurationOfPass { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string StudentInstitAdd { get; set; }
        public string OfficeAdd { get; set; }
        public decimal Fees { get; set; }
        public decimal TotalAmount { get; set; }
        public string PhoneNumber { get; set; }
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
        public int UserType { get; set; }
        public byte[] ApplicantPhoto { get; set; }



        #endregion
        #region function

        public DBReturn InsertTempTraBusPass()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[45];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[3] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[4] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[5] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar,15) { Value = PhoneNumber };
                prm[8] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo }; 
                prm[9] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[10] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[11] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[12] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[13] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[14] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[15] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[16] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[17] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[18] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[19] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[20] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[21] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[22] = new SqlParameter("@IsTempPermSameAddress", SqlDbType.Char, 1) { Value = IsTempPermSameAddress };
                prm[23] = new SqlParameter("@BusPassCategory", SqlDbType.VarChar, 50) { Value = BusPassCategory };
                prm[24] = new SqlParameter("@BusPassPassengerCategory", SqlDbType.VarChar, 250) { Value = BusPassPassengerCategory };
                prm[25] = new SqlParameter("@Nature", SqlDbType.VarChar, 15) { Value = Nature };
                prm[26] = new SqlParameter("@DurationOfPass", SqlDbType.VarChar, 50) { Value = DurationOfPass };
                prm[27] = new SqlParameter("@ValidFrom", SqlDbType.DateTime) { Value = ValidFrom };
                prm[28] = new SqlParameter("@ValidTo", SqlDbType.DateTime) { Value = ValidTo };
                prm[29] = new SqlParameter("@StudentInstitAdd", SqlDbType.VarChar, 500) { Value = StudentInstitAdd };
                prm[30] = new SqlParameter("@OfficeAdd", SqlDbType.VarChar, 500) { Value = OfficeAdd };
                prm[31] = new SqlParameter("@Fees", SqlDbType.Decimal) { Value = Fees };
                prm[32] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[33] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[34] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[35] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[36] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[36].Direction = ParameterDirection.Output;
                prm[37] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[37].Direction = ParameterDirection.Output;
                prm[38] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[39] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[40] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[41] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Value = TotalAmount };
                prm[42] = new SqlParameter("@BusPassSamparkCenter", SqlDbType.VarChar, 50) { Value = BusPassSamparkCenter };
                prm[43] = new SqlParameter("@ServiceCharges", SqlDbType.Decimal) { Value = ServiceCharges };
                prm[44] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTempTraBusPass", prm);
                objReturn.ErrMessage = prm[36].Value.ToString();

                objReturn.ReturnCode = prm[37].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }


        public DBReturn UpdateTempTraBusPass(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[47];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[3] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[4] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[5] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@PhoneNumber", SqlDbType.VarChar,15) { Value = PhoneNumber };
                prm[8] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[9] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[10] = new SqlParameter("@TempPremises", SqlDbType.VarChar, 60) { Value = TempPremises };
                prm[11] = new SqlParameter("@TempLocality", SqlDbType.VarChar, 60) { Value = TempLocality };
                prm[12] = new SqlParameter("@TempTehsil", SqlDbType.VarChar, 50) { Value = TempTehsil };
                prm[13] = new SqlParameter("@TempDistrict", SqlDbType.VarChar, 50) { Value = TempDistrict };
                prm[14] = new SqlParameter("@TempState", SqlDbType.VarChar, 50) { Value = TempState };
                prm[15] = new SqlParameter("@TempPINCode", SqlDbType.Int) { Value = TempPINCode };
                prm[16] = new SqlParameter("@PermPremises", SqlDbType.VarChar, 60) { Value = PermPremises };
                prm[17] = new SqlParameter("@PermLocality", SqlDbType.VarChar, 60) { Value = PermLocality };
                prm[18] = new SqlParameter("@PermTehsil", SqlDbType.VarChar, 50) { Value = PermTehsil };
                prm[19] = new SqlParameter("@PermDistrict", SqlDbType.VarChar, 50) { Value = PermDistrict };
                prm[20] = new SqlParameter("@PermState", SqlDbType.VarChar, 50) { Value = PermState };
                prm[21] = new SqlParameter("@PermPINCode", SqlDbType.Int) { Value = PermPINCode };
                prm[22] = new SqlParameter("@IsTempPermSameAddress", SqlDbType.Char, 1) { Value = IsTempPermSameAddress };
                prm[23] = new SqlParameter("@BusPassCategory", SqlDbType.VarChar, 50) { Value = BusPassCategory };
                prm[24] = new SqlParameter("@BusPassPassengerCategory", SqlDbType.VarChar, 250) { Value = BusPassPassengerCategory };
                prm[25] = new SqlParameter("@Nature", SqlDbType.VarChar, 15) { Value = Nature };
                prm[26] = new SqlParameter("@DurationOfPass", SqlDbType.VarChar, 50) { Value = DurationOfPass };
                prm[27] = new SqlParameter("@ValidFrom", SqlDbType.DateTime) { Value = ValidFrom };
                prm[28] = new SqlParameter("@ValidTo", SqlDbType.DateTime) { Value = ValidTo };
                prm[29] = new SqlParameter("@StudentInstitAdd", SqlDbType.VarChar, 500) { Value = StudentInstitAdd };
                prm[30] = new SqlParameter("@OfficeAdd", SqlDbType.VarChar, 500) { Value = OfficeAdd };
                prm[31] = new SqlParameter("@Fees", SqlDbType.Decimal) { Value = Fees };
                prm[32] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[33] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[34] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[35] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[36] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[36].Direction = ParameterDirection.Output;
                prm[37] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[37].Direction = ParameterDirection.Output;
                prm[38] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[39] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[40] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[41] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Value = TotalAmount };
                prm[42] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[43] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[44] = new SqlParameter("@BusPassSamparkCenter", SqlDbType.VarChar, 50) { Value = BusPassSamparkCenter };
                prm[45] = new SqlParameter("@ServiceCharges", SqlDbType.Decimal) { Value = ServiceCharges };
                prm[46] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraBusPass", prm);
                objReturn.ErrMessage = prm[36].Value.ToString();
                objReturn.ReturnCode = prm[37].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }

        public DataSet GetDashBoardForSamparkCenterUser()
        {
            DataSet ds = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = oprcode };
            ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDashBoardForSamparkCenterUser", prm);

            return ds;

        }
        #endregion



    }
}
