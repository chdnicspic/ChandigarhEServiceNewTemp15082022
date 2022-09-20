using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class AuthorityWorkFlow
    {
        #region MyProperties
        public string AuthorityCode { get; set; }
        public string ServiceCode { get; set; }
        public string Subservice { get; set; }
        public string LevelName { get; set; }
        public string LevelType { get; set; }
        public Int32 DesigCode { get; set; }
        public string UserCode { get; set; }
        public string LinkOfficer { get; set; }
        public string IsActive { get; set; }
        public DateTime? DeactiveDate { get; set; }
        public string DeactiveReason { get; set; }
        public DateTime? EntryDate { get; set; }
        public string IsLevelDSCEnabled { get; set; }
        public Int32 LevelNo { get; set; }
        public Int32 DaysLimit { get; set; }
        public string DealsWith { get; set; }
        public string  GenerateNotice { get; set; }
        public string UserDept { get; set; }
        public string Useroffice { get; set; }
        public string ServiceOwnerDept { get; set; }
        public string ServiceOwnerOfice { get; set; }

        //*************28/03/2015***************
        public string DesigName { get; set; }
        public string UserName { get; set; }
        public Int64 WorkflowId { get; set; }
        #endregion

        #region MyFunction
        public DBReturn InsertPortalUser()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[6];
            //prm[0] = new SqlParameter("@Email", SqlDbType.VarChar, 50) { Value = PortalUserEmail };
            //prm[1] = new SqlParameter("@Mobile", SqlDbType.VarChar, 10) { Value = PortalUserMobile };
            //prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            //prm[2].Direction = ParameterDirection.Output;
            //prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            //prm[3].Direction = ParameterDirection.Output;
            //prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = IPAddress };
            //prm[5] = new SqlParameter("@PortaluserPassword", SqlDbType.VarChar, 50) { Value = PortalUserPassword };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "PORTRegisterUser", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
        }
        #endregion




        public DBReturn SaveWorkFlowforAuthority()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[20];
            prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar, 10) { Value = AuthorityCode };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@SubService", SqlDbType.VarChar, 8) { Value = Subservice };
            prm[5] = new SqlParameter("@LevelName", SqlDbType.VarChar, 50) { Value = LevelName };
            prm[6] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            prm[7] = new SqlParameter("@UserCode", SqlDbType.VarChar,15) { Value = UserCode };
            prm[8] = new SqlParameter("@IsActive", SqlDbType.VarChar, 1) { Value = IsActive };
            prm[9] = new SqlParameter("@IsDSC", SqlDbType.VarChar, 1) { Value = IsLevelDSCEnabled };
            prm[10] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = LevelNo };
            prm[11] = new SqlParameter("@DaysLimit", SqlDbType.Int) { Value = DaysLimit };
            prm[12] = new SqlParameter("@DealsWith", SqlDbType.VarChar,1) { Value = DealsWith };
            prm[13] = new SqlParameter("@GenerateNotice", SqlDbType.VarChar, 1) { Value = GenerateNotice };
            prm[14] = new SqlParameter("@UserName", SqlDbType.VarChar, 50) { Value = UserName };
            prm[15] = new SqlParameter("@DesigName", SqlDbType.VarChar, 50) { Value = DesigName };
            prm[16] = new SqlParameter("@Officecode", SqlDbType.VarChar, 5) { Value = Useroffice };
            prm[17] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = UserDept };
            prm[18] = new SqlParameter("@ServiceOfficecode", SqlDbType.VarChar, 5) { Value = ServiceOwnerOfice };
            prm[19] = new SqlParameter("@ServiceDeptCode", SqlDbType.VarChar, 5) { Value = ServiceOwnerDept };

            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertWorkFlowEntry", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            return objReturn;
            
        }

        public DBReturn ModifyWorkFlowforAuthority(string Flag)
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[19];
            prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar, 10) { Value = AuthorityCode };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@SubService", SqlDbType.VarChar, 8) { Value = Subservice };
            prm[5] = new SqlParameter("@LevelName", SqlDbType.VarChar, 50) { Value = LevelName };
            prm[6] = new SqlParameter("@DesigCode", SqlDbType.Int) { Value = DesigCode };
            prm[7] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = UserCode };
            prm[8] = new SqlParameter("@IsActive", SqlDbType.VarChar, 1) { Value = IsActive };
            prm[9] = new SqlParameter("@IsDSC", SqlDbType.VarChar, 1) { Value = IsLevelDSCEnabled };
            prm[10] = new SqlParameter("@LevelNo", SqlDbType.Int) { Value = LevelNo };
            prm[11] = new SqlParameter("@DaysLimit", SqlDbType.Int) { Value = DaysLimit };
            
            prm[12] = new SqlParameter("@GenerateNotice", SqlDbType.VarChar, 1) { Value = GenerateNotice };
            
            prm[13] = new SqlParameter("@DesigName", SqlDbType.VarChar, 50) { Value = DesigName };
            prm[14] = new SqlParameter("@Officecode", SqlDbType.VarChar, 5) { Value = Useroffice };
            prm[15] = new SqlParameter("@DeptCode", SqlDbType.VarChar, 5) { Value = UserDept };
            prm[16] = new SqlParameter("@WorkFlowId", SqlDbType.BigInt) { Value = WorkflowId };
            prm[17] = new SqlParameter("@WorkflowFlag", SqlDbType.VarChar, 1) { Value = Flag };
            prm[18] = new SqlParameter("@UserName", SqlDbType.VarChar, 50) { Value = UserName };

            DataSet Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ModifyWorkFlowForAuthorityService", prm);
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
            if (Ds.Tables.Count > 0)
            {
                objReturn.DataTable = Ds.Tables[0];
            }
            return objReturn;


        }




        public DataTable GetWorkFlowForAuthorityService()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar, 10) { Value = AuthorityCode };
            prm[1] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[2] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value = Subservice };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetWorkFlowForAuthorityService", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }
       
    }
}
