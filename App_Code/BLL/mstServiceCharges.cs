using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstServiceCharges
    {

        #region Properties
        public string ServiceCode { get; set; }
        public string SubServiceCode { get; set; }
        public string ServiceFeeType { get; set; }
        public decimal SamparkServiceFee { get; set; }
        public Int32 ServiceFeeTypeId { get; set; }
        public decimal OnlineServiceFee { get; set; }
        public string IsActive { get; set; }
        public string IsOptional { get; set; }
        #endregion



        #region Functions
        public DBReturn InsertserviceCharge()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[10];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@SubserviceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };
            prm[2] = new SqlParameter("@ServiceFeeType", SqlDbType.VarChar, 50) { Value = ServiceFeeType };
            prm[3] = new SqlParameter("@ServiceActive", SqlDbType.Char, 1) { Value = IsActive };
            prm[4] = new SqlParameter("@ServiceFeeTypeid", SqlDbType.Int) { Value = ServiceFeeTypeId };
            prm[5] = new SqlParameter("@errmsg", SqlDbType.VarChar,50);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@SamparkServiceFee", SqlDbType.Decimal) { Value = SamparkServiceFee };
            prm[7] = new SqlParameter("@OnLineServiceFee", SqlDbType.Decimal) { Value = OnlineServiceFee};
            prm[8] = new SqlParameter("@IsOptional", SqlDbType.Char, 1) { Value = IsOptional };
            prm[9] = new SqlParameter("@returncode", SqlDbType.VarChar, 50);
            prm[9].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertServiceFee", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            return objReturn;
        }


        public DataTable GetServiceChargeByServiceCode()
        {
            DataTable dt = new DataTable();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };

                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetServiceChargeByServiceCode", prm);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return dt;
            }
            finally
            {
                dt.Dispose();
            }


        }
        #endregion
    }
}
