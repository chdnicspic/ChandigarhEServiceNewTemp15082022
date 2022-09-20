using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class mstCaste
    {
        public string MstCaste { get; set; }
        public DataSet GetCaste()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getCaste", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }
        }

        public DBReturn InsertCast()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@castname", SqlDbType.VarChar, 100) { Value = MstCaste };
            prm[1] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertcaste", prm);
            objReturn.ErrMessage = prm[1].Value.ToString();
            return objReturn;
        }
    }
}
