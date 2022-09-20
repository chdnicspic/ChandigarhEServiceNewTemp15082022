using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class FinalCertificate
    {

        public string Applicationno { get; set; }
        public string CurrentUserid { get; set; }
        public string Approved { get; set; }
        public string Service;
        public string SubService;


        public DataSet GetIncomeCertificate()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalIncomeCertificate", prm);
           
            return ds;
        }
        public DataSet GetIncomeCertificatenew()
	          {
	              DataSet dt = new DataSet();
	              DBReturn objReturn = new DBReturn();
	              SqlParameter[] prm = new SqlParameter[5];
	              prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
	              prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
	              prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
	              prm[2].Direction = ParameterDirection.Output;
	              prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
	              prm[3].Direction = ParameterDirection.Output;
	              prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };
	
	              DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalIncomeCertificatenew", prm);
	
	              return ds;
	          }
        public DataSet GetElectricityNewConnectionCertificatenew()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalElectricityNewConnCertificatenew", prm);

            return ds;
        }

        public DataSet GetPensionDisabledSanctionOrder()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalPensionDisabledSanctionOrder", prm);

            return ds;
        }
        public DataSet GetPensionOldAgeSanctionOrder()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalPensionOldAgeSanctionOrder", prm);

            return ds;
        }
        public DataSet GetPensionWidowDestituteSanctionOrder()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalPensionWidowDestituteSanctionOrder", prm);

            return ds;
        }
          public DataSet GenerateFinalSeniorCitizenIdCard()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalSeniorCitizenIdCard", prm);

            return ds;
        }

        public DataSet GenerateFinalSoundPermissionCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalSoundCertificate", prm);

            return ds;
        }
        public DataSet GenerateFinalBirthCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalBirthCertificate", prm);

            return ds;
        }
        public DataSet GenerateFinalDeathCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalDeathCertificate", prm);

            return ds;
        }
        public DataSet GenerateFinalEventPermissionCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalEventCertificate", prm);

            return ds;
        }
        public DataSet GetINcomeReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetINcomeReport", prm);

            return ds;
        }
        public DataSet GetINcomeReportNew()
	        {
	            DataSet dt = new DataSet();
	            DBReturn objReturn = new DBReturn();
	            SqlParameter[] prm = new SqlParameter[4];
	            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
	            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
	            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
	            prm[2].Direction = ParameterDirection.Output;
	            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
	            prm[3].Direction = ParameterDirection.Output;
	
	
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetINcomeReportNew", prm);
	
	            return ds;
        }
        public DataSet GetBirthPatwariReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetBirthPatwariReport", prm);

            return ds;
        }
        public DataSet GetDeathPatwariReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDeathPatwariReport", prm);

            return ds;
        }
        public DataSet GetPatwariResidenceReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPatwariResidenceReport", prm);

            return ds;
        }

        public DataSet GetCASTEOBCVerificationReceipt()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getOBCDetail_TEMP", prm);

            return ds;
        }

        public DataSet GetCASTEOBCVerificationReceiptFinal()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getOBCDetail", prm);

            return ds;
        }



        public DataSet GetINcomeverificationReceipt()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetINcomeVerificationReceipt", prm);
            return ds;
        }
	public DataSet GetINcomeverificationReceiptnew()
	        {
	            DataSet dt = new DataSet();
	            DBReturn objReturn = new DBReturn();
	            SqlParameter[] prm = new SqlParameter[4];
	            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
	            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
	            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
	            prm[2].Direction = ParameterDirection.Output;
	            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
	            prm[3].Direction = ParameterDirection.Output;
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetINcomeVerificationReceiptnew", prm);
	            return ds;
        }
        

        public DataSet PrintCertificateForSamparkuser()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@CurrentUserId", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PrintCertificateForSamparkuser", prm);
            return ds;
        }



        public DataSet GetCasteCertificate()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalCasteCertificate", prm);
            return ds;
        }

        public DataSet GenerateFinalBusPass()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalBusPassCard", prm);

            return ds;
        }

        public DataSet GetCastePatwariProfarma()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            //prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            //prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            //prm[2].Direction = ParameterDirection.Output;
            //prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            //prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PrintReciptCaste", prm);

            return ds;
        }
        public DataSet GenerateFinalSoundPermissionCert1()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
           
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getfinalcertificateDetailsSound", prm);

            return ds;
        }
        public DataSet GetCasteVerificationReceipt()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            //prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            //prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            //prm[2].Direction = ParameterDirection.Output;
            //prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            //prm[3].Direction = ParameterDirection.Output;


            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PrintReciptCasteVerification", prm);

            return ds;
        }
        public DataSet GenerateVerificationReceipt()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = Service };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = SubService };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "EditServiceDetail", prm);

            return ds;
        }
        public DataSet GenerateFinalMoviePermissionCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_Get_MoviePermission_Certificate", prm);

            return ds;
        }
        public DataSet GenerateFinalDependentCert()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_Get_Dependent_Certificate", prm);
            return ds;

        }
        public DataSet GetDepedentPatwariReport()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDependentPatwariReport", prm);

            return ds;
        }
        
        public DataSet GenerateFinalResidenceCertificate()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@Approved", SqlDbType.VarChar, 1) { Value = Approved };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFinalResidenceCertificate", prm);

            return ds;
        }

        //public DataSet GetBirthPatwariReport()
        //{
        //    DataSet dt = new DataSet();
        //    DBReturn objReturn = new DBReturn();
        //    SqlParameter[] prm = new SqlParameter[4];
        //    prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
        //    prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
        //    prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        //    prm[2].Direction = ParameterDirection.Output;
        //    prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        //    prm[3].Direction = ParameterDirection.Output;
        //    DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetBirthPatwariReport", prm);

        //    return ds;
        //}
        //public DataSet GetDeathPatwariReport()
        //{
        //    DataSet dt = new DataSet();
        //    DBReturn objReturn = new DBReturn();
        //    SqlParameter[] prm = new SqlParameter[4];
        //    prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = Applicationno };
        //    prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = CurrentUserid };
        //    prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        //    prm[2].Direction = ParameterDirection.Output;
        //    prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        //    prm[3].Direction = ParameterDirection.Output;


        //    DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDeathPatwariReport", prm);

        //    return ds;
        //}
    }

}
