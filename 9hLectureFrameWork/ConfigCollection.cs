namespace _9hLecture
{
    using System.Configuration;

    /// <summary>
    /// Класс коллекции
    /// </summary>
    [ConfigurationCollection(typeof(ConfigElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class ConfigCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Создание нового элемента конфигурации
        /// </summary>
        /// <returns>новый елемент</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigElement();
        }

        /// <summary>
        /// Получение ключа елемента
        /// </summary>
        /// <param name="el">элемент конфигурации</param>
        /// <returns>ключ элемента</returns>
        protected override object GetElementKey(ConfigurationElement el)  // Плохое название параметра.
        {
            return ((ConfigElement)el).MySettingKey;
        }
    }
}
