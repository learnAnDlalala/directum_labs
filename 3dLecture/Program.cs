namespace Figures
{
    using System;

    /// <summary>
    /// Start class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">can be empty</param>
        public static void Main(string[] args)
        {
            Square test1 = new Square(1, 1, 3);
            Console.WriteLine(test1.GetArea());
        }
    }
}