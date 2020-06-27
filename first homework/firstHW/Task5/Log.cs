namespace Task5
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Класс Log
    /// </summary>
    public class Log : StreamReader
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="path">пусть к файлу</param>
        public Log(string path)
            : base(path)
        { 
        }

        /// <summary>
        /// Подсчет количество логов за выбранный период
        /// </summary>
        /// <param name="startDate">начальная дата</param>
        /// <param name="endDate">конечная дата</param>
        /// <returns>count кол-во логов</returns>
        public int GetCountLogs(DateTime startDate, DateTime endDate)
        {
            int count = 0;
            string line;
            string pattern = @"^\d{2}.\d{2}.\d{4}";
            while ((line = this.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, pattern))
                {
                    DateTime dateFromLog = DateTime.ParseExact(Regex.Match(line, pattern).Value, "dd.MM.yyyy", null);
                    if (startDate <= dateFromLog && dateFromLog <= endDate)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
