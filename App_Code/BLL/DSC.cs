using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDistrictBL;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public  class DSC
    {
        public Int64 DSCRegisterId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string dscCommonName { get; set; }
        public string dscSerialNo { get; set; }
        public string dscThumb { get; set; }
        public DateTime dscValidFrom { get; set; }
        public DateTime  dscValidUpto { get; set; }
        public string dscProvider { get; set; }
        public string dscAlias { get; set; }
        public byte[] dscPublicKey { get; set; }
        public string IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DeactivationDate { get; set; }
        public string DSCCertificate { get; set; }

        public DBReturn RegisterDSC()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[14];
                prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar,50) { Value = UserCode };
                prm[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50) { Value = UserName };
                prm[2] = new SqlParameter("@dscCommonName", SqlDbType.VarChar,100) { Value = dscCommonName };
                prm[3] = new SqlParameter("@dscSerialNo", SqlDbType.VarChar, 200) { Value = dscSerialNo };
                prm[4] = new SqlParameter("@dscThumb", SqlDbType.VarChar) { Value = dscThumb };
                prm[5] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[6].Direction = ParameterDirection.Output;
                prm[7] = new SqlParameter("@dscValidFrom", SqlDbType.DateTime) { Value = dscValidFrom };
                prm[8] = new SqlParameter("@dscValidUpto", SqlDbType.DateTime) { Value = dscValidUpto };
                prm[9] = new SqlParameter("@dscProvider", SqlDbType.VarChar, 100) { Value = dscProvider };
                prm[10] = new SqlParameter("@dscAlias", SqlDbType.VarChar, 50) { Value = dscAlias };
                prm[11] = new SqlParameter("@dscPublicKey", SqlDbType.Image) { Value = dscPublicKey };
                prm[12] = new SqlParameter("@IsActive", SqlDbType.Char, 1) { Value = IsActive };
                prm[13] = new SqlParameter("@DSCCertificate", SqlDbType.VarChar) { Value = DSCCertificate };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "RegisterDSC", prm);
                objReturn.ErrMessage = prm[5].Value.ToString();
                objReturn.ReturnCode = prm[6].Value.ToString();
                return objReturn;
           }
           catch (Exception Ex)
           {
              // MyExceptionHandler.HandleException(Ex, "BL-DSC", "RegisterDSC");
               return objReturn;
           }

        }

    }


}
