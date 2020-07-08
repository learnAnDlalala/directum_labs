namespace _9hLEcture
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="args">can be empty</param>
        static void Main(string[] args)                       // STYLECOP.
        {                                                     // Не компилируется. Ругается на содержимое папки 9hLecture в проекте.
            Console.WriteLine("Hello World!");
            MyTestClass alltest = new MyTestClass(5);
            alltest.Name = "fdfdf";
            GetObjProperty(alltest);
            
        }

        public static void GetObjProperty(object obj)
        {
            Type type = obj.GetType();
            //FieldInfo[] fields = type.GetFields(BindingFlags.Public);
            foreach (PropertyInfo field in type.GetProperties())
            {
                Console.WriteLine($"{field.Name} === {field.GetValue(obj)}");
            }
        }
    }
}
