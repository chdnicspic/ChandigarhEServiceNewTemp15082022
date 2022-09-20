using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EDistrictBL
{
    public class mstService
    {
        #region MyProperties
       
        public string serviceCode { get; set; }
        public string serviceName { get; set; }
        public string serviceCategory { get; set; }
        public string serviceActive { get; set; }
        public DateTime? serviceStartDate { get; set; }
        public DateTime? serviceEndDate { get; set; }
        public string updatedBY { get; set; }
        public string documentsrequired { get; set; }
        public string subserviceCode { get; set; }
        public string subserviceName { get; set; }
        public int DeliveryDays { get; set; }
        
        #endregion

        #region MyFunction
        public DataTable GetAllService()
        {
            DataTable dt = new DataTable();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[0];
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllService", prm);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return dt;
            }
            finally
            {
                dt.Dispose();
            }
            

        }

        public DBReturn Insertservice()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = serviceCode };
            prm[1] = new SqlParameter("@ServiceName", SqlDbType.VarChar, 50) { Value = serviceName };
            prm[2] = new SqlParameter("@ServiceCategory", SqlDbType.VarChar, 50) { Value = serviceCategory };
            prm[3] = new SqlParameter("@ServiceActive", SqlDbType.Char, 1) { Value = serviceActive };
            prm[4] = new SqlParameter("@Documentsrequired", SqlDbType.Char, 1) { Value = documentsrequired };
            prm[5] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@updatedBY", SqlDbType.VarChar, 15) { Value = updatedBY };
            prm[7] = new SqlParameter("@DeliveryDays", SqlDbType.Int) { Value = DeliveryDays };
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertService", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            return objReturn;
        }
        public DBReturn InsertSubService()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = serviceCode };
            prm[1] = new SqlParameter("@SubServiceCode", SqlDbType.VarChar, 8) { Value =subserviceCode };
            prm[2] = new SqlParameter("@subserviceName", SqlDbType.VarChar, 50) { Value = subserviceName };
            prm[3] = new SqlParameter("@DeliveryDays", SqlDbType.Int) { Value = DeliveryDays };
            prm[4] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[4].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertSubService", prm);
            objReturn.ErrMessage = prm[4].Value.ToString();
            return objReturn;
        }
        public DataTable GetSubServiceForService()
        {
            DataTable dt = new DataTable();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = serviceCode };
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetSubServiceByServiceCode", prm);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return dt;
            }
            finally
            {
                dt.Dispose();
            }


        }
        public DataTable GetAllServiceDetail()
        {
            DataTable dt = new DataTable();
            try
            {

                DBReturn objReturn = new DBReturn();
                SqlParameter[] prm = new SqlParameter[0];
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllService", prm);
                if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    dt = ds.Tables[1];
                }
                return dt;
            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return dt;
            }
            finally
            {
                dt.Dispose();
            }


        }
        #endregion
        }
      

    }
      

