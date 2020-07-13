namespace _9hLecture
{
    using System;

    /// <summary>
    /// Тестовый класс
    /// </summary>
    public class MyTestClass
    {
        /// <summary>
        /// поле только дл чтения
        /// </summary>
        private readonly int value1 = 22;

        /// <summary>
        /// поле только дл чтения
        /// </summary>
        private readonly int value2 = 445;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">целочисленое значение</param>
        public MyTestClass(int a)
        {
            this.value1 = a;
        }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public MyTestClass()
        {
        }

        /// <summary>
        /// Свойство имя
        /// </summary>
        public string Name { get; set; } = "dll 2";

        /// <summary>
        /// Свойство строка
        /// </summary>
        public string Str { get; set; }

        /// <summary>
        /// Свойство клог
        /// </summary>
        public string Clone { get; } = "CLONE!!!";

        /// <summary>
        /// Свойство с атрибутом
        /// </summary>
        [Obsolete]
        public string Settler { get; set; }

        /// <summary>
        /// Метод для вычисления суммы
        /// </summary>
        /// <returns>Возвращает сумму</returns>
        public int Sum()
        {
            return this.value1 + this.value2;
        }
    }
}
