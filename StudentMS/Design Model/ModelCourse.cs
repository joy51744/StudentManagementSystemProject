using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS.Design_Model
{
    public class ModelCourse
    {
        private string _courseName;

        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        private int _classID;

        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        private string _classTeacher;

        public string ClassTeacher
        {
            get { return _classTeacher; }
            set { _classTeacher = value; }
        }

        private int _subjectID;

        public int SubjectID
        {
            get { return _subjectID; }
            set { _subjectID = value; }
        }

        private DateTime _beginDate;

        public DateTime BeginDate
        {
            get { return _beginDate; }
            set { _beginDate = value; }
        }

        private DateTime _finishDate;

        public DateTime FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; }
        }
    }
}