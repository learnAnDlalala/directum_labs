namespace Task3
{
    using System;

    /// <summary>
    /// Класс для вызова прав пользователя
    /// </summary>
    public static class AccessRightsList    // Имя класса не совпадает с именем файла.
    {
        /// <summary>
        /// Показывает права пользователя.
        /// </summary>
        /// <param name="rights">Список прав пользователя</param>
        public static void ShowRights(AccessRights rights)
        {
            byte count = (byte)rights;
            if (rights.HasFlag(AccessRights.AccessDenied))
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
