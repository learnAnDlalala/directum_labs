namespace Task4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">can be empty</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(new StringValue("ADA").Equals(new StringValue("AAA")));
            Console.WriteLine(new StringValue("AAA") == (new StringValue("ACA")));
            Console.WriteLine(new StringValue("AAA") != (new StringValue("AVA")));
            var TwoComplexes = new List<Complex>()
            {
              new Complex() { Re = 3, Im = 5},
              new Complex() { Re = 2, Im = 2}
            };

            TwoComplexes.Sort();
        }
    }
}
