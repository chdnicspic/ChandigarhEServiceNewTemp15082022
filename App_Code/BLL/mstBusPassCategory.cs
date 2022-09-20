using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
  public  class mstBusPassCategory
  {
      #region Properties
      public string BusPassCategory { get; set; }
      public string BusPassPassengerCategory { get; set; }
      public string IsActive { get; set; }
      public string Nature { get; set; }
      public string Area { get; set; }
      public decimal Rate { get; set; }
      public string Info { get; set; }
      public string DurationOfPass { get; set; }
      #endregion

      #region Function

      public DBReturn InsertBusPassCategory()
      {
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[9];
          prm[0] = new SqlParameter("@BusPassCategory", SqlDbType.VarChar, 50) { Value = BusPassCategory };
          prm[1] = new SqlParameter("@BusPassPassengerCategory", SqlDbType.VarChar, 250) { Value = BusPassPassengerCategory };
          prm[2] = new SqlParameter("@IsActive", SqlDbType.Char, 1) { Value = IsActive };
          prm[3] = new SqlParameter("@Nature", SqlDbType.VarChar, 15) { Value = Nature };
          prm[4] = new SqlParameter("@Area", SqlDbType.VarChar, 50) { Value = Area };
          prm[5] = new SqlParameter("@Rate", SqlDbType.Decimal ) { Value = Rate };
          prm[6] = new SqlParameter("@Info", SqlDbType.VarChar, 500) { Value = Info };
          prm[7] = new SqlParameter("@DurationOfPass", SqlDbType.VarChar, 50) { Value = DurationOfPass };
          prm[8] = new SqlParameter("@errorCode", SqlDbType.Int);
          prm[8].Direction = ParameterDirection.Output;
          SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ADMInsertBusPassCategory", prm);
          objReturn.ErrMessage = prm[8].Value.ToString();
          return objReturn;
      }

      public DataTable GetAllBusPassCategory()
      {
          DataTable dt = new DataTable();
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[0];
          DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllBusPassCategory", prm);
          if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
          {
              dt = ds.Tables[0];
          }
          return dt;

      }

      public DataTable GetUniqueBusPassCategory()
      {
          DataTable dt = new DataTable();
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[0];
          DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllBusPassCategory", prm);
          if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
          {
              dt = ds.Tables[1];
          }
          return dt;

      }

      public DataTable GetUniqueBusPassNature()
      {
          DataTable dt = new DataTable();
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[0];
          DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllBusPassCategory", prm);
          if (ds.Tables.Count > 0 && ds.Tables[2].Rows.Count > 0)
          {
              dt = ds.Tables[2];
          }
          return dt;

      }

      public DataTable GetBusPassPassengerCategoryForBusPassCategory()
      {
          DataTable dt = new DataTable();
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[1];
          prm[0] = new SqlParameter("@BusPassCategory", SqlDbType.VarChar, 50) { Value = BusPassCategory };
          DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetBusPassPassengerCategoryForBusPassCategory", prm);
          if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
          {
              dt = ds.Tables[0];
          }
          return dt;

      }

      public DataTable GetBusPassFeesforoneMonthDuration()
      {
          DataTable dt = new DataTable();
          DBReturn objReturn = new DBReturn();
          SqlParameter[] prm = new SqlParameter[3];
          prm[0] = new SqlParameter("@BusPassCategory", SqlDbType.VarChar, 50) { Value = BusPassCategory };
          prm[1] = new SqlParameter("@BusPassPassengerCategory", SqlDbType.VarChar, 250) { Value = BusPassPassengerCategory };
          prm[2] = new SqlParameter("@Nature", SqlDbType.VarChar, 15) { Value = Nature };
          DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetBusPassFeesforoneMonthDuration", prm);
          if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
          {
              dt = ds.Tables[0];
          }
          return dt;

      }
     

      #endregion


  }
}
