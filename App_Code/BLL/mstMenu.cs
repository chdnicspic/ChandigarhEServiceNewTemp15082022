using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class mstMenu
    {
        #region My_Properties

        public Int32 MenuId { get; set; }
        public string MenuDesc { get; set; }
        public string NavigateUrl { get; set; }
        public Int32 MenuParentId { get; set; }
        public string MenuSecured { get; set; }
        public Int32 ModuleId { get; set; }
        public string ObjectType { get; set; }
        public Int32 OrderId { get; set; }
        public string MenuEnabled { get; set; }
        public string MenuVisible { get; set; }
        public DateTime? TransDate { get; set; }
        public Int32 UserId { get; set; }
        public string UserType { get; set; }
        public string ToolTip { get; set; }
        public string UserRole { get; set; }
        public string UserCode { get; set; }
        public string OfficeCode { get; set; }

        #endregion




        #region Function
        public DataSet GetMenuForUserType()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@UserId", SqlDbType.VarChar, 1) { Value = UserType };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetMenuByUserId", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }
            
        }
        public DataSet GetMenubyRoles()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = UserCode };
                prm[1] = new SqlParameter("@OfficeCOde", SqlDbType.VarChar, 5) { Value = OfficeCode };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetMenuByUserRole", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        #endregion
    }
}
