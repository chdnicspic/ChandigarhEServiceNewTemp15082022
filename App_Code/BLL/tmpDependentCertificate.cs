using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EDistrictBL
{
    public class tmpDependentCertificate : TempEntryGeneral
    {
        public string ServiceCode { get; set; }
        public string DeceasedName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string DepartmentAddress { get; set; }
        public string RelationwithDeceased { get; set; }
        public byte[] ApplicantImage { get; set; }
        public DateTime DiedOnDate { get; set; }
        public DataTable dtDependentDetail { get; set; }
        public string LetterFromDesignation { get; set; }
        public string LetterNo { get; set; }
        public string LetterDate { get; set; }
        public string State { get; set; }
         public string UserType { get; set; }
         public string FatherName { get; set; }
         public string ApplicationNo { get; set; }
         public int Id { get; set; }
         public string Name { get; set; }
         public string Relation { get; set; }
         public int Age { get; set; }
         public string MarritalStatus { get; set; }
         public string Occupation { get; set; }
         public string MotherStatus { get; set; }
         public string DeceasedReligion { get; set; }
         public string DeceasedGender { get; set; }
         public string DeceasedMarritalStatus { get; set; }
         public string DeceasedHouseNo { get; set; }
         public string DeceasedLocalityId { get; set; }
         public string DeceasedLocality { get; set; }
         public string DeceasedState { get; set; }
         public string DeceasedTehsil { get; set; }
         public string DeceasedDistrict { get; set; }
         public int DeceasedPinCode { get; set; }
         public bool isSameAddress { get; set; }
         public string Purposeofjob { get; set; }
         public string DependentName { get; set; }

         public string CurrentUserid { get; set; }
         public string Approved { get; set; }
         public DBReturn InsertIntoDependent()
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[47];
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
                 prm[12] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                 prm[13] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                 prm[14] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                 prm[15] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                 prm[16] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                 prm[17] = new SqlParameter("@DeceasedName", SqlDbType.VarChar, 99) { Value = DeceasedName };
                 prm[18] = new SqlParameter("@Department", SqlDbType.VarChar, 59) { Value = Department };
                 prm[19] = new SqlParameter("@Designation", SqlDbType.VarChar, 59) { Value = Designation };
                 prm[20] = new SqlParameter("@DepartmentAddress", SqlDbType.VarChar, 150) { Value = DepartmentAddress };
                 prm[21] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                 prm[22] = new SqlParameter("@RelationwithDeceased", SqlDbType.VarChar, 30) { Value = RelationwithDeceased };
                 prm[23] = new SqlParameter("@DiedOnDate", SqlDbType.DateTime) { Value = DiedOnDate };
                 prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 prm[25] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                 prm[26] = new SqlParameter("@DependentDetails", SqlDbType.Structured) { Value = dtDependentDetail };
                 prm[27] = new SqlParameter("@LetterFromDesignation", SqlDbType.VarChar, 59) { Value = LetterFromDesignation };
                 prm[28] = new SqlParameter("@LetterNo", SqlDbType.VarChar, 50) { Value = LetterNo };
                 prm[29] = new SqlParameter("@LetterDate", SqlDbType.DateTime) { Value = LetterDate };
                 prm[30] = new SqlParameter("@FatherName", SqlDbType.VarChar, 99) { Value = FatherName };
                 prm[31] = new SqlParameter("@MotherStatus", SqlDbType.VarChar, 30) { Value = MotherStatus };
                 prm[32] = new SqlParameter("@DeceasedReligion", SqlDbType.VarChar, 99) { Value = DeceasedReligion };
                 prm[33] = new SqlParameter("@DeceasedMarritalStatus", SqlDbType.VarChar, 30) { Value = DeceasedMarritalStatus };
                 prm[34] = new SqlParameter("@DeceasedGender", SqlDbType.Char, 1) { Value = DeceasedGender };
                 prm[35] = new SqlParameter("@DeceasedHouseNo", SqlDbType.VarChar, 49) { Value = DeceasedHouseNo };
                 prm[36] = new SqlParameter("@DeceasedLocalityId", SqlDbType.VarChar, 20) { Value = DeceasedLocalityId };
                 prm[37] = new SqlParameter("@DeceasedLocalityName", SqlDbType.VarChar, 50) { Value = DeceasedLocality };
                 prm[38] = new SqlParameter("@DeceasedState", SqlDbType.VarChar, 50) { Value = DeceasedState };
                 prm[39] = new SqlParameter("@DeceasedPincode", SqlDbType.Int) { Value = DeceasedPinCode };
                 prm[40] = new SqlParameter("@DeceasedTehsil", SqlDbType.VarChar, 50) { Value = DeceasedTehsil };
                 prm[41] = new SqlParameter("@DeceasedDistrict", SqlDbType.VarChar, 50) { Value = DeceasedDistrict };
                 prm[42] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                 prm[43] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                 prm[44] = new SqlParameter("@isSameAddress", SqlDbType.Bit) { Value = isSameAddress };
                 prm[45] = new SqlParameter("@PurposeofApplication", SqlDbType.VarChar,200) { Value = Purposeofjob };
                 prm[46] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraDependentCertificate", prm);
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


         public DataSet GetAllDependentDetail()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[1];
                 
                 prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDependentDetails", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }

         }

         public DBReturn UpdateIntoDependentTemp(string ImageUpdated)
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[49];                
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
                 prm[12] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                 prm[13] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                 prm[14] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                 prm[15] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                 prm[16] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                 prm[17] = new SqlParameter("@DeceasedName", SqlDbType.VarChar, 99) { Value = DeceasedName };
                 prm[18] = new SqlParameter("@Department", SqlDbType.VarChar, 59) { Value = Department };
                 prm[19] = new SqlParameter("@Designation", SqlDbType.VarChar, 59) { Value = Designation };
                 prm[20] = new SqlParameter("@DepartmentAddress", SqlDbType.VarChar, 150) { Value = DepartmentAddress };
                 prm[21] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                 prm[22] = new SqlParameter("@RelationwithDeceased", SqlDbType.VarChar, 30) { Value = RelationwithDeceased };
                 prm[23] = new SqlParameter("@DiedOnDate", SqlDbType.DateTime) { Value = DiedOnDate };
                 prm[24] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                 prm[25] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };                
                 prm[26] = new SqlParameter("@LetterFromDesignation", SqlDbType.VarChar, 59) { Value = LetterFromDesignation };
                 prm[27] = new SqlParameter("@LetterNo", SqlDbType.VarChar, 30) { Value = LetterNo };
                 prm[28] = new SqlParameter("@LetterDate", SqlDbType.DateTime) { Value = LetterDate };
                 prm[29] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 prm[30] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                 prm[31] = new SqlParameter("@FatherName", SqlDbType.VarChar, 99) { Value = FatherName };
                 prm[32] = new SqlParameter("@MotherStatus", SqlDbType.VarChar, 30) { Value = MotherStatus };
                 prm[33] = new SqlParameter("@DeceasedReligion", SqlDbType.VarChar, 99) { Value = DeceasedReligion };
                 prm[34] = new SqlParameter("@DeceasedMarritalStatus", SqlDbType.VarChar, 30) { Value = DeceasedMarritalStatus };
                 prm[35] = new SqlParameter("@DeceasedGender", SqlDbType.Char, 1) { Value = DeceasedGender };
                 prm[36] = new SqlParameter("@DeceasedHouseNo", SqlDbType.VarChar, 49) { Value = DeceasedHouseNo };
                 prm[37] = new SqlParameter("@DeceasedLocalityId", SqlDbType.VarChar, 20) { Value = DeceasedLocalityId };
                 prm[38] = new SqlParameter("@DeceasedLocalityName", SqlDbType.VarChar, 50) { Value = DeceasedLocality };
                 prm[39] = new SqlParameter("@DeceasedState", SqlDbType.VarChar, 50) { Value = DeceasedState };
                 prm[40] = new SqlParameter("@DeceasedPincode", SqlDbType.Int) { Value = DeceasedPinCode };
                 prm[41] = new SqlParameter("@DeceasedTehsil", SqlDbType.VarChar, 50) { Value = DeceasedTehsil };
                 prm[42] = new SqlParameter("@DeceasedDistrict", SqlDbType.VarChar, 50) { Value = DeceasedDistrict };
                 prm[43] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
                 prm[44] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                 prm[45] = new SqlParameter("@DependentDetails", SqlDbType.Structured) { Value = dtDependentDetail };
                 prm[46] = new SqlParameter("@isSameAddress", SqlDbType.Bit) { Value = isSameAddress };
                 prm[47] = new SqlParameter("@PurposeofApplication", SqlDbType.VarChar, 200) { Value = Purposeofjob };
                 prm[48] = new SqlParameter("@ApplicantMaritalStatus", SqlDbType.Int) { Value = ApplicantMaritalStatus };
                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraDependentCertificate", prm);
                 objReturn.ErrMessage = prm[1].Value.ToString();
                 objReturn.ReturnCode = prm[2].Value.ToString();
                // objReturn.ReturnCode1 = prm[36].Value.ToString();
                 return objReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return objReturn;
             }
         }

        public DBReturn UpdateDependentDetail()
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
                 prm[3] = new SqlParameter("@Name", SqlDbType.VarChar, 99) { Value = Name };
                 prm[4] = new SqlParameter("@Relation", SqlDbType.VarChar, 50) { Value = Relation };
                 prm[5] = new SqlParameter("@Age", SqlDbType.Int) { Value = Age };
                 prm[6] = new SqlParameter("@MarritalStatus", SqlDbType.VarChar, 50) { Value = MarritalStatus };
                 prm[7] = new SqlParameter("@Occupation", SqlDbType.VarChar, 99) { Value = Occupation };

                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_DependentDetail", prm);
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
         public DBReturn UpdateTehsildarRemark(string ApplicationNo, string TehsildarRemark)
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[2];

                 prm[0] = new SqlParameter("@TehsildarRemark", SqlDbType.VarChar, 500) { Value = TehsildarRemark };
                 prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_TehsildarRemark_DependentCert", prm);               
                 return objReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return objReturn;
             }
         }

         public DataSet GetdependentsDetail_MainTable()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[2];

                 prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                 prm[1] = new SqlParameter("@servicecode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDependentDetailsfrom_Maintable", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }
         }

         public DataSet GetDataSetClubNotings()
         {
             SqlParameter[] prm = new SqlParameter[1];
             prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsDependency", prm);
             DataTable dt = new DataTable();
             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 dt = ds.Tables[0];
             }
             return ds;
         }
         public DataSet GetRelation()
         {
             DataSet DsReturn = new DataSet();
             try
             {
                 SqlParameter[] prm = new SqlParameter[0];
                 DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getRelationDependent", prm);

                 return DsReturn;
             }
             catch (Exception Ex)
             {
                 // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                 return DsReturn;
             }
         }
         public byte[] GetDependentDocs()
         {

             Byte[] b = null;
             SqlParameter[] prm = new SqlParameter[3];
             prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
             prm[1] = new SqlParameter("@TempApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
             prm[2] = new SqlParameter("@Id", SqlDbType.VarChar, 99) { Value = Id };

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDependentDocs", prm);


             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

             }
             return b;
         }
         public byte[] GetDependentDocsFromMain()
         {

             Byte[] b = null;
             SqlParameter[] prm = new SqlParameter[3];
             prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
             prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
             prm[2] = new SqlParameter("@Id", SqlDbType.VarChar, 99) { Value = Id };

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDependentDocsFromMain", prm);


             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

             }
             return b;
         }

         public DBReturn UpdatePatwariRemark()
         {
             DBReturn objReturn = new DBReturn();
             try
             {
                 SqlParameter[] prm = new SqlParameter[5];
                 prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                 prm[0].Direction = ParameterDirection.Output;
                 prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                 prm[1].Direction = ParameterDirection.Output;
                 prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 99) { Value = ServiceCode };
                 prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                 prm[4] = new SqlParameter("@DependentDetails", SqlDbType.Structured) { Value = dtDependentDetail };


                 SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateDependentPatwariRemark", prm);
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
         public DataSet GenerateDraftFinalDependentCert()
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

             DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_Draft_DependentFinal_Certificate", prm);
             return ds;

         }

    }
}
