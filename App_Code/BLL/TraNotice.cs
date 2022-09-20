using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDistrictBL
{
    public class TraNotice : traGeneralApplicationDetail
    {
        public Int64 NoticeId { get; set; }
        public Int64 ApplicationStatusId { get; set; }
        public string ApplicationNo { get; set; }
        public DateTime? NoticeGenerationDate { get; set; }
        public string NoticeMode { get; set; }
        public string NoticeGeneratedByAuthority { get; set; }
        public string NoticeGeneratedByUSer { get; set; }
        public byte[] NoticeDocumentBySender { get; set; }
        public string NoticeDocumentBySenderPath { get; set; }
        public string NoticeSentToDepartmentId { get; set; }
        public string NoticeSentToOfficeId { get; set; }
        public Int32 NoticeSentToDesignationCode { get; set; }
        public string NoticeSentToUserCode { get; set; }
        public Int32 MaximumPendancyPeriod { get; set; }
        public DateTime? MaximumPendencyDate { get; set; }
        public string NoticeReplied { get; set; }
        public string NoticeRemarks { get; set; }
        public byte[] NoticeRemarksSigned { get; set; }
        public DateTime? NoticeRepliedDate { get; set; }
        public byte[] NoticeUploadedDocument { get; set; }
        public string NoticeUploadedDocumentPath { get; set; }
        public string NoticeManualOfficeAddres { get; set; }
        public int Noticesntbyuserlevel { get; set; }
        public string NoticeNo { get; set; }
        public string ReplyLetterNo { get; set; }
        public string OlDNoticeNo { get; set; }
        //*************For Transaction Table***********//

        public string NoticeSenderRemarks { get; set; }
        public Int64 NoticeDSCId { get; set; }
        public Int64 ReplyDSCID { get; set; }
        public string NoticeDispatchNo { get; set; }
        public string CurrentuserLogin { get; set; }




        public string NoticeSentToDepartment { get; set; }
        public string NoticeSentToDesignation { get; set; }
        public Int64 NoticeReplyDSC { get; set; }
        public Int64 NoticeSentDSC { get; set; }
        public string LinkOfficer { get; set; }
        public DateTime? ReplyLetterdate { get; set; }

        //****************For Notice Log*********************//
        public string NoticeMovementFromDept { get; set; }
        public string NoticeMovementToDept { get; set; }
        public string NoticeMovementFromOffice { get; set; }
        public string NoticeMovementToOffice { get; set; }
        public Int32 NoticeMovementFromDesig { get; set; }
        public Int32 NoticeMovementToDesig { get; set; }





        public DBReturn inserNotice()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[19];

                prm[0] = new SqlParameter("@ApplicationStatusId", SqlDbType.BigInt) { Value = ApplicationStatusId };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

                prm[2] = new SqlParameter("@NoticeMode", SqlDbType.VarChar, 10) { Value = NoticeMode };
                prm[3] = new SqlParameter("@NoticeGeneratedByAuthority", SqlDbType.VarChar, 10) { Value = NoticeGeneratedByAuthority };

                prm[4] = new SqlParameter("@NoticeGeneratedByUSer", SqlDbType.VarChar, 15) { Value = NoticeGeneratedByUSer };
                prm[5] = new SqlParameter("@NoticeDocumentBySender", SqlDbType.Image) { Value = NoticeDocumentBySender };

                prm[6] = new SqlParameter("@NoticeDocumentBySenderPath", SqlDbType.VarChar, 2000) { Value = NoticeDocumentBySenderPath };
                prm[7] = new SqlParameter("@NoticeSentToDepartmentId", SqlDbType.Char, 5) { Value = NoticeSentToDepartmentId };

                prm[8] = new SqlParameter("@NoticeSentToOfficeId", SqlDbType.Char, 5) { Value = NoticeSentToOfficeId };
                prm[9] = new SqlParameter("@NoticeSentToDesignationCode", SqlDbType.Int) { Value = NoticeSentToDesignationCode };

                prm[10] = new SqlParameter("@NoticeSentToUserCode", SqlDbType.VarChar, 15) { Value = NoticeSentToUserCode };

                prm[11] = new SqlParameter("@NoticeManualOfficeAddres", SqlDbType.VarChar, 500) { Value = NoticeManualOfficeAddres };

                prm[12] = new SqlParameter("@Noticesntbyuserlevel", SqlDbType.Int) { Value = Noticesntbyuserlevel };
                prm[13] = new SqlParameter("@NoticeRemarks", SqlDbType.VarChar, 200) { Value = NoticeRemarks };


                prm[14] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[14].Direction = ParameterDirection.Output;
                prm[15] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[15].Direction = ParameterDirection.Output;
                prm[16] = new SqlParameter("@NoticeSentDSC", SqlDbType.BigInt) { Value = NoticeDSCId };
                prm[17] = new SqlParameter("@NoticeDispatchNo", SqlDbType.VarChar, 30) { Value = NoticeDispatchNo };
                prm[18] = new SqlParameter("@CurrentUserLogin", SqlDbType.VarChar, 15) { Value = CurrentuserLogin };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertNotice", prm);
                objReturn.ErrMessage = prm[14].Value.ToString();
                objReturn.ReturnCode = prm[15].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }

        }

        public DataSet GetNoticeDept(String ServiceCode)
        {
            DataSet DsReturn = new DataSet();
            try
            {
                SqlParameter[] prm = new SqlParameter[1];
                prm[0] = new SqlParameter("@servicecode", SqlDbType.VarChar, 8) { Value = ServiceCode };
                DsReturn = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "fetchNoticeDepartment", prm);

                return DsReturn;
            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return DsReturn;
            }

        }

        public DBReturn ReplyNotice()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[9];

                prm[0] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

                prm[2] = new SqlParameter("@ReplyRemarks", SqlDbType.VarChar, 8000) { Value = NoticeRemarks };
                prm[3] = new SqlParameter("@Attachment", SqlDbType.Image) { Value = NoticeUploadedDocument };

                prm[4] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[4].Direction = ParameterDirection.Output;
                prm[5] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[5].Direction = ParameterDirection.Output;
                prm[6] = new SqlParameter("@NoticeUploadPath", SqlDbType.VarChar, 2000) { Value = NoticeUploadedDocumentPath };
                prm[7] = new SqlParameter("@NoticeReplyDSC", SqlDbType.BigInt) { Value = ReplyDSCID };
                prm[8] = new SqlParameter("@ReplyLetterNo", SqlDbType.VarChar) { Value = ReplyLetterNo };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ReplyNotice", prm);
                objReturn.ErrMessage = prm[4].Value.ToString();
                objReturn.ReturnCode = prm[5].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }




        public byte[] GetNoticeSentDocument()
        {

            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
            prm[1] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeSentDocumentForView", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                b = (byte[])ds.Tables[0].Rows[0]["NoticeDocumentBySender"];

            }
            else
            {
                b = null;
            }
            return b;
        }

        public byte[] GetNoticeRepliedDocument()
        {

            Byte[] b = null;
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@NoticeNo", SqlDbType.VarChar, 30) { Value = NoticeNo };
            prm[1] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };

            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeRepliedDocumentForView", prm);

            if (ds == null)
            { }
            else
            {
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    b = (byte[])ds.Tables[0].Rows[0]["NoticeUploadedDocument"];

                }
                else
                {
                    b = null;
                }
            }
            return b;
        }

        public DataSet GetActiveNoticeNoforApplicationNo()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[1];

                prm[0] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetActiveNoticeNoforApplicationNo", prm);
                return ds;

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
                return new DataSet();
            }
        }




        public DBReturn insertNoticeNew()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[25];
                prm[0] = new SqlParameter("@CurrentUserLogin", SqlDbType.VarChar, 15) { Value = CurrentuserLogin };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@NoticeDocumentBySender", SqlDbType.Image) { Value = NoticeDocumentBySender };
                prm[3] = new SqlParameter("@NoticeDocumentBySenderPath", SqlDbType.VarChar, 2000) { Value = NoticeDocumentBySenderPath };
                prm[4] = new SqlParameter("@NoticeMode", SqlDbType.VarChar, 10) { Value = NoticeMode };
                prm[5] = new SqlParameter("@NoticeManualOfficeAddres", SqlDbType.VarChar, 500) { Value = NoticeManualOfficeAddres };
                prm[6] = new SqlParameter("@NoticeRemarks", SqlDbType.VarChar, 8000) { Value = NoticeRemarks };
                prm[7] = new SqlParameter("@NoticeDispatchNo", SqlDbType.VarChar, 30) { Value = NoticeDispatchNo };
                prm[8] = new SqlParameter("@NoticeSentToDepartmentId", SqlDbType.Char, 5) { Value = NoticeSentToDepartmentId };
                prm[9] = new SqlParameter("@NoticeSentToOfficeId", SqlDbType.Char, 5) { Value = NoticeSentToOfficeId };
                prm[10] = new SqlParameter("@NoticeSentToUserCode", SqlDbType.VarChar, 15) { Value = NoticeSentToUserCode };
                prm[11] = new SqlParameter("@NoticeSentDSC", SqlDbType.BigInt) { Value = NoticeDSCId };
                prm[12] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[12].Direction = ParameterDirection.Output;
                prm[13] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[13].Direction = ParameterDirection.Output;


                prm[14] = new SqlParameter("@NoticeSentToDesignation", SqlDbType.VarChar, 50) { Value = NoticeSentToDesignation };
                prm[15] = new SqlParameter("@NoticeSentToDesignationCode", SqlDbType.Int) { Value = NoticeSentToDesignationCode };
                prm[16] = new SqlParameter("@NoticeSentToDepartment", SqlDbType.VarChar, 100) { Value = NoticeSentToDepartment };
                prm[17] = new SqlParameter("@OlDNoticeNo", SqlDbType.VarChar, 30) { Value = OlDNoticeNo };

                prm[18] = new SqlParameter("@NoticeMovementFromDeptCode", SqlDbType.VarChar, 5) { Value = NoticeMovementFromDept };
                prm[19] = new SqlParameter("@NoticeMovementFromOfficeCode", SqlDbType.VarChar, 5) { Value = NoticeMovementFromOffice };
                prm[20] = new SqlParameter("@NoticeMovementFromDesig", SqlDbType.Int) { Value = NoticeMovementFromDesig };
                prm[21] = new SqlParameter("@NoticeMovementToDeptCode", SqlDbType.VarChar, 5) { Value = NoticeMovementToDept };
                prm[22] = new SqlParameter("@NoticeMovementToOfficeCode", SqlDbType.VarChar, 5) { Value = NoticeMovementToOffice };
                prm[23] = new SqlParameter("@NoticeMovementToDesig", SqlDbType.Int) { Value = NoticeMovementToDesig };
                prm[24] = new SqlParameter("@PendencyPeriodId", SqlDbType.Int) { Value = MaximumPendancyPeriod };






                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "insertNoticenew", prm);
                objReturn.ErrMessage = prm[12].Value.ToString();
                objReturn.ReturnCode = prm[13].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }

        public byte[] GetNoticeDocument()
        {
            Byte[] b = null;
            try
            {



                SqlParameter[] prm = new SqlParameter[2];
                prm[0] = new SqlParameter("@NoticeId", SqlDbType.BigInt) { Value = NoticeId };
                prm[1] = new SqlParameter("@AppNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetNoticeDocumentForView", prm);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    b = (byte[])ds.Tables[0].Rows[0]["NoticeDocument"];

                }
                else
                {
                    b = null;
                }

            }
            catch (Exception Ex)
            {
                MyExceptionHandler.HandleException(Ex);
            }
            return b;
        }

        public DBReturn insertReplyNew()
        {
            DBReturn objReturn = new DBReturn();
            try
            {

                SqlParameter[] prm = new SqlParameter[14];
                prm[0] = new SqlParameter("@CurrentUserLogin", SqlDbType.VarChar, 15) { Value = CurrentuserLogin };
                prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 30) { Value = ApplicationNo };
                prm[2] = new SqlParameter("@NoticeDocumentBySender", SqlDbType.Image) { Value = NoticeDocumentBySender };
                prm[3] = new SqlParameter("@NoticeDocumentBySenderPath", SqlDbType.VarChar, 2000) { Value = NoticeDocumentBySenderPath };
                prm[4] = new SqlParameter("@NoticeMode", SqlDbType.VarChar, 10) { Value = NoticeMode };
                prm[5] = new SqlParameter("@NoticeRemarks", SqlDbType.VarChar, 8000) { Value = NoticeRemarks };
                prm[6] = new SqlParameter("@NoticeDispatchNo", SqlDbType.VarChar, 30) { Value = NoticeDispatchNo };
                prm[7] = new SqlParameter("@NoticeSentDSC", SqlDbType.BigInt) { Value = NoticeDSCId };
                prm[8] = new SqlParameter("@ErrMsg", SqlDbType.VarChar, 50);
                prm[8].Direction = ParameterDirection.Output;
                prm[9] = new SqlParameter("@ReturnCode", SqlDbType.VarChar, 50);
                prm[9].Direction = ParameterDirection.Output;
                prm[10] = new SqlParameter("@OlDNoticeNo", SqlDbType.VarChar, 30) { Value = OlDNoticeNo };
                prm[11] = new SqlParameter("@NoticeMovementFromDeptCode", SqlDbType.VarChar, 5) { Value = NoticeMovementFromDept };
                prm[12] = new SqlParameter("@NoticeMovementFromOfficeCode", SqlDbType.VarChar, 5) { Value = NoticeMovementFromOffice };
                prm[13] = new SqlParameter("@NoticeMovementFromDesig", SqlDbType.Int) { Value = NoticeMovementFromDesig };
                SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "ReplyNoticenew", prm);
                objReturn.ErrMessage = prm[8].Value.ToString();
                objReturn.ReturnCode = prm[9].Value.ToString();
                return objReturn;

            }
            catch (Exception Ex)
            {
                // MyExceptionHandler.HandleException(Ex, "BL-LocalityMaster", "GetAllReligion");
                return objReturn;
            }
        }
    }
}
