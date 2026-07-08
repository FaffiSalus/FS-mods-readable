using System.Text;

namespace FS_mods_readable.Core.CSV;

public static class CreateAndFillCsvFile
{
    public static void CreateAndFill(DataTable dataTable)
    {
        var dir = ConfigHandler.GetCsvDirectory();
        var maxBatch = int.Parse(ConfigHandler.GetCsvBatchLimit() ?? "0");
        if (dataTable.Rows.Count > maxBatch && maxBatch > 0)
        {
            LogHandler.WriteToLog(dataTable.TableName + " Records exceed csv batch limit. DataTable split.");
            var tables = CreateDataTable.SplitTable(dataTable, maxBatch);
            dataTable.Clear();
            foreach (var table in tables)
            {
                Export2Csv(dir + "\\" + table.TableName + ".csv", table);
                table.Clear();
            }
        }
        else
        {
            Export2Csv(dir + "\\" + dataTable.TableName + ".csv", dataTable);
        }
    }

    private static void Export2Csv(string destFilePath, DataTable dataTable)
    {
        StreamWriter? streamWriter = null;
        try
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Join(",",
                dataTable.Columns.Cast<DataColumn>().Select<DataColumn, string>(column => $"\"{column.ColumnName}\"")
                    .ToList()) + "\n");
            dataTable.AsEnumerable().ToList().ForEach((Action<DataRow>)(row =>
                stringBuilder.Append(string.Join(",",
                    row.ItemArray!.Select<object, string>(item => $"\"{item}\"").ToList()) + "\n")));
            var str = stringBuilder.ToString();
            streamWriter = new StreamWriter(new FileStream(destFilePath, FileMode.Append, FileAccess.Write));
            streamWriter.Write(str);
            LogHandler.WriteToLog(dataTable.Rows.Count + " Rows written to " + dataTable.TableName);
        }
        catch (Exception ex)
        {
            LogHandler.WriteToLog(ex.Message);
        }
        finally
        {
            streamWriter?.Flush();
            streamWriter?.Dispose();
            streamWriter?.Close();
        }
    }
}