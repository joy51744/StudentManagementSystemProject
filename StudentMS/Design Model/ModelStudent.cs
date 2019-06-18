using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS.Design_Model
{
    public class ModelStudent
    {
        private int _batchID;

        public int BatchID
        {
            get { return _batchID; }
            set { _batchID = value; }
        }

        private string _studentNo;

        public string StudentNo
        {
            get { return _studentNo; }
            set { _studentNo = value; }
        }

        private string _studentName;

        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private int _classID;

        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        private string _studentDep;

        public string StudentDep
        {
            get { return _studentDep; }
            set { _studentDep = value; }
        }
    }
}