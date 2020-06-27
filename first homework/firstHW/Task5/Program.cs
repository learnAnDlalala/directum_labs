namespace Task5
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
            DateTime interval2 = new DateTime(2007, 12, 17);
            Log logs = new Log(@"D:\direction\ClientConnectionLog.log");
            Console.WriteLine(logs.GetCountLogs(interval1, interval2));
            Console.ReadKey();
        }
    }
}
