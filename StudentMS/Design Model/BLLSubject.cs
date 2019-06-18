using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentMS.Design_Model
{
    public class BLLSubject
    {
        private DBConn db = new DBConn();
        private DataTable dt = null;

        //查询所有科目类别
        public DataTable GetSubjectName()
        {
            dt = new DataTable();
            string strError = "";
            string sqlquery = "select * from Subject";
            dt = db.DBExcuteDataTable(sqlquery, out strError);
            return dt;
        }

        //根据科目类别名称查询科目类别编号
        public int GetSubjectID(string subjectName)
        {
            string strError = "";
            string sqlquery = "select SubjectID from Subject where SubjectName=@subjectName";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@subjectName", subjectName);
            int subjectid = Convert.ToInt32(db.DBExecuteSalar(sqlquery, sps, out strError));
            return subjectid;
        }
    }
}