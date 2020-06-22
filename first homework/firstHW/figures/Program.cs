using System;

namespace figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle test1 = new Circle(0,0,15);
            Console.WriteLine(test1.Length());
        }
    }
}