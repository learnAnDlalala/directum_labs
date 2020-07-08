namespace _8thLecture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Мain class
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">can be empty</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMax("a", "b", "c"));
            Perebor();
            TextList test = new TextList(@".\testfor8.txt");
            foreach (string a in test)
            {
                Console.WriteLine(a);
            }
        }

        /// <summary>
        /// Максимальный элемент
        /// </summary>
        /// <typeparam name="T">генерик тип</typeparam>
        /// <param name="first">первое значение</param>
        /// <param name="second">второе значение</param>
        /// <param name="third">третье значение</param>
        /// <returns>максимальное значение</returns>
        public static T GetMax<T>(T first, T second, T third) where T : IComparable<T>
        {
            List<T> list = new List<T>() { first, second, third };
            return list.Max();
        }

        /// <summary>
        /// Метод показывающий реализацию foreach
        /// </summary>
        public static void Perebor()          // Eto eIILe 4To Takoe?
        {
            List<int> testList = new List<int> { 1, 2, 3, 4 };
            testList.Add(5);
            foreach (int i in testList)
            {
                Console.WriteLine(i);
            }

            Dictionary<string, string> testDictionaty = new Dictionary<string, string>();
            testDictionaty.Add("Dog", "Rex");
            testDictionaty.Add("Cat", "Tom");
            testDictionaty.Add("Mouse", "Mickey");
            testDictionaty.Add("Duck", "Donald");
            foreach (KeyValuePair<string, string> value in testDictionaty)
            {
                Console.WriteLine($"{value.Key} has name {value.Value}");
            }
        }
    }
}
