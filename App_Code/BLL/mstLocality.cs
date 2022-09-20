using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
   public class mstLocality
    {
        #region Properties
        public Int32 LocalityCode { get; set; }
        public string LocalityName { get; set; }
        public DateTime? LocalityEntryDate { get; set; }
        public string LocalityIsActive { get; set; }
        public DateTime? LocalityDeActiveDate { get; set; }
        public string LocalityDeActivateReason { get; set; }
        public string LocalityDeActivateBy { get; set; }
        #endregion


        #region Function
        public DataSet GetAllLocality()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Getlocality", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
               // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }

        public DataSet GetFinYear()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetFinYear", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }
        #endregion 

    }
}
