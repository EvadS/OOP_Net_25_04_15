using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDiplomWork
{
    public class DiplomWork:Work
    {
        private QualificationOfWorkType qualificationOfWork;

        /// <summary>
        /// квалификационный уровень работы
        /// </summary>
        public QualificationOfWorkType QualificationOfWork
        {
            get { return qualificationOfWork; }
            set { qualificationOfWork = value; }
        }

        /// <summary>
        /// конструктор по умолчанию посредством вызова конструктора базового класса 
        /// </summary>
        public DiplomWork():base()
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
        /// <param name="qualificationOfWorkType_"></param>
        public DiplomWork(int id_, string name_, string studentName_, string groupNumber_, string scientificDirector_, int year_, QualificationOfWorkType qualificationOfWorkType_):
            base(id_, name_, studentName_, groupNumber_, scientificDirector_, year_)
        {
            QualificationOfWork = qualificationOfWorkType_;
        }

       
    }

    public enum QualificationOfWorkType
    {
        Bachelor, Specialist, Master
    }
}
