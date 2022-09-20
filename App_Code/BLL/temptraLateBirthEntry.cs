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
    public class temptraLateBirthEntry : TempEntryGeneral
    {
        #region properties
        //public int Id { get; set; }
        
        //public DateTime? BirthDate { get; set; }
        //public string BirthTime { get; set; }
        //public string BirthLocation { get; set; }
        //public string HospitalName { get; set; }
        //public string DaiName { get; set; }
        //public string TypeofBirth { get; set; }
        //public string AppliedBy { get; set; }
        //public string Relationship { get; set; }
        //public byte[] ApplicantPhoto { get; set; }
        //public string DaiRegNo { get; set; }
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
        //public string IsTempPremAddressSame{get;set;}
        //public string BirthPersonName { get; set; }
        //public string BirthPersonGender { get; set; }
        //public string Relationshipofbirthperson { get; set; }
        //public string BirthOrder { get; set; }
           
        //public string BirthPersonHouseno{ get;set;}
        //public string BirthPersonLocality { get;set;}
        //public string BirthPersonLocalityId { get; set; }
        //public string BirthPersonState { get;set;}
        //public string BirthPersonTehsil { get;set;}
        //public string BirthPersonPinCode { get;set;}
        //public string BirthPersonDistrict { get;set;}
        //public string Otherslocation { get; set; }
        //public string birthpersonfathername { get; set; }

        //public string birthpersonmothername { get; set; }
        //public string hospitalname;
        public Int64 id { get; set; }
        public string TempApplicationNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthVenue { get; set; }
        public string DaiName { get; set; }
        public string DAI_Regno { get; set; }
        public string HospitalName { get; set; }
        public string TypeofBirth { get; set; }
        public string ServiceCode { get; set; }
        public string SubServiceCode { get; set; }
        public string RelationofapplicantwithBirthpe { get; set; }
        public string Birthpersonname { get; set; }
        public string BirthpersonGender { get; set; }
        public string birthorder { get; set; }
        public string Birthpersonmothername { get; set; }
        public string BirthpersonFathername { get; set; }
        public Int32 BirthPersonLocalityId { get; set; }
        public string Birthpersonlocality { get; set; }
        public byte[] ApplicantImage { get; set; }

        public Int32 UserType { get; set; }

        #endregion



        public DBReturn InsertTempLateBirthEntry()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[36];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
            
                prm[2] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 50) { Value = oprcode };
                prm[3] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 30) { Value = ServiceCode };
                prm[4] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.VarChar,15) { Value = ApplicantAadharNo };
                prm[5] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                
                prm[8] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[9] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = RelationofapplicantwithBirthpe };
                prm[10] = new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = BirthDate };
                
                prm[11] = new SqlParameter("@TypeofBirth", SqlDbType.VarChar, 50) { Value = TypeofBirth };
                prm[12] = new SqlParameter("@BirthVenue", SqlDbType.VarChar, 100) { Value = BirthVenue };
                prm[13] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[14] = new SqlParameter("@DaiName", SqlDbType.VarChar, 50) { Value = DaiName };
                prm[15] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                

                prm[16] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 100) { Value = ApplicantLocality };
                prm[17] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[18] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value =  ApplicantPremises };
                
                prm[19] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[20] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[21] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[22] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar, 50) { Value = ApplicantPinCode };

                

                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                
                prm[24] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[25] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[26] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[27] = new SqlParameter("@DAIRegNo", SqlDbType.VarChar, 50) { Value = DAI_Regno };
                
                prm[28] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                
                prm[29] = new SqlParameter("@BirthPersonName", SqlDbType.VarChar, 100) { Value =  Birthpersonname };
                
                prm[30] = new SqlParameter("@BirthPersonGender", SqlDbType.VarChar, 1) { Value = BirthpersonGender };
                prm[31] = new SqlParameter("@BirthOrder", SqlDbType.VarChar, 50) { Value = birthorder };
                
                prm[32] = new SqlParameter("@BirthPersonLocality", SqlDbType.VarChar, 99) { Value = Birthpersonlocality };
                
                prm[33] = new SqlParameter("@BirthPersonLocalityId", SqlDbType.VarChar, 50) { Value = BirthPersonLocalityId };
                prm[34] = new SqlParameter("@BirthPersonFatherName", SqlDbType.VarChar, 50) { Value = BirthpersonFathername };
                prm[35] = new SqlParameter("@BirthPersonMotherName", SqlDbType.VarChar, 50) { Value = Birthpersonmothername };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraBirthEntry", prm);
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
                SqlParameter[] prm = new SqlParameter[38];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;

                prm[2] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 50) { Value = oprcode };
                prm[3] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 30) { Value = ServiceCode };
                prm[4] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.VarChar, 15) { Value = ApplicantAadharNo };
                prm[5] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };

                prm[8] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[9] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = RelationofapplicantwithBirthpe };
                prm[10] = new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = BirthDate };

                prm[11] = new SqlParameter("@TypeofBirth", SqlDbType.VarChar, 50) { Value = TypeofBirth };
                prm[12] = new SqlParameter("@BirthVenue", SqlDbType.VarChar, 100) { Value = BirthVenue };
                prm[13] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[14] = new SqlParameter("@DaiName", SqlDbType.VarChar, 50) { Value = DaiName };
                prm[15] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };


                prm[16] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 100) { Value = ApplicantLocality };
                prm[17] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[18] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value = ApplicantPremises };

                prm[19] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[20] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[21] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[22] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar, 50) { Value = ApplicantPinCode };



                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };

                prm[24] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[25] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[26] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[27] = new SqlParameter("@DAIRegNo", SqlDbType.VarChar, 50) { Value = DAI_Regno };

                prm[28] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                prm[29] = new SqlParameter("@BirthPersonName", SqlDbType.VarChar, 100) { Value = Birthpersonname };

                prm[30] = new SqlParameter("@BirthPersonGender", SqlDbType.VarChar, 1) { Value = BirthpersonGender };
                prm[31] = new SqlParameter("@BirthOrder", SqlDbType.VarChar, 50) { Value = birthorder };

                prm[32] = new SqlParameter("@BirthPersonLocality", SqlDbType.VarChar, 99) { Value = Birthpersonlocality };

                prm[33] = new SqlParameter("@BirthPersonLocalityId", SqlDbType.VarChar, 50) { Value = BirthPersonLocalityId };
                prm[34] = new SqlParameter("@BirthPersonFatherName", SqlDbType.VarChar, 50) { Value = BirthpersonFathername };
                prm[35] = new SqlParameter("@BirthPersonMotherName", SqlDbType.VarChar, 50) { Value = Birthpersonmothername };
                prm[36] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[37] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempLateBirthEntry", prm);
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

        public DataSet GetHospitalName()
        {
            SqlParameter[] prm = new SqlParameter[0];

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetHospitalinfo", prm);

            return ds;
        }
	public DBReturn UpdateBirthEntryMain(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[38];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;

                prm[2] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 50) { Value = oprcode };
                prm[3] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 30) { Value = ServiceCode };
                prm[4] = new SqlParameter("@ApplicantAadhaarNo", SqlDbType.VarChar, 15) { Value = ApplicantAadharNo };
                prm[5] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[6] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 99) { Value = ApplicantEmail };
                prm[7] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };

                prm[8] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[9] = new SqlParameter("@Relationship", SqlDbType.VarChar, 50) { Value = RelationofapplicantwithBirthpe };
                prm[10] = new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = BirthDate };

                prm[11] = new SqlParameter("@TypeofBirth", SqlDbType.VarChar, 50) { Value = TypeofBirth };
                prm[12] = new SqlParameter("@BirthVenue", SqlDbType.VarChar, 100) { Value = BirthVenue };
                prm[13] = new SqlParameter("@HospitalName", SqlDbType.VarChar, 100) { Value = HospitalName };
                prm[14] = new SqlParameter("@DaiName", SqlDbType.VarChar, 50) { Value = DaiName };
                prm[15] = new SqlParameter("@ApplicantFathersName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };


                prm[16] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 100) { Value = ApplicantLocality };
                prm[17] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[18] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 50) { Value = ApplicantPremises };

                prm[19] = new SqlParameter("@ApplicantState", SqlDbType.VarChar, 50) { Value = State };
                prm[20] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar, 50) { Value = District };
                prm[21] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                prm[22] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar, 50) { Value = ApplicantPinCode };



                prm[23] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };

                prm[24] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
                prm[25] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[26] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[27] = new SqlParameter("@DAIRegNo", SqlDbType.VarChar, 50) { Value = DAI_Regno };

                prm[28] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                prm[29] = new SqlParameter("@BirthPersonName", SqlDbType.VarChar, 100) { Value = Birthpersonname };

                prm[30] = new SqlParameter("@BirthPersonGender", SqlDbType.VarChar, 1) { Value = BirthpersonGender };
                prm[31] = new SqlParameter("@BirthOrder", SqlDbType.VarChar, 50) { Value = birthorder };

                prm[32] = new SqlParameter("@BirthPersonLocality", SqlDbType.VarChar, 99) { Value = Birthpersonlocality };

                prm[33] = new SqlParameter("@BirthPersonLocalityId", SqlDbType.VarChar, 50) { Value = BirthPersonLocalityId };
                prm[34] = new SqlParameter("@BirthPersonFatherName", SqlDbType.VarChar, 50) { Value = BirthpersonFathername };
                prm[35] = new SqlParameter("@BirthPersonMotherName", SqlDbType.VarChar, 50) { Value = Birthpersonmothername };
                prm[36] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[37] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateLateBirthEntryMain", prm);
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
