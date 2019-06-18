using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentMS.Design_Model
{
   public class BLLScore
    {
        private DBConn db = new DBConn();

        //添加成绩信息
        public int AddScore(ModelScore ms)
        {
            string strError = "";
            string sqlcmd = "insert into Score values(@CourseID,@StudentID,@Score)";
            SqlParameter[] sps = new SqlParameter[3];
            sps[0] = new SqlParameter("@CourseID", ms.CourseID);
            sps[1] = new SqlParameter("@StudentID", ms.StudentID);
            sps[2] = new SqlParameter("@Score", ms.Score);
            int x = db.DBExecuteNonQuery(sqlcmd, sps, out strError);
            return x;
        }
    }
}