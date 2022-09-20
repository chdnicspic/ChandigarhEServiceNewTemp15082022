using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EDistrictBL;

public class EdistrictReporting
{
    #region Properties
    public string ApplicationNo { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string ReportCode { get; set; }
    public string AuthorityCode { get; set; }
    #endregion

    public DataSet Get_ReverttoSmp_and_FinalApplications()
    {
        DataSet ds = new DataSet();
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[3];
        prm[0] = new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = StartDate };
        prm[1] = new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = EndDate };
        prm[2] = new SqlParameter("@ReportCode", SqlDbType.VarChar,50) { Value = ReportCode };
        ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "Get_ReverttoSmp_and_FinalApplications", prm);
        return ds;
    }

    public DataSet GetPendencyReportSummary()
    {
        DataSet ds = new DataSet();
        SqlParameter[] prm = new SqlParameter[1];
        prm[0] = new SqlParameter("@AuthorityCode", SqlDbType.VarChar,30) { Value = AuthorityCode };
        ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "getPendencyReportSummary", prm);
        return ds;
    }
}