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
            var test = new MeetingWithOutEnd();
            test.StartDate = DateTime.Now;
           test.EndDate = DateTime.Now.AddHours(3);
         
            Console.WriteLine(test.Duration);
            Console.ReadKey();
        }
    }
}
