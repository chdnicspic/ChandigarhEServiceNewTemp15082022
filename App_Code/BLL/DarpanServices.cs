using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EDistrictBL;

/// <summary>
/// Summary description for DarpanServices
/// </summary>
public class DarpanServices
{
	public DarpanServices()
	{
		//
		// TODO: Add constructor logic here
		//
    }

    public DataTable DarpanDMDashCaption()
    {
        DataTable dt = new DataTable();
        
        SqlParameter[] prm = new SqlParameter[0];
        //prm[0] = new SqlParameter("@officeCode", SqlDbType.VarChar, 30) { Value = OfficeCode };
        //prm[1] = new SqlParameter("@serviceCode", SqlDbType.VarChar, 15) { Value = serviceCode };
        //prm[2] = new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = FromDate };
        //prm[3] = new SqlParameter("@todate", SqlDbType.DateTime) { Value = ToDate };
        //prm[4] = new SqlParameter("@returnCode", SqlDbType.Int);
        //prm[4].Direction = ParameterDirection.Output;

        DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "DarpanDMDashCaption", prm);

        return ds.Tables[0];
    }


}