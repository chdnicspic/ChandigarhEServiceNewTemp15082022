using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EDistrictBL
{
    public class DispatchApplication
    {

        #region Properties
        public Int64 DispatchID { get; set; }
        public string ApplicationNo { get; set; }
        public string FinalCertificateNo { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string DispatchBy { get; set; }
        public string PostOfficeRegNo { get; set; }
        public string IsDeliver { get; set; }
        public string IPAddress { get; set; }
        public string DispatchByUser { get; set; }
        #endregion

        #region Function
      
      
       

        public DataTable GetCertificatedgeneratedApplication()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetCertificatedgeneratedApplication", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DataTable GetCertificateNOfromAppNO()
        {
            DataTable dt = new DataTable();
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetCertificateNOfromAppNO", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;
        }

        public DBReturn InsertDispatchApplicationDetail()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@FinalCertificateNo", SqlDbType.VarChar, 50) { Value = FinalCertificateNo };
            prm[2] = new SqlParameter("@DispatchDate", SqlDbType.DateTime) { Value = DispatchDate };
            prm[3] = new SqlParameter("@DispatchBy", SqlDbType.VarChar, 30) { Value = DispatchBy };
            prm[4] = new SqlParameter("@PostOfficeRegNo", SqlDbType.VarChar, 50) { Value = PostOfficeRegNo };
            prm[5] = new SqlParameter("@errmsg", SqlDbType.VarChar, 50);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
            prm[7] = new SqlParameter("@DispatchByUser", SqlDbType.VarChar, 15) { Value = DispatchByUser };
            prm[8] = new SqlParameter("@returncode", SqlDbType.VarChar, 50);
            prm[8].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertDispatchApplicationDetail", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            objReturn.ReturnCode = prm[8].Value.ToString();
            return objReturn;
        }
        #endregion


    }
}
