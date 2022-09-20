using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class ChargeTransfer : mstAuthority
    {
        #region properties
        public string UserCode { get; set; }
        public string ApplicationNo { get; set; }
        public string Remarks { get; set; }
        public string ErrMsg { get; set; }
        public string FromUserCode { get; set; }
        public string ToUserCode { get; set; }
        public string ToUserName { get; set; }
        public string ActionTakenbyUser { get; set; }
        #endregion

        #region Functions

       

        public DataTable GetAuthorityWiseUser()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Authority", SqlDbType.VarChar, 30) { Value = AuthCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getAuthorityWiseUser", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DataTable getChargetoTransfer()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar, 30) { Value = AuthCode };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getChargetoTransfer", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }
	 public DataTable getLocalityAccToAuthorityandUserCode()
	        {
	            DataTable dt = new DataTable();
	            SqlParameter[] prm = new SqlParameter[2];
	            prm[0] = new SqlParameter("@Authority", SqlDbType.VarChar, 30) { Value = AuthCode };
	            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SP_GetLocality_By_AuthorityandUserCode", prm);
	            if (ds.Tables[0].Rows.Count > 0)
	            {
	                dt = ds.Tables[0];
	            }
	            return dt;
        }
        public DataTable getPendingApplication()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Authority", SqlDbType.VarChar, 30) { Value = AuthCode };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
            prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getPendingApplication", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
public DataTable getPendingApplication1()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Authority", SqlDbType.VarChar, 30) { Value = AuthCode };
            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
            prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            //prm[3] = new SqlParameter("@LocalityId", SqlDbType.VarChar, 30) { Value = Remarks };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getPendingApplication1", prm);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DBReturn InsertApplicationTransfer()
        {
            DBReturn objReturn = new DBReturn();
            try
            {
                SqlParameter[] prm = new SqlParameter[7];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 3000) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@FromUser", SqlDbType.VarChar, 30) { Value = FromUserCode }; 
                prm[2] = new SqlParameter("@ToUser", SqlDbType.VarChar, 30) { Value = ToUserCode }; 
                prm[3] = new SqlParameter("@ToUserName", SqlDbType.VarChar, 99) { Value = ToUserName }; 
                prm[4] = new SqlParameter("@remaks", SqlDbType.VarChar, 250) { Value = Remarks };
                prm[5] = new SqlParameter("@ActionTakenByUser", SqlDbType.VarChar, 30) { Value = ActionTakenbyUser }; 
                prm[6] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 1);
                prm[6].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ApplicationTransfer", prm);
                objReturn.ErrMessage = prm[6].Value.ToString();
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);

            }
            return objReturn;

        }
        #endregion
	//============================NEw Code 1/05/2017
	public string LevelNo { get; set; }
	
	
	  public DataTable getChargetoTransferLevelWise()
	        {
	            DataTable dt = new DataTable();
	            SqlParameter[] prm = new SqlParameter[2];
	            prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar, 30) { Value = AuthCode };
	           // prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
	            prm[1] = new SqlParameter("@LevelNo", SqlDbType.VarChar, 10) { Value = LevelNo };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getChargetoTransferLevelWise", prm);
	            if (ds.Tables[0].Rows.Count > 0)
	            {
	                dt = ds.Tables[0];
	            }
	
	            return dt;
	        }
	
	 public DataTable GetLevel_SubServiceWise()
	        {
	            DataTable dt = new DataTable();
	            SqlParameter[] prm = new SqlParameter[1];
	            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 30) { Value = ServiceCode };
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetLevel_SubServiceWise", prm);
	            if (ds.Tables[0].Rows.Count > 0)
	            {
	                dt = ds.Tables[0];
	            }
	
	            return dt;
	        }
	
	   public DataTable getPendingApplicationToAnyLevel()
	        {
	            DataTable dt = new DataTable();
	            SqlParameter[] prm = new SqlParameter[3];
	            prm[0] = new SqlParameter("@Authority", SqlDbType.VarChar, 30) { Value = AuthCode };
	            prm[1] = new SqlParameter("@UserCode", SqlDbType.VarChar, 30) { Value = UserCode };
	            prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
	            //prm[3] = new SqlParameter("@LocalityId", SqlDbType.VarChar, 30) { Value =  Remarks};
	            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getPendingApplicationToAnyLevel", prm);
	            if (ds.Tables[0].Rows.Count > 0)
	            {
	                dt = ds.Tables[0];
	            }
	            return dt;
	        }
	
	 public DBReturn InsertApplicationTransferToAnyLevel()
	        {
	            DBReturn objReturn = new DBReturn();
	            try
	            {
	                SqlParameter[] prm = new SqlParameter[8];
	                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 3000) { Value = ApplicationNo };
	                prm[1] = new SqlParameter("@FromUser", SqlDbType.VarChar, 30) { Value = FromUserCode };
	                prm[2] = new SqlParameter("@ToUser", SqlDbType.VarChar, 30) { Value = ToUserCode };
	                prm[3] = new SqlParameter("@ToUserName", SqlDbType.VarChar, 99) { Value = ToUserName };
	                prm[4] = new SqlParameter("@remaks", SqlDbType.VarChar, 250) { Value = Remarks };
	                prm[5] = new SqlParameter("@ActionTakenByUser", SqlDbType.VarChar, 30) { Value = ActionTakenbyUser };
	                prm[6] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 1);
	                prm[6].Direction = ParameterDirection.Output;
	                prm[7] = new SqlParameter("@LevelNo", SqlDbType.VarChar, 10) { Value = LevelNo };
	                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ApplicationTransferToAnyLevel", prm);
	                objReturn.ErrMessage = prm[6].Value.ToString();
	            }
	            catch (Exception Ex)
	            {
	                MyExceptionHandler.HandleException(Ex);
	
	            }
	            return objReturn;
	
        }
	
    }
}