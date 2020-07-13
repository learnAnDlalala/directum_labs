namespace _11hLecture
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
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
            var data = this.content
                .Where(t => t.StartsWith(dateString))
                .OrderBy(t => GetTime(t))
                .Select(t => t);  // Зачем?
            foreach (var s in data)
            {
                Console.WriteLine(s);
            }
        }
        
        /// <summary>
        /// Метод получения времени
        /// </summary>
        /// <param name="logLine">строка лога</param>
        /// <returns> Время лога</returns>
        public static DateTime GetTime(string logLine)
        {
            return DateTime.ParseExact(Regex.Match(logLine, @"\d?\d{1}:\d{2}:\d{2}").Value, "HH:mm:ss", null);
        }
    }
}
