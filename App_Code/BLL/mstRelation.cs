using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;


namespace EDistrictBL
{
   public class mstRelation
    {
        public Int32 Relationshipcode { get; set; }
        public string Relationship { get; set; }
        public DataSet GetRelation()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getRelation", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }
        }
        public DataSet GetRelationLegalHeir()
	{
	        DataSet DsReturn = new DataSet();
	        try
	        {
	            SqlParameter[] prm = new SqlParameter[0];
	            DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getRelationLegalHeir", prm);
	
	            return DsReturn;
	        }
	        catch (Exception Ex)
	        {
	            // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
	            return DsReturn;
	        }
    	 }

	public DataSet GetRelationresidence()
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[0];
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetRelationresidence", prm);

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

