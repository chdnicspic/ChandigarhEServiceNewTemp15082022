using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EDistrictBL;

/// <summary>
/// Summary description for SamparkReporting
/// </summary>
public class SamparkReporting
{

    #region MyProperties
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string OfficeCode { get; set; }
    #endregion
    public SamparkReporting()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public DataSet SamparkDateRangeRegister()
    {
        DataSet ds = new DataSet();
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[3];
        prm[0] = new SqlParameter("@FromDate", SqlDbType.DateTime) { Value = FromDate };
        prm[1] = new SqlParameter("@ToDate", SqlDbType.DateTime) { Value = ToDate };
        prm[2] = new SqlParameter("@OfficeCode", SqlDbType.VarChar,5) { Value = OfficeCode };


        ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SamparkDateRangeRegister", prm);

        return ds;

    }
}