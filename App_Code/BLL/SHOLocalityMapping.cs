using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EDistrictBL;

/// <summary>
/// Summary description for SHOLocalityMapping
/// </summary>
public class SHOLocalityMapping
{

    public Int64 MappingId { get; set; }
    public string NewUser { get; set; }
    public string LoginUser { get; set; }
	public SHOLocalityMapping()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public System.Data.DataSet GetShoMappingDetail()
    {
        DataSet Ds = new DataSet();
        try
        {
            SqlParameter[] prm = new SqlParameter[1];
            //prm[0] = new SqlParameter("@UserId", SqlDbType.VarChar, 1) { Value = UserType };
            Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, "Select MappingId,S.UserCode,LocalityId,UserName,UserMobile,LocalityName + '-'+O.Officename as localityName ,Loginname,AreaID from mstsholocalitymapping S inner join mstuser U on S.userCode=U.UserCode inner join mstLocality L on S.LocalityId=L.LocalityCode inner join mstOfficeUserMapping M on S.UserCode=M.UserCode and M.DesigCode=16 and M.userisactive='Y' inner join mstOffice O on M.OfficeCode=O.OfficeCode  and O.OfficeDeptCode='D0008' order by 4", prm);
            return Ds;
        }
        catch (Exception Ex)
        {

            MyExceptionHandler.HandleException(Ex);
            return Ds;
        }
    }

    public System.Data.DataSet GetActiveSHODetail()
    {
        DataSet Ds = new DataSet();
        try
        {
            SqlParameter[] prm = new SqlParameter[1];
            //prm[0] = new SqlParameter("@UserId", SqlDbType.VarChar, 1) { Value = UserType };
            Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.Text, " Select distinct U.UserCode,UserName+ ' ('+A.OfficeName+')' as userName,A.Officename from mstUser U Inner join  mstOfficeUserMapping O on U.Usercode=O.UserCode and O.DesigCode=16 and O.UserIsActive='Y' inner join mstOffice A on A.OfficeCode=O.OfficeCode and A.OfficeDeptCode='D0008' order by A.OfficeName", prm);
            return Ds;
        }
        catch (Exception Ex)
        {

            MyExceptionHandler.HandleException(Ex);
            return Ds;
        }
    }

    public DBReturn UpdateMappingUser()
    {
        DBReturn objReturn = new DBReturn();
        try
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@MappingId", SqlDbType.Int) { Value = MappingId };
            prm[1] = new SqlParameter("@NewUser", SqlDbType.VarChar, 10) { Value = NewUser };
            prm[2] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
            prm[2].Direction = ParameterDirection.Output;
            prm[3] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
            prm[3].Direction = ParameterDirection.Output;
            prm[4] = new SqlParameter("@LoginUser", SqlDbType.VarChar, 10) { Value = LoginUser };
            DataSet Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure,"UpdateShoLocalityMapping" , prm);
            objReturn.DataSet = Ds;
            objReturn.ErrMessage = prm[2].Value.ToString();
            objReturn.ReturnCode = prm[3].Value.ToString();
        }
        catch (Exception Ex)
        {

            MyExceptionHandler.HandleException(Ex);

        }
        
        return objReturn;
        

    }
}