namespace Figures
{
    using System;
    public class Project
    {
        public static void Main(string[] args)
        {
            var arr = new Triangle(1, 1, 4, 5, 6);
            Console.WriteLine(arr.Perimetr());
        }
    }
}
