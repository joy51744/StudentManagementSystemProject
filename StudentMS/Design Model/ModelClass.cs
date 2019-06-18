using System;

namespace StudentMS.Design_Model
{
    public class ModelClass
    {
        private int _classID;

        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        private int _batchID;

        public int BatchID
        {
            get { return _batchID; }
            set { _batchID = value; }
        }

        private string _className;

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        private DateTime _entranceDate;

        public DateTime EntranceDate
        {
            get { return _entranceDate; }
            set { _entranceDate = value; }
        }

        private DateTime _finishDate;

        public DateTime FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; }
        }

        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}