﻿namespace task3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    
    /// <summary>
    /// Вспомогательный класс
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Получение Description
        /// </summary>
        /// <param name="value">Data type</param>
        /// <returns>string Description</returns>
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attribute.Length == 0 ? value.ToString() : (attribute[0] as DescriptionAttribute).Description;
        }
    }
}
