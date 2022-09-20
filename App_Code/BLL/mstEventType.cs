using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EDistrictBL
{
   public class mstEventType
    {
       public string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string eventname;

        public string Eventname
        {
            get { return eventname; }
            set { eventname = value; }
        }
        public DateTime Activationdate;

        public DateTime Activationdate1
        {
            get { return Activationdate; }
            set { Activationdate = value; }
        }
        public string EventisActive { get; set; }
        public DBReturn InsertEventDetail()
        {
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@EventId", SqlDbType.VarChar, 50) { Value = Id };
            prm[1] = new SqlParameter("@EventName", SqlDbType.VarChar, 15) { Value = Eventname };
            prm[2] = new SqlParameter("@EventisActive", SqlDbType.Char, 1) { Value =  EventisActive };
            prm[3] = new SqlParameter("@errorCode", SqlDbType.Int);
            prm[3].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "mstInsertEventType", prm);
            objReturn.ErrMessage = prm[3].Value.ToString();
            return objReturn;
        }
        public DataTable GetAllEvents()
        {
            DataTable dt = new DataTable();
            DBReturn objReturn = new DBReturn();
            SqlParameter[] prm = new SqlParameter[0];
            DataSet ds = SqlHelper.ExecuteDataset(SQLHelperConnection.ConnStringDefault, CommandType.StoredProcedure, "GetAllEvents", prm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            return dt;

        }

       
    }
}
