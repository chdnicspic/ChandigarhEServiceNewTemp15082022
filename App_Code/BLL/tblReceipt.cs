using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace EDistrictBL
{
    public class tblReceipt
    {

        #region Properties
        public Int64 Recieptid { get; set; }
        public string ReceiptNo { get; set; }
        public string ApplicationNo { get; set; }
        public string TempApplicationNo { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptGeneratedBy { get; set; }
        public string ReceiptGeneratedByOffice { get; set; }
        public Int32 ReceiptPrint { get; set; }
        public Int32 Receipt_Usertype { get; set; }
        public string ServiceCode { get; set; }
        public string SubServiceCode { get; set; }
        public string ServiceName { get; set; }
        public byte[] Barcode { get; set; }

        public DataTable ReceiptDetail { get; set; }
        
        #endregion

        #region Function
        public DBReturn InsertReceipt()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[10];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            prm[1] = new SqlParameter("@SubserviceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };
            prm[2] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
            prm[3] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Value = TotalAmount };
            prm[4] = new SqlParameter("@FeeDetail", SqlDbType.Structured) { Value = ReceiptDetail };
            prm[5] = new SqlParameter("@errmsg", SqlDbType.VarChar, 50);
            prm[5].Direction = ParameterDirection.Output;
            prm[6] = new SqlParameter("@UserLoggedin", SqlDbType.VarChar,15) { Value = ReceiptGeneratedBy };
            prm[7] = new SqlParameter("@Usertype", SqlDbType.Decimal) { Value = Receipt_Usertype };
            //prm[8] = new SqlParameter("@IsOptional", SqlDbType.Char, 1) { Value = IsOptional };
            prm[8] = new SqlParameter("@returncode", SqlDbType.VarChar, 50);

            prm[8].Direction = ParameterDirection.Output;
            prm[9] = new SqlParameter("@Barcode", SqlDbType.Image) { Value = Barcode };
            DataSet ds=SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "InsertServiceReceipt", prm);
            objReturn.ErrMessage = prm[5].Value.ToString();
            objReturn.ReturnCode = prm[8].Value.ToString();
            objReturn.DataSet = ds;
            
            return objReturn;
        }

        public DBReturn GenerateServiceReceipt()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ServiceCode", SqlDbType.VarChar, 8) { Value = ServiceCode };
            //prm[1] = new SqlParameter("@SubserviceCode", SqlDbType.VarChar, 8) { Value = SubServiceCode };
            prm[1] = new SqlParameter("@ApplicationNo", SqlDbType.VarChar, 50) { Value = ApplicationNo };
            //prm[3] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Value = TotalAmount };
            //prm[4] = new SqlParameter("@FeeDetail", SqlDbType.Structured) { Value = ReceiptDetail };
            //prm[5] = new SqlParameter("@errmsg", SqlDbType.VarChar, 50);
            //prm[5].Direction = ParameterDirection.Output;
            //prm[6] = new SqlParameter("@UserLoggedin", SqlDbType.VarChar, 15) { Value = ReceiptGeneratedBy };
            //prm[7] = new SqlParameter("@Usertype", SqlDbType.Decimal) { Value = Receipt_Usertype };
            ////prm[8] = new SqlParameter("@IsOptional", SqlDbType.Char, 1) { Value = IsOptional };
            //prm[8] = new SqlParameter("@returncode", SqlDbType.VarChar, 50);

            //prm[8].Direction = ParameterDirection.Output;
            //prm[9] = new SqlParameter("@Barcode", SqlDbType.Image) { Value = Barcode };
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GenerateServiceReceipt", prm);
            objReturn.DataSet = ds;

            return objReturn;
        }
        #endregion
    }


   
}
