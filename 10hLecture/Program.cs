namespace _10hLecture
{
    using System;
    using System.IO;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">could be empty</param>
        public static void Main(string[] args)
        {
            EarlyExcelCreate(Directory.GetCurrentDirectory() + @"\early1.xlsx");
            LateExcelCreate(Directory.GetCurrentDirectory() + @"\later1.xlsx");
            Console.WriteLine("cоздание оконченно");
            Console.ReadLine();
        }

        /// <summary>
        /// Создание таблицы (ранее связывание)
        /// </summary>
        /// <param name="endPath">путь к будущему файлу</param>
        public static void EarlyExcelCreate(string endPath)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            var worksSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            worksSheet.Cells[1, "A"] = "Первое число";
            worksSheet.Cells[1, "B"] = "Второе число";
            worksSheet.Cells[1, "C"] = "Результат";
            worksSheet.Columns[1].AutoFit();
            worksSheet.Columns[2].AutoFit();
            var row = 1;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    row++;
                    worksSheet.Cells[row, "A"] = i;
                    worksSheet.Cells[row, "B"] = j;
                    worksSheet.Cells[row, "C"] = i * j;
                }
            }

            excelApp.Application.ActiveWorkbook.SaveAs(
                endPath,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
        }

        /// <summary>
        /// Создание таблицы (позднее связывание)
        /// </summary>
        /// <param name="endPath">путь к будущему файлу</param>
        public static void LateExcelCreate(string endPath)
        {
            dynamic excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            dynamic worksSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            worksSheet.Cells[1, "A"] = "Первое число";
            worksSheet.Cells[1, "B"] = "Второе число";
            worksSheet.Cells[1, "C"] = "Результат";
            worksSheet.Columns[1].AutoFit();
            worksSheet.Columns[2].AutoFit();
            var row = 1;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    row++;
                    worksSheet.Cells[row, "A"] = i;
                    worksSheet.Cells[row, "B"] = j;
                    worksSheet.Cells[row, "C"] = i * j;
                }
            }

            dynamic access = Type.GetType("Microsoft.Office.Interop.Excel.XlSaveAsAccessMode");
            dynamic withoutChanges = access.GetField("xlNoChange").GetValue(access);
            excelApp.Application.ActiveWorkbook.SaveAs(
                endPath,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                withoutChanges,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
        }
    }
}
