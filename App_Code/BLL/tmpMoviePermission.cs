using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EDistrictBL
{
    public class tmpMoviePermission : TempEntryGeneral
    {
        public Int64 Id { get; set; }
        public string ServiceCode { get; set; }
        public string SelfServiceCode { get; set; }
        public string TempAplicationNo { get; set; }
        public string ApplicantAadharNo { get; set; }
        public string NameOfUnitProduction { get; set; }
        public string Add_UnitProduction { get; set; }
        public string TitleofFilm { get; set; }
        public string FilmType { get; set; }
        public string FilmSubject { get; set; }
        public string ArtistNames { get; set; }
        public string ProducerName { get; set; }
        public string DirectorName { get; set; }
        public string AddressofUnitinCHD { get; set; }
        public string IndoorShootingPermission { get; set; }
        public string SoundPermission { get; set; }
        public Int32 NoofPersonatShooting { get; set; }
        public string DetailofVehicleUsedinShooting { get; set; }
        public string SecurityfoArtists { get; set; }
        public string FirstAidArrangement { get; set; }
        public string EmergencyNoAvailiability { get; set; }
        public string LightingArragementforHouseAndP { get; set; }
        public string ContactNoofUnitInCHD { get; set; }
        public string UserType { get; set; }
        public byte[] ApplicantImage { get; set; }
        public string ApplicantDesigation { get; set; }
        public DataTable dtMovieDetail { get; set; }
        public long UniqueId { get; set; }
        public string Locality { get; set; }
        public string LocalityCode { get; set; }
        public string Roadside { get; set; }
        public DateTime DateFrom { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }

        public DBReturn InsertIntoMovieTemp()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[39];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
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
                prm[17] = new SqlParameter("@NameOfUnitProduction", SqlDbType.VarChar, 99) { Value = NameOfUnitProduction };
                prm[18] = new SqlParameter("@Add_UnitProduction", SqlDbType.VarChar, 150) { Value = Add_UnitProduction };
                prm[19] = new SqlParameter("@TitleofFilm", SqlDbType.VarChar, 99) { Value = TitleofFilm };
                prm[20] = new SqlParameter("@FilmType", SqlDbType.VarChar, 99) { Value = FilmType };
                prm[21] = new SqlParameter("@FilmSubject", SqlDbType.VarChar, 99) { Value = FilmSubject };
                prm[22] = new SqlParameter("@ArtistNames", SqlDbType.VarChar) { Value = ArtistNames };
                prm[23] = new SqlParameter("@ProducerName", SqlDbType.VarChar, 99) { Value = ProducerName };
                prm[24] = new SqlParameter("@DirectorName", SqlDbType.VarChar, 99) { Value = DirectorName };
                prm[25] = new SqlParameter("@AddressofUnitinCHD", SqlDbType.VarChar, 150) { Value = AddressofUnitinCHD };
                prm[26] = new SqlParameter("@IndoorShootingPermission", SqlDbType.Char, 1) { Value = IndoorShootingPermission };
                prm[27] = new SqlParameter("@SoundPermission", SqlDbType.Char, 1) { Value = SoundPermission };
                prm[28] = new SqlParameter("@NoofPersonatShooting", SqlDbType.Int) { Value = NoofPersonatShooting };
                prm[29] = new SqlParameter("@DetailofVehicleUsedinShooting", SqlDbType.VarChar, 200) { Value = DetailofVehicleUsedinShooting };
                prm[30] = new SqlParameter("@SecurityfoArtists", SqlDbType.Char, 1) { Value = SecurityfoArtists };
                prm[31] = new SqlParameter("@FirstAidArrangement", SqlDbType.Char, 1) { Value = FirstAidArrangement };
                prm[32] = new SqlParameter("@EmergencyNoAvailiability", SqlDbType.Char, 1) { Value = EmergencyNoAvailiability };
                prm[33] = new SqlParameter("@LightingArragementforHouseAndParkigArea", SqlDbType.Char, 1) { Value = LightingArragementforHouseAndP };
                prm[34] = new SqlParameter("@ContactNoofUnitInCHD", SqlDbType.Char, 100) { Value = ContactNoofUnitInCHD };
                prm[35] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[36] = new SqlParameter("@ApplicantDesignation", SqlDbType.VarChar, 50) { Value = ApplicantDesigation };
                prm[37] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[38] = new SqlParameter("@RouteDetails", SqlDbType.Structured) { Value = dtMovieDetail };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTemptraMoviePermission", prm);
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


        public DBReturn UpdateIntoMovieTemp(string ImageUpdated)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[38];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[1].Direction = ParameterDirection.Output;
                prm[2] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 99) { Value = ApplicantName };
                prm[4] = new SqlParameter("@ApplicantFatherName", SqlDbType.VarChar, 99) { Value = ApplicantFatherName };
                prm[5] = new SqlParameter("@ApplicantAadharNo", SqlDbType.VarChar, 12) { Value = ApplicantAadharNo };
                prm[6] = new SqlParameter("@ApplicantPremises", SqlDbType.VarChar, 59) { Value = ApplicantPremises };
                prm[7] = new SqlParameter("@ApplicantLocalityId", SqlDbType.VarChar, 50) { Value = ApplicantLocalityId };
                prm[8] = new SqlParameter("@ApplicantLocality", SqlDbType.VarChar, 60) { Value = ApplicantLocality };
                prm[9] = new SqlParameter("@ApplicantPinCode", SqlDbType.Int) { Value = ApplicantPinCode };
                prm[10] = new SqlParameter("@ApplicantEmail", SqlDbType.VarChar, 50) { Value = ApplicantEmail };
                prm[11] = new SqlParameter("@ApplicantMobileNo", SqlDbType.VarChar, 10) { Value = ApplicantMobileNo };
                prm[12] = new SqlParameter("@ApplicantDOB", SqlDbType.DateTime) { Value = ApplicantDOB };
                prm[13] = new SqlParameter("@ApplicantGender", SqlDbType.Char, 1) { Value = ApplicantGender };
                prm[14] = new SqlParameter("@NameOfUnitProduction", SqlDbType.VarChar, 99) { Value = NameOfUnitProduction };
                prm[15] = new SqlParameter("@Add_UnitProduction", SqlDbType.VarChar, 150) { Value = Add_UnitProduction };
                prm[16] = new SqlParameter("@TitleofFilm", SqlDbType.VarChar, 99) { Value = TitleofFilm };
                prm[17] = new SqlParameter("@FilmType", SqlDbType.VarChar, 99) { Value = FilmType };
                prm[18] = new SqlParameter("@FilmSubject", SqlDbType.VarChar, 99) { Value = FilmSubject };
                prm[19] = new SqlParameter("@ArtistNames", SqlDbType.VarChar) { Value = ArtistNames };
                prm[20] = new SqlParameter("@ProducerName", SqlDbType.VarChar, 99) { Value = ProducerName };
                prm[21] = new SqlParameter("@DirectorName", SqlDbType.VarChar, 99) { Value = DirectorName };
                prm[22] = new SqlParameter("@AddressofUnitinCHD", SqlDbType.VarChar, 150) { Value = AddressofUnitinCHD };
                prm[23] = new SqlParameter("@IndoorShootingPermission", SqlDbType.Char, 1) { Value = IndoorShootingPermission };
                prm[24] = new SqlParameter("@SoundPermission", SqlDbType.Char, 1) { Value = SoundPermission };
                prm[25] = new SqlParameter("@NoofPersonatShooting", SqlDbType.Int) { Value = NoofPersonatShooting };
                prm[26] = new SqlParameter("@DetailofVehicleUsedinShooting", SqlDbType.VarChar, 200) { Value = DetailofVehicleUsedinShooting };
                prm[27] = new SqlParameter("@SecurityfoArtists", SqlDbType.Char, 1) { Value = SecurityfoArtists };
                prm[28] = new SqlParameter("@FirstAidArrangement", SqlDbType.Char, 1) { Value = FirstAidArrangement };
                prm[29] = new SqlParameter("@EmergencyNoAvailiability", SqlDbType.Char, 1) { Value = EmergencyNoAvailiability };
                prm[30] = new SqlParameter("@LightingArragementforHouseAndParkigArea", SqlDbType.Char, 1) { Value = LightingArragementforHouseAndP };
                prm[31] = new SqlParameter("@ContactNoofUnitInCHD", SqlDbType.VarChar, 100) { Value = ContactNoofUnitInCHD };
                prm[32] = new SqlParameter("@ApplicantImage", SqlDbType.Image) { Value = ApplicantImage };
                prm[33] = new SqlParameter("@ImageUpdated", SqlDbType.VarChar, 1) { Value = ImageUpdated };
                prm[34] = new SqlParameter("@ApplicantDesignation", SqlDbType.VarChar, 50) { Value = ApplicantDesigation };
                prm[35] = new SqlParameter("@tempAppNO", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                prm[36] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[37] = new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = UserType };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateTempTraMoviePermission", prm);
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

        public DataSet GetAllRouteDetail()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = tempApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_GetMovieLocationDetail", prm);

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
                prm[6] = new SqlParameter("@RoadSide", SqlDbType.VarChar, 50) { Value = DBNull.Value };
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