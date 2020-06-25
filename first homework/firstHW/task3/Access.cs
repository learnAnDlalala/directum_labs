namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Класс для вызова прав пользователя
    /// </summary>
    public static class AccessRightsList
    {
        /// <summary>
        /// Показывает права пользователя.
        /// </summary>
        /// <param name="rights">Список прав пользователя</param>
        public static void ShowRights(AccessRights rights)
        {
            byte count = (byte)rights;
            if (count >= 64)
            {
                Console.WriteLine((AccessRights)64);
                return;
            }

            double power = Math.Floor(Math.Log2(count - 1));
            
            double finalPower = Math.Pow(2, power + 1) - 1;
            Console.WriteLine((AccessRights)finalPower);
        }
    }
}
