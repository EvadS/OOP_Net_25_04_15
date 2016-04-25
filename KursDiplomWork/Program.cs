using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDiplomWork
{
    class Program
    {
        //название файлов
        private static readonly string kursWorkFileName = "KursWork.txt";
        private static readonly string diplimWorkFileName = "DiplomWork.txt";

        // словарь данных 
        // 2 коллекции, отдельно для дипломных и курсовых
        Dictionary<int, KursWork> kursWorks = new Dictionary<int, KursWork>();
        Dictionary<int, DiplomWork> diplomWorks = new Dictionary<int, DiplomWork>();

        /// <summary>
        /// чтение курсовых работ из файла 
        /// </summary>
        public void KursWorkReadFromFile()
        {
            //TODO :считать все из файла в коллекцию
        }

        /// <summary>
        /// чтение дипломных работ из файла 
        /// </summary>
        public void DiplomWorkReadFromFile()
        {
            //TODO :считать все из файла в коллекцию
        }

        /// <summary>
        /// запись  курсовых работ в файл 
        /// </summary>
        public void KursWorkWriteFile()
        {
            //TODO :записать всю коллекцию в файл
        }

        /// <summary>
        /// запись дипломных работ в файл 
        /// </summary>
        public void DiplomWorkWriteToFile()
        {
            //TODO :записать всю коллекцию в файл
        }


        /// <summary>
        /// редактирование диплрмной работы
        /// </summary>
        /// <param name="Id"></param>
        public void DiplomWorkEditItem(int Id)
        {
            //TODO: редактирование одной работы
        }
        /// редактирование курсовой  работы
        public void KursWorkEditItem(int Id)
        {
            //TODO: редактирование одной работы
        }


        #region Ввод Данных
        #region Выполнение запросов

        /// <summary>
        /// поиск работ по фамилии
        /// </summary>
        /// <param name="StudentFName"></param>
        public void FindByStudentFName(string StudentFName)
        {
            //TODO: поиск по фамилии
        }

        /// <summary>
        ///  Просмотр всех названий работ в алфавитном порядке
        /// </summary>
        public void DisplayAlphabeticalOrder()
        {

        }

        /// <summary>
        /// Отбор только курсовых работ
        /// </summary>
        public void DisplayKursWork()
        {

        }

        #endregion
        /// <summary>
        /// ведение с консоли новых работ и запись их в файл
        /// </summary>
        /// <returns></returns>
        public bool KursWorkInputData()
        {

        }

        /// <summary>
        /// ведение с консоли новых работ и запись их в файл
        /// </summary>
        /// <returns></returns>
        public bool DiplomWorkInputData()
        {

        }

        #endregion


        static void Main(string[] args)
        {
            // TODO: тестирование операций 
        }
    }
}
