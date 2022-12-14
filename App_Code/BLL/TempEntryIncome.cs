using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EDistrictBL
{
    public class TempEntryIncome : TempEntryGeneral
    {
            public Int64 IncomeId { get; set; }
            public string ApplicationNo { get; set; }
            public decimal ApplicantTotalIncome { get; set; }
            public string PurposeCertificate { get; set; }
            public string ReasonOfCertificate { get; set; }
            public string FinancialYear { get; set; }
            public string BankName { get; set; }
            public string EducationDetails { get; set; }
            public string subservicecode { get; set; }
            public Int32 UserType { get; set; }
            public byte[] ApplicantImage { get; set; }
            public string ChildName { get; set; }
            public string RelationShip { get; set; }
            public string CollegeName { get; set; }
            public int DurationOfCourse { get; set; }
            public string EducationSession { get; set; }

            
            //
            public byte[] PatwariDocument { get; set; }
            public string PoliceStationName { get; set; }
            public DateTime PatwariverificationDate { get; set; }
            public DateTime PoliceVerificationDate { get; set; }
            public string PatwariName { get; set; }
            public decimal PatwariVerifiedIncome { get; set; }
            public decimal PoliceVerifiedIncome { get; set; }
            public Int64 PatwariDocumentId { get; set; }
            public int ChildMonthlyFee { get; set; }

            public DBReturn insertincometemp()
            {
                DBReturn objReturn = new DBReturn();
                try
                {
                   
                    SqlParameter[] prm = new SqlParameter[33];

                    prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                    prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                    prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                    prm[3] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                    prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                    prm[5] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                    prm[6] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                    prm[7] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                    prm[8] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                    prm[9] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                    prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                    prm[11] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode};
                    prm[12] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                    prm[13] = new SqlParameter("@Remarks", SqlDbType.VarChar, 100) { Value = Remarks };
                    prm[14] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                    //********************************
                    prm[15] = new SqlParameter("@ApplicantTotalIncome", SqlDbType.Decimal) { Value = ApplicantTotalIncome };
                    prm[16] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                    prm[17] = new SqlParameter("@ReasonOfCertificate", SqlDbType.VarChar, 99) { Value = ReasonOfCertificate };
                    prm[18] = new SqlParameter("@FinancialYear", SqlDbType.VarChar, 10) { Value = FinancialYear };
                    prm[19] = new SqlParameter("@subservicecode", SqlDbType.VarChar, 8) { Value = subservicecode };
                    prm[20] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                    prm[20].Direction = ParameterDirection.Output;
                    prm[21] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                    prm[21].Direction = ParameterDirection.Output;
                    prm[22] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                    prm[23] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar,1) { Value = ApplicantGender };
                    prm[24] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                    prm[25] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//
                    
                    prm[26] = new SqlParameter("@Childname", SqlDbType.VarChar, 50) { Value = ChildName};
                    prm[27] = new SqlParameter("@RelationShip", SqlDbType.VarChar, 50) { Value = RelationShip };
                    prm[28] = new SqlParameter("@CollegeName", SqlDbType.VarChar, 100) { Value = CollegeName};
                    prm[29] = new SqlParameter("@Education", SqlDbType.VarChar, 99) { Value = EducationDetails};
                    prm[30] = new SqlParameter("@DurationofCourse", SqlDbType.Int) { Value = DurationOfCourse};
                    prm[31] = new SqlParameter("@EducationSession", SqlDbType.VarChar, 10) { Value = EducationSession};
                    prm[32] = new SqlParameter("@BankName", SqlDbType.VarChar, 99) { Value = BankName };

                 
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertincometemp", prm);
                    objReturn.ErrMessage = prm[20].Value.ToString();
                    objReturn.ReturnCode = prm[21].Value.ToString();
                    return objReturn;
                   
                }
                catch (Exception Ex)
                {
                    // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                    return objReturn;
                }

            }
            public DBReturn insertincometempNew()
            {
                DBReturn objReturn = new DBReturn();
                try
                {

                    SqlParameter[] prm = new SqlParameter[34];

                    prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                    prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                    prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                    prm[3] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                    prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                    prm[5] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                    prm[6] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                    prm[7] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                    prm[8] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                    prm[9] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                    prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                    prm[11] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                    prm[12] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                    prm[13] = new SqlParameter("@Remarks", SqlDbType.VarChar, 100) { Value = Remarks };
                    prm[14] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                    //********************************
                    prm[15] = new SqlParameter("@ApplicantTotalIncome", SqlDbType.Decimal) { Value = ApplicantTotalIncome };
                    prm[16] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                    prm[17] = new SqlParameter("@ReasonOfCertificate", SqlDbType.VarChar, 99) { Value = ReasonOfCertificate };
                    prm[18] = new SqlParameter("@FinancialYear", SqlDbType.VarChar, 10) { Value = FinancialYear };
                    prm[19] = new SqlParameter("@subservicecode", SqlDbType.VarChar, 8) { Value = "" };
                    prm[20] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                    prm[20].Direction = ParameterDirection.Output;
                    prm[21] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                    prm[21].Direction = ParameterDirection.Output;
                    prm[22] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                    prm[23] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                    prm[24] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                    prm[25] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                    //

                    prm[26] = new SqlParameter("@Childname", SqlDbType.VarChar, 50) { Value = ChildName };
                    prm[27] = new SqlParameter("@RelationShip", SqlDbType.VarChar, 50) { Value = RelationShip };
                    prm[28] = new SqlParameter("@CollegeName", SqlDbType.VarChar, 100) { Value = CollegeName };
                    prm[29] = new SqlParameter("@Education", SqlDbType.VarChar, 99) { Value = EducationDetails };
                    prm[30] = new SqlParameter("@DurationofCourse", SqlDbType.Int) { Value = DurationOfCourse };
                    prm[31] = new SqlParameter("@EducationSession", SqlDbType.VarChar, 10) { Value = EducationSession };
                    prm[32] = new SqlParameter("@BankName", SqlDbType.VarChar, 99) { Value = BankName };
                    prm[33] = new SqlParameter("@ChildMonthlyFee", SqlDbType.Int) { Value = ChildMonthlyFee };


                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertincometempNew", prm);
                    objReturn.ErrMessage = prm[20].Value.ToString();
                    objReturn.ReturnCode = prm[21].Value.ToString();
                    return objReturn;

                }
                catch (Exception Ex)
                {
                    // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                    return objReturn;
                }

            }

            public DBReturn Updateincometemp(string ImageUpdated)
            {
                DBReturn objReturn = new DBReturn();
                try
                {

                    SqlParameter[] prm = new SqlParameter[35];

                    prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                    prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                    prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                    prm[3] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                    prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                    prm[5] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                    prm[6] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                    prm[7] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                    prm[8] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                    prm[9] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                    prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                    prm[11] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                    prm[12] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                    prm[13] = new SqlParameter("@Remarks", SqlDbType.VarChar, 100) { Value = Remarks };
                    prm[14] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                    //********************************
                    prm[15] = new SqlParameter("@ApplicantTotalIncome", SqlDbType.Decimal) { Value = ApplicantTotalIncome };
                    prm[16] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                    prm[17] = new SqlParameter("@ReasonOfCertificate", SqlDbType.VarChar, 99) { Value = ReasonOfCertificate };
                    prm[18] = new SqlParameter("@FinancialYear", SqlDbType.VarChar, 10) { Value = FinancialYear };
                    prm[19] = new SqlParameter("@subservicecode", SqlDbType.VarChar, 8) { Value = subservicecode };
                    prm[20] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                    prm[20].Direction = ParameterDirection.Output;
                    prm[21] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                    prm[21].Direction = ParameterDirection.Output;
                    prm[22] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                    prm[23] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                    prm[24] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                    
                    //--------------------Two Fields Added for Update----------------------------------------
                    prm[25] = new SqlParameter("@tempAppno", SqlDbType.VarChar,30) { Value = tempApplicationNo };
                    prm[26] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar,1) { Value = ImageUpdated };
                    prm[27] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//

                    prm[28] = new SqlParameter("@Childname", SqlDbType.VarChar, 50) { Value = ChildName };
                    prm[29] = new SqlParameter("@RelationShip", SqlDbType.VarChar, 50) { Value = RelationShip };
                    prm[30] = new SqlParameter("@CollegeName", SqlDbType.VarChar, 100) { Value = CollegeName };
                    prm[31] = new SqlParameter("@Education", SqlDbType.VarChar, 99) { Value = EducationDetails };
                    prm[32] = new SqlParameter("@DurationofCourse", SqlDbType.Int) { Value = DurationOfCourse };
                    prm[33] = new SqlParameter("@EducationSession", SqlDbType.VarChar, 10) { Value = EducationSession };
                    prm[34] = new SqlParameter("@BankName", SqlDbType.VarChar, 99) { Value = BankName };


                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Updateincometemp", prm);
                    objReturn.ErrMessage = prm[20].Value.ToString();
                    objReturn.ReturnCode = prm[21].Value.ToString();
                    return objReturn;

                }
                catch (Exception Ex)
                {
                    // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                    return objReturn;
                }
            }
            public DBReturn Updateincometempnew(string ImageUpdated)
            {
                DBReturn objReturn = new DBReturn();
                try
                {

                    SqlParameter[] prm = new SqlParameter[36];

                    prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                    prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                    prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                    prm[3] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                    prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                    prm[5] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                    prm[6] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                    prm[7] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                    prm[8] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                    prm[9] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                    prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                    prm[11] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                    prm[12] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                    prm[13] = new SqlParameter("@Remarks", SqlDbType.VarChar, 100) { Value = Remarks };
                    prm[14] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                    //********************************
                    prm[15] = new SqlParameter("@ApplicantTotalIncome", SqlDbType.Decimal) { Value = ApplicantTotalIncome };
                    prm[16] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                    prm[17] = new SqlParameter("@ReasonOfCertificate", SqlDbType.VarChar, 99) { Value = ReasonOfCertificate };
                    prm[18] = new SqlParameter("@FinancialYear", SqlDbType.VarChar, 10) { Value = FinancialYear };
                    prm[19] = new SqlParameter("@subservicecode", SqlDbType.VarChar, 8) { Value = "" };
                    prm[20] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                    prm[20].Direction = ParameterDirection.Output;
                    prm[21] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                    prm[21].Direction = ParameterDirection.Output;
                    prm[22] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                    prm[23] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                    prm[24] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };

                    //--------------------Two Fields Added for Update----------------------------------------
                    prm[25] = new SqlParameter("@tempAppno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
                    prm[26] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                    prm[27] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//

                    prm[28] = new SqlParameter("@Childname", SqlDbType.VarChar, 50) { Value = ChildName };
                    prm[29] = new SqlParameter("@RelationShip", SqlDbType.VarChar, 50) { Value = RelationShip };
                    prm[30] = new SqlParameter("@CollegeName", SqlDbType.VarChar, 100) { Value = CollegeName };
                    prm[31] = new SqlParameter("@Education", SqlDbType.VarChar, 99) { Value = EducationDetails };
                    prm[32] = new SqlParameter("@DurationofCourse", SqlDbType.Int) { Value = DurationOfCourse };
                    prm[33] = new SqlParameter("@EducationSession", SqlDbType.VarChar, 10) { Value = EducationSession };
                    prm[34] = new SqlParameter("@BankName", SqlDbType.VarChar, 99) { Value = BankName };
                    prm[35] = new SqlParameter("@ChildMonthlyFee", SqlDbType.Int) { Value = ChildMonthlyFee };

                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Updateincometempnew", prm);
                    objReturn.ErrMessage = prm[20].Value.ToString();
                    objReturn.ReturnCode = prm[21].Value.ToString();
                    return objReturn;

                }
                catch (Exception Ex)
                {
                    // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                    return objReturn;
                }
            }
	        
            public DBReturn UpdateincomeMain(string ImageUpdated)
            {
                DBReturn objReturn = new DBReturn();
                try
                {

                    SqlParameter[] prm = new SqlParameter[35];

                    prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                    prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                    prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                    prm[3] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                    prm[4] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                    prm[5] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 60) { Value = ApplicantPremises };
                    prm[6] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                    prm[7] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 50) { Value = ApplicantLocality };
                    prm[8] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                    prm[9] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                    prm[10] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                    prm[11] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                    prm[12] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                    prm[13] = new SqlParameter("@Remarks", SqlDbType.VarChar, 100) { Value = Remarks };
                    prm[14] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                    //********************************
                    prm[15] = new SqlParameter("@ApplicantTotalIncome", SqlDbType.Decimal) { Value = ApplicantTotalIncome };
                    prm[16] = new SqlParameter("@PurposeCertificate", SqlDbType.VarChar, 99) { Value = PurposeCertificate };
                    prm[17] = new SqlParameter("@ReasonOfCertificate", SqlDbType.VarChar, 99) { Value = ReasonOfCertificate };
                    prm[18] = new SqlParameter("@FinancialYear", SqlDbType.VarChar, 10) { Value = FinancialYear };
                    prm[19] = new SqlParameter("@subservicecode", SqlDbType.VarChar, 8) { Value = subservicecode };
                    prm[20] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                    prm[20].Direction = ParameterDirection.Output;
                    prm[21] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                    prm[21].Direction = ParameterDirection.Output;
                    prm[22] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                    prm[23] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
                    prm[24] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };

                    //--------------------Two Fields Added for Update----------------------------------------
                    prm[25] = new SqlParameter("@tempAppno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
                    prm[26] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                    prm[27] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//

                    prm[28] = new SqlParameter("@Childname", SqlDbType.VarChar, 50) { Value = ChildName };
                    prm[29] = new SqlParameter("@RelationShip", SqlDbType.VarChar, 50) { Value = RelationShip };
                    prm[30] = new SqlParameter("@CollegeName", SqlDbType.VarChar, 100) { Value = CollegeName };
                    prm[31] = new SqlParameter("@Education", SqlDbType.VarChar, 99) { Value = EducationDetails };
                    prm[32] = new SqlParameter("@DurationofCourse", SqlDbType.Int) { Value = DurationOfCourse };
                    prm[33] = new SqlParameter("@EducationSession", SqlDbType.VarChar, 10) { Value = EducationSession };
                    prm[34] = new SqlParameter("@BankName", SqlDbType.VarChar, 99) { Value = BankName };


                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateincomeMain", prm);
                    objReturn.ErrMessage = prm[20].Value.ToString();
                    objReturn.ReturnCode = prm[21].Value.ToString();
                    return objReturn;

                }
                catch (Exception Ex)
                {
                    // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                    return objReturn;
                }
            }

                public DataSet GetSubService()
                {
                    DataSet Ds = new DataSet();
                    try
                    {
                        SqlParameter[] prm = new SqlParameter[0];
                        Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, "Select * from mstSubService where Servicecode='INCOMENW'", prm);

                    }
                    catch (Exception Ex)
                    {
                        MyExceptionHandler.HandleException(Ex);
                    }
                    return Ds;
                }
                public DBReturn UpdateverificationDetail()
                {
                    DBReturn objReturn = new DBReturn();
                    try
                    {

                        SqlParameter[] prm = new SqlParameter[12];

                        prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                        prm[1] = new SqlParameter("@PatwariDocument", SqlDbType.Image) { Value = PatwariDocument };
                        prm[2] = new SqlParameter("@PatwariVerificationDate", SqlDbType.DateTime) { Value = PatwariverificationDate };
                        prm[3] = new SqlParameter("@PoliceStation", SqlDbType.VarChar, 50) { Value = PoliceStationName };
                        prm[4] = new SqlParameter("@PoliceVerificationDate", SqlDbType.DateTime) { Value = PoliceVerificationDate };
                        prm[5] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };

                        //********************************

                        prm[6] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                        prm[6].Direction = ParameterDirection.Output;
                        prm[7] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                        prm[7].Direction = ParameterDirection.Output;
                        prm[8] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                        prm[9] = new SqlParameter("@PatwariName", SqlDbType.VarChar, 50) { Value = PatwariName };
                        prm[10] = new SqlParameter("@PatwariVerifiedIncome", SqlDbType.Decimal) { Value = PatwariVerifiedIncome };
                        prm[11] = new SqlParameter("@PoliceVerifiedIncome", SqlDbType.Decimal) { Value = PoliceVerifiedIncome };
                        SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "updateIncomeVerificationStatus", prm);
                        objReturn.ErrMessage = prm[6].Value.ToString();
                        objReturn.ReturnCode = prm[7].Value.ToString();
                        return objReturn;

                    }
                    catch (Exception Ex)
                    {
                        MyExceptionHandler.HandleException(Ex);
                        return objReturn;
                    }
                }

                public byte[] GetPatwariSignedDocument()
                {
                    byte[] Document = null;
                    try
                    {
                        SqlParameter[] prm = new SqlParameter[2];
                        prm[0] = new SqlParameter("@Applicationno", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                        prm[1] = new SqlParameter("@Docid", SqlDbType.BigInt) { Value = PatwariDocumentId };
                        DataSet Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, "Select SignedDoc from tblDocument where DocApplicationNo=@Applicationno and DocId=@Docid", prm);
                        if (Ds.Tables.Count > 0 && Ds.Tables[0].Rows.Count > 0)
                        {
                            Document = (byte[])Ds.Tables[0].Rows[0]["SignedDoc"];
                        }
                    }
                    catch (Exception Ex)
                    {

                        MyExceptionHandler.HandleException(Ex);
                    }
                    return Document;
                }
		public DataSet GetIncomeSnapShot()
                {
                    DataSet Ds = new DataSet();
                    SqlParameter[] prm = new SqlParameter[0];
                    Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "IncomeSnapShot");
                    return Ds;
                }
    }
}
