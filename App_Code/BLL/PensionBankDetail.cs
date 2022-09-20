using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EDistrictBL;

/// <summary>
/// Summary description for PensionBankDetail
/// </summary>
public class PensionBankDetail
{
	public PensionBankDetail()
	{
		
	}

    public DBReturn UpdatePensionAccountDetail()
    {
        DBReturn objReturn = new DBReturn();
        try
        {

            SqlParameter[] prm = new SqlParameter[8];

            prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
            prm[1] = new SqlParameter("@BankAccountNumber", SqlDbType.VarChar,50) { Value = BankAccountNumber };
            prm[2] = new SqlParameter("@BankName", SqlDbType.VarChar,100) { Value = BankName };
            prm[3] = new SqlParameter("@IFSCCode", SqlDbType.VarChar, 50) { Value = IFSCCode };
            
            prm[4] = new SqlParameter("@oprcode", SqlDbType.VarChar, 15) { Value = OprCode };

            //********************************

            prm[5] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[6].Direction = ParameterDirection.Output;
            prm[7] = new SqlParameter("@MachineIP", SqlDbType.VarChar, 30) { Value = HttpContext.Current.Request.UserHostAddress };



            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "updatePensionBankInfo", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            objReturn.ReturnCode = prm[6].Value.ToString();
            return objReturn;

        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
            return objReturn;
        }
    }

    public string ApplicationNo { get; set; }
    public string BankName { get; set; }
    public string BankAccountNumber { get; set; }
    public string IFSCCode { get; set; }
    public string OprCode { get; set; }
    

    
}