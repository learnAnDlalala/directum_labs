﻿namespace Task4
{
    /// <summary>
    /// Class String Value
    /// </summary>
    public class StringValue
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="value">value string</param>
        public StringValue(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Get or Set Value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Переопределение сравнения
        /// </summary>
        /// <param name="obj1">первый обьект сравнения</param>
        /// <param name="obj2">второе обьект сравнения</param>
        /// <returns>обратный результат сравнения</returns>
        public static bool operator ==(StringValue obj1, StringValue obj2)
        {
            return (bool)(obj1.Value == obj2.Value);
        }

        /// <summary>
        /// Переопределение сравнения
        /// </summary>
        /// <param name="obj1">первый обьект сравнения</param>
        /// <param name="obj2">второе обьект сравнения</param>
        /// <returns>результат сравнения</returns>
        public static bool operator !=(StringValue obj1, StringValue obj2)
        {
            return (bool)!(obj1.Value == obj2.Value);
        }

        /// <summary>
        /// Переопределение метода Equals
        /// </summary>
        /// <param name="obj">второй обьект</param>
        /// <returns>true of false</returns>
        public override bool Equals(object obj)
        {
            if (obj is StringValue stringValue)
            {
                return this.Value == stringValue.Value;
            }

            return false;
        }
    }
}
