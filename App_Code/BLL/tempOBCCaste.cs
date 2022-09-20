using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;
namespace EDistrictBL
{

    public class tempOBCCaste : TempEntryGeneral
    {
        public Int64 CasteId { get; set; }
        public string TempApplicationNo { get; set; }
        public Int32 ApplicantReligon { get; set; }
        public Int32 ResidencyPeriod { get; set; }
        public string ApplicantCaste { get; set; }
        public string ApplicantSubCaste { get; set; }
        public Int32 RelationWithApplicant { get; set; }
        public string OldCertificateNo { get; set; }
        public DateTime? OldCertificateDate { get; set; }
        public Int32 OldRelationship { get; set; }
        public string OldCertificateIssueAuthority { get; set; }
        public Int32 OldCertificateIssuePinCode { get; set; }
        public string OldCertificateAddress { get; set; }
        public string OldCertificateTahsil { get; set; }
        public string OldCertificateDistrict { get; set; }
        public string OldCertificateState { get; set; }
        public string Proofbefore1966 { get; set; }
        public string NameofOfficer1 { get; set; }
        public string AddressOfficer1 { get; set; }
        public string DesigOfficer1 { get; set; }
        public string DeptOfficer1 { get; set; }
        public string NameofOfficer2 { get; set; }
        public string AddressOfficer2 { get; set; }
        public string DesigOfficer2 { get; set; }
        public string DeptOfficer2 { get; set; }
        public string OldCertApplicantname { get; set; }
        public string OldcertFatherName { get; set; }

        //OBC Case Father Detail
        public string FatherOccupation { get; set; }
        public string IsFatherGazettedOfficer { get; set; }
        public string FatherDesignation { get; set; }
        public string FatherDepartment { get; set; }
        public DateTime? FatherGazettedDateofJoining { get; set; }
        public Int32 IncomeofFather { get; set; }
        public string IsFatherPropertyOwned { get; set; }
        public string FatherPropertyDetail { get; set; }
        public Int32 FatherIncomefromProperty { get; set; }
        public string IsFatherAgricultureProperty { get; set; }
        public string FatherAgriPropertyDetail { get; set; }
        //

        //OBC Case Mother Detail
        public string MotherOccupation { get; set; }
        public string IsMotherGazettedOfficer { get; set; }
        public string MotherDesignation { get; set; }
        public string MotherDepartment { get; set; }
        public DateTime? MotherGazettedDateofJoining { get; set; }
        public Int32 IncomeofMother { get; set; }
        public string IsMotherPropertyOwned { get; set; }
        public string MotherPropertyDetail { get; set; }
        public Int32 MotherIncomefromProperty { get; set; }
        public string IsMotherAgricultureProperty { get; set; }
        public string MotherAgriPropertyDetail { get; set; }
        public byte[] ApplicantImage { get; set; }
        //


        public string ISCreamyLayer { get; set; }
        public string AnyGazettedOfficerinFamily { get; set; }
        public DataTable dtFamilyDetails { get; set; }
        public string UserType { get; set; }
        public decimal FamilyIncome { get; set; }


        public DBReturn InsertTempCaste()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[66];



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




                prm[15] = new SqlParameter("@ResidencePeriod", SqlDbType.Int) { Value = ResidencyPeriod };
                prm[16] = new SqlParameter("@ApplicantReligon", SqlDbType.Int) { Value = ApplicantReligon };
                prm[17] = new SqlParameter("@RelationWithApplicant", SqlDbType.Int) { Value = RelationWithApplicant };
                prm[18] = new SqlParameter("@OldCertificateNo", SqlDbType.VarChar, 50) { Value = OldCertificateNo };
                prm[19] = new SqlParameter("@OldCertificateDate", SqlDbType.DateTime) { Value = OldCertificateDate };
                prm[20] = new SqlParameter("@OldRelationship", SqlDbType.Int) { Value = OldRelationship };
                prm[21] = new SqlParameter("@OldCertificateIssueAuthority", SqlDbType.VarChar, 150) { Value = OldCertificateIssueAuthority };
                prm[22] = new SqlParameter("@OldCertificateIssuePinCode", SqlDbType.Int) { Value = OldCertificateIssuePinCode };
                prm[23] = new SqlParameter("@OldCertificateAddress", SqlDbType.VarChar, 300) { Value = OldCertificateAddress };
                prm[24] = new SqlParameter("@OldCertificateTahsil", SqlDbType.VarChar, 50) { Value = OldCertificateTahsil };
                prm[25] = new SqlParameter("@OldCertificateDistrict", SqlDbType.VarChar, 50) { Value = OldCertificateDistrict };
                prm[26] = new SqlParameter("@OldCertificateState", SqlDbType.VarChar, 50) { Value = OldCertificateState };


                prm[27] = new SqlParameter("@Proofbefore1966", SqlDbType.VarChar, 100) { Value = Proofbefore1966 };
                prm[28] = new SqlParameter("@NameofOfficer1", SqlDbType.VarChar, 99) { Value = NameofOfficer1 };
                prm[29] = new SqlParameter("@DesigOfficer1", SqlDbType.VarChar, 150) { Value = DesigOfficer1 };
                prm[30] = new SqlParameter("@DeptOfficer1", SqlDbType.VarChar, 200) { Value = DeptOfficer1 };
                prm[31] = new SqlParameter("@NameofOfficer2", SqlDbType.VarChar, 99) { Value = NameofOfficer2 };
                prm[32] = new SqlParameter("@DesigOfficer2", SqlDbType.VarChar, 150) { Value = DesigOfficer2 };
                prm[33] = new SqlParameter("@DeptOfficer2", SqlDbType.VarChar, 200) { Value = DeptOfficer2 };


                prm[34] = new SqlParameter("@Caste ", SqlDbType.VarChar, 50) { Value = ApplicantCaste };



                prm[35] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[35].Direction = ParameterDirection.Output;
                prm[36] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[36].Direction = ParameterDirection.Output;
                prm[37] = new SqlParameter("@AppliedBy", SqlDbType.VarChar, 99) { Value = AppliedBy };
                prm[38] = new SqlParameter("@AppliedbyFather", SqlDbType.VarChar, 99) { Value = AppliedByFatherName };
                prm[39] = new SqlParameter("@OldCertApplicantname", SqlDbType.VarChar, 99) { Value = OldCertApplicantname };
                prm[40] = new SqlParameter("@OldcertFatherName ", SqlDbType.VarChar, 99) { Value = OldcertFatherName };
                prm[41] = new SqlParameter("@ApplicantGender ", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[42] = new SqlParameter("@ApplicantMothername ", SqlDbType.VarChar, 99) { Value = ApplicantMothername };



                //New Params Added in case of OBC -Father Details
                prm[43] = new SqlParameter("@FatherOccupation", SqlDbType.VarChar, 100) { Value = FatherOccupation };
                prm[44] = new SqlParameter("@IsFatherGazettedOfficer", SqlDbType.Char, 1) { Value = IsFatherGazettedOfficer };
                prm[45] = new SqlParameter("@FatherDesignation", SqlDbType.VarChar, 99) { Value = FatherDesignation };
                prm[46] = new SqlParameter("@FatherDepartment ", SqlDbType.VarChar, 99) { Value = FatherDepartment };
                prm[47] =new SqlParameter("@FatherGazettedDateofJoining", SqlDbType.DateTime) { Value = FatherGazettedDateofJoining };
                prm[48] =new SqlParameter("@IncomeofFather", SqlDbType.Int) { Value = IncomeofFather };
                prm[49] = new SqlParameter("@IsFatherPropertyOwned ", SqlDbType.Char, 1) { Value = IsFatherPropertyOwned };
                prm[50] =new SqlParameter("@FatherPropertyDetail", SqlDbType.VarChar,500) { Value = FatherPropertyDetail };
                prm[51] = new SqlParameter("@FatherIncomefromProperty ", SqlDbType.Int, 99) { Value = FatherIncomefromProperty };
                prm[52] =new SqlParameter("@IsFatherAgricultureProperty", SqlDbType.Char,1) { Value = IsFatherAgricultureProperty };
                prm[53] = new SqlParameter("@FatherAgriPropertyDetail ", SqlDbType.VarChar, 500) { Value = FatherAgriPropertyDetail };
                //



                //New Params Added in case of OBC -Mother Details
                prm[54] = new SqlParameter("@MotherOccupation", SqlDbType.VarChar, 100) { Value = MotherOccupation };
                prm[55] = new SqlParameter("@IsMotherGazettedOfficer", SqlDbType.Char, 1) { Value = IsMotherGazettedOfficer };
                prm[56] = new SqlParameter("@MotherDesignation", SqlDbType.VarChar, 99) { Value = MotherDesignation };
                prm[57] = new SqlParameter("@MotherDepartment ", SqlDbType.VarChar, 99) { Value = MotherDepartment };
                prm[58] = new SqlParameter("@MotherGazettedDateofJoining", SqlDbType.DateTime) { Value = MotherGazettedDateofJoining };
                prm[59] = new SqlParameter("@IncomeofMother", SqlDbType.Int) { Value = IncomeofMother };
                prm[60] = new SqlParameter("@IsMotherPropertyOwned ", SqlDbType.Char, 1) { Value = IsMotherPropertyOwned };
                prm[61] = new SqlParameter("@MotherPropertyDetail", SqlDbType.VarChar, 500) { Value = MotherPropertyDetail };
                prm[62] = new SqlParameter("@MotherIncomefromProperty ", SqlDbType.Int, 99) { Value = MotherIncomefromProperty };
                prm[63] = new SqlParameter("@IsMotherAgricultureProperty", SqlDbType.Char, 1) { Value = IsMotherAgricultureProperty };
                prm[64] = new SqlParameter("@MotherAgriPropertyDetail ", SqlDbType.VarChar, 500) { Value = MotherAgriPropertyDetail };
                prm[65] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                //
                //

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertobccastetemp", prm);
                objReturn.ErrMessage = prm[35].Value.ToString();
                objReturn.ReturnCode = prm[36].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }

        public DBReturn InsertTempOBCCasteNEW()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[50];

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

                prm[15] = new SqlParameter("@ResidencePeriod", SqlDbType.Int) { Value = ResidencyPeriod };
                prm[16] = new SqlParameter("@ApplicantReligon", SqlDbType.Int) { Value = ApplicantReligon };
                prm[17] = new SqlParameter("@RelationWithApplicant", SqlDbType.Int) { Value = RelationWithApplicant };
                prm[18] = new SqlParameter("@OldCertificateNo", SqlDbType.VarChar, 50) { Value = OldCertificateNo };
                prm[19] = new SqlParameter("@OldCertificateDate", SqlDbType.DateTime) { Value = OldCertificateDate };
                prm[20] = new SqlParameter("@OldRelationship", SqlDbType.Int) { Value = OldRelationship };
                prm[21] = new SqlParameter("@OldCertificateIssueAuthority", SqlDbType.VarChar, 150) { Value = OldCertificateIssueAuthority };
                prm[22] = new SqlParameter("@OldCertificateIssuePinCode", SqlDbType.Int) { Value = OldCertificateIssuePinCode };
                prm[23] = new SqlParameter("@OldCertificateAddress", SqlDbType.VarChar, 300) { Value = OldCertificateAddress };
                prm[24] = new SqlParameter("@OldCertificateTahsil", SqlDbType.VarChar, 50) { Value = OldCertificateTahsil };
                prm[25] = new SqlParameter("@OldCertificateDistrict", SqlDbType.VarChar, 50) { Value = OldCertificateDistrict };
                prm[26] = new SqlParameter("@OldCertificateState", SqlDbType.VarChar, 50) { Value = OldCertificateState };


                prm[27] = new SqlParameter("@Proofbefore1966", SqlDbType.VarChar, 100) { Value = Proofbefore1966 };
                prm[28] = new SqlParameter("@NameofOfficer1", SqlDbType.VarChar, 99) { Value = NameofOfficer1 };
                prm[29] = new SqlParameter("@DesigOfficer1", SqlDbType.VarChar, 150) { Value = DesigOfficer1 };
                prm[30] = new SqlParameter("@DeptOfficer1", SqlDbType.VarChar, 200) { Value = DeptOfficer1 };
                prm[31] = new SqlParameter("@NameofOfficer2", SqlDbType.VarChar, 99) { Value = NameofOfficer2 };
                prm[32] = new SqlParameter("@DesigOfficer2", SqlDbType.VarChar, 150) { Value = DesigOfficer2 };
                prm[33] = new SqlParameter("@DeptOfficer2", SqlDbType.VarChar, 200) { Value = DeptOfficer2 };


                prm[34] = new SqlParameter("@Caste", SqlDbType.VarChar, 50) { Value = ApplicantCaste };



                prm[35] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[35].Direction = ParameterDirection.Output;
                prm[36] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[36].Direction = ParameterDirection.Output;
                prm[37] = new SqlParameter("@AppliedBy", SqlDbType.VarChar, 99) { Value = AppliedBy };
                prm[38] = new SqlParameter("@AppliedbyFather", SqlDbType.VarChar, 99) { Value = AppliedByFatherName };
                prm[39] = new SqlParameter("@OldCertApplicantname", SqlDbType.VarChar, 99) { Value = OldCertApplicantname };
                prm[40] = new SqlParameter("@OldcertFatherName", SqlDbType.VarChar, 99) { Value = OldcertFatherName };
                prm[41] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[42] = new SqlParameter("@ApplicantMothername", SqlDbType.VarChar, 99) { Value = ApplicantMothername };
                prm[43] = new SqlParameter("@ISCreamyLayer", SqlDbType.VarChar, 1) { Value = ISCreamyLayer };
                prm[44] = new SqlParameter("@Gazettedofficer", SqlDbType.VarChar, 1) { Value = AnyGazettedOfficerinFamily };
                prm[45] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = dtFamilyDetails };


                



                
                prm[46] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[47] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[48] = new SqlParameter("@FamilyIncome", SqlDbType.Int) { Value = FamilyIncome };
                prm[49] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//
                //
                //

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertobccastetempNew", prm);
                objReturn.ErrMessage = prm[35].Value.ToString();
                objReturn.ReturnCode = prm[36].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }



        public DBReturn UpdateTempOBCCasteNEW(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[52];

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

                prm[15] = new SqlParameter("@ResidencePeriod", SqlDbType.Int) { Value = ResidencyPeriod };
                prm[16] = new SqlParameter("@ApplicantReligon", SqlDbType.Int) { Value = ApplicantReligon };
                prm[17] = new SqlParameter("@RelationWithApplicant", SqlDbType.Int) { Value = RelationWithApplicant };
                prm[18] = new SqlParameter("@OldCertificateNo", SqlDbType.VarChar, 50) { Value = OldCertificateNo };
                prm[19] = new SqlParameter("@OldCertificateDate", SqlDbType.DateTime) { Value = OldCertificateDate };
                prm[20] = new SqlParameter("@OldRelationship", SqlDbType.Int) { Value = OldRelationship };
                prm[21] = new SqlParameter("@OldCertificateIssueAuthority", SqlDbType.VarChar, 150) { Value = OldCertificateIssueAuthority };
                prm[22] = new SqlParameter("@OldCertificateIssuePinCode", SqlDbType.Int) { Value = OldCertificateIssuePinCode };
                prm[23] = new SqlParameter("@OldCertificateAddress", SqlDbType.VarChar, 300) { Value = OldCertificateAddress };
                prm[24] = new SqlParameter("@OldCertificateTahsil", SqlDbType.VarChar, 50) { Value = OldCertificateTahsil };
                prm[25] = new SqlParameter("@OldCertificateDistrict", SqlDbType.VarChar, 50) { Value = OldCertificateDistrict };
                prm[26] = new SqlParameter("@OldCertificateState", SqlDbType.VarChar, 50) { Value = OldCertificateState };


                prm[27] = new SqlParameter("@Proofbefore1966", SqlDbType.VarChar, 100) { Value = Proofbefore1966 };
                prm[28] = new SqlParameter("@NameofOfficer1", SqlDbType.VarChar, 99) { Value = NameofOfficer1 };
                prm[29] = new SqlParameter("@DesigOfficer1", SqlDbType.VarChar, 150) { Value = DesigOfficer1 };
                prm[30] = new SqlParameter("@DeptOfficer1", SqlDbType.VarChar, 200) { Value = DeptOfficer1 };
                prm[31] = new SqlParameter("@NameofOfficer2", SqlDbType.VarChar, 99) { Value = NameofOfficer2 };
                prm[32] = new SqlParameter("@DesigOfficer2", SqlDbType.VarChar, 150) { Value = DesigOfficer2 };
                prm[33] = new SqlParameter("@DeptOfficer2", SqlDbType.VarChar, 200) { Value = DeptOfficer2 };


                prm[34] = new SqlParameter("@Caste", SqlDbType.VarChar, 50) { Value = ApplicantCaste };



                prm[35] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[35].Direction = ParameterDirection.Output;
                prm[36] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[36].Direction = ParameterDirection.Output;
                prm[37] = new SqlParameter("@AppliedBy", SqlDbType.VarChar, 99) { Value = AppliedBy };
                prm[38] = new SqlParameter("@AppliedbyFather", SqlDbType.VarChar, 99) { Value = AppliedByFatherName };
                prm[39] = new SqlParameter("@OldCertApplicantname", SqlDbType.VarChar, 99) { Value = OldCertApplicantname };
                prm[40] = new SqlParameter("@OldcertFatherName", SqlDbType.VarChar, 99) { Value = OldcertFatherName };
                prm[41] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[42] = new SqlParameter("@ApplicantMothername", SqlDbType.VarChar, 99) { Value = ApplicantMothername };
                prm[43] = new SqlParameter("@ISCreamyLayer", SqlDbType.VarChar, 1) { Value = ISCreamyLayer };
                prm[44] = new SqlParameter("@Gazettedofficer", SqlDbType.VarChar, 1) { Value = AnyGazettedOfficerinFamily };
                prm[45] = new SqlParameter("@FamilyDetail", SqlDbType.Structured) { Value = dtFamilyDetails };







                prm[46] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[47] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
                prm[48] = new SqlParameter("@FamilyIncome", SqlDbType.Int) { Value = FamilyIncome };
                prm[49] = new SqlParameter("@TempAppNo", SqlDbType.VarChar,30) { Value = TempApplicationNo };
                prm[50] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar,1) { Value = ImageUpdated };
                prm[51] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };//
                //
                //

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateobccastetempNew", prm);
                objReturn.ErrMessage = prm[35].Value.ToString();
                objReturn.ReturnCode = prm[36].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
    }
}
