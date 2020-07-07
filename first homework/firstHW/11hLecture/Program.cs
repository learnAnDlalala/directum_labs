namespace _11hLecture
{
    using System;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">can be empty</param>
        public static void Main(string[] args)
        {
            DateTime interval1 = new DateTime(2007, 12, 13);
            var a = new SortedLogs(@".\ClientConnectionLog.log");
            a.GetSortedLog(interval1);
        }
    }
}
