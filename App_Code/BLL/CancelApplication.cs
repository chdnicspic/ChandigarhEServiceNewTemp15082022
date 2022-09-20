using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDistrictBL;


/// <summary>
/// Summary description for CancelApplication
/// </summary>
public class CancelApplication
{
    public string ApplicationNo { get; set; }
    public string Remarks { get; set; }
    public string ActionPerformed { get; set; }
    public byte[] FinalNotingFile { get; set; }
    public string FinalNotingPath { get; set; }
    public string IPAddress { get; set; }
    public int FromLevel { get; set; }
    public string LogUserId { get; set; }
    public Int64 DSCID { get; set; }
    public string FinalNotepath { get; set; }
    public Int64 NotingDSCId { get; set; }

    public string ReRecomend { get; set; }
    public int CancelProcessStatus { get; set; }

	public CancelApplication()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public System.Data.DataSet GetFileStatus()
    {
        DataSet dt = new DataSet();
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[2];
        prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
        prm[1] = new SqlParameter("@UserLoggedIn", SqlDbType.VarChar, 15) { Value = LogUserId };

        DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetApplicationDetailForCancelCertificate", prm);

        return ds;
    }


    public DBReturn SaveCancelFileApplication()
    {
        DBReturn objReturn = new DBReturn();
        try
        {
            SqlParameter[] prm = new SqlParameter[11];
            prm[0] = new SqlParameter("@Remarks", SqlDbType.VarChar, 2000) { Value = Remarks };
            prm[1] = new SqlParameter("@ActionPerformed", SqlDbType.VarChar, 10) { Value = ActionPerformed };
            prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            prm[3] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[4].Direction = ParameterDirection.Output;
            prm[5] = new SqlParameter("@IpAddress", SqlDbType.VarChar, 20) { Value = IPAddress };
            prm[6] = new SqlParameter("@UploadDocument", SqlDbType.Image) { Value = FinalNotingFile };
            prm[7] = new SqlParameter("@LoginUserId", SqlDbType.VarChar, 15) { Value = LogUserId };
            prm[8] = new SqlParameter("@DSCID", SqlDbType.BigInt) { Value = DSCID };
            prm[9] = new SqlParameter("@Certpath", SqlDbType.VarChar, 2000) { Value = FinalNotingPath };
            prm[10] = new SqlParameter("@CancelProcessStatus", SqlDbType.Int) { Value = CancelProcessStatus };
            //prm[12] = new SqlParameter("@CurrentLoginUser", SqlDbType.VarChar, 15) { Value = CurrentLoggedInUser };


            SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "CancelCertificate", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            objReturn.ReturnCode = prm[4].Value.ToString();
            return objReturn;
        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
        }
        return objReturn;


    }
}