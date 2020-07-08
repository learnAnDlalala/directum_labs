namespace Task7
{
    using System;

    /// <summary>
    /// Свой класс исключений(ошибки)
    /// </summary>
    public class LoadFileException : Exception
    {
        /// <summary>
        /// Constructor LoadFileException
        /// </summary>
        /// <param name="message">ex.message string</param>
        /// <param name="originalException">exception obj</param>
        public LoadFileException(string message, Exception originalException)
            : base(message, originalException)
        { 
        }
    }
}
