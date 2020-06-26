namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Text;
        
    /// <summary>
    /// Класс для формирование DataSet
    /// </summary>
    public class Class2
    {
        /// <summary>
        /// Создание DataSet
        /// </summary>
        /// <returns>DataSet object</returns>
        public DataSet Create()
        {
            DataSet bookStore = new DataSet("BookStore");
            DataTable booksTable = new DataTable("Books");
            bookStore.Tables.Add(booksTable);
            DataColumn idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;
            DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn newTest = new DataColumn("1", Type.GetType("System.Int32"));
            DataColumn priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            priceColumn.DefaultValue = 100; // значение по умолчанию
            DataColumn discountColumn = new DataColumn("Discount", Type.GetType("System.Decimal"));
            discountColumn.Expression = "Price * 0.2";
            booksTable.Columns.Add(idColumn);
            booksTable.Columns.Add(nameColumn);
            booksTable.Columns.Add(priceColumn);
            booksTable.Columns.Add(discountColumn);
            booksTable.PrimaryKey = new DataColumn[] { booksTable.Columns["Id"] };
            DataRow row = booksTable.NewRow();
            row.ItemArray = new object[] { null, "Война и мир", 200 };
            booksTable.Rows.Add(row); // добавляем первую строку
            booksTable.Rows.Add(new object[] { null, "Отцы и дети", 170 });
            return bookStore;
        }
    }
}
