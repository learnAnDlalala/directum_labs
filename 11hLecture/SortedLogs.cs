namespace _11hLecture
{
    using System;
    using System.Linq;
    using _8thLecture;

    /// <summary>
    /// New class of Sorted Strings from log
    /// </summary>
    public class SortedLogs : TextList
    {
        /// <summary>
        /// Class onstructor
        /// </summary>
        /// <param name="path">path to the log file</param>
        public SortedLogs(string path)
             : base(path)
        {
        }

        /// <summary>
        /// Geting Sorted Log Strings
        /// </summary>
        /// <param name="date">DateTime date</param>
        public void GetSortedLog(DateTime date)
        {
            var dateString = date.ToString("dd.MM.yyyy");
            var data = from t in this.content           // Хорошо, но лучше сделать через методы расширения. Такой синтаксис почти не используют.
                       where t.StartsWith(dateString)
                       orderby t.Substring(0, 19)       // Всё же лучше сортировать не по строкам, а приводить в дате-времени.
                       select t;
            foreach (var s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
