namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Логгер - класс для ведения логов.
    /// </summary>
    public class Logger : IDisposable // Название класса не совпадает с именем файла.
    {
        /// <summary>
        /// Log file.
        /// </summary>
        private FileStream logFile;

        /// <summary>
        /// Log writter.
        /// </summary>
        private StreamWriter logWriter;

        /// <summary>
        /// Create object.
        /// </summary>
        /// <param name="fileName">file name</param>
        public Logger(string fileName)
        {
            this.logFile = new FileStream(fileName, FileMode.Append);
            this.logWriter = new StreamWriter(this.logFile);
        }

        /// <summary>
        /// Write string log.
        /// </summary>
        /// <param name="data">string data</param>
        public void WriteString(string data)
        {
            this.logWriter.WriteLine(data);
        }

        /// <summary>
        /// Реализация интерфейса IDispose
        /// </summary>
        public void Dispose()
        {
            this.logWriter.Flush();
            this.logWriter.Close();
            this.logFile.Close();
        }
    }
}
