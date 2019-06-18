using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentMS.Design_Model
{
    public class BLLCourse
    {
        private DBConn db = new DBConn();
        private DataTable dtCourse = null;

        public DataTable GetCourseInfoClassID(int classID)
        {
            dtCourse = new DataTable();
            string strError = "";
            string sqlcmd = "select * from Course where ClassID = @classID";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@classID", classID);
            dtCourse = db.DBExcuteDataTable(sqlcmd, sps, out strError);
            return dtCourse;
        }

        //查询成绩信息
        public DataTable GetCourseAll()
        {
            dtCourse = new DataTable();
            string strError = "";
            string sqlcmd = "select (select StudentName from Student where StudentID = Score.StudentID) as StudentName, (select ClassName from Class where ClassID=Course.ClassID) as ClassName, Course.CourseName,Score.Score from Course,Score where Course.CourseID=Score.CourseID";
            dtCourse = db.DBExcuteDataTable(sqlcmd, out strError);
            return dtCourse;
        }

        //插入课程信息
        public int AddCourseInfo(ModelCourse mc)
        {
            string strError = "";
            string sqlcmd = "insert into Course values(@courseName,@classID,@subjectID,@beginDate,@finishDate)";
            SqlParameter[] sps = new SqlParameter[5];
            sps[0] = new SqlParameter("@courseName", mc.CourseName);
            sps[1] = new SqlParameter("@ClassID", mc.ClassID);
            sps[2] = new SqlParameter("@subjectID", mc.SubjectID);
            sps[3] = new SqlParameter("@beginDate", mc.BeginDate);
            sps[4] = new SqlParameter("@finishDate", mc.FinishDate);
            int x = db.DBExecuteNonQuery(sqlcmd, sps, out strError);
            return x;
        }

        //根据课程名称查询课程编号
        public int GetCourseIDCourseName(string courseName)
        {
            string strError = "";
            string sqlcmd = "select CourseID from Course where CourseName = @courseName";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@courseName", courseName);
            int courseID = Convert.ToInt32(db.DBExecuteSalar(sqlcmd, sps, out strError));
            return courseID;
        }
    }
}