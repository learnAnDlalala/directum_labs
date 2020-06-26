namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;    
    using FirstHW;
    
    /// <summary>
    /// Тип возможных встреч
    /// </summary>
    public enum MeetingTypes
    {
        /// <summary>
        /// Тип встреча
        /// </summary>
        [Description("встреча")] meeting,

        /// <summary>
        /// Тип поручение
        /// </summary>
        [Description("поручение")] commission,

        /// <summary>
        /// Тип звонок
        /// </summary>
        [Description("звонок")] call,

        /// <summary>
        /// Тип ДР
        /// </summary>
        [Description("день рождения")] birthDay
    }

    /// <summary>
    /// Встреча с определенным типом
    /// </summary>
    public class MeetingWithTypes : Meeting
    {
        /// <summary>
        /// Get or Set DataType
        /// </summary>
        public MeetingTypes DateType { get; set; }

        /// <summary>
        /// Get DataType Description
        /// </summary>
        /// <returns>Description string</returns>
        public string GetTypeDescription()
        {
            return this.DateType.GetDescription();
             
        }
    }
}
