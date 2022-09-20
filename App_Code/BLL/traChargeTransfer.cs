using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class traChargeTransfer
    {

        #region Preoperties

        public Int64 ChargeTransferId { get; set; }
        public DateTime? TransferDate { get; set; }
        public string TransferType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string FromDeptId { get; set; }
        public string FromOfficeCode { get; set; }
        public Int32 FromDesignationId { get; set; }
        public string ToDeptId { get; set; }
        public string ToOfficeCode { get; set; }
        public Int32 ToDesignationId { get; set; }
        public string FromUserName { get; set; }
        public string ToUserName { get; set; }

        #endregion

        #region Function

        #endregion

        public DBReturn ChargeTransfer()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[13];
            prm[0] = new SqlParameter("@FromDeptCode", SqlDbType.VarChar, 5) { Value = FromDeptId };
            prm[1] = new SqlParameter("@FromOfficeCode", SqlDbType.VarChar, 5) { Value = FromOfficeCode };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            //prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = UserIpAddress };
            prm[4] = new SqlParameter("@FromDesignationId", SqlDbType.Int) { Value = FromDesignationId };
            prm[5] = new SqlParameter("@FromUser", SqlDbType.VarChar, 15) { Value = FromUser };
            prm[6] = new SqlParameter("@ToUser", SqlDbType.VarChar, 15) { Value = ToUser };
            prm[7] = new SqlParameter("@TransferType", SqlDbType.VarChar, 1) { Value = TransferType };
            prm[8] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate };
            prm[9] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate };

            prm[10] = new SqlParameter("@ToDeptCode", SqlDbType.VarChar, 5) { Value = ToDeptId };
            prm[11] = new SqlParameter("@ToOfficeCode", SqlDbType.VarChar, 5) { Value = ToOfficeCode };
            prm[12] = new SqlParameter("@ToDesignationId", SqlDbType.Int) { Value = ToDesignationId };

            objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ChargeTransfer", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
    }
}
