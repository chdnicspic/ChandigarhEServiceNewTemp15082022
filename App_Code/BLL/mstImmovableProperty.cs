using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for mstImmovableProperty
/// </summary>
/// namespace EDistrictBL
namespace EDistrictBL
{
    public class mstImmovableProperty
    {

        #region Property
        public Int32 Propertyid { get; set; }
        public string PropertyName { get; set; }
        public string isActive { get; set; }
        public string EntryBy { get; set; }
       
        #endregion


        public DataTable GetAllImmovableProperty()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllImmovableProperty", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }

        public DBReturn InsertImmovableProperty()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@PropertyName", SqlDbType.VarChar, 50) { Value = PropertyName };
            prm[1] = new SqlParameter("@EntryBy", SqlDbType.VarChar, 15) { Value = EntryBy };
            prm[2] = new SqlParameter("@isActive", SqlDbType.Char, 1) { Value = isActive };
            prm[3] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[3].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertImmovableProperty", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            return objReturn;
        }
    }
}