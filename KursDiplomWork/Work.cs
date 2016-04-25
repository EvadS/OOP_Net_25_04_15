using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDiplomWork
{
    public abstract  class Work
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        private string groupNumber;

        public string GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }


        private string scientificDirector;

        /// <summary>
        /// научный руководитель
        /// </summary>
        public string ScientificDirector
        {
            get { return scientificDirector; }
            set { scientificDirector = value; }
        }

        private int year;

        /// <summary>
        ///год защиты
        /// </summary>
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public virtual void ShowData() { }

        public Work()
        {

        }

        public Work(int id_, string name_, string studentName_,string groupNumber_,string scientificDirector_,int year_)
        {
            Id = id_;
            Name = name_;
            StudentName = studentName_;
            GroupNumber = groupNumber;
            ScientificDirector = scientificDirector_;
            Year = year_;
        }
    }
}
