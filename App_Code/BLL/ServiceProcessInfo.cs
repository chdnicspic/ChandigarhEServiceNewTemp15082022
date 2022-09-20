using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDistrictBL;
using System.Data.SqlClient;
using System.Data;

namespace EDistrictBL
{
    public class ServiceProcessInfo : traGeneralApplicationDetail
    {
        public DataSet GetProcessInfoForSound()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForSound", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetProcessInfoForIncome()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForIncome", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetProcessInfoForIncomeNew()
	        {
	            DataSet Ds = new DataSet();
	            try
	            {
	                SqlParameter[] prm = new SqlParameter[1];
	                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
	                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForIncomeNEW", prm);
	                return Ds;
	            }
	            catch (Exception Ex)
	            {
	
	                MyExceptionHandler.HandleException(Ex);
	                return Ds;
	            }
	
        }
        public DataSet GetProcessInfoForNewElectricityConnection()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForElectricityNewConnection", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }

        public DataSet GetProcessInfoForCaste()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForCaste", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetProcessInfoForOBCCaste()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForOBCCaste", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetProcessInfoForService()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessInfoForService", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        //GetProcessInfoForOBCCaste

    }
}
