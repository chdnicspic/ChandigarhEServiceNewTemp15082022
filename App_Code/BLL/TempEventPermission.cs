using EDistrictBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TempEventPermission
/// </summary>
namespace EDistrictBL
{
    public class TempEventPermission : TempEntryGeneral
    {
        public string CompanyRepresentative { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ApplicationNo { get; set; }
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
        public string EventVenueLocality { get; set; }
        public Int64 EventVenueLocalityID { get; set; }
        public string EventVenueAddress { get; set; }

        public string GatheringSize { get; set; }
        public string EventVenue { get; set; }

        public int NoofInstruments { get; set; }
        public string SoundPitch { get; set; }
        public int EventNoofdays { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string ApproxArea { get; set; }
        public string InstrumentType { get; set; }
        public byte[] ApplicantImage { get; set; }
        public string UserType { get; set; }
        public int EventMobility { get; set; }
        public DataTable EventDetaildt { get; set; }
        public string CurrentUserid { get; set; }
        public string Approved { get; set; }
        public string NoofVoluntere { get; set; }
        public string PurposeofEvent { get; set; }
        public string EventConditions { get; set; }

        public string IsApproved { get; set; }
        public string ActionPerformed { get; set; }

        public string IpAddress { get; set; }
        public byte[] UploadDocument { get; set; }
        public Int32 FromLevel { get; set; }
        public string pendingwith { get; set; }
        public Int64 TransactionDSCId { get; set; }
        public string UploadDocumentPath { get; set; }


        public DBReturn InsertEventTempTable()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[51];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[3] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[4] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[5] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[6] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[7] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };              
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[10] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[11] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[12] = new SqlParameter("@CompanyRepresentative", SqlDbType.Char, 1) { Value = CompanyRepresentative };
                prm[13] = new SqlParameter("@CompanyName", SqlDbType.VarChar, 99) { Value = CompanyName };
                prm[14] = new SqlParameter("@CompanyAddress", SqlDbType.VarChar, 250) { Value = CompanyAddress };
                prm[15] = new SqlParameter("@Organizer_1_Name", SqlDbType.VarChar, 99) { Value = Organizer_1_Name };
                prm[16] = new SqlParameter("@Organizer_1_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_1_Mobile };
                prm[17] = new SqlParameter("@Organizer_2_Name", SqlDbType.VarChar, 99) { Value = Organizer_2_Name };
                prm[18] = new SqlParameter("@Organizer_2_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_2_Mobile };
                prm[19] = new SqlParameter("@Organizer_3_Name", SqlDbType.VarChar, 99) { Value = Organizer_3_Name };
                prm[20] = new SqlParameter("@Organizer_3_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_3_Mobile };
                prm[21] = new SqlParameter("@Organization_Name", SqlDbType.VarChar, 99) { Value = Organization_Name };
                prm[22] = new SqlParameter("@Organization_Address", SqlDbType.VarChar, 200) { Value = Organization_Address };
                prm[23] = new SqlParameter("@EventType", SqlDbType.VarChar, 1000) { Value = EventType };
                prm[24] = new SqlParameter("@Gathering", SqlDbType.VarChar, 50) { Value = GatheringSize };
                prm[25] = new SqlParameter("@EventVenueLocality", SqlDbType.VarChar, 99) { Value = EventVenueLocality };
                prm[26] = new SqlParameter("@EventVenueLocalityID", SqlDbType.BigInt) { Value = EventVenueLocalityID };
                prm[27] = new SqlParameter("@EventVenueAddress", SqlDbType.VarChar, 250) { Value = EventVenueAddress };
                prm[28] = new SqlParameter("@ApproxArea", SqlDbType.VarChar, 20) { Value = ApproxArea };
                prm[29] = new SqlParameter("@EventStartDate", SqlDbType.DateTime) { Value = EventStartDate };
                prm[30] = new SqlParameter("@EventEndDate", SqlDbType.DateTime) { Value = EventEndDate };              
                prm[31] = new SqlParameter("@EventNoofdays", SqlDbType.Int) { Value = EventNoofdays };                
                prm[32] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 100) { Value = InstrumentType};
                prm[33] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[34] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[35] = new SqlParameter("@NoofInstruments", SqlDbType.Int) { Value = NoofInstruments };
                prm[36] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
                prm[37] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };             
                prm[38] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };                
                prm[39] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 50) { Value = SoundPitch };
                prm[40] = new SqlParameter("@EventRouteDetails", SqlDbType.Structured) { Value = EventDetaildt };
                prm[41] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[42] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[43] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[44] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 60) { Value = Tehsil };
                prm[45] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[46] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[47] = new SqlParameter("@NoofVoluntere", SqlDbType.VarChar, 50) { Value = NoofVoluntere };
                prm[48] = new SqlParameter("@EventMobility", SqlDbType.Int) { Value = EventMobility };
                prm[49] = new SqlParameter("@EntryOfficeCode", SqlDbType.VarChar, 50) { Value = EntryOfficeCode };
                prm[50] =new SqlParameter("@PurposeofEvent", SqlDbType.VarChar, 500) { Value = PurposeofEvent };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTempTraEventPermission", prm);
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
        public DataSet GetEventTimeDetail()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetEventRouteTimeDetail", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DBReturn UpdateEventTempTable(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[50];
                prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[0].Direction = ParameterDirection.Output;
                prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[3] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[4] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[5] = new SqlParameter("@ApplicantAadharNo", SqlDbType.BigInt) { Value = ApplicantAadharNo };
                prm[6] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[7] = new SqlParameter("@ApplicantLocalityId", SqlDbType.Int) { Value = ApplicantLocalityId };
                prm[8] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[9] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[10] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[11] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[12] = new SqlParameter("@CompanyRepresentative", SqlDbType.Char, 1) { Value = CompanyRepresentative };
                prm[13] = new SqlParameter("@CompanyName", SqlDbType.VarChar, 99) { Value = CompanyName };
                prm[14] = new SqlParameter("@CompanyAddress", SqlDbType.VarChar, 250) { Value = CompanyAddress };
                prm[15] = new SqlParameter("@Organizer_1_Name", SqlDbType.VarChar, 99) { Value = Organizer_1_Name };
                prm[16] = new SqlParameter("@Organizer_1_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_1_Mobile };
                prm[17] = new SqlParameter("@Organizer_2_Name", SqlDbType.VarChar, 99) { Value = Organizer_2_Name };
                prm[18] = new SqlParameter("@Organizer_2_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_2_Mobile };
                prm[19] = new SqlParameter("@Organizer_3_Name", SqlDbType.VarChar, 99) { Value = Organizer_3_Name };
                prm[20] = new SqlParameter("@Organizer_3_Mobile", SqlDbType.VarChar, 10) { Value = Organizer_3_Mobile };
                prm[21] = new SqlParameter("@Organization_Name", SqlDbType.VarChar, 99) { Value = Organization_Name };
                prm[22] = new SqlParameter("@Organization_Address", SqlDbType.VarChar, 200) { Value = Organization_Address };
                prm[23] = new SqlParameter("@EventType", SqlDbType.VarChar, 1000) { Value = EventType };
                prm[24] = new SqlParameter("@Gathering", SqlDbType.VarChar, 50) { Value = GatheringSize };
                prm[25] = new SqlParameter("@EventVenueLocality", SqlDbType.VarChar, 99) { Value = EventVenueLocality };
                prm[26] = new SqlParameter("@EventVenueLocalityID", SqlDbType.BigInt) { Value = EventVenueLocalityID };
                prm[27] = new SqlParameter("@EventVenueAddress", SqlDbType.VarChar, 250) { Value = EventVenueAddress };
                prm[28] = new SqlParameter("@ApproxArea", SqlDbType.VarChar, 20) { Value = ApproxArea };
                prm[29] = new SqlParameter("@EventStartDate", SqlDbType.DateTime) { Value = EventStartDate };
                prm[30] = new SqlParameter("@EventEndDate", SqlDbType.DateTime) { Value = EventEndDate };
                prm[31] = new SqlParameter("@EventNoofdays", SqlDbType.Int) { Value = EventNoofdays };
                prm[32] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 100) { Value = InstrumentType };             
                prm[33] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };
                prm[34] = new SqlParameter("@NoofInstruments", SqlDbType.Int) { Value = NoofInstruments };
                prm[35] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[36] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[37] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 50) { Value = SoundPitch };
                prm[38] = new SqlParameter("@EventRouteDetails", SqlDbType.Structured) { Value = EventDetaildt };
                prm[39] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[40] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };        
                prm[41] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 60) { Value = Tehsil };
                prm[42] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
                prm[43] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
                prm[44] = new SqlParameter("@EventMobility", SqlDbType.VarChar, 50) { Value = EventMobility };
                prm[45] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
                prm[46] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[47] = new SqlParameter("@EntryOfficeCode", SqlDbType.VarChar, 50) { Value = EntryOfficeCode };
                prm[48] = new SqlParameter("@NoofVoluntere", SqlDbType.VarChar, 50) { Value = NoofVoluntere };
                prm[49] = new SqlParameter("@PurposeofEvent", SqlDbType.VarChar, 500) { Value = PurposeofEvent };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraEventPermission", prm);
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
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsEvent", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }     
        public DataSet GetEventTimeDetailFromMain()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetEventRouteTimeDetailFromMain", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DataSet GenerateFinalEventCert()
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

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalEventCertificate", prm);
            return ds;

        }
        public DataSet GetEventConditions()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllEventsConditions");

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        public DBReturn InsertEventConditions()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@EventConditions", SqlDbType.VarChar, 4000) { Value =  EventConditions};     
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertEventConditions", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;

        }
        public DBReturn UpdateSuprintendentTime()
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
                prm[4] = new SqlParameter("@EventDetails", SqlDbType.Structured) { Value = EventDetaildt };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateEventTimeDetail", prm);
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
        public DataSet GetFullApplication()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            DataSet Ds = new DataSet();
            //prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };

            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetFullApplicationDetailEvent", prm);
            return Ds;
        }
        public DBReturn SaveFinalCertificateForEvent()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[12];
                prm[0] = new SqlParameter("@IsApproved", SqlDbType.VarChar, 1) { Value = IsApproved };
                prm[1] = new SqlParameter("@Remarks", SqlDbType.VarChar, 2000) { Value = Remarks };
                prm[2] = new SqlParameter("@ActionPerformed", SqlDbType.VarChar, 10) { Value = ActionPerformed };
                prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@IpAddress", SqlDbType.VarChar, 20) { Value = IpAddress };
                prm[7] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = UploadDocument };
                prm[8] = new SqlParameter("@FromLevel", SqlDbType.Int) { Value = FromLevel };
                prm[9] = new SqlParameter("@LoginUserId", SqlDbType.VarChar, 15) { Value = pendingwith };
                prm[10] = new SqlParameter("@DSCID", SqlDbType.BigInt) { Value = TransactionDSCId };
                prm[11] = new SqlParameter("@Certpath", SqlDbType.VarChar, 2000) { Value = UploadDocumentPath };
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalCertificateforEvent", prm);
                objReturn.ErrMessage = prm[4].Value.ToString();
                objReturn.ReturnCode = prm[5].Value.ToString();
                return objReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
            }
            return objReturn;


        }

        public DataSet isNoticeClosed()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            DataSet Ds = new DataSet();
            //prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };

            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "isAllNoticeClose", prm);
            return Ds;
        }
    }


}