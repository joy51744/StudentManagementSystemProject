using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentMS.Design_Model
{
   public class BLLClass
    {
        private DBConn db = new DBConn();
        private DataTable dt = null;

        public DataTable GetClassName()
        {
            dt = new DataTable();
            string strError = "";
            string sqlcmd = "select * from Class";
            dt = db.DBExcuteDataTable(sqlcmd, out strError);
            return dt;
        }

        public int AddClass(ModelClass mc)
        {
            string strError = "";
            string sqlcmd = "insert into Class values(@batchID,@className,@entranceDate,@finishDate,@remark)";
            SqlParameter[] sps = new SqlParameter[5];
            sps[0] = new SqlParameter("@batchID", mc.BatchID);
            sps[1] = new SqlParameter("@className", mc.ClassName);
            sps[2] = new SqlParameter("@entranceDate", mc.EntranceDate);
            sps[3] = new SqlParameter("@finishDate", mc.ClassName);
            sps[4] = new SqlParameter("@remark", mc.Remark);
            int x = db.DBExecuteNonQuery(sqlcmd, sps, out strError);
            return x;
        }

        public int GetClassIDClassName(string className)
        {
            string strError = "";
            string sqlcmd = "select ClassID from Class where ClassName=@className";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@className", className);
            int x = Convert.ToInt32(db.DBExecuteSalar(sqlcmd, sps, out strError));
            return x;
        }
    }
}