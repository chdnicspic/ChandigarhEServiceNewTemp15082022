using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDistrictBL;
using System.Data.SqlClient;
using System.Data;

namespace EDistrictBL
{
    public class ServiceNoticeInfo : TraNotice 
    {


        public DataSet GetNoticeInfoForIncome()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeInfoForIncome", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }

        public DataSet GetNoticeInfoForCaste()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeInfoForCaste", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetNoticeInfoForSound()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeInfoForSound", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
        public DataSet GetNoticeInfoForEvent()
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[1] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
                Ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeInfoForEvent", prm);
                return Ds;
            }
            catch (Exception Ex)
            {

                MyExceptionHandler.HandleException(Ex);
                return Ds;
            }

        }
    }
}
