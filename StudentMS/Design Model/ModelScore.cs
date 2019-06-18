using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS.Design_Model
{
    public class ModelScore
    {
        private int _courseID;

        public int CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
        }

        private int _studentID;

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        private int _classID;

        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
    }
}