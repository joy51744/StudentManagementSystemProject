using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentMS.Design_Model
{
    public class BLLStudent
    {
        private DBConn db = new DBConn();
        private DataTable dtStudent = null;

        public DataTable GetStudentInfoClassID(int classID)
        {
            dtStudent = new DataTable();
            string strError = "";
            string sqlquery = "select BatchID,StudentNo,StudentName,Gender,Birthday,StudentDep from Student where ClassID = @classID";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@classID", classID);
            dtStudent = db.DBExcuteDataTable(sqlquery, sps, out strError);
            return dtStudent;
        }

        public DataTable GetStudentInfoStudentID(int studentID)
        {
            dtStudent = new DataTable();
            return dtStudent;
        }

        public int AddStudent(ModelStudent ms)
        {
            string strError = "";
            string sqlquery = "insert into Student values(@batchID,@studentNo,@studentName,@gender,@birthday,@classID,@studentDep)";
            SqlParameter[] sps = new SqlParameter[7];
            sps[0] = new SqlParameter("@batchID", ms.BatchID);
            sps[1] = new SqlParameter("@studentNo", ms.StudentNo);
            sps[2] = new SqlParameter("@studentName", ms.StudentName);
            sps[3] = new SqlParameter("@gender", ms.Gender);
            sps[4] = new SqlParameter("@birthday", ms.Birthday);
            sps[5] = new SqlParameter("@classID", ms.ClassID);
            sps[6] = new SqlParameter("@studentDep", ms.StudentDep);
            int x = db.DBExecuteNonQuery(sqlquery, sps, out strError);
            return x;
        }

        public int UpdateStudentInfo(int clsid, ModelStudent ms)
        {
            string strError = "";
            string sqlquery = "update Student set BatchID=@batchID,StudentName=@studentName,Gender=@gender,Birthday=@birthday,ClassID=@classID,StudentDep=@studentDep where StudentNo=@studentno";
            SqlParameter[] sps = new SqlParameter[7];
            sps[0] = new SqlParameter(@"batchID", ms.BatchID);
            sps[1] = new SqlParameter("@studentName", ms.StudentName);
            sps[2] = new SqlParameter("@gender", ms.Gender);
            sps[3] = new SqlParameter("@birthday", ms.Birthday);
            sps[4] = new SqlParameter("@classID", ms.ClassID);
            sps[5] = new SqlParameter("@studentDep", ms.StudentDep);
            sps[6] = new SqlParameter("@studentNo", ms.StudentNo);
            int x = db.DBExecuteNonQuery(sqlquery, sps, out strError);
            return x;
        }

        public int GetStudentIDStudentNo(string studentNo)
        {
            string strError = "";
            string sqlquery = "select StudentID from Student where StudentNo= @studentNo";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@studentNo", studentNo);
            int studentID = Convert.ToInt32(db.DBExecuteSalar(sqlquery, sps, out strError));
            return studentID;
        }
    }
}