namespace _8thLecture
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Класс для перебора строк
    /// </summary>
    public class TextList : IEnumerable<string>
    {
        /// <summary>
        /// Хранилище строк
        /// </summary>
        public readonly List<string> content = new List<string>();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public TextList(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    this.content.Add(line);
                }
            }
        }

        /// <summary>
        /// Реализация интерфейса
        /// </summary>
        /// <returns>поле класса</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return ((IEnumerable<string>)this.content).GetEnumerator();
        }

        /// <summary>
        /// Реализация интерфейса
        /// </summary>
        /// <returns>возращает поле класса</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.content).GetEnumerator();
        }
    }
}
