using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDiplomWork
{
    public class KursWork : Work
    {
        private string disciplinesName;

        /// <summary>
        /// название дисциплины
        /// </summary>
        public string DisciplinesName
        {
            get { return disciplinesName; }
            set { disciplinesName = value; }
        }

        private string department;


        /// <summary>
        /// кафедра
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// конструктор по умолчанию посредством вызова конструктора базового класса 
        /// </summary>
        public KursWork()
            : base()
        {

        }    

        /// <summary>
        /// конструктор по умолчанию посредством вызова конструктора базового класса с параметрами
        /// </summary>
        /// <param name="id_"></param>
        /// <param name="name_"></param>
        /// <param name="studentName_"></param>
        /// <param name="groupNumber_"></param>
        /// <param name="scientificDirector_"></param>
        /// <param name="year_"></param>
        /// <param name="disciplinesName_"></param>
        /// <param name="department_"></param>
        public KursWork(int id_, string name_, string studentName_, string groupNumber_, string scientificDirector_, int year_,
                    string disciplinesName_, string department_)
            : base(id_, name_, studentName_, groupNumber_, scientificDirector_, year_)
        {
            DisciplinesName = disciplinesName_;
            Department = department_;
        }




    }
}
