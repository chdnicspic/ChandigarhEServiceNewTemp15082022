using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDistrictBL
{
    public class mstUserPortal
    {
        #region BaseProperties
            public string PortalUserId { get; set; }
            public string PortalUserMobile { get; set; }
            public string PortalUserEmail { get; set; }
            public DateTime? PortalUserRegisterDate { get; set; }
            
            public Int32 PortalUserLoginAttempt { get; set; }
            public string IPAddress { get; set; }
            public string  PortalUserPassword { get; set; }
            public string PortalUserPassword1 { get; set; }
            public string PortalUserPassword2 { get; set; }
            public string PortalUserIsActive { get; set; }
            
            public DateTime? PortalUserLastSLogin { get; set; }
            public DateTime? PortalUserLastFLogin { get; set; }
            public DateTime? PortalUserActivationDate { get; set; }
            public string PortalUserIsVerified { get; set; }
        #endregion
            #region Other properties
            public string RandomNumber { get; set; }
            public string strEncryptString { get; set; }
            #endregion



            #region Functions
            public DBReturn InsertPortalUser()
            {
                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[6];
                prm[0] = new SqlParameter("@Email", SqlDbType.VarChar,50) { Value = PortalUserEmail };
                prm[1] = new SqlParameter("@Mobile", SqlDbType.VarChar, 10) { Value = PortalUserMobile };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
                prm[5] = new SqlParameter("@PortaluserPassword", SqlDbType.VarChar, 50) { Value = PortalUserPassword };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTRegisterUser", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;
            }

            public DBReturn GetLogin()
            {
                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[6];
                prm[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = PortalUserEmail };
                prm[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50) { Value = PortalUserPassword };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
                prm[5] = new SqlParameter("@Salt", SqlDbType.VarChar, 50) { Value = RandomNumber };
                objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTUserLogin", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;
            }


            public DBReturn ChangePassword()
            {
                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[6];
                prm[0] = new SqlParameter("@OldPassword", SqlDbType.VarChar, 50) { Value = PortalUserPassword1 };
                prm[1] = new SqlParameter("@newPassword", SqlDbType.VarChar, 50) { Value = PortalUserPassword };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
                prm[5] = new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = PortalUserEmail };
                objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTUserChangepassword", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;
            }

            public DBReturn SetNewPassword()
            {
                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[5];
                prm[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = PortalUserEmail };
                prm[1] = new SqlParameter("@newPassword", SqlDbType.VarChar, 50) { Value = PortalUserPassword };
                prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[2].Direction = ParameterDirection.Output;
                prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[3].Direction = ParameterDirection.Output;
                prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
                
                objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTUserSetNewPassword", prm);
                objReturn.ErrMessage = prm[2].Value.ToString();
                objReturn.ReturnCode = prm[3].Value.ToString();
                return objReturn;
            }
            
        #endregion









           
    }
}
