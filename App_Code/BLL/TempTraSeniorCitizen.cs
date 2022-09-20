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
    public class TempTraSeniorCitizen : TempEntryGeneral
    {
        #region Properties
        public Int64 ServiceId { get; set; }
        public string TempApplicationNo { get; set; }
        public string ApplicantAge { get; set; }
        public decimal ApplicantHeight { get; set; }
        public string MarkOfIdentification { get; set; }
        public string TempPremises { get; set; }
        public string TempLocality { get; set; }
        public Int32 TempPINCode { get; set; }
        public string TempTehsil { get; set; }
        public string TempDistrict { get; set; }
        public string TempState { get; set; }
        public string TempVillage { get; set; }
        public string PermPremises { get; set; }
        public string PermLocality { get; set; }
        public Int32 PermPINCode { get; set; }
        public string PermTehsil { get; set; }
        public string PermDistrict { get; set; }
        public string PermState { get; set; }
        public string PermVillage { get; set; }
        public byte[] ApplicantPhoto { get; set; }
        public string IsTempPermAddressSame { get; set; }
        public Int32 UserType { get; set; }
        #endregion

        #region function
        public DBReturn InsertTempTraSeniorCitizen()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[34];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[3] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[4] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[5] = new SqlParameter("@ApplicantHeight", SqlDbType.Decimal) { Value = ApplicantHeight };
                prm[6] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[7] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new  SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[10] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
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
                prm[23] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[24]= new  SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[27].Direction = ParameterDirection.Output;
                prm[28] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[28].Direction = ParameterDirection.Output;
                prm[29] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[30] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[31] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[32] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPermAddressSame };
                prm[33] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTempTraSeniorCitizen", prm);
                objReturn.ErrMessage = prm[27].Value.ToString();
                objReturn.ReturnCode = prm[28].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DBReturn UpdateTempTraSeniorCitizen(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[36];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[3] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[4] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[5] = new SqlParameter("@ApplicantHeight", SqlDbType.Decimal) { Value = ApplicantHeight };
                prm[6] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[7] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[10] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
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
                prm[23] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[24] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[27].Direction = ParameterDirection.Output;
                prm[28] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[28].Direction = ParameterDirection.Output;
                prm[29] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[30] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[31] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[32] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPermAddressSame };
                prm[33] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[34] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[35] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraSeniorCitizen", prm);
                objReturn.ErrMessage = prm[27].Value.ToString();
                objReturn.ReturnCode = prm[28].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DBReturn UpdateTraSeniorCitizenMain(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[36];
                prm[0] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[1] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[2] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[3] = new SqlParameter("@ApplicantAge", SqlDbType.VarChar, 50) { Value = ApplicantAge };
                prm[4] = new SqlParameter("@MarkOfIdentification", SqlDbType.VarChar, 99) { Value = MarkOfIdentification };
                prm[5] = new SqlParameter("@ApplicantHeight", SqlDbType.Decimal) { Value = ApplicantHeight };
                prm[6] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[7] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                prm[10] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
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
                prm[23] = new SqlParameter("@ApplicantPhoto", SqlDbType.Image) { Value = ApplicantPhoto };
                prm[24] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[25] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[26] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[27] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[27].Direction = ParameterDirection.Output;
                prm[28] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[28].Direction = ParameterDirection.Output;
                prm[29] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[30] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[31] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[32] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = IsTempPermAddressSame };
                prm[33] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[34] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[35] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTraSeniorCitizenMain", prm);
                objReturn.ErrMessage = prm[27].Value.ToString();
                objReturn.ReturnCode = prm[28].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
        public DataSet GetDataSetClubNotingsForSeniorCitizen()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };//in temp applicationNo here actual permanet application number come
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsForSeniorCitizen", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
      
        #endregion
    }
}
