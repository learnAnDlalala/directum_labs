namespace Task4
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Класс Комплексного числа
    /// </summary>
    public class Complex : IComparable<Complex>
    {
        /// <summary>
        /// Конструктор класса Complex
        /// </summary>
        /// <param name="re">Реальная часть комплексного числа</param>
        /// <param name="im">Мнимая часть комплексного числа</param>
        public Complex(float re = 0, float im = 0)
        {
            this.Re = re;
            this.Im = im;
        }

        /// <summary>
        /// Реальная часть комплексного числа
        /// </summary>
        public float Re { get; set; }

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public float Im { get; set; }

        /// <summary>
        /// Вычисление модуля комплексного числа
        /// </summary>
        public double AbsoluteValue
        {
            get { return Math.Sqrt(Math.Pow(this.Re, 2) + Math.Pow(this.Im, 2)); }
        }

        /// <summary>
        /// Реализация интерфейса сравнения
        /// </summary>
        /// <param name="number"> число для сравнения</param>
        /// <returns>результат сравнения</returns>
        public int CompareTo([AllowNull] Complex number)
        {
            if (number != null)
            {
                this.AbsoluteValue.CompareTo(number.AbsoluteValue);
            }

            return 1;
        }
    }
}
