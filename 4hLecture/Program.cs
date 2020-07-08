namespace Task3
{
    using System;
    using System.Data;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Тип прав.
    /// </summary>
    [Flags, Serializable]
    public enum AccessRights : byte // Лучше было бы вынести в отдельный файл.
    {
        /// <summary>
        /// Права на просмотр.
        /// </summary>
        View = 1,

        /// <summary>
        /// Права на запуск.
        /// </summary>
        Run = 2,

        /// <summary>
        /// Права на добавление.
        /// </summary>
        Add = 4,

        /// <summary>
        /// Права на изменение.
        /// </summary>
        Edit = 8,

        /// <summary>
        /// Права на утверждение.
        /// </summary>
        Ratify = 16,

        /// <summary>
        /// Права на удаление. 
        /// </summary>
        Delete = 32,

        /// <summary>
        /// Нет доступа.
        /// </summary>
        /// <remarks>
        /// Этот флаг имеет максимальный приоритет.
        /// Если он установлен, остальные флаги игнорируются 
        /// </remarks>
        AccessDenied = 64
    }

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="args">can be empty</param>
       public static void Main(string[] args)
        {
            DataSetObject tests = new DataSetObject();
            DataSet or = tests.Create();
            Console.WriteLine(or.GetDataSet("foo", "bbaa"));

            AccessRightsList.ShowRights(AccessRights.Ratify | AccessRights.Delete | AccessRights.Add | AccessRights.Run | AccessRights.View);
            //Race(10000);
            //ShowFormats();
        }

        /// <summary>
        /// Сравнение string and stringbuilder
        /// </summary>
        /// <param name="charValue">кол-во символов</param>
        public static void Race(int charValue)
        {
            StrConcat(charValue);
            StrBuild(charValue);
        }

        /// <summary>
        /// Создание строки конкатенацией
        /// </summary>
        /// <param name="charValue">кол-во символов</param>
        public static void StrConcat(int charValue)
        {
            string str = new string(string.Empty);
            Stopwatch stop = new Stopwatch();
            stop.Start();
            for (int i = 0; i < charValue; i++)
            {
                str += "1";
            }

            stop.Stop();
            TimeSpan ts = stop.Elapsed;
            Console.WriteLine($"Concat time {ts}");
        }

        /// <summary>
        /// Создание строки StringBuilder
        /// </summary>
        /// <param name="charValue">количество символов</param>
        public static void StrBuild(int charValue)
        {
            StringBuilder bld = new StringBuilder();
            Stopwatch stop = new Stopwatch();
            stop.Start();
            for (int i = 0; i < charValue; i++)
            {
                bld.Append("1");
            }

            stop.Stop();
            TimeSpan ts = stop.Elapsed;
            Console.WriteLine($"Builder time {ts}");
        }

        /// <summary>
        /// Виды форматирования даты
        /// </summary>
        public static void ShowFormats()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Форматы даты");
            Console.WriteLine("D: {0:D}", now);
            Console.WriteLine("d: {0:d}", now);
            Console.WriteLine("F: {0:f}", now);
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);

            Console.WriteLine("\nФорматы чисел");
            var doubleNum = 15.37;
            var intNum = 15;
            var phone = 89127348164;
            Console.WriteLine(string.Format("{0:0.00;minus 0.00;zero}", -123.4567));
            Console.WriteLine(string.Format("C: {0:C2}", doubleNum));
            Console.WriteLine(string.Format("d: {0:d3}", intNum));
            Console.WriteLine(string.Format("f: {0:f4}", doubleNum));
            Console.WriteLine(string.Format("x: {0:x}", intNum));
            Console.WriteLine(string.Format("P: {0:P2}", doubleNum));
            Console.WriteLine(string.Format("{0:+# (###) ###-##-##}", phone));
            Console.ReadLine();
        }
    }
}