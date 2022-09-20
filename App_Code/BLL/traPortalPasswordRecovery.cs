using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class traPortalPasswordRecovery
    {
        #region Properties
        public Int64 RecoveryId { get; set; }
        public string RecoverybyUserId { get; set; }
        public string RandomNumberUsed { get; set; }
        public string EncryptedStringSent { get; set; }
        public DateTime? SentDate { get; set; }
        public string IsRecoveryUsed { get; set; }
        public DateTime? RecoveryUsedDate { get; set; }
        public string IPSent { get; set; }
        public string IPRecoveryUsed { get; set; }
        #endregion



        #region Function
        public DBReturn InsertPasswordRecovery()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = RecoverybyUserId };
            prm[1] = new SqlParameter("@RandomNumberUsed", SqlDbType.VarChar, 50) { Value = RandomNumberUsed };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPSent };
            prm[5] = new SqlParameter("@CodeSent", SqlDbType.VarChar, 50) { Value = EncryptedStringSent };
            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTPasswordRecoveryLog", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
        #endregion




        public DBReturn GetRecoveryDetail()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@RecoveryId", SqlDbType.BigInt) { Value = RecoveryId };
            prm[1] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPRecoveryUsed };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTGetRecoveryDetail", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
    }
}
