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
public class PensionData
{
    public string ServiceCode { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public int PLAOLDAge { get; set; }
    public int PLAdisabled { get; set; }
    public int PlaWidow { get; set; }
    public PensionData()
	{
		//
		// TODO: Add constructor logic here
		//
        

	}
    public DataSet LoadpensionData()
    {
        DataSet dt = new DataSet();
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[5];
        //prm[0] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = ServiceCode };
        prm[0] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = FromDate };
        prm[1] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = ToDate };
        prm[2] = new SqlParameter("@PLAOLD", SqlDbType.Int) { Value = PLAOLDAge };
        prm[3] = new SqlParameter("@PLA_DISABLED", SqlDbType.Int) { Value = PLAdisabled };
        prm[4] = new SqlParameter("@PLA_Widow", SqlDbType.Int) { Value = PlaWidow };
        DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetPensionData", prm);

        return ds;
    }
}