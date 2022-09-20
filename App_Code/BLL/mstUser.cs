using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstUser
    {
        #region Properties
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public DateTime? UserDOB { get; set; }
        public string UserParentDept { get; set; }
        public string UserParentOffice { get; set; }
        public string UserMobile { get; set; }
        public DateTime? UserEntryDate { get; set; }
        public DateTime? UserDeActiveDate { get; set; }
        public string UserPassword { get; set; }
        public string LoginName { get; set; }
        public string UserIsActive { get; set; }
        public string UserEmailId { get; set; }
        public Int32 LoginAttempt { get; set; }
        public Int32 UserType { get; set; }
        public string UserIsDSCEnabled { get; set; }
        public string UserIsVerified { get; set; }
        public DateTime? UserActivationDate { get; set; }
        public DateTime? UserLastSLogin { get; set; }
        public DateTime? UserLastFLogin { get; set; }
        public string UserPassword1 { get; set; }
        public string UserPassword2 { get; set; }
        public string UserIpAddress { get; set; }
        #endregion

        #region Other properties
        public string RandomNumber { get; set; }
        public string strEncryptString { get; set; }
        #endregion

        #region Functions
        public DBReturn InsertSystemUser()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[13];
            prm[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50) { Value = UserName };
            prm[1] = new SqlParameter("@DOB", SqlDbType.DateTime) { Value = UserDOB };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = UserIpAddress };
            prm[5] = new SqlParameter("@UserParentDept", SqlDbType.VarChar,5) { Value = UserParentDept };
            prm[6] = new SqlParameter("@UserParentoffice", SqlDbType.VarChar, 5) { Value = UserParentOffice };
            prm[7] = new SqlParameter("@UserMobile", SqlDbType.VarChar, 10) { Value = UserMobile };
            prm[8] = new SqlParameter("@UserPassword", SqlDbType.VarChar, 50) { Value = UserPassword };
            prm[9] = new SqlParameter("@LoginName", SqlDbType.VarChar, 20) { Value = LoginName };
            prm[10] = new SqlParameter("@UserEmailId", SqlDbType.VarChar, 50) { Value = UserEmailId };
            prm[11] = new SqlParameter("@UserType", SqlDbType.Int) { Value = UserType };
            prm[12] = new SqlParameter("@UserIsDSCEnabled", SqlDbType.VarChar, 1) { Value = UserIsDSCEnabled };
            
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMRegisterUser", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
        #endregion



        public DBReturn GetLogin()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@LoginName", SqlDbType.VarChar, 50) { Value = LoginName };
            prm[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50) { Value = UserPassword };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = UserIpAddress };
            prm[5] = new SqlParameter("@Salt", SqlDbType.VarChar, 50) { Value = RandomNumber };
            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMUserLogin", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
	 public DataTable GetAllCertificateGeneratedUser()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllCertificateGeneratedUser", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn ChangePassword()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@OldPassword", SqlDbType.VarChar, 50) { Value = UserPassword1 };
            prm[1] = new SqlParameter("@newPassword", SqlDbType.VarChar, 50) { Value = UserPassword };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = UserIpAddress };
            prm[5] = new SqlParameter("@LoginName", SqlDbType.VarChar, 50) { Value = LoginName };
            prm[6] = new SqlParameter("@UserCode", SqlDbType.VarChar, 50) { Value = UserCode };
            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMUserChangepassword", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }

        public DataTable GetAllUser()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllSystemUser", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn RecoverPassword()
        {

            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];       
            prm[0] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[0].Direction = ParameterDirection.Output;
            prm[1] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[1].Direction = ParameterDirection.Output;
            prm[2] = new SqlParameter("@LoginName", SqlDbType.VarChar, 50) { Value = LoginName };
            prm[3] = new SqlParameter("@Password", SqlDbType.VarChar, 50) { Value = UserPassword };
            prm[4] = new SqlParameter("@UserMobile", SqlDbType.VarChar, 50) { Value = UserMobile };
            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "USP_RecoverPassword", prm);
            objReturn.ErrMessage = prm[0].Value.ToString();
            objReturn.ReturnCode = prm[1].Value.ToString();

            return objReturn;

        }
    }
}
