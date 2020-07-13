namespace _9hLecture
{
    using System;   // Лишний using.
    using System.Configuration;

    /// <summary>
    /// Класс чтения конфигурации
    /// </summary>
    public class ReadConfig : ConfigurationSection
    {
        /// <summary>
        /// Получение настроек конфигурации
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = false)]
        public ConfigCollection MySettings => (ConfigCollection)this[string.Empty];
    }
}
