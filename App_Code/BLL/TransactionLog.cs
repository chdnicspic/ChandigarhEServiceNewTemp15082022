using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
   public class TransactionLog
    {
        public Int64 ApplicationStatusId { get; set; }
        public string ApplicationNo { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ActionPerformed { get; set; }
        public string Remarks { get; set; }
        public string RemarksSigned { get; set; }
        public Int32 FromLevel { get; set; }
        public string MarkFrom { get; set; }
        public Int32 pendingwithlevel { get; set; }
        public string pendingwith { get; set; }
        public string pendingwithlevelname { get; set; }
        public string pendingwithleveltype { get; set; }
        public Int32 ToLevel { get; set; }
        public string MarkTo { get; set; }
        public string IsNoticeGenerated { get; set; }
        public string NoticeNo { get; set; }
        public string ISDocumentUploaded { get; set; }
        public string UploadDocumentPath { get; set; }
        public Int64 UploadDocumentId { get; set; }
        public byte[] UploadDocument { get; set; }
        public string IsVerified { get; set; }
        public string IsApproved { get; set; }
        public string NoticeVerified { get; set; }
        public DateTime? NoticeReplyDate { get; set; }
        public string NoticeFeedback { get; set; }
        public string LevelLocked { get; set; }
        public byte[] NotingFile { get; set; }
        public string NotingFilePath { get; set; }
        public Int64 TransactionDSCId { get; set; }


        public string IpAddress { get; set; }
        public int userType { get; set; }
        public string CurrentLoggedInUser { get; set; }
        public string service { get; set; }

	public DataSet GetForwardRevertPersonSound(string authCode, int level, string ActionType, string AppNo)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonSound", prm);

            return ds;
        }

        public DBReturn insertTransaction(string ServiceCode)
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[23];

                prm[0] = new SqlParameter("@Applicationno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@ActionType", SqlDbType.VarChar, 10) { Value = ActionPerformed };
                prm[2] = new SqlParameter("@remarks", SqlDbType.VarChar, 8000) { Value = Remarks };
                prm[3] = new SqlParameter("@RemarksSigned", SqlDbType.VarChar, 4000) { Value = RemarksSigned };
                prm[4] = new SqlParameter("@FromLevel", SqlDbType.Int) { Value = FromLevel };
                prm[5] = new SqlParameter("@MarkFrom", SqlDbType.VarChar, 15) { Value = MarkFrom };
                prm[6] = new SqlParameter("@pendingwithlevel", SqlDbType.Int) { Value = pendingwithlevel };
                prm[7] = new SqlParameter("@pendingwith", SqlDbType.VarChar, 15) { Value = pendingwith };
                prm[8] = new SqlParameter("@ToLevel", SqlDbType.Int) { Value = ToLevel };
                prm[9] = new SqlParameter("@MarkTo", SqlDbType.VarChar, 15) { Value = MarkTo };
                prm[10] = new SqlParameter("@ISDocumentUploaded", SqlDbType.VarChar,1) { Value = ISDocumentUploaded };
                prm[11] = new SqlParameter("@UploadDocumentPath", SqlDbType.VarChar, 1000) { Value = UploadDocumentPath };
                prm[12] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = UploadDocument };
                prm[13] = new SqlParameter("@IsVerified", SqlDbType.Char, 1) { Value = IsVerified };
                prm[14] = new SqlParameter("@IsApproved", SqlDbType.Char, 1) { Value = IsApproved };
                prm[15] = new SqlParameter("@NoticeVerified", SqlDbType.Char, 1) { Value = NoticeVerified };

                prm[16] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[16].Direction = ParameterDirection.Output;
                prm[17] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[17].Direction = ParameterDirection.Output;
                prm[18] = new SqlParameter("@NotingFile", SqlDbType.Image) { Value = NotingFile };
                prm[19] = new SqlParameter("@NotingFilePath", SqlDbType.VarChar, 2000) { Value = NotingFilePath };
                prm[20] = new SqlParameter("@UploadDocumentId", SqlDbType.BigInt) { Value = UploadDocumentId };
                prm[21] = new SqlParameter("@DSCID", SqlDbType.BigInt) { Value = TransactionDSCId };
                prm[22] = new SqlParameter("@CurrentLoginUser", SqlDbType.VarChar,15) { Value = CurrentLoggedInUser };
                
                if(ServiceCode=="INCOME")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionIncome", prm);
                else if (ServiceCode == "ELENCNLT")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionElectricityNewConnection", prm);
                else if(ServiceCode=="CASTE")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);
                else if (ServiceCode == "CERTRESI")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionResidence", prm);

                else if (ServiceCode == "SWPENOLD")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "SWPENDIS")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "SWPENWID")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "SWIDCSNC")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "ELECNCON")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "BUSPASS")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "SOUNDPER")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "EVENTPER")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);

                else if (ServiceCode == "LTBIRDTH")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionBirthHome", prm);

                else if (ServiceCode == "MOVIEPER")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);
                else if (ServiceCode == "DEPECERT")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionDependent", prm);
                else if (ServiceCode == "CRACKERS")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionCrackers", prm);
		 else if (ServiceCode == "SOLVCERT")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionSolvency", prm);
                 else if (ServiceCode == "LEGLHEIR")
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransactionLegal", prm);
                else
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertTransaction", prm);
                

                objReturn.ErrMessage = prm[16].Value.ToString();
                objReturn.ReturnCode = prm[17].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
		 MyExceptionHandler.HandleException(Ex);
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }
	public DataSet ClubNotingsLegalHeir()
	        {
	            SqlParameter[] prm = new SqlParameter[1];
	            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsLegalHeir", prm);
	            DataTable dt = new DataTable();
	            if (ds.Tables.Count > 0)
	            {
	                dt = ds.Tables[0];
	            }
	            return ds;
	        }
	
	        
	        public DataSet GetForwardRevertPersonLegalHeir(string authCode, int level, string ActionType, string AppNo)
	        {
	            SqlParameter[] prm = new SqlParameter[4];
	            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
	            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
	            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
	            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
	
	            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
	            // DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPerson", prm);
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonLegalHeir", prm);
	            return ds;
        }


        public DataSet GetForwardRevertPerson(string authCode, int level, string ActionType,string AppNo)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPerson", prm);

            return ds;
        }
        public DataSet GetForwardRevertPersonIncomeNew(string authCode, int level, string ActionType, string AppNo)
	        {
	            SqlParameter[] prm = new SqlParameter[4];
	            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
	            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
	            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
	            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
	            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonIncomenew", prm);
	
	            return ds;
        }
        public DataSet GetForwardRevertPersonNewElectricityConn(string authCode, int level, string ActionType, string AppNo)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonNewElectricityConn", prm);

            return ds;
        }

        public DataSet GetForwardtCrackerPerson(string authCode, int level, string ActionType, string AppNo, string subservice)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            prm[4] = new SqlParameter("@SubService", SqlDbType.VarChar, 30) { Value = subservice };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertcracker ", prm);

            return ds;
        }

        public DataSet GetForwardRevertPersonBirth(string authCode, int level, string ActionType, string AppNo,string subservice)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            prm[4] = new SqlParameter("@SubService", SqlDbType.VarChar, 30) { Value = subservice };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonBirth", prm);

            return ds;
        }
        public DataSet GetForwardRevertPersonDeath(string authCode, int level, string ActionType, string AppNo, string subservice)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = AppNo };
            prm[4] = new SqlParameter("@SubService", SqlDbType.VarChar, 30) { Value = subservice };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonDeath", prm);

            return ds;
        }

        public DataSet GetForwardRevertPersonCaste(string authCode, int level, string ActionType,string applno)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Autcode", SqlDbType.VarChar, 10) { Value = authCode };
            prm[1] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = level };
            prm[2] = new SqlParameter("@actionType", SqlDbType.VarChar, 10) { Value = ActionType };
            prm[3] = new SqlParameter("@applno", SqlDbType.VarChar, 30) { Value = applno };
            //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ForwardRevertPersonCaste", prm);

            return ds;
        }

        public byte[] GetTransactionNoting()
        {
            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@AppStatusid", SqlDbType.BigInt) { Value = ApplicationStatusId };




            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessNoting", prm);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["NotingFile"];

            }
            return b;
        }

        public byte[] GetTransactionDoc()
        {
            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@AppStatusid", SqlDbType.BigInt) { Value = ApplicationStatusId };
            



            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessDoc", prm);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["UploadDocument"];

            }
            return b;
        }

        public DBReturn SaveFinalCertificateIncome()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[12];
                prm[0] = new SqlParameter("@IsApproved", SqlDbType.VarChar, 1) { Value = IsApproved };
                prm[1] = new SqlParameter("@Remarks", SqlDbType.VarChar,2000) { Value = Remarks };
                prm[2] = new SqlParameter("@ActionPerformed", SqlDbType.VarChar, 10) { Value = ActionPerformed };
                prm[3] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@IpAddress", SqlDbType.VarChar, 20) { Value =  IpAddress};
                prm[7] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = UploadDocument };
                prm[8] = new SqlParameter("@FromLevel", SqlDbType.Int) { Value = FromLevel };
                prm[9] = new SqlParameter("@LoginUserId", SqlDbType.VarChar,15) { Value =  pendingwith};
                prm[10] = new SqlParameter("@DSCID", SqlDbType.BigInt) { Value =TransactionDSCId };
                prm[11] = new SqlParameter("@Certpath", SqlDbType.VarChar,2000) { Value = UploadDocumentPath };
                //prm[12] = new SqlParameter("@CurrentLoginUser", SqlDbType.VarChar, 15) { Value = CurrentLoggedInUser };


                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalCertificateIncome", prm);
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
        public DBReturn SaveFinalCertificateElectricityNewConn()
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
                //prm[12] = new SqlParameter("@CurrentLoginUser", SqlDbType.VarChar, 15) { Value = CurrentLoggedInUser };


                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalCertificateElectricityNewConn", prm);
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
        public DBReturn SaveFinalCertificateCaste()
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
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalCertificateCaste", prm);
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

        public DBReturn SaveFinalCertificatePensionDisabled()
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
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalSanctionorderPensionDisabled", prm);
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
        public DBReturn SaveFinalSanctionorderPensionOldAge()
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
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalSanctionorderPensionOldAge", prm);
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
        public DBReturn SaveFinalSanctionorderPensionWidow()
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
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFinalSanctionorderPensionWidow", prm);
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

        public DBReturn RevertToApplicantorSampark()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[7];

                prm[0] = new SqlParameter("@Applicationno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@FromLevel", SqlDbType.Int) { Value = FromLevel };
                prm[2] = new SqlParameter("@remarks", SqlDbType.VarChar, 8000) { Value = Remarks };
                prm[3] = new SqlParameter("@MarkFrom", SqlDbType.VarChar, 15) { Value = MarkFrom };
                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@CurrentLoginuser", SqlDbType.VarChar, 15) { Value = CurrentLoggedInUser };


                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "RevertToApplicantorSampark", prm);
                objReturn.ErrMessage = prm[4].Value.ToString();
                objReturn.ReturnCode = prm[5].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }

        public DataTable GetObjectionDetail()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetObjectionDetail", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn UploadObjectionDocument()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[7];

                prm[0] = new SqlParameter("@Applicationno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = UploadDocument };
                prm[2] = new SqlParameter("@UploadByUser", SqlDbType.VarChar, 15) { Value = MarkFrom };
                prm[3] = new SqlParameter("@UserType", SqlDbType.Int) { Value = userType };

                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@UploadDocumentPath", SqlDbType.VarChar, 2000) { Value = UploadDocumentPath };

                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UploadObjectionDocument", prm);
                objReturn.ErrMessage = prm[4].Value.ToString();
                objReturn.ReturnCode = prm[5].Value.ToString();
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
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotings", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
        public DataSet GetDataSetClubNotingsBirth()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsBirth", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }

        public DataSet GetDataSetClubNotingsIncome()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsIncome", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }


        public DataSet GetDataSetClubNotingsElectricityNewConnection()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsElectricityNewConnection", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
        

        public DataSet GetDataSetClubNotingsforcracker()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsforCracker", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }


        public DataTable GetClubNotings()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotings", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DataTable GetClubDocuments()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubDocuments", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public string GetApplicationApprovalRecomend()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@PendingWithLevel", SqlDbType.Int) { Value = pendingwithlevel };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetApplicationApprovalRecomend", prm);
            string SS;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                 SS = ds.Tables[0].Rows[0]["IsVerified"].ToString();
            }
            else
            {
                SS = "X";
            }
            return SS;
        }

        public DataSet GetProcessSummary()
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@Service", SqlDbType.VarChar, 50) { Value = service };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ProcessShowSummary", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }
        public DataSet RegenerateFinalCertificate()
        {
            DataSet dt = new DataSet();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ReGenerateFinalCertificate", prm);

            return ds;
        }
	//Transaction log.cs 
	public DataSet GetDataSetClubNotingsSound()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Appno", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ClubNotingsSound", prm);
            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return ds;
        }

        public DBReturn SaveRegenerateFinalCertificate()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[10];
                prm[0] = new SqlParameter("@ActionPerformed", SqlDbType.VarChar, 10) { Value = ActionPerformed };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@IpAddress", SqlDbType.VarChar, 20) { Value = IpAddress };
                prm[5] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = UploadDocument };
                prm[6] = new SqlParameter("@LoginUserId", SqlDbType.VarChar, 15) { Value = CurrentLoggedInUser };
                prm[7] = new SqlParameter("@DSCID", SqlDbType.BigInt) { Value = TransactionDSCId };
                prm[8] = new SqlParameter("@Certpath", SqlDbType.VarChar, 2000) { Value = UploadDocumentPath };
                prm[9] = new SqlParameter("@Remarks", SqlDbType.VarChar, 2000) { Value = Remarks };
                SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveReGenerateFinalCertificate", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MyExceptionHandler.HandleException(ex);
            }
            return objReturn;
        }

    }
}
