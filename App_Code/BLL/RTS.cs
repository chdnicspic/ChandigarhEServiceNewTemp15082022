using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EDistrictBL;
using System.Data.SqlClient;

/// <summary>
/// Summary description for RTS
/// </summary>
public class RTS
{
    public string ServiceCode { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
	public RTS()
	{
		//
		// TODO: Add constructor logic here
		//
        

	}
    public DataSet LoadRTS()
    {
        DataSet dt = new DataSet();
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[3];
        prm[0] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = ServiceCode };
        prm[1] = new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = FromDate };
        prm[2] = new SqlParameter("@todate", SqlDbType.DateTime) { Value = ToDate };
        DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "LoadRTS", prm);

        return ds;
    }
}