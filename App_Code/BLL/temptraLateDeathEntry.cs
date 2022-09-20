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
    public class temptraLateDeathEntry : TempEntryGeneral
    {
        #region properties
        public Int64 id { get; set; }
        public string TempApplicationNo { get; set; }
        public DateTime? DeathDate { get; set; }
        public string CremationVenue { get; set; }
        public string HospitalName { get; set; }
        public string ServiceCode { get; set; }
        public string SubServiceCode { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public byte[] ApplicantImage { get; set; }
        public string NameofDeceased { get; set; }
        public string RelationwithDeceased { get; set; }
        public string Deathpersonhouseno { get; set; }
        public string Deathpersonlocality { get; set; }
        public string Deathpersondistrict { get; set; }
        public string Deathpersontehsil { get; set; }
        public string Deathpersonstate { get; set; }
        public string Deathpersonpincode { get; set; }
        public string typeofdeath { get; set; }
        public Int32 DeathLocalityId { get; set; }
        public string DeathPersonGender { get; set; }
        public string deathpersonFathername { get; set; }
        public string deathpersonMothername { get; set; }
        public Int32 DeathpersonlocalityId { get; set; }
        public string DeathLocality { get; set; }
        public string DeathVenue { get; set; }
        public string AppDeathPerAddressSame { get; set; }


        //public int Id { get; set; }
        
        //public DateTime? CremationDate { get; set; }
        //public string CremationTime { get; set; }
        //public string CremationLocation { get; set; }
        //public string HospitalName { get; set; }
        //public string AppliedBy { get; set; }
        //public string Relationship { get; set; }
        //public byte[] ApplicantPhoto { get; set; }
        //public string HospitalAddress { get; set; }
        //public int UserType { get; set; }

        //public string ApplicantCity { get; set; }
        //public string ApplicantState { get; set; }
        //public string ApplicantDistrict { get; set; }
        //public string ApplicantTehsil { get; set; }

        //public string TempApplicantCity { get; set; }
        //public string TempApplicantState { get; set; }
        //public string TempApplicantDistrict { get; set; }
        //public string TempApplicantTehsil { get; set; }
        //public string TempApplicantLocality { get; set; }
        //public string TempApplicantLocalityId { get; set; }
        //public string TempApplicantPremises { get; set; }
        //public string TempApplicantPincode { get; set; }
        //public string IsTempPremAddressSame { get; set; }

        //public string Nameofdeceased { get; set; }
        //public string Relationwithdeceased { get; set; }

        //public string TypeofDeath { get; set; }
        //public string DeathPersonHouseno { get; set; }
        //public string DeathPersonGender { get; set; }
        //public string DeathPersonLocality { get; set; }
        //public string DeathPersonLocalityId { get; set; }
        //public string DeathPersonState { get; set; }
        //public string DeathPersonTehsil { get; set; }
        //public string DeathPersonPinCode { get; set; }
        //public string DeathPersonDistrict { get; set; }
        //public string OthersLocation { get; set; }

        //public string deathpersonfathername { get; set; }

        //public string deathpersonmothername { get; set; }
        public int UserType { get; set; }
        #endregion



        public DBReturn InsertTempLateDeathEntry()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[42];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;

                prm[2] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[3] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[7] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@Relationwithdeceased", SqlDbType.VarChar, 50) { Value = RelationwithDeceased };
                prm[9] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[10] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                prm[11] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[12] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value = ApplicantPremises };
                prm[13] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[14] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@Deceasedname", SqlDbType.VarChar, 99) { Value = NameofDeceased };
                prm[17] = new SqlParameter("@DeathPersonGender", SqlDbType.VarChar, 1) { Value = DeathPersonGender };
                prm[18] = new SqlParameter("@DeathPersonFatherName", SqlDbType.VarChar, 50) { Value = deathpersonFathername };
                prm[19] = new SqlParameter("@DeathPersonMotherName", SqlDbType.VarChar, 50) { Value = deathpersonMothername };
                prm[20] = new SqlParameter("@TypeofDeath", SqlDbType.VarChar, 50) { Value = typeofdeath };
                prm[21] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[22] = new SqlParameter("@Deathvenue", SqlDbType.VarChar, 200) { Value = DeathVenue };
                prm[23] = new SqlParameter("@Deathlocality", SqlDbType.VarChar, 50) { Value = DeathLocality };
                prm[24] = new SqlParameter("@DeathLocalityId", SqlDbType.Int) { Value = DeathLocalityId };
                prm[25] = new SqlParameter("@DeathDate", SqlDbType.DateTime) { Value = DeathDate };
                prm[26] = new SqlParameter("@CremationVenue", SqlDbType.VarChar, 50) { Value = CremationVenue };
                prm[27] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = AppDeathPerAddressSame };
                prm[28] = new SqlParameter("@DeathPersonState", SqlDbType.VarChar, 99) { Value = Deathpersonstate };
                prm[29] = new SqlParameter("@DeathPersonLocality", SqlDbType.VarChar, 99) { Value = Deathpersonlocality };
                prm[30] = new SqlParameter("@DeathPersonLocalityId", SqlDbType.Int) { Value = DeathpersonlocalityId };
                prm[31] = new SqlParameter("@DeathPersonHouseno", SqlDbType.VarChar, 99) { Value = Deathpersonhouseno };
                prm[32] = new SqlParameter("@DeathPersonTehsil", SqlDbType.VarChar, 99) { Value = Deathpersontehsil };
                prm[33] = new SqlParameter("@DeathPersonDistrict", SqlDbType.VarChar, 99) { Value = Deathpersondistrict };
                prm[34] = new SqlParameter("@DeathPersonPinCode", SqlDbType.VarChar, 99) { Value = Deathpersonpincode };
                prm[35] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[36] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[37] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[38] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[39] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[40] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                
                prm[41] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraDeathEntry", prm);
                objReturn.ErrMessage = prm[0].Value.ToString();
                objReturn.ReturnCode = prm[1].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                 MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }

        }


        public DBReturn UpdateTempBirthEntry(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[44];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;

                prm[2] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[3] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[7] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@Relationwithdeceased", SqlDbType.VarChar, 50) { Value = RelationwithDeceased };
                prm[9] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[10] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                prm[11] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[12] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value = ApplicantPremises };
                prm[13] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[14] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@Deceasedname", SqlDbType.VarChar, 99) { Value = NameofDeceased };
                prm[17] = new SqlParameter("@DeathPersonGender", SqlDbType.VarChar, 1) { Value = DeathPersonGender };
                prm[18] = new SqlParameter("@DeathPersonFatherName", SqlDbType.VarChar, 50) { Value = deathpersonFathername };
                prm[19] = new SqlParameter("@DeathPersonMotherName", SqlDbType.VarChar, 50) { Value = deathpersonMothername };
                prm[20] = new SqlParameter("@TypeofDeath", SqlDbType.VarChar, 50) { Value = typeofdeath };
                prm[21] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[22] = new SqlParameter("@Deathvenue", SqlDbType.VarChar, 200) { Value = DeathVenue };
                prm[23] = new SqlParameter("@Deathlocality", SqlDbType.VarChar, 50) { Value = DeathLocality };
                prm[24] = new SqlParameter("@DeathLocalityId", SqlDbType.Int) { Value = DeathLocalityId };
                prm[25] = new SqlParameter("@DeathDate", SqlDbType.DateTime) { Value = DeathDate };
                prm[26] = new SqlParameter("@CremationVenue", SqlDbType.VarChar, 50) { Value = CremationVenue };
                prm[27] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = AppDeathPerAddressSame };
                prm[28] = new SqlParameter("@DeathPersonState", SqlDbType.VarChar, 99) { Value = Deathpersonstate };
                prm[29] = new SqlParameter("@DeathPersonLocality", SqlDbType.VarChar, 99) { Value = Deathpersonlocality };
                prm[30] = new SqlParameter("@DeathPersonLocalityId", SqlDbType.Int) { Value = DeathpersonlocalityId };
                prm[31] = new SqlParameter("@DeathPersonHouseno", SqlDbType.VarChar, 99) { Value = Deathpersonhouseno };
                prm[32] = new SqlParameter("@DeathPersonTehsil", SqlDbType.VarChar, 99) { Value = Deathpersontehsil };
                prm[33] = new SqlParameter("@DeathPersonDistrict", SqlDbType.VarChar, 99) { Value = Deathpersondistrict };
                prm[34] = new SqlParameter("@DeathPersonPinCode", SqlDbType.VarChar, 99) { Value = Deathpersonpincode };
                prm[35] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[36] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[37] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[38] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[39] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[40] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                prm[41] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[42] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[43] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempLateDeathEntry", prm);
                objReturn.ErrMessage = prm[0].Value.ToString();
                objReturn.ReturnCode = prm[1].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
	public DBReturn UpdateBirthEntryMain(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[44];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;

                prm[2] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[3] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[5] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[6] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[7] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[8] = new SqlParameter("@Relationwithdeceased", SqlDbType.VarChar, 50) { Value = RelationwithDeceased };
                prm[9] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[10] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                prm[11] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[12] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value = ApplicantPremises };
                prm[13] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[14] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[15] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[16] = new SqlParameter("@Deceasedname", SqlDbType.VarChar, 99) { Value = NameofDeceased };
                prm[17] = new SqlParameter("@DeathPersonGender", SqlDbType.VarChar, 1) { Value = DeathPersonGender };
                prm[18] = new SqlParameter("@DeathPersonFatherName", SqlDbType.VarChar, 50) { Value = deathpersonFathername };
                prm[19] = new SqlParameter("@DeathPersonMotherName", SqlDbType.VarChar, 50) { Value = deathpersonMothername };
                prm[20] = new SqlParameter("@TypeofDeath", SqlDbType.VarChar, 50) { Value = typeofdeath };
                prm[21] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[22] = new SqlParameter("@Deathvenue", SqlDbType.VarChar, 200) { Value = DeathVenue };
                prm[23] = new SqlParameter("@Deathlocality", SqlDbType.VarChar, 50) { Value = DeathLocality };
                prm[24] = new SqlParameter("@DeathLocalityId", SqlDbType.Int) { Value = DeathLocalityId };
                prm[25] = new SqlParameter("@DeathDate", SqlDbType.DateTime) { Value = DeathDate };
                prm[26] = new SqlParameter("@CremationVenue", SqlDbType.VarChar, 50) { Value = CremationVenue };
                prm[27] = new SqlParameter("@IsTempPremAddressSame", SqlDbType.VarChar, 1) { Value = AppDeathPerAddressSame };
                prm[28] = new SqlParameter("@DeathPersonState", SqlDbType.VarChar, 99) { Value = Deathpersonstate };
                prm[29] = new SqlParameter("@DeathPersonLocality", SqlDbType.VarChar, 99) { Value = Deathpersonlocality };
                prm[30] = new SqlParameter("@DeathPersonLocalityId", SqlDbType.Int) { Value = DeathpersonlocalityId };
                prm[31] = new SqlParameter("@DeathPersonHouseno", SqlDbType.VarChar, 99) { Value = Deathpersonhouseno };
                prm[32] = new SqlParameter("@DeathPersonTehsil", SqlDbType.VarChar, 99) { Value = Deathpersontehsil };
                prm[33] = new SqlParameter("@DeathPersonDistrict", SqlDbType.VarChar, 99) { Value = Deathpersondistrict };
                prm[34] = new SqlParameter("@DeathPersonPinCode", SqlDbType.VarChar, 99) { Value = Deathpersonpincode };
                prm[35] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[36] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[37] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[38] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[39] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[40] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                prm[41] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[42] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[43] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateLateDeathEntryMain", prm);
                objReturn.ErrMessage = prm[0].Value.ToString();
                objReturn.ReturnCode = prm[1].Value.ToString();
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
