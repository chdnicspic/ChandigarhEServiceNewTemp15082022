using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EDistrictBL
{
    public class mstSupportingDocuments
    {
        //***************Service Ducuments Master*************
        public Int32 documentid { get; set; }
        public string ServiceCode { get; set; }
        public Int32 DocumentNo { get; set; }
        public string Mandatory { get; set; }
        public string DocumentName { get; set; }
        public string Active { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string UserCode { get; set; }

        //***************Service Ducuments*******************
        public string TempApplicationNo { get; set; }
        public string ApplicationNo { get; set; }
        public byte[] DocumentBinary { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string SubServiceCode { get; set; }
        public string applicationNoActual { get; set; }
        public int UserType { get; set; }
        public string OfficeCode { get; set; }
        public string ModeOfPayment_Cashless { get; set; }
        public string Cheque_DD_No { get; set; }
        public string CardTransactionNumber { get; set; }
        public int BankCode { get; set; }
        public string BankName { get; set; }
        public DateTime? Cheque_DD_PaymentDate { get; set; }





        public DataSet Get_ModeofPayment()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Get_ModeofPayment", prm);
                return DsReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return DsReturn;
            }

        }
        public DataSet Get_BankNames()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Get_BankNames", prm);
                return DsReturn;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return DsReturn;
            }

        }
               
        public DataTable dtUploadDoc { get; set; }

        public DataSet GetSupportingDocuments()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[3];
                prm[0] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                prm[1] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };
                prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ShowServiceDocuments", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }
        }
        /// <summary>
        /// Upload Document For Service
        /// </summary>
        /// <param name="ServiceName">Name of Service</param>
        /// <returns></returns>
        public DBReturn UploadDocuments(string ServiceName, tblReceipt objReceipt)
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[12];

                prm[0] = new SqlParameter("@tempApplicationno", SqlDbType.VarChar, 30) { Value = TempApplicationNo };
                prm[1] = new SqlParameter("@DocTable", SqlDbType.Structured) { Value = dtUploadDoc };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;

                prm[4] = new SqlParameter("@applicationNoActual", SqlDbType.VarChar, 30);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
                prm[6] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };

                prm[7] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Value = objReceipt.TotalAmount };
                prm[8] = new SqlParameter("@FeeDetail", SqlDbType.Structured) { Value = objReceipt.ReceiptDetail };
                prm[9] = new SqlParameter("@UserLoggedin", SqlDbType.VarChar, 15) { Value = objReceipt.ReceiptGeneratedBy };
                prm[10] = new SqlParameter("@Barcode", SqlDbType.Image) { Value = objReceipt.Barcode };
                prm[11] = new SqlParameter("@WorkingOfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
                //prm[12] = new SqlParameter("@ModeOfPayment_Cashless", SqlDbType.VarChar, 50) { Value = ModeOfPayment_Cashless };
                //prm[13] = new SqlParameter("@Cheque_DD_No", SqlDbType.VarChar, 50) { Value = Cheque_DD_No };
                //prm[14] = new SqlParameter("@BankName", SqlDbType.VarChar, 100) { Value = BankName };
                //prm[15] = new SqlParameter("@Cheque_DD_PaymentDate", SqlDbType.DateTime) { Value = Cheque_DD_PaymentDate };
                //prm[16] = new SqlParameter("@BankCode", SqlDbType.Int) { Value = BankCode };
                //prm[17] = new SqlParameter("@CardTransactionNumber", SqlDbType.VarChar, 50) { Value = CardTransactionNumber };

                if (ServiceName == "INCOME")
                {
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertincomedocmaintable", prm);
                }
                if (ServiceName == "ELENCNLT")
                {
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertNewElectricityConnectionmaintable", prm);
                }
                if (ServiceName == "INCOMENW")
                {
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertincomedocmaintablenew", prm);
                }
                else if (ServiceName == "CASTE" && (SubServiceCode == "SCBONACR" || SubServiceCode == "SCOTMIGR" || SubServiceCode == "SCBONARE"))
                {
                    //    //sc
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertScCastedocmaintable", prm);
                }
                else if (ServiceName == "CASTE" && (SubServiceCode == "BCBONACR" || SubServiceCode == "BCOTMIGR" || SubServiceCode == "BCBONARE"))
                {
                    //obc
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertObcCastedocmaintableNew", prm);
                }
                else if (ServiceName == "SWPENOLD" && SubServiceCode == "SWPENOLD")
                {
                    //Social welfare Old Age pension
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertOLDAgePensionMainTable", prm);
                }
                else if (ServiceName == "SWPENDIS" && SubServiceCode == "SWPENDIS")
                {
                    //Social welfare Old Age pension
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertPensionForDisableMainTable", prm);
                }
                else if (ServiceName == "SWPENWID" && SubServiceCode == "SWPENWID")
                {
                    //Social welfare Old Age pension
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertPensionForWidowDestituteMainTable", prm);
                }
                else if (ServiceName == "SWIDCSNC" && SubServiceCode == "SWIDCSNC")
                {
                    //Social welfare Old Age pension
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertSeniorCitizenIdCardMainTable", prm);
                }
                else if (ServiceName == "ELECNCON" && (SubServiceCode == "ELECTOWN" || SubServiceCode == "ELECTTAN" || SubServiceCode == "ELECTFRM"))
                {
                    //    //ELECNCON
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertElectricitydocmaintable", prm);
                }
                else if (ServiceName == "BUSPASS" && SubServiceCode == "BUSPASS")
                {
                    //BUSPASS
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertBusPassMainTable", prm);
                }
                else if (ServiceName == "SOUNDPER" && SubServiceCode == "SOUNDPER")
                {
                    //    //ELECNCON
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertSoundDetailMainTable", prm);
                }
                else if (ServiceName == "LEGLHEIR" && SubServiceCode == "LEGLHEIR")
                {
                    //    //CERTIFICATE FOR Dependency
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertLegalHeirCertificatemainTable", prm);

                }
                else if (ServiceName == "EVENTPER" && (SubServiceCode == "EVENTPER" || SubServiceCode == "EVTPERDC"))
                {
                    //    //EVENT
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertEventPermissionMainTable", prm);
                }
                else if (ServiceName == "LTBIRDTH" && (SubServiceCode == "BIRTHHOM" || SubServiceCode == "BIRTHHOS"))
                {
                    //    //ELECNCON
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertBirthEntryMainTable", prm);
                }
                else if (ServiceName == "LTBIRDTH" && (SubServiceCode == "DEATHHOM" || SubServiceCode == "DEATHHOS"))
                {
                    //    //ELECNCON
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertDeathEntryMainTable", prm);
                }
                else if (ServiceName == "MOVIEPER" && SubServiceCode == "MOVIEPER")
                {
                    //    //ELECNCON
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertMoviePermissionMainTable", prm);
                }
                else if (ServiceName == "CERTRESI" && SubServiceCode == "CERTRESI")
                {
                    //    //CERTIFICATE FOR RESIDENCE
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertTraResidenceCertificateMainTable", prm);
                }
                else if (ServiceName == "DEPECERT" && SubServiceCode == "DEPECERT")
                {
                    //    //CERTIFICATE FOR Dependency
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertDependencyCertificatemainTable", prm);
                }
                else if (ServiceName == "SOLVCERT" && SubServiceCode == "SOLVCERT")
                {
                    //    //sc
                    SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertSolvency_CertificateMainTable", prm);
                }
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                objReturn.ApplicationNo = prm[4].Value.ToString();
                return objReturn;
                 
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }
        public DBReturn Insertsupportingdocument()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@DocumentNo", SqlDbType.Int) { Value = DocumentNo };
            prm[2] = new SqlParameter("@Mandatory", SqlDbType.Char, 1) { Value = Mandatory };
            prm[3] = new SqlParameter("@DocumentName", SqlDbType.VarChar, 50) { Value = DocumentName };
            prm[4] = new SqlParameter("@Active", SqlDbType.Char, 3) { Value = Active };
            prm[5] = new SqlParameter("@UserCode", SqlDbType.VarChar, 20) { Value = UserCode };
            prm[6] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[6].Direction = ParameterDirection.Output;
            prm[7] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };


            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertSuportingDocument", prm);
            objReturn.ErrMessage = prm[6].Value.ToString();

            return objReturn;


        }




        public void saveFileServerPath(string PathName)
        {
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.Text, PathName);
        }




        public byte[] GetDocument_Service_DocNO()
        {

            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };
            prm[2] = new SqlParameter("@DocNo", SqlDbType.Int) { Value = DocumentNo };
            prm[3] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };



            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceDocumentForView", prm);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["DocumentBinary"];

            }
            return b;
        }

        public DBReturn UpdateDocumentPath()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[5];

                prm[0] = new SqlParameter("@Applicationno", SqlDbType.VarChar, 30) { Value = applicationNoActual };
                prm[1] = new SqlParameter("@DocTable", SqlDbType.Structured) { Value = dtUploadDoc };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "updateDocumentPath", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return objReturn;
            }
        }
    }
}
