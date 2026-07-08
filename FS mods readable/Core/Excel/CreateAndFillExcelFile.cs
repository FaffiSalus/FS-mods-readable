using DataTable = System.Data.DataTable;

namespace FS_mods_readable.Core.Excel;

public static class CreateAndFillExcelFile
{
    public static void CreateAndFill(DataTable dataTable)
    {
        var fileName = ConfigHandler.GetExcelDirectory() + "\\" + ConfigHandler.GetExcelFileName() + ".xlsx";
        var maxRows = int.Parse(ConfigHandler.GetExcelRowLimit() ?? "0");
        if (dataTable.Rows.Count > maxRows && maxRows > 0)
        {
            var tables = CreateDataTable.SplitTable(dataTable, maxRows);
            LogHandler.WriteToLog(dataTable.TableName + " exceeds Excel Row Limit. DataTable split.");
            var i = 0;
            foreach (var table in tables)
            {
                Export2Excel(fileName, table.TableName + "_" + i, table);
                i++;
            }
        }
        else
        {
            Export2Excel(fileName, dataTable.TableName, dataTable);
        }
    }

    private static void Export2Excel(string fileName, string sheetName, DataTable dataTable)
    {
        if (dataTable.Rows.Count <= 0) return;
        using var package = new ExcelPackage(fileName);
        var sheet = package.Workbook.Worksheets.Add(sheetName);
        sheet.Cells["A1"].LoadFromDataTable(dataTable, true);
        package.Save();
        LogHandler.WriteToLog("Wrote " + sheetName + "\n");
    }
}