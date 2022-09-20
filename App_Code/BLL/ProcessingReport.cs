using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDistrictBL;

/// <summary>
/// Summary description for ProcessingReport
/// </summary>
public class ProcessingReport
{


    public DateTime? FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string userCode { get; set; }
    public string ServiceCode { get; set; }

	public ProcessingReport()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable GetProcessingData()
    {
        DataTable dt = new DataTable();
        try
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = FromDate };
            prm[1] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = ToDate };
            prm[2] = new SqlParameter("@UserCode", SqlDbType.VarChar, 15) { Value = userCode };
            prm[3] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetProcessingDataUserWise", prm);
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

     
}