using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace EDistrictBL
{
    public class tmpEventPermission : TempEntryGeneral
    {
        public string ServiceCode { get; set; }
        public string SubService { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantAadharNo { get; set; }
        public string ApplicantPremises { get; set; }
        public string ApplicantLocalityId { get; set; }
        public string ApplicantLocality { get; set; }
        public string ApplicantMobileNo { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPinCode { get; set; }
        public string UserType { get; set; }
        public string ApplicationEnteredBy { get; set; }
        public string ApplicationTimeStamp { get; set; }
        public string Remarks { get; set; }
        public string oprcode { get; set; }

        public string TempAplicationNo { get; set; }
        public string AppliedByName { get; set; }
        public string AppliedByFatherName { get; set; }
        public string AppliedByRelationwithApplicant { get; set; }
        public string AppliedByPremise { get; set; }
        public string AppliedByLocality { get; set; }
        public string AppliedByLocalityid { get; set; }
        public int AppliedByPinCode { get; set; }
        public string AppliedByMobile { get; set; }
        public string AppliedByEmail { get; set; }
        public string Organizer_1_Name { get; set; }
        public string Organizer_1_Mobile { get; set; }

        public string Organizer_2_Name { get; set; }
        public string Organizer_2_Mobile { get; set; }

        public string Organizer_3_Name { get; set; }
        public string Organizer_3_Mobile { get; set; }

        public string Organization_Name { get; set; }
        public string Organization_Address { get; set; }

        public string EventType { get; set; }
        public string EventDetails { get; set; }
        public string EventAuthorityCode { get; set; }
        public string GatheringSize { get; set; }
        public string EventRemarks { get; set; }
        public string EventVenue { get; set; }
        public string EventCode { get; set; }
        public int NoofInstruments { get; set; }
        public string SoundPitch { get; set; }
        public string EventNoofdays { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string CourtNoofDays { get; set; }
        public int  CourtFees { get; set; }
        public string TentArea { get; set; }
        public string InstrumentType { get; set; }
        public byte[] ApplicantImage { get; set; }

        public DataTable EventDetaildt { get; set; }
        public long UniqueId { get; set; }
        public string Locality { get; set; }
        public string LocalityCode { get; set; }
        public string Roadside { get; set; }
        public DateTime DateFrom { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }

        public DBReturn InsertEventTemp()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[53];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[3] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[5] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[6] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[7] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };

                prm[10] = new SqlParameter("@AppliedByName", SqlDbType.VarChar, 99) { Value = AppliedByName };
                prm[11] = new SqlParameter("@AppliedByFatherName", SqlDbType.VarChar, 99) { Value = AppliedByFatherName };
                prm[12] = new SqlParameter("@AppliedByRelationwithApplicant", SqlDbType.VarChar) { Value = AppliedByRelationwithApplicant };
                prm[13] = new SqlParameter("@AppliedByPremise", SqlDbType.VarChar, 100) { Value = AppliedByPremise };
                prm[14] = new SqlParameter("@AppliedByLocality", SqlDbType.VarChar) { Value = AppliedByLocality };
                prm[15] = new SqlParameter("@AppliedByLocalityId", SqlDbType.VarChar) { Value = AppliedByLocalityid };
                prm[16] = new SqlParameter("@AppliedByPinCode", SqlDbType.Int) { Value = AppliedByPinCode };
                prm[17] = new SqlParameter("@AppliedByMobile", SqlDbType.VarChar, 10) { Value = AppliedByMobile };
                prm[18] = new SqlParameter("@AppliedByEmail", SqlDbType.VarChar, 50) { Value = AppliedByEmail };

                prm[19] = new SqlParameter("@Organizer_1_Name", SqlDbType.VarChar, 99) { Value = Organizer_1_Name };
                prm[20] = new SqlParameter("@Organizer_1_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_1_Mobile };
                prm[21] = new SqlParameter("@Organizer_2_Name", SqlDbType.VarChar, 99) { Value = Organizer_2_Name };
                prm[22] = new SqlParameter("@Organizer_2_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_2_Mobile };
                prm[23] = new SqlParameter("@Organizer_3_Name", SqlDbType.VarChar, 99) { Value = Organizer_3_Name };
                prm[24] = new SqlParameter("@Organizer_3_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_3_Mobile };
                prm[25] = new SqlParameter("@Organization_Name", SqlDbType.VarChar, 99) { Value = Organization_Name };
                prm[26] = new SqlParameter("@Organization_Address", SqlDbType.VarChar, 200) { Value = Organization_Address };


                prm[27] = new SqlParameter("@EventType", SqlDbType.VarChar, 20) { Value = EventType };
                prm[28] = new SqlParameter("@RouteDetails", SqlDbType.Structured) { Value = EventDetaildt };
                prm[29] = new SqlParameter("@EventDetails", SqlDbType.VarChar, 99) { Value = EventDetails };
                prm[30] = new SqlParameter("@EventAuthorityCode", SqlDbType.VarChar) { Value = EventAuthorityCode };
                prm[31] = new SqlParameter("@GatheringSize", SqlDbType.VarChar, 50) { Value = GatheringSize };

                prm[32] = new SqlParameter("@EventRemarks", SqlDbType.VarChar, 200) { Value = EventRemarks };
                prm[33] = new SqlParameter("@EventVenue", SqlDbType.VarChar, 99) { Value = EventVenue };
                prm[34] = new SqlParameter("@EventCode", SqlDbType.VarChar) { Value = EventCode };
                prm[35] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 50) { Value = SoundPitch };
                prm[36] = new SqlParameter("@EventNoofdays", SqlDbType.Int) { Value = EventNoofdays };
                prm[37] = new SqlParameter("@EventStartDate", SqlDbType.DateTime) { Value = EventStartDate };
                prm[38] = new SqlParameter("@EventEndDate", SqlDbType.DateTime) { Value = EventEndDate };
                prm[39] = new SqlParameter("@CourtNoofDays", SqlDbType.VarChar, 10) { Value = CourtNoofDays };

                prm[40] = new SqlParameter("@CourtFees", SqlDbType.Int) { Value = CourtFees };
                prm[41] = new SqlParameter("@TentArea", SqlDbType.VarChar, 20) { Value = TentArea };
                prm[42] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 100) { Value = InstrumentType };
                //prm[10] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
                prm[43] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[44] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[45] = new SqlParameter("@NoofInstruments", SqlDbType.Int) { Value = NoofInstruments };
                prm[46] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[47] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[48] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[49] = new SqlParameter("@ApplicantGender", SqlDbType.Char,1) { Value = ApplicantGender };
                prm[50] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[50].Direction = ParameterDirection.Output;
                prm[51] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[51].Direction = ParameterDirection.Output;
                prm[52] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraEventDetail", prm);
                objReturn.ErrMessage = prm[50].Value.ToString();
                objReturn.ReturnCode = prm[51].Value.ToString();
                return objReturn;



            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }
        public DBReturn UpdateEventTemp(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[54];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[2] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[3] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[4] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[5] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[6] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[7] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };

                prm[10] = new SqlParameter("@AppliedByName", SqlDbType.VarChar, 99) { Value = AppliedByName };
                prm[11] = new SqlParameter("@AppliedByFatherName", SqlDbType.VarChar, 99) { Value = AppliedByFatherName };
                prm[12] = new SqlParameter("@AppliedByRelationwithApplicant", SqlDbType.VarChar) { Value = AppliedByRelationwithApplicant };
                prm[13] = new SqlParameter("@AppliedByPremise", SqlDbType.VarChar, 100) { Value = AppliedByPremise };
                prm[14] = new SqlParameter("@AppliedByLocality", SqlDbType.VarChar) { Value = AppliedByLocality };
                prm[15] = new SqlParameter("@AppliedByLocalityId", SqlDbType.VarChar) { Value = AppliedByLocalityid };
                prm[16] = new SqlParameter("@AppliedByPinCode", SqlDbType.Int) { Value = AppliedByPinCode };
                prm[17] = new SqlParameter("@AppliedByMobile", SqlDbType.VarChar, 10) { Value = AppliedByMobile };
                prm[18] = new SqlParameter("@AppliedByEmail", SqlDbType.VarChar, 50) { Value = AppliedByEmail };

                prm[19] = new SqlParameter("@Organizer_1_Name", SqlDbType.VarChar, 99) { Value = Organizer_1_Name };
                prm[20] = new SqlParameter("@Organizer_1_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_1_Mobile };
                prm[21] = new SqlParameter("@Organizer_2_Name", SqlDbType.VarChar, 99) { Value = Organizer_2_Name };
                prm[22] = new SqlParameter("@Organizer_2_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_2_Mobile };
                prm[23] = new SqlParameter("@Organizer_3_Name", SqlDbType.VarChar, 99) { Value = Organizer_3_Name };
                prm[24] = new SqlParameter("@Organizer_3_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_3_Mobile };
                prm[25] = new SqlParameter("@Organization_Name", SqlDbType.VarChar, 99) { Value = Organization_Name };
                prm[26] = new SqlParameter("@Organization_Address", SqlDbType.VarChar, 200) { Value = Organization_Address };
                //prm[27] = new SqlParameter("@RouteDetails", SqlDbType.Structured) { Value = EventDetaildt };

                prm[27] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[28] = new SqlParameter("@EventType", SqlDbType.VarChar, 20) { Value = EventType };
                prm[29] = new SqlParameter("@EventDetails", SqlDbType.VarChar, 99) { Value = EventDetails };
                prm[30] = new SqlParameter("@EventAuthorityCode", SqlDbType.VarChar) { Value = EventAuthorityCode };
                prm[31] = new SqlParameter("@GatheringSize", SqlDbType.VarChar, 50) { Value = GatheringSize };

                prm[32] = new SqlParameter("@EventRemarks", SqlDbType.VarChar, 200) { Value = EventRemarks };
                prm[33] = new SqlParameter("@EventVenue", SqlDbType.VarChar, 99) { Value = EventVenue };
                prm[34] = new SqlParameter("@EventCode", SqlDbType.VarChar) { Value = EventCode };
                prm[35] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 50) { Value = SoundPitch };
                prm[36] = new SqlParameter("@EventNoofdays", SqlDbType.VarChar, 10) { Value = EventNoofdays };
                prm[37] = new SqlParameter("@EventStartDate", SqlDbType.DateTime) { Value = EventStartDate };
                prm[38] = new SqlParameter("@EventEndDate", SqlDbType.DateTime) { Value = EventEndDate };
                prm[39] = new SqlParameter("@CourtNoofDays", SqlDbType.VarChar, 10) { Value = CourtNoofDays };

                prm[40] = new SqlParameter("@CourtFees", SqlDbType.Int) { Value = CourtFees };
                prm[41] = new SqlParameter("@TentArea", SqlDbType.VarChar, 20) { Value = TentArea };
                prm[42] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 100) { Value = InstrumentType };
                prm[45] = new SqlParameter("@NoofInstruments", SqlDbType.Int) { Value = NoofInstruments };
                prm[46] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[47] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };

                prm[48] = new SqlParameter("@ApplicantGender", SqlDbType.Char,1) { Value = ApplicantGender };
                prm[49] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[49].Direction = ParameterDirection.Output;
                prm[50] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[50].Direction = ParameterDirection.Output;

                
                prm[51] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[52] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[53] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraEventDetail", prm);
                objReturn.ErrMessage = prm[49].Value.ToString();
                objReturn.ReturnCode = prm[50].Value.ToString();
                return objReturn;



            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        
        }

        public DataSet GetAllRouteDetail()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetRouteDetails", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DBReturn UpdateRouteDetail()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[11];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ID", SqlDbType.BigInt) { Value = UniqueId };
                prm[3] = new SqlParameter("@Servicecode", SqlDbType.VarChar, 30) { Value = ServiceCode };
                prm[4] = new SqlParameter("@Locality", SqlDbType.VarChar, 50) { Value = Locality };
                prm[5] = new SqlParameter("@LocalityCode", SqlDbType.VarChar) { Value = LocalityCode };
                prm[6] = new SqlParameter("@RoadSide", SqlDbType.VarChar, 50) { Value = Roadside };
                prm[7] = new SqlParameter("@DateFrom", SqlDbType.DateTime, 99) { Value = DateFrom };
                prm[8] = new SqlParameter("@TimeFrom", SqlDbType.Time, 7) { Value = TimeFrom };
                prm[9] = new SqlParameter("@TimeTo", SqlDbType.Time, 7) { Value = TimeTo };
                prm[10] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Update_RouteDetail", prm);
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
    }
}