namespace _9hLecture
{
    using System.Configuration;

    /// <summary>
    /// Класс описания настроек
    /// </summary>
    public class ConfigElement : ConfigurationElement
    {
        /// <summary>
        /// Имя Ключа
        /// </summary>
        [ConfigurationProperty(nameof(MySettingKey), IsRequired = true, IsKey = true)]
        public string MySettingKey
        {
            get { return (string)this[nameof(this.MySettingKey)]; }
        }

        /// <summary>
        /// Значение Ключа
        /// </summary>
        [ConfigurationProperty(nameof(MySettingValue), IsRequired = true)]
        public int MySettingValue
        {
            get { return (int)this[nameof(this.MySettingValue)]; }
        }
    }
}
