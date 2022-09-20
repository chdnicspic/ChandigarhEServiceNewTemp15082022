using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

/// <summary>
/// Summary description for tmpSolvencyCertificate
/// </summary>
/// 
namespace EDistrictBL
{
    public class tmpSolvencyCertificate : TempEntryGeneral
    {
        public string Occupation { get; set; }
        public string Age { get; set; }
        public string BankAccountDetail { get; set; }
        public byte[] ApplicantImage { get; set; }
        public string UserType { get; set; }
        public DataTable dtPropertyDetail { get; set; }

        public string PropertyType { get; set; }
        public string PropDetail  { get; set; }
        public string Location  { get; set; }
        public string ExtentofOwnership  { get; set; }
        public string CurrentMarketValue { get; set; }
        public long Id { get; set; }
        public string ApplicationNo { get; set; }
        public string CurrentUserid { get; set; }
        public string Approved { get; set; }

        public string SolvenyType { get; set; }
        public string SolvenyTypeId { get; set; }
        public string OrgName { get; set; }
        public string AppDesignation { get; set; }
        public string OrgState { get; set; }
        public string OrgHouseNo { get; set; }
        public string OrgLocality { get; set; }
        public string orgLocalityId { get; set; }
        public string OrgTehsil { get; set; }
        public string OrgDistrict { get; set; }
        public string OrgPincode { get; set; }
        public string ActionTakenBy { get; set; }

        public DBReturn InsertSolvencyCertificate()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[28];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[5] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[6] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[7] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[9] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[10] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[11] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[12] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[13] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[14] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[17] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[18] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[19] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[20] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[21] = new SqlParameter("@Age", SqlDbType.VarChar, 50) { Value = Age };
                prm[22] = new SqlParameter("@BankAccountDetail", SqlDbType.VarChar, 30) { Value = BankAccountDetail };
                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[25] = new SqlParameter("@PropertyDetails", SqlDbType.Structured) { Value = dtPropertyDetail };
                prm[26] = new SqlParameter("@SolvencyType", SqlDbType.VarChar, 50) { Value = SolvenyType };
                prm[27] = new SqlParameter("@SolvencyTypeID", SqlDbType.VarChar, 1) { Value = SolvenyTypeId };

                //FirmDetail
                //prm[28] = new SqlParameter("@OrgName", SqlDbType.VarChar, 199) { Value = OrgName };
                //prm[29] = new SqlParameter("@AppDesignation", SqlDbType.VarChar, 99) { Value = AppDesignation };
                //prm[30] = new SqlParameter("@OrgState", SqlDbType.VarChar, 99) { Value = OrgState };
                //prm[31] = new SqlParameter("@OrgHouseNo", SqlDbType.VarChar, 199) { Value = OrgHouseNo };
                //prm[32] = new SqlParameter("@OrgLocality", SqlDbType.VarChar, 50) { Value = OrgLocality };
                //prm[33] = new SqlParameter("@orgLocalityId", SqlDbType.VarChar, 10) { Value = orgLocalityId };
                //prm[34] = new SqlParameter("@OrgTehsil", SqlDbType.VarChar, 60) { Value = OrgTehsil };
                //prm[35] = new SqlParameter("@OrgDistrict", SqlDbType.VarChar, 60) { Value = OrgDistrict };
                //prm[36] = new SqlParameter("@OrgPincode", SqlDbType.VarChar, 6) { Value = OrgPincode };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraSolvencyCertificate", prm);
                objReturn.ErrMessage = prm[1].Value.ToString();
                objReturn.ReturnCode = prm[2].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }

        public DBReturn InsertSolvencyCertificateForFirm()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[37];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[5] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[6] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[7] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[9] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[10] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[11] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[12] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[13] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[14] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[17] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[18] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[19] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[20] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[21] = new SqlParameter("@Age", SqlDbType.VarChar, 50) { Value = Age };
                prm[22] = new SqlParameter("@BankAccountDetail", SqlDbType.VarChar, 30) { Value = BankAccountDetail };
                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[25] = new SqlParameter("@PropertyDetails", SqlDbType.Structured) { Value = dtPropertyDetail };

                // firm Detail
                prm[26] = new SqlParameter("@SolvencyType", SqlDbType.VarChar, 50) { Value = SolvenyType };
                prm[27] = new SqlParameter("@SolvencyTypeID", SqlDbType.VarChar, 1) { Value = SolvenyTypeId };
                prm[28] = new SqlParameter("@OrgName", SqlDbType.VarChar, 199) { Value = OrgName };
                prm[29] = new SqlParameter("@AppDesignation", SqlDbType.VarChar, 99) { Value = AppDesignation };
                prm[30] = new SqlParameter("@OrgState", SqlDbType.VarChar, 99) { Value = OrgState };
                prm[31] = new SqlParameter("@OrgHouseNo", SqlDbType.VarChar, 199) { Value = OrgHouseNo };
                prm[32] = new SqlParameter("@OrgLocality", SqlDbType.VarChar, 50) { Value = OrgLocality };
                prm[33] = new SqlParameter("@orgLocalityId", SqlDbType.VarChar, 10) { Value = orgLocalityId };
                prm[34] = new SqlParameter("@OrgTehsil", SqlDbType.VarChar, 60) { Value = OrgTehsil };
                prm[35] = new SqlParameter("@OrgDistrict", SqlDbType.VarChar, 60) { Value = OrgDistrict };
                prm[36] = new SqlParameter("@OrgPincode", SqlDbType.VarChar, 6) { Value = OrgPincode };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraSolvencyCertificate", prm);
                objReturn.ErrMessage = prm[1].Value.ToString();
                objReturn.ReturnCode = prm[2].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
        public DBReturn UpdateSolvencyCertificate(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[30];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[5] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[6] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[7] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[9] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[10] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[11] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[12] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[13] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[14] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[17] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[18] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[19] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[20] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[21] = new SqlParameter("@Age", SqlDbType.VarChar, 50) { Value = Age };
                prm[22] = new SqlParameter("@BankAccountDetail", SqlDbType.VarChar, 30) { Value = BankAccountDetail };
                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[25] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[26] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[27] = new SqlParameter("@PropertyDetails", SqlDbType.Structured) { Value = dtPropertyDetail };
                prm[28] = new SqlParameter("@SolvencyType", SqlDbType.VarChar, 50) { Value = SolvenyType };
                prm[29] = new SqlParameter("@SolvencyTypeID", SqlDbType.VarChar, 1) { Value = SolvenyTypeId };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraSolvencyCertificate", prm);
                objReturn.ErrMessage = prm[1].Value.ToString();
                objReturn.ReturnCode = prm[2].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
        public DBReturn UpdateSolvencyCertificateForFirm(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[39];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[5] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[6] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[7] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[9] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[10] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[11] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[12] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[13] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[14] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[17] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[18] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[19] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[20] = new SqlParameter("@Occupation", SqlDbType.VarChar, 50) { Value = Occupation };
                prm[21] = new SqlParameter("@Age", SqlDbType.VarChar, 50) { Value = Age };
                prm[22] = new SqlParameter("@BankAccountDetail", SqlDbType.VarChar, 30) { Value = BankAccountDetail };
                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[25] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[26] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[27] = new SqlParameter("@PropertyDetails", SqlDbType.Structured) { Value = dtPropertyDetail };

                prm[28] = new SqlParameter("@SolvencyType", SqlDbType.VarChar, 50) { Value = SolvenyType };
                prm[29] = new SqlParameter("@SolvencyTypeID", SqlDbType.VarChar, 1) { Value = SolvenyTypeId };
                prm[30] = new SqlParameter("@OrgName", SqlDbType.VarChar, 199) { Value = OrgName };
                prm[31] = new SqlParameter("@AppDesignation", SqlDbType.VarChar, 99) { Value = AppDesignation };
                prm[32] = new SqlParameter("@OrgState", SqlDbType.VarChar, 99) { Value = OrgState };
                prm[33] = new SqlParameter("@OrgHouseNo", SqlDbType.VarChar, 199) { Value = OrgHouseNo };
                prm[34] = new SqlParameter("@OrgLocality", SqlDbType.VarChar, 50) { Value = OrgLocality };
                prm[35] = new SqlParameter("@orgLocalityId", SqlDbType.VarChar, 10) { Value = orgLocalityId };
                prm[36] = new SqlParameter("@OrgTehsil", SqlDbType.VarChar, 60) { Value = OrgTehsil };
                prm[37] = new SqlParameter("@OrgDistrict", SqlDbType.VarChar, 60) { Value = OrgDistrict };
                prm[38] = new SqlParameter("@OrgPincode", SqlDbType.VarChar, 6) { Value = OrgPincode };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraSolvencyCertificate", prm);
                objReturn.ErrMessage = prm[1].Value.ToString();
                objReturn.ReturnCode = prm[2].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
        public DataSet GetAllPropertyDetail()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetSolvencyPropertyDetails", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }


        }
        public DataSet GetAllPropertyDetailMainTable()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetSolvencyPropertyDetails_MainTable", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DBReturn UpdatePropertyDetail()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[8];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ID", SqlDbType.Int) { Value = Id };
                prm[3] = new SqlParameter("@PropertyType", SqlDbType.VarChar, 99) { Value = PropertyType };
                prm[4] = new SqlParameter("@PropDetail", SqlDbType.VarChar, 150) { Value = PropDetail };
                prm[5] = new SqlParameter("@Location", SqlDbType.VarChar, 50) { Value = Location };
                prm[6] = new SqlParameter("@ExtentofOwnership", SqlDbType.VarChar, 10) { Value = ExtentofOwnership };
                prm[7] = new SqlParameter("@CurrentMarketValue", SqlDbType.VarChar, 50) { Value = CurrentMarketValue };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_SolvencyDetail", prm);
                objReturn.ErrMessage = prm[0].Value.ToString();
                objReturn.ReturnCode = prm[1].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
     
        public byte[] GetPropertyDocs()
        {

            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@TempApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
            prm[2] = new SqlParameter("@Id", SqlDbType.VarChar, 99) { Value = Id };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPropertyDocs", prm);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

            }
            return b;
        }

        public byte[] GetPropertyDocsFromMain()
        {

            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
            prm[2] = new SqlParameter("@Id", SqlDbType.VarChar, 99) { Value = Id };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPropertyDocsFromMain", prm);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

            }
            return b;
        }

        public DBReturn UpdatePatwriPropertyValue()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[6];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 99) { Value = ServiceCode };
                prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                prm[4] = new SqlParameter("@PropertyDetails", SqlDbType.Structured) { Value = dtPropertyDetail };
                prm[5] = new SqlParameter("@ActionTakenBy", SqlDbType.VarChar, 15) { Value = ActionTakenBy };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Solvency_PropertyValue_Log", prm);
                objReturn.ErrMessage = prm[0].Value.ToString();
                objReturn.ReturnCode = prm[1].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
        public DataSet GetDataSetClubNotings()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsSolvency", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }

        public DataSet GetSolvencyPatwariReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetSolvencyPatwariReport", prm);

            return ds;
        }

        public DataSet GenerateFinalSolvencyCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_Final_Solvency_Certificate", prm);
            return ds;

        }

        public DBReturn UpdateTehsildarRemark(string ApplicationNo, string TehsildarRemark)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[4];

                prm[0] = new SqlParameter("@TehsildarRemark", SqlDbType.VarChar, 500) { Value = TehsildarRemark };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_TehsildarRemark_SolvencyCert", prm);
                return objReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }

        public DataSet GetForwardRevertPerson(string authCode, int level, string ActionType, string AppNo)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPerson", prm);

            return ds;
        }
        public DataSet GenerateDraftFinalSolvencyCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_Draft_FinalSolvency_Certificate", prm);
            return ds;

        }

    }

}