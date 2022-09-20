using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class TempEntryGeneral
    {
        public Int64 Id { get; set; }
        public string tempApplicationNo { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string tempApplicationYear { get; set; }
        public string ServiceCode { get; set; }
        public string AppliedBy { get; set; }
        public string AppliedByFatherName { get; set; }
        public string ApplicantMothername { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantFatherName { get; set; }
        public string ApplicantGender { get; set; }
        public DateTime? ApplicantDOB { get; set; }
        public Int32 ApplicantMaritalStatus { get; set; }
        public Int64 ApplicantAadharNo { get; set; }
        public string ApplicantPremises { get; set; }
        public Int32 ApplicantLocalityId { get; set; }
        public string ApplicantLocality { get; set; }
        public Int32 ApplicantPinCode { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantMobileNo { get; set; }
        public Int64 ApplicationHeldWith { get; set; }
        public Int64 ApplicationPrevHeldWith { get; set; }
        public string Authority { get; set; }
        public string CurrentStatus { get; set; }
        public string ApplicationEnteredBy { get; set; }
        public DateTime? ApplicationTimeStamp { get; set; }
        public string Remarks { get; set; }
        public string State { get; set; }
        public Int32 Village { get; set; }
        public string District { get; set; }
        public string Tehsil { get; set; }
        public string oprcode { get; set; }
        public Int64 ApplicantId { get; set; }
        public string ReceiptNo { get; set; }
        public string GovtFee { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public Decimal ServiceCharges { get; set; }
        public string DocUploadFlag { get; set; }
        
        public string CancelEntry { get; set; }
        public string TempSubServiceCode { get; set; }
        public string MachineIP { get; set; }
        public string EntryOfficeCode { get; set; }

        public DataTable GetApplicationDetail()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "EditServiceDetail", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
	public DataTable GetApplicationDetailMainTable()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "EditServiceDetailMainTable", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataSet GetDatasetApplicationDetailMainTable()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "EditServiceDetailMainTable", prm);

            return ds;

        }

        public DataSet GetDatasetApplicationDetail()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "EditServiceDetail", prm);
            
            return ds;
        
        }

        public DataSet GetServiceVerification()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[1];
            DataSet Ds=new DataSet ();
            //prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };

            prm[0] = new SqlParameter("@TempAppNo", SqlDbType.VarChar, 30) { Value = tempApplicationNo };
            //prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = TempSubServiceCode };

            if(ServiceCode =="SWPENDIS" && TempSubServiceCode=="SWPENDIS")

            Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyPensionDisablityDetail", prm);
            else if (ServiceCode == "SWPENOLD" && TempSubServiceCode == "SWPENOLD")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyPensionOLDAgeDetail", prm);
            else if (ServiceCode == "SWPENWID" && TempSubServiceCode == "SWPENWID")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyPensionWidowDestituteDetail", prm);
            else if (ServiceCode == "SWIDCSNC" && TempSubServiceCode == "SWIDCSNC")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyPensionSeniorIDCardDetail", prm);
            else if (ServiceCode == "SOUNDPER" && TempSubServiceCode == "SOUNDPER")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifySoundDetail", prm);
            else if (ServiceCode == "EVENTPER" && TempSubServiceCode == "EVENTPER" || TempSubServiceCode == "EVTPERDC")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyEventDetail", prm);
            else if (ServiceCode == "MOVIEPER" && TempSubServiceCode == "MOVIEPER")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyMovieDetail", prm);
            else if (ServiceCode == "CERTRESI" && TempSubServiceCode == "CERTRESI")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyResidenceCertificateDetail", prm);
            else if (ServiceCode == "DEPECERT" && TempSubServiceCode == "DEPECERT")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyDependentDetail", prm);
            else if (ServiceCode == "LTBIRDTH" && (TempSubServiceCode == "BIRTHHOM" || TempSubServiceCode == "BIRTHHOS"))
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyBirthDetail", prm);
            else if (ServiceCode == "LTBIRDTH" && (TempSubServiceCode == "DEATHHOM" || TempSubServiceCode == "DEATHHOS"))
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyDeathDetail", prm);
	    else if (ServiceCode == "SOLVCERT" && TempSubServiceCode == "SOLVCERT")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifySolvencyDetail", prm);
            else if (ServiceCode == "LEGLHEIR" && TempSubServiceCode == "LEGLHEIR")
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyLegalHeirDetail", prm);
            return Ds;


        }

    }
}
