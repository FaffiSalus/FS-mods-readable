using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using ClosedXML.Excel;

namespace FS_mods_readable.Core.Excel;

public static class CreateAndFillExcelFile
{
    private const int _maxRows = 1000000;

    public static void CreateAndFill(string fileName, string sheetName, DataTable dataTable)
    {
        if (dataTable.Rows.Count > _maxRows)
        {
            var tables = CreateDataTable.SplitTable(dataTable, _maxRows);
            int i = 0;
            foreach (var table in tables)
            {
                Export2Excel(fileName, sheetName + "_" + i, table);
                i++;
            }
        }
        else
        {
            Export2Excel(fileName, sheetName, dataTable);
        }
    }
    
    private static void Export2Excel(string fileName, string sheetName, DataTable dataTable)
    {
        if (dataTable.Rows.Count <= 0) return;
        using var package = new ExcelPackage(fileName);
        var sheet = package.Workbook.Worksheets.Add(sheetName);
        var filledRange = sheet.Cells["A1"].LoadFromDataTable(dataTable, true);
        package.Save();
        File.AppendAllText(Directory.GetCurrentDirectory() + "\\log.txt", DateTime.Now.ToShortTimeString() + ": Wrote " + sheetName + "\n");
    }
}