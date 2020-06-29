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
            Log logs = new Log(@"D:\direction\ClientConnectionLog.log");    // Лучше сделать относительный путь.
            Console.WriteLine(logs.GetCountLogs(interval1, interval2));     // Добавить в проект файл лога и в свойствах указать "Copy if newer".
            Console.ReadKey();                                              // Тогда файл лога будет в том же каталоге, что и экзешник.
        }
    }
}
