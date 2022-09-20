using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstsupportingdocument
    {
        #region Properties
        public string documentid { get; set; }
        public string ServiceCode { get; set; }
        public string DocumentNo { get; set; }
        public string Mandatory { get; set; }
        public string DocumentName { get; set; }
        public string Active { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string UserCode { get; set; }
        public string SubservicCode { get; set; }
        #endregion
        #region Functions
        public DBReturn Insertsupportingdocument()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@DocumentNo", SqlDbType.Int) { Value = DocumentNo };
            prm[2] = new SqlParameter("@Mandatory", SqlDbType.Char, 1) { Value = Mandatory };
            prm[3] = new SqlParameter("@DocumentName", SqlDbType.VarChar, 250) { Value = DocumentName };
            prm[4] = new SqlParameter("@Active", SqlDbType.Char, 3) { Value = Active };
            prm[5] = new SqlParameter("@UserCode", SqlDbType.VarChar, 20) { Value = UserCode };
            prm[6] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[6].Direction = ParameterDirection.Output;
            prm[7] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = SubservicCode };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertSuportingDocument", prm);
            objReturn.ErrMessage = prm[6].Value.ToString();
            return objReturn;
        #endregion
        }
        
       
    }
}
