using CarRental.Entities;
using ClosedXML.Excel;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Helper
{
    public static class ExcelHelper
    {
        public static bool Export<T>(List<T> list, string fileName, string sheetName)
        {
            bool exported = false;
            using (IXLWorkbook workbook = new XLWorkbook())
            {
                workbook.AddWorksheet(sheetName).FirstCell().InsertTable<T>(list, false);
                workbook.SaveAs(fileName);
                exported = true;
            }

            return exported;
        }

        public static List<T> Import<T>(string path)
        {
            return new ExcelMapper(path).Fetch<T>().ToList();
        }
    }
}
