namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    /// <summary>
    /// Класс создания строки DataSet
    /// </summary>
    public static partial class DataExtension
    {
        /// <summary>
        /// Создание строки из DataSet
        /// </summary>
        /// <param name="data">DataSet data</param>
        /// <param name="column">Разделитель column</param>
        /// <param name="raw">Разделитель rows</param>
        /// <returns>OutStr = DataSet</returns>
        public static StringBuilder GetDataSet(this DataSet data, string column, string raw)
        {
            int count = 0;
            StringBuilder outStr = new StringBuilder();

            foreach (DataTable dt in data.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    count++;
                    if (count == dt.Rows.Count)
                    {
                        outStr.AppendJoin($" { column} ", dr.ItemArray);
                    }
                    else
                    {
                        outStr.AppendJoin($" { column} ", dr.ItemArray).Append($" {raw} ");
                    }
                }
            }

            return outStr;
        }
    }
}
