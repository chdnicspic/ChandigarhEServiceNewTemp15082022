using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDistrictBL;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Feedback
/// </summary>
public class Feedback
{
    public Int64 OtpId { get; set; }
    public string MobileNumber { get; set; }
    public string OtpContent { get; set; }
    public DateTime? SentDate { get; set; }
    public string OTPUsed { get; set; }
    public string OTPRequestIP { get; set; }
    public string OTP { get; set; }



    public Int64 FeedBackId { get; set; }
    public Int32 Rating { get; set; }
    public string FeedbackContent { get; set; }
    public DateTime? FeedbackDate { get; set; }
    

	public Feedback()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DBReturn GenerateOTP()
    {
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[6];
        prm[0] = new SqlParameter("@OTP", SqlDbType.VarChar, 50) { Value = OTP };
        prm[1] = new SqlParameter("@OTPContent", SqlDbType.VarChar, 50) { Value = OtpContent };
        prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        prm[2].Direction = ParameterDirection.Output;
        prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        prm[3].Direction = ParameterDirection.Output;
        prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress};
        prm[5] = new SqlParameter("@Mobile", SqlDbType.VarChar, 10) { Value = MobileNumber };
        
        objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateFeedBackOTP", prm);
        objReturn.ErrMessage = prm[2].Value.ToString();
        objReturn.ReturnCode = prm[3].Value.ToString();
        return objReturn;
    }

    public DBReturn SaveFeedBack()
    {
        DBReturn objReturn = new DBReturn();
        SqlParameter[] prm = new SqlParameter[7];
        prm[0] = new SqlParameter("@rating", SqlDbType.Int) { Value = Rating };
        prm[1] = new SqlParameter("@FeedBack", SqlDbType.VarChar, 250) { Value = FeedbackContent };
        prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
        prm[2].Direction = ParameterDirection.Output;
        prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
        prm[3].Direction = ParameterDirection.Output;
        prm[4] = new SqlParameter("@IPAddress", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };
        prm[5] = new SqlParameter("@Otp", SqlDbType.VarChar, 6) { Value = OTP };
        prm[6] = new SqlParameter("@Mobile", SqlDbType.VarChar, 10) { Value = MobileNumber };
        objReturn.DataSet = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "SaveFeedBack", prm);
        objReturn.ErrMessage = prm[2].Value.ToString();
        objReturn.ReturnCode = prm[3].Value.ToString();
        return objReturn;
    }

}