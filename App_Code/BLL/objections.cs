using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for objections
/// </summary>
/// 
namespace EDistrictBL
{
    public class objections
    {
        public objections()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region properties
        public string ServiceCode { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicantName { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string GeneratedBy { get; set; }
        public string OfficeCode { get; set; }
        public int ApplicationType { get; set; }

        public string PersonLoggedIn { get; set; }
        #endregion

	 public System.Data.DataSet GetAllObjectionApplicationForuser()
        {
            DataSet dt = new DataSet();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[9];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 50) { Value = ApplicantName };
                prm[3] = new SqlParameter("@FatherName", SqlDbType.VarChar, 50) { Value = FatherName };
                prm[4] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50) { Value = Mobile };
                prm[5] = new SqlParameter("@GeneratedBy", SqlDbType.VarChar, 50) { Value = GeneratedBy };
                prm[6] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 50) { Value = OfficeCode };
                prm[7] = new SqlParameter("@ApplicationType", SqlDbType.Int) { Value = ApplicationType };
                prm[8] = new SqlParameter("@PersonLoggedIn", SqlDbType.VarChar,15) { Value = PersonLoggedIn };
                //prm[4].Direction = ParameterDirection.Output;

                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllobjectionApplicationForUser", prm);

                return ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
            }
            return dt;
        }

        public System.Data.DataSet GetAllObjectionApplication()
        {
            DataSet dt = new DataSet();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[8];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 50) { Value = ServiceCode };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@ApplicantName", SqlDbType.VarChar, 50) { Value = ApplicantName };
                prm[3] = new SqlParameter("@FatherName", SqlDbType.VarChar, 50) { Value = FatherName };
                prm[4] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50) { Value = Mobile };
                prm[5] = new SqlParameter("@GeneratedBy", SqlDbType.VarChar, 50) { Value = GeneratedBy };
                prm[6] = new SqlParameter("@OfficeCode", SqlDbType.VarChar, 50) { Value = OfficeCode };
                prm[7] = new SqlParameter("@ApplicationType", SqlDbType.Int) { Value = ApplicationType };
                //prm[4].Direction = ParameterDirection.Output;

                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllobjectionApplication", prm);

                return ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
            }
            return dt;
        }
    }
}