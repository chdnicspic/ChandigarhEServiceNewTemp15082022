using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class VerifyDoc
    {
        public string Applicationno { get; set; }
        public string MstCaste { get; set; }
        public string CertificateNo { get; set; }
        public DataSet getDoc()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@CertificateNo", SqlDbType.VarChar, 100) { Value = CertificateNo };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 100) { Value = Applicationno };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "VerifyCert", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }
        }
    }

}

