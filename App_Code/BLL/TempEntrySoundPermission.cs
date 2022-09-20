using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace EDistrictBL
{
   public class TempEntrySoundPermission : TempEntryGeneral
    {
        //public TempEntrySoundPermisson();

       public string ServiceCode { get; set; }
       public string SubService { get; set; }
       public string ApplicantName { get; set; }
       public string ApplicantAadharNo { get; set; }
       public string ApplicantPremises { get; set; }
       public string LocalityId { get; set; }
       public string Locality { get; set; }
       public string ApplicantMobileNo { get; set; }
       public string ApplicantEmail { get; set; }
       public string ApplicantPinCode { get; set; }
        public string UserType { get; set; }
        public string ApplicationEnteredBy { get; set; }
        public string ApplicationTimeStamp { get; set; }
        public string Remarks { get; set; }
        public string oprcode { get; set; }
     
       public string Occasion { get; set; }      
       public string locality { get; set; }
       public string RoadSide { get; set; }
       public string StartingPoint { get; set; }
       public string EndingPoint { get; set; }
       public string NoOfDays { get; set; }
      
       public string ExpactedGathering { get; set; }
       public string ApproxArea { get; set; }
       public string SoundInstrumentLocation { get; set; }
       public string TypeofInstrument { get; set; }
       public string NoofInstrument { get; set; }
       public string SoundPitch { get; set; }
       public string SoundLevel { get; set; }
       public string TimeSlot { get; set; }
       public string CourtDetailNoofDays { get; set; }
       public string CourtFeeTotalAmount { get; set; }
       public string EventType { get; set; }
       public string EventDetail { get; set; }
       public string EventAuthorityCode { get; set; }
       public string EventRemarks { get; set; }
       public string EventVenueLocality { get; set; }
       public string EventVenueLocalityId { get; set; }
       public string EventVenueFullAddress { get; set; }
       public string ApplicationDate { get; set; }
       public string username { get; set; }
       public byte[] ApplicantImage { get; set; }
       public long UniqueId { get; set; }
       public string Route { get; set; }
       public string LocalityCode { get; set; }
       public string Roadside { get; set; }
       public DateTime DateFrom { get; set; }
       public string TimeFrom { get; set; }
       public string TimeTo { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
       public string VenuePremises { get; set; }

       public DataTable SoundRoutedt { get; set; }

       public DBReturn InsertSoundTemp()
       {
           DBReturn objReturn = new DBReturn();
           try
           {
               SqlParameter[] prm = new SqlParameter[45];

               prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value =  ServiceCode };
               prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
               prm[2] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 15) { Value = ApplicantAadharNo };
               prm[3] = new SqlParameter("@Premises", SqlDbType.VarChar) { Value = ApplicantPremises };
               prm[4] = new SqlParameter("@LocalityId", SqlDbType.VarChar) { Value = LocalityId };
               prm[5] = new SqlParameter("@Locality", SqlDbType.VarChar, 60) { Value = Locality };
               prm[6] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar) { Value =  ApplicantPinCode };
               prm[7] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
               prm[8] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar) { Value = ApplicantMobileNo };
               prm[9] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[10] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
               prm[11] = new SqlParameter("@Occassion", SqlDbType.VarChar, 1000) { Value = Occasion };
               prm[12] = new SqlParameter("@NoofDaysforOccasion", SqlDbType.VarChar, 15) { Value = NoOfDays };
               prm[13] = new SqlParameter("@VanueLocality", SqlDbType.VarChar) { Value = EventVenueLocality };
               prm[14] = new SqlParameter("@ApproxArea", SqlDbType.VarChar, 100) { Value = ApproxArea };              
               prm[15] = new SqlParameter("@NoofInstrument", SqlDbType.VarChar) { Value = NoofInstrument };
               prm[16] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 99) { Value = SoundPitch };
               prm[17] = new SqlParameter("@SoundLevel", SqlDbType.VarChar, 99) { Value = SoundLevel };           
               prm[18] = new SqlParameter("@SoundInstrumentLocation", SqlDbType.VarChar, 1000) { Value = SoundInstrumentLocation };
               prm[19] = new SqlParameter("@TimeSlotBetween10to6", SqlDbType.VarChar, 15) { Value = TimeSlot };
               prm[20] = new SqlParameter("@CourtDetailNoofDays", SqlDbType.VarChar, 8) { Value = CourtDetailNoofDays };
               prm[21] = new SqlParameter("@CourtFeeTotalAmount", SqlDbType.VarChar, 50) { Value = CourtFeeTotalAmount };
               prm[22] = new SqlParameter("@ExpactedGathering", SqlDbType.VarChar, 50) { Value = ExpactedGathering };
               //prm[22] = new SqlParameter("@DatesDetail", SqlDbType.Structured) { Value = Sounddt };
               prm[23] = new SqlParameter("@RouteDetails", SqlDbType.VarChar) { Value = Route };
               prm[24] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[25] = new SqlParameter("@UserType", SqlDbType.VarChar, 15) { Value = UserType };
               prm[26] = new SqlParameter("@username", SqlDbType.VarChar, 15) { Value = username };
               prm[27] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 50) { Value = TypeofInstrument };
               prm[28] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
               prm[29] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
               prm[30] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
               prm[31] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
               prm[32] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
               prm[32].Direction = ParameterDirection.Output;
               prm[33] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
               prm[33].Direction = ParameterDirection.Output;
               prm[34] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
               prm[35] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
               prm[36] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
               prm[37] = new SqlParameter("@VanueFullAddress", SqlDbType.VarChar) { Value = EventVenueFullAddress };
               prm[38] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
               prm[39] = new SqlParameter("@fromtime", SqlDbType.VarChar, 50) { Value = TimeFrom };
               prm[40] = new SqlParameter("@totime", SqlDbType.VarChar, 50) { Value = TimeTo };
               prm[41] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate };
               prm[42] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate };
               prm[43] = new SqlParameter("@VenuePremises", SqlDbType.VarChar) { Value = VenuePremises };
               prm[44] = new SqlParameter("@VanueLocalityId", SqlDbType.VarChar) { Value = EventVenueLocalityId };
               SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraSoundDetail", prm);
               objReturn.ErrMessage = prm[32].Value.ToString();
               objReturn.ReturnCode = prm[33].Value.ToString();
               return objReturn;



           }
           catch (Exception Ex)
           {
               // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
               return objReturn;
           }

       }
	public DataTable GetSHOReport()
       {
           SqlParameter[] prm = new SqlParameter[2];
           prm[0] = new SqlParameter("@startdate", SqlDbType.DateTime) { Value = StartDate };
           prm[1] = new SqlParameter("@officecode", SqlDbType.VarChar) { Value = EntryOfficeCode };
           DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SHOReportSound", prm);
           DataTable dt = new DataTable();
           if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
           {
               dt = ds.Tables[0];
           }
           return dt;
       }
       public DataTable GetCertificateDocfromAppNO()
       {
           DataTable dt = new DataTable();
           SqlParameter[] prm = new SqlParameter[1];
           prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
           DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetCertificateDocfromAppNO", prm);
           if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
           {
               dt = ds.Tables[0];
           }
           return dt;
       }

       public DBReturn UpdateTempTraSoundDetail(string ImageUpdated)
       {
           DBReturn objReturn = new DBReturn();
           try
           {

               SqlParameter[] prm = new SqlParameter[48];
               prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
               prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
               prm[2] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 15) { Value = ApplicantAadharNo };
               prm[3] = new SqlParameter("@Premises", SqlDbType.VarChar) { Value = ApplicantPremises };
               prm[4] = new SqlParameter("@LocalityId", SqlDbType.VarChar) { Value = LocalityId };
               prm[5] = new SqlParameter("@Locality", SqlDbType.VarChar, 60) { Value = Locality };
               prm[6] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar) { Value = ApplicantPinCode };
               prm[7] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
               prm[8] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar) { Value = ApplicantMobileNo };
               prm[9] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[10] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
               prm[11] = new SqlParameter("@Occassion", SqlDbType.VarChar, 1000) { Value = Occasion };
               prm[12] = new SqlParameter("@NoofDaysforOccasion", SqlDbType.VarChar, 15) { Value = NoOfDays };
               prm[13] = new SqlParameter("@VanueLocality", SqlDbType.VarChar) { Value = EventVenueLocality };
               prm[14] = new SqlParameter("@ApproxArea", SqlDbType.VarChar, 100) { Value = ApproxArea };
               prm[15] = new SqlParameter("@NoofInstrument", SqlDbType.VarChar, 10) { Value = NoofInstrument };
               prm[16] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 99) { Value = SoundPitch };
               prm[17] = new SqlParameter("@SoundLevel", SqlDbType.VarChar, 99) { Value = SoundLevel };
               prm[18] = new SqlParameter("@SoundInstrumentLocation", SqlDbType.VarChar, 1000) { Value = SoundInstrumentLocation };
               prm[19] = new SqlParameter("@TimeSlotBetween10to6", SqlDbType.VarChar, 15) { Value = TimeSlot };
               prm[20] = new SqlParameter("@CourtDetailNoofDays", SqlDbType.VarChar, 8) { Value = CourtDetailNoofDays };
               prm[21] = new SqlParameter("@CourtFeeTotalAmount", SqlDbType.VarChar, 50) { Value = CourtFeeTotalAmount };
               prm[22] = new SqlParameter("@ExpactedGathering", SqlDbType.VarChar, 50) { Value = ExpactedGathering };
               prm[23] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[24] = new SqlParameter("@UserType", SqlDbType.VarChar, 15) { Value = UserType };
               prm[26] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 50) { Value = TypeofInstrument };
               prm[27] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
               prm[28] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
               prm[29] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
               prm[30] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
               prm[31] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
               prm[32] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
               prm[33] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
               prm[34] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
               prm[34].Direction = ParameterDirection.Output;
               prm[35] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
               prm[35].Direction = ParameterDirection.Output;
               prm[36] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

               prm[37] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
               prm[38] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
               prm[39] = new SqlParameter("@VanueFullAddress", SqlDbType.VarChar) { Value = EventVenueFullAddress };
               prm[40] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
               prm[41] = new SqlParameter("@fromtime", SqlDbType.VarChar, 50) { Value = TimeFrom };
               prm[42] = new SqlParameter("@totime", SqlDbType.VarChar, 50) { Value = TimeTo };
               prm[43] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate };
               prm[44] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate };
               prm[45] = new SqlParameter("@RouteDetails", SqlDbType.VarChar) { Value = Route };
               prm[46] = new SqlParameter("@VenuePremises", SqlDbType.VarChar) { Value = VenuePremises };
               prm[47] = new SqlParameter("@VanueLocalityId", SqlDbType.VarChar) { Value = EventVenueLocalityId };
               SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraSoundDetail", prm);
               objReturn.ErrMessage = prm[34].Value.ToString();
               objReturn.ReturnCode = prm[35].Value.ToString();
               return objReturn;
           }
           catch (Exception Ex)
           {
               MyExceptionHandler.HandleException(Ex);
               return objReturn;
           }
       }

       public DBReturn UpdateSoundMain(string ImageUpdated)
       {
           DBReturn objReturn = new DBReturn();
           try
           {

               SqlParameter[] prm = new SqlParameter[42];
               prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
               prm[1] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
               prm[2] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 15) { Value = ApplicantAadharNo };
               prm[3] = new SqlParameter("@Premises", SqlDbType.VarChar) { Value = ApplicantPremises };
               prm[4] = new SqlParameter("@LocalityId", SqlDbType.VarChar) { Value = LocalityId };
               prm[5] = new SqlParameter("@Locality", SqlDbType.VarChar, 60) { Value = Locality };
               prm[6] = new SqlParameter("@ApplicantPinCode", SqlDbType.VarChar) { Value = ApplicantPinCode };
               prm[7] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
               prm[8] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar) { Value = ApplicantMobileNo };
               prm[9] = new SqlParameter("@ApplicationEnteredBy", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[10] = new SqlParameter("@ApplicationTimeStamp", SqlDbType.DateTime) { Value = ApplicationTimeStamp };
               //prm[11] = new SqlParameter("@Occassion", SqlDbType.VarChar, 1000) { Value = Occasion };
               //prm[12] = new SqlParameter("@NoofDaysforOccasion", SqlDbType.VarChar, 15) { Value = NoOfDays };
               //prm[13] = new SqlParameter("@VanueLocality", SqlDbType.VarChar) { Value = EventVenueLocality };
               //
               prm[11] = new SqlParameter("@NoofInstrument", SqlDbType.VarChar, 10) { Value = NoofInstrument };
               prm[12] = new SqlParameter("@SoundPitch", SqlDbType.VarChar, 99) { Value = SoundPitch };
               prm[13] = new SqlParameter("@SoundLevel", SqlDbType.VarChar, 99) { Value = SoundLevel };
               prm[14] = new SqlParameter("@SoundInstrumentLocation", SqlDbType.VarChar, 1000) { Value = SoundInstrumentLocation };
               prm[15] = new SqlParameter("@TimeSlotBetween10to6", SqlDbType.VarChar, 15) { Value = TimeSlot };
               //prm[20] = new SqlParameter("@CourtDetailNoofDays", SqlDbType.VarChar, 8) { Value = CourtDetailNoofDays };
               //prm[21] = new SqlParameter("@CourtFeeTotalAmount", SqlDbType.VarChar, 50) { Value = CourtFeeTotalAmount };
               prm[16] = new SqlParameter("@ExpactedGathering", SqlDbType.VarChar, 50) { Value = ExpactedGathering };
               prm[17] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = oprcode };
               prm[18] = new SqlParameter("@UserType", SqlDbType.VarChar, 15) { Value = UserType };
               prm[19] = new SqlParameter("@InstrumentType", SqlDbType.VarChar, 50) { Value = TypeofInstrument };
               prm[20] = new SqlParameter("@ApplicantGender", SqlDbType.VarChar, 1) { Value = ApplicantGender };
               prm[21] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
               prm[22] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
               prm[23] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
             //  prm[24] = new SqlParameter("@TempSubServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
               prm[24] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
               prm[25] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
               prm[26] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
               prm[26].Direction = ParameterDirection.Output;
               prm[27] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
               prm[27].Direction = ParameterDirection.Output;
              // prm[28] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };

               prm[28] = new SqlParameter("@Tehsil", SqlDbType.VarChar, 50) { Value = Tehsil };
               prm[29] = new SqlParameter("@District", SqlDbType.VarChar, 50) { Value = District };
               //prm[39] = new SqlParameter("@VanueFullAddress", SqlDbType.VarChar) { Value = EventVenueFullAddress };
               prm[30] = new SqlParameter("@State", SqlDbType.VarChar, 50) { Value = State };
               prm[31] = new SqlParameter("@ApproxArea", SqlDbType.VarChar, 100) { Value = ApproxArea };
               prm[32] = new SqlParameter("@Remarks", SqlDbType.VarChar, 1000) { Value = Remarks };
               prm[33] = new SqlParameter("@Occassion", SqlDbType.VarChar, 1000) { Value = Occasion };

               prm[34] = new SqlParameter("@VanueFullAddress", SqlDbType.VarChar) { Value = EventVenueFullAddress };
               prm[35] = new SqlParameter("@fromtime", SqlDbType.VarChar, 50) { Value = TimeFrom };
               prm[36] = new SqlParameter("@totime", SqlDbType.VarChar, 50) { Value = TimeTo };
               prm[37] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate };
               prm[38] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate };
               prm[39] = new SqlParameter("@route", SqlDbType.VarChar) { Value = Route };
               prm[40] = new SqlParameter("@CourtFeeTotalAmount", SqlDbType.VarChar, 50) { Value = CourtFeeTotalAmount };
               prm[41] = new SqlParameter("@CourtDetailNoofDays", SqlDbType.VarChar, 15) { Value = NoOfDays };
               //prm[46] = new SqlParameter("@VenuePremises", SqlDbType.VarChar) { Value = VenuePremises };
               //prm[47] = new SqlParameter("@VanueLocalityId", SqlDbType.VarChar) { Value = EventVenueLocalityId };
               SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateSoundMain", prm);
               objReturn.ErrMessage = prm[26].Value.ToString();
               objReturn.ReturnCode = prm[27].Value.ToString();
               return objReturn;
           }
           catch (Exception Ex)
           {
               MyExceptionHandler.HandleException(Ex);
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

       public DBReturn UpdateDate_SUP()
       {
           DBReturn objReturn = new DBReturn();
           try
           {
               SqlParameter[] prm = new SqlParameter[7];
               prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
               prm[0].Direction = ParameterDirection.Output;
               prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
               prm[1].Direction = ParameterDirection.Output;
               prm[2] = new SqlParameter("@startdate", SqlDbType.DateTime) { Value = StartDate };
               prm[3] = new SqlParameter("@enddate", SqlDbType.DateTime) { Value = EndDate };
               prm[4] = new SqlParameter("@fromtime", SqlDbType.Time, 7) { Value = TimeFrom };
               prm[5] = new SqlParameter("@totime", SqlDbType.Time,7) { Value = TimeTo };
               prm[6] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = tempApplicationNo };

               SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateSoundSUP_DateTime", prm);
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
