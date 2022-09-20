using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstofficeusermapping
    {

        #region Properties
        public string OfficeCode { get; set; }
        public Int32 DesigCode { get; set; }
        public string UserCode { get; set; }
        public DateTime? UserMapDate { get; set; }
        public DateTime? UserRelieveDate { get; set; }
        public string UserIsHead { get; set; }
        public string UserIsAdmin { get; set; }
        public string UserIsActive { get; set; }
        public string UserRole { get; set; }
        public string DeptCode { get; set; }
        public Int64  OfficeUserMappingId { get; set; }
        #endregion

        #region Function
      
        #endregion

        public DataTable GetDesignationWiseOfficeUsers()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
            prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetDesignationWiseOfficeUsers", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataTable GetPendingApplications(string UserCode)
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 5) { Value = UserCode };
          //  prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, "select * from TraGeneralApplicationDetail where pendingwith='" + UserCode.ToString() + "' and pendingwithlevel='1'", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DataTable GetOfficeWiseUsers()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetOfficeWiseUsers", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn Insertofficeusermapping()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.Char, 5) { Value = OfficeCode };
            prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            prm[2] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = UserCode };
            prm[3] = new SqlParameter("@UserRole", SqlDbType.Char, 1) { Value = UserRole };
            prm[4] = new SqlParameter("@UserIsActive", SqlDbType.Char, 1) { Value = UserIsActive };
            prm[5] = new SqlParameter("@ReturnCode", SqlDbType.Int);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@ErrMsg", SqlDbType.VarChar,50);
            prm[6].Direction = ParameterDirection.Output;
            prm[7] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = DeptCode };
            //prm[7] = new SqlParameter("@UserIsAdmin", SqlDbType.Char, 1) { Value = UserIsAdmin };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertofficeusermapping", prm);
            objReturn.ErrMessage = prm[6].Value.ToString();
            return objReturn;
        }

        public DataTable GetMappedOfficesForUser()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = UserCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetMappedOfficesForUser", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataTable GetMappedServiceForOffice()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 5) { Value = OfficeCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetMappedServiceForOffice", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }
        public DataTable GetMappingById()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@UserId", SqlDbType.BigInt) { Value = OfficeUserMappingId };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, "Select * from mstOfficeuserMapping where officeusermappingId=@UserId", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }



        public DBReturn updateDeptCode(string csvmappingId)
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@DeptCode", SqlDbType.Char, 5) { Value = DeptCode };
            prm[1] = new SqlParameter("@CSV", SqlDbType.VarChar,500) { Value = csvmappingId };
            
            prm[2] = new SqlParameter("@ReturnCode", SqlDbType.Int);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            //prm[7] = new SqlParameter("@UserIsAdmin", SqlDbType.Char, 1) { Value = UserIsAdmin };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "UpdateOfficeuserMapping_deptcode", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            return objReturn;
        }




        public DBReturn Updateofficeusermapping()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter("@OfficeCode", SqlDbType.Char, 5) { Value = OfficeCode };
            prm[1] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            prm[2] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = UserCode };
            prm[3] = new SqlParameter("@UserRole", SqlDbType.Char, 1) { Value = UserRole };
            prm[4] = new SqlParameter("@UserIsActive", SqlDbType.Char, 1) { Value = UserIsActive };
            prm[5] = new SqlParameter("@ReturnCode", SqlDbType.Int);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[6].Direction = ParameterDirection.Output;
            prm[7] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = DeptCode };
            prm[8] = new SqlParameter("@OfficeUsermappingId", SqlDbType.BigInt) { Value = OfficeUserMappingId };
            
            //prm[7] = new SqlParameter("@UserIsAdmin", SqlDbType.Char, 1) { Value = UserIsAdmin };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMUpdateofficeusermapping", prm);
            objReturn.ErrMessage = prm[6].Value.ToString();
            return objReturn;
        }
    }
}
