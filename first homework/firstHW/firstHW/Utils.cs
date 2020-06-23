namespace FirstHW
{
    using System;
    using System.ComponentModel;

    public static class Utils
    {
        public static string GetDescriprion(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var atribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return atribute.Length == 0 ? value.ToString() : (atribute[0] as DescriptionAttribute).Description;
        }


    }
}
