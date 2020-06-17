namespace FirstHW
{
    using System;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>      
        /// <param name="args">Some text</param>
        public static void Main(string[] args)
        {
            MeetingWithReminder test = new MeetingWithReminder();
            test.ReminderDate = DateTime.Now.AddMinutes(+2);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
