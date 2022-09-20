using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EDistrictBL
{
    public class tmpLegalHeirCertificate : TempEntryGeneral
    {
        public string ServiceCode { get; set; }
        public string DeceasedName { get; set; }
        public string DeceasedPremises { get; set; }
        public string DeceasedDistrict { get; set; }
        public string DeceasedTehsil { get; set; }
        public string DeceasedPincode { get; set; }
        public string DeceasedState { get; set; }
        public string DeceasedLocalityId { get; set; }
        public string DeceasedLocality { get; set; }
        public string DeceasedDesignation { get; set; }
        public string DeceasedGender { get; set; }
        public string Motherstatus { get; set; }
        public string Deceasedmaritalstatus { get; set; }
        public string ApplicantState { get; set; }
        public string ApplicantDistrict { get; set; }
        public string ApplicantTehsil { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string DepartmentAddress { get; set; }
        public string RelationwithDeceased { get; set; }
        public byte[] ApplicantImage { get; set; }
        public DateTime DiedOnDate { get; set; }
        public DataTable dtLegalHeirDetails { get; set; }
        public string ActionTakenBy { get;set; }
        //public DataTable dtLegalHeirSubDetail { get; set; }
        public string LetterFromDesignation { get; set; }
        public string LetterNo { get; set; }
        public string LetterDate { get; set; }
        public string State { get; set; }
         public string UserType { get; set; }
         public string FatherName { get; set; }
         public string DeceasedReligion { get; set; }
         public string Purpose { get; set; }
         public bool isSameAddress { get; set; }
         public string ApplicationNo { get; set; }
         public DataTable dtLegalHeirDetail { get; set; }
         public string CurrentUserid { get; set; }
         public string Approved { get; set; }

         public DBReturn InsertIntoLegalHeir()
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[48];
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
                 prm[12] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar) { Value = ApplicantPinCode };
                 prm[13] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                 prm[14] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                 prm[15] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                 prm[16] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                 prm[17] = new SqlParameter("@DeceasedName", SqlDbType.VarChar, 99) { Value = DeceasedName };
                 prm[18] = new SqlParameter("@Department", SqlDbType.VarChar, 99) { Value = Department };
                 prm[19] = new SqlParameter("@Designation", SqlDbType.VarChar, 50) { Value = Designation };
                 prm[20] = new SqlParameter("@DepartmentAddress", SqlDbType.VarChar, 150) { Value = DepartmentAddress };
                 prm[21] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                 prm[22] = new SqlParameter("@RelationwithDeceased", SqlDbType.VarChar, 30) { Value = RelationwithDeceased };
                 prm[23] = new SqlParameter("@DiedOnDate", SqlDbType.DateTime) { Value = DiedOnDate };
                 prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 prm[25] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                 prm[26] = new SqlParameter("@LetterFromDesignation", SqlDbType.VarChar, 99) { Value = LetterFromDesignation };
                 prm[27] = new SqlParameter("@LetterNo", SqlDbType.VarChar, 50) { Value = LetterNo };
                 prm[28] = new SqlParameter("@LetterDate", SqlDbType.DateTime) { Value = LetterDate };
                 prm[29] = new SqlParameter("@FatherName", SqlDbType.VarChar) { Value = FatherName };
                 prm[30] = new SqlParameter("@LegalheirDetails", SqlDbType.Structured) { Value = dtLegalHeirDetail };
                 prm[31] = new SqlParameter("@ApplicantState", SqlDbType.VarChar) { Value = ApplicantState };
                 prm[32] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar) { Value = ApplicantDistrict };
                 prm[33] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar) { Value = ApplicantTehsil };
                 prm[34] = new SqlParameter("@DeceasedDesignation", SqlDbType.VarChar) { Value = DeceasedDesignation };
                 prm[35] = new SqlParameter("@DeceasedPremises", SqlDbType.VarChar) { Value = DeceasedPremises };
                 prm[36] = new SqlParameter("@DeceasedLocalityId", SqlDbType.VarChar) { Value = DeceasedLocalityId };
                 prm[37] = new SqlParameter("@DeceasedLocality", SqlDbType.VarChar) { Value = DeceasedLocality };
                 prm[38] = new SqlParameter("@DeceasedState", SqlDbType.VarChar) { Value = DeceasedState };
                 prm[39] = new SqlParameter("@DeceasedDistrict", SqlDbType.VarChar) { Value = DeceasedDistrict };
                 prm[40] = new SqlParameter("@DeceasedTehsil", SqlDbType.VarChar) { Value = DeceasedTehsil };
                 prm[41] = new SqlParameter("@DeceasedPincode", SqlDbType.VarChar) { Value = DeceasedPincode };
                 prm[42] = new SqlParameter("@issameAddress",SqlDbType.Bit) { Value = isSameAddress };
                 prm[43] = new SqlParameter("@DeceasedGender", SqlDbType.VarChar) { Value = DeceasedGender };
                 prm[44] = new SqlParameter("@MotherStatus", SqlDbType.VarChar) { Value = Motherstatus };
                 prm[45] = new SqlParameter("@DeceasedMaritalStatus", SqlDbType.VarChar) { Value = Deceasedmaritalstatus };
                 prm[46] = new SqlParameter("@DeceasedReligion", SqlDbType.VarChar) { Value = DeceasedReligion };
                 prm[47] = new SqlParameter("@Purpose", SqlDbType.VarChar) { Value = Purpose };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraLegalheirCertificate", prm);
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
          public DBReturn UpdateLegalHeirDetailBySuperintendent()
	          {
	              DBReturn objReturn = new DBReturn();
	              try
	              {
	                  SqlParameter[] prm = new SqlParameter[9];
	                  
	                  prm[0] = new SqlParameter("@LetterNo", SqlDbType.VarChar, 50) { Value = LetterNo };
	                  prm[1] = new SqlParameter("@LetterDate", SqlDbType.DateTime) { Value = LetterDate };
	                  prm[2] = new SqlParameter("@LetterFromDesignation", SqlDbType.VarChar, 99) { Value = LetterFromDesignation };
	 
	                  prm[3] = new SqlParameter("@DepartmentAddress", SqlDbType.VarChar, 150) { Value = DepartmentAddress };
	                  prm[4] = new SqlParameter("@Department", SqlDbType.VarChar, 99) { Value = Department };
	                  prm[5] = new SqlParameter("@TempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
	                  prm[6] = new SqlParameter("@ErrMessage", SqlDbType.VarChar, 50);
	                  prm[6].Direction = ParameterDirection.Output;
	                  prm[7] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
	                  prm[7].Direction = ParameterDirection.Output;
	                  prm[8] = new SqlParameter("@UserLogin", SqlDbType.VarChar, 15) { Value = CurrentUserid};
	                  SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateLegalHeirDetailBySuperintendent", prm);
	                  objReturn.ErrMessage = prm[6].Value.ToString();
	                  objReturn.ReturnCode = prm[7].Value.ToString();
	                  return objReturn;
	              }
	              catch (Exception Ex)
	              {
	                  // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
	                  return objReturn;
	              }
	              
         }

	public DataSet GenerateFinalLegalHeirCertDraft()
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

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateLegalHeirFinalCertificateDraft", prm);
             return ds;

         }
         public DataSet GetAllLegalHeirDetail()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 prm[0] = new SqlParameter("@tempAppno", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetTemproryHeirDetails", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }


         }

         public DataSet GetAllLegalHeirDetailmain()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetTemproryHeirDetailsmain", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }


         }

         public DataSet GetDirectLegalHeir()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 prm[0] = new SqlParameter("@TempAppno", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getDirectLegalHeir", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }


         }
         public DataSet GetInDirectLegalHeir()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 prm[0] = new SqlParameter("@TempAppno", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getInDirectLegalHeir", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }


         }
         public DataSet GetCheckPatwariVerifiedLegalHeirDetail()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "CheckPatwariVerifiedLegalHeirDetail", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }


         }
         public DBReturn UpdatePatwriRemark()
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
                 prm[4] = new SqlParameter("@LegalHeirCSVID", SqlDbType.VarChar,8000) { Value = LegalHeirCSVID };
                 prm[5] = new SqlParameter("@ActionTakenBy", SqlDbType.VarChar, 15) { Value = ActionTakenBy };

                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateLegalHeirPatwariRemark", prm);
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
         public byte[] GetLegalHeirDocsFromMain()
         {

             Byte[] b = null;
             SqlParameter[] prm = new SqlParameter[3];
             prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
             prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
             prm[2] = new SqlParameter("@Id", SqlDbType.VarChar, 99) { Value = Id };

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetLegalHeirDocsFromMain", prm);


             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

             }
             return b;
         }
         public DBReturn UpdateIntoLegalHeirTemp(string ImageUpdated)
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[50];

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
                 prm[12] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar) { Value = ApplicantPinCode };
                 prm[13] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                 prm[14] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                 prm[15] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                 prm[16] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                 prm[17] = new SqlParameter("@DeceasedName", SqlDbType.VarChar, 99) { Value = DeceasedName };
                 prm[18] = new SqlParameter("@Department", SqlDbType.VarChar, 99) { Value = Department };
                 prm[19] = new SqlParameter("@Designation", SqlDbType.VarChar, 50) { Value = Designation };
                 prm[20] = new SqlParameter("@DepartmentAddress", SqlDbType.VarChar, 150) { Value = DepartmentAddress };
                 prm[21] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                 prm[22] = new SqlParameter("@RelationwithDeceased", SqlDbType.VarChar, 30) { Value = RelationwithDeceased };
                 prm[23] = new SqlParameter("@DiedOnDate", SqlDbType.DateTime) { Value = DiedOnDate };
                 prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 prm[25] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = ApplicantState };
                 prm[26] = new SqlParameter("@LetterFromDesignation", SqlDbType.VarChar, 99) { Value = LetterFromDesignation };
                 prm[27] = new SqlParameter("@LetterNo", SqlDbType.VarChar, 50) { Value = LetterNo };
                 prm[28] = new SqlParameter("@LetterDate", SqlDbType.DateTime) { Value = LetterDate };
                 prm[29] = new SqlParameter("@FatherName", SqlDbType.VarChar) { Value = FatherName };
                 prm[30] = new SqlParameter("@LegalheirDetails", SqlDbType.Structured) { Value = dtLegalHeirDetail };
                 prm[31] = new SqlParameter("@ApplicantState", SqlDbType.VarChar) { Value = ApplicantState };
                 prm[32] = new SqlParameter("@ApplicantDistrict", SqlDbType.VarChar) { Value = ApplicantDistrict };
                 prm[33] = new SqlParameter("@ApplicantTehsil", SqlDbType.VarChar) { Value = ApplicantTehsil };
                 prm[34] = new SqlParameter("@DeceasedDesignation", SqlDbType.VarChar) { Value = DeceasedDesignation };
                 prm[35] = new SqlParameter("@DeceasedPremises", SqlDbType.VarChar) { Value = DeceasedPremises };
                 prm[36] = new SqlParameter("@DeceasedLocalityId", SqlDbType.VarChar) { Value = DeceasedLocalityId };
                 prm[37] = new SqlParameter("@DeceasedLocality", SqlDbType.VarChar) { Value = DeceasedLocality };
                 prm[38] = new SqlParameter("@DeceasedState", SqlDbType.VarChar) { Value = DeceasedState };
                 prm[39] = new SqlParameter("@DeceasedDistrict", SqlDbType.VarChar) { Value = DeceasedDistrict };
                 prm[40] = new SqlParameter("@DeceasedTehsil", SqlDbType.VarChar) { Value = DeceasedTehsil };
                 prm[41] = new SqlParameter("@DeceasedPincode", SqlDbType.VarChar) { Value = DeceasedPincode };
                 prm[42] = new SqlParameter("@issameAddress", SqlDbType.Bit) { Value = isSameAddress };
                 prm[43] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                 prm[44] = new SqlParameter("@TempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 prm[45] = new SqlParameter("@DeceasedGender", SqlDbType.VarChar) { Value = DeceasedGender };
                 prm[46] = new SqlParameter("@MotherStatus", SqlDbType.VarChar) { Value = Motherstatus };
                 prm[47] = new SqlParameter("@DeceasedMaritalStatus", SqlDbType.VarChar) { Value = Deceasedmaritalstatus };
                 prm[48] = new SqlParameter("@DeceasedReligion", SqlDbType.VarChar) { Value = DeceasedReligion };
                 prm[49] = new SqlParameter("@Purpose", SqlDbType.VarChar) { Value = Purpose };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraLegalHeirCertificate", prm);
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
         public DBReturn UpdateTehsildarRemark(string ApplicationNo, string TehsildarRemark)
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[2];

                 prm[0] = new SqlParameter("@TehsildarRemark", SqlDbType.VarChar, 500) { Value = TehsildarRemark };
                 prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_TehsildarRemark_LegalHeir", prm);
                 return objReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return objReturn;
             }
         }


         public string LegalHeirCSVID { get; set; }

         public DataSet GenerateFinalLegalHeirCert()
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

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateLegalHeirFinalCertificate", prm);
             return ds;

         }

         public DataSet GenerateLegalHeirPatwariReport()
         {
             DataSet dt = new DataSet();
             DBReturn objReturn = new DBReturn();
             SqlParameter[] prm = new SqlParameter[3];
             prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
             //prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
             prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
             prm[1].Direction = ParameterDirection.Output;
             prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
             prm[2].Direction = ParameterDirection.Output;


             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateLegalHeirPatwariReport", prm);

             return ds;
         }
	




	


    }
}
