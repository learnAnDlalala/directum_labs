namespace _9hLecture
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;    // Лишние using.
    using System.Reflection;
    using System.Threading.Tasks;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="args">can be empty</param>
        static void Main(string[] args) // Почему Program.cs был в исключениях StyleCop?
        {

            test();
            string mainPath = Directory.GetCurrentDirectory();
            MyTestClass alltest = new MyTestClass(5);
            alltest.Name = "aaaa";
            GetClassPropety($@"{mainPath}\test\1.0.0.0 ver\9hLecture.dll", "_9hLecture.MyTestClass"); // Добавь dll'ки в проект. Можно с таким же путём(структурой папок).
            GetClassPropety($@"{mainPath}\test\2.0.0.0 ver\9hLecture.dll", "_9hLecture.MyTestClass"); // Тогда и копироваться они будут с ними.
            foreach (var i in GetObjPropertyV2(alltest))
            {
                Console.WriteLine(i);
            }
            GetClassPropety($@"{mainPath}\test\testclass.dll", "testclass.TestClass");
        }

        public static List<String> GetObjProperty(object obj)
        {
            Type type = obj.GetType();
            List<string> outData = new List<string>();
            foreach (PropertyInfo field in type.GetProperties())
            {
                if (field.CanRead && field.CanWrite)
                {
                    outData.Add($"{ field.Name} === { field.GetValue(obj)}");
                }
            }
            return outData;

        }
        public static List<String> GetObjPropertyV2(object obj)
        {
            Type type = obj.GetType();
            List<string> outData = new List<string>();
            foreach (PropertyInfo field in type.GetProperties())  // Не field, а property.
            {
                if (field.GetCustomAttribute<ObsoleteAttribute>(true) == null && field.CanRead && field.CanWrite)
                {
                    outData.Add($"{ field.Name} === { field.GetValue(obj)}");
                }
            }
            return outData;
        }

        /// <summary>
        /// Получение свойств
        /// </summary>
        /// <param name="path">путь к сборке</param>
        /// <param name="classname">название класса</param>
        public static void GetClassPropety(string path, string classname)
        {
            try
            {
                Assembly asm = Assembly.LoadFile(path);
                Type type = asm.GetType(classname);
                ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                var instance = constructor.Invoke(new object[0]);
                foreach (var i in type.GetProperties())
                {
                    Console.WriteLine($"{i.Name} == {i.GetValue(instance)}");
                }

            }
            catch (ReflectionTypeLoadException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Работа с классом чтения конфигурации
        /// </summary>
        public static void test() // Плохое название для метода.
        {
            var seet = (ReadConfig)ConfigurationManager.GetSection("MySettings");
            var seetings = seet.MySettings;
            foreach (ConfigElement line in seetings)
            {

                foreach (PropertyInformation properties in line.ElementInformation.Properties)
                {
                    Console.WriteLine($"{properties.Name}=={properties.Value}");
                }
            }
            Console.WriteLine("pool");
        }
    }
}
