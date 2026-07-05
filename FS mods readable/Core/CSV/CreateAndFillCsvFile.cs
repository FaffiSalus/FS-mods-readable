using System.Text;

namespace FS_mods_readable.Core.CSV;

public static class CreateAndFillCsvFile
{
    public static void CreateAndFill(string fileName, DataTable dataTable)
    {
        if (dataTable.Rows.Count > 10000)
        {
            List<DataTable> tables = SplitTable(dataTable, 10000);
            dataTable.Clear();
            foreach (DataTable table in tables)
            {
                Export(fileName, table);
                table.Clear();
            }
        }
        else
        {
            Export(fileName, dataTable);
        }
    }
    
    // Source - https://stackoverflow.com/q/34663933
    // Posted by Nilesh Barai, modified by community. See post 'Timeline' for change history
    // Retrieved 2026-07-05, License - CC BY-SA 3.0
    private static List<DataTable> SplitTable(DataTable originalTable, int batchSize)
    {
        List<DataTable> tables = new List<DataTable>();
        int i = 0;
        int j = 1;
        DataTable newDt = originalTable.Clone();
        newDt.Clear();
        foreach (DataRow row in originalTable.Rows)
        {
            DataRow newRow = newDt.NewRow();
            newRow.ItemArray = row.ItemArray;
            newDt.Rows.Add(newRow);
            i++;
            if (i == batchSize)
            {
                tables.Add(newDt);
                j++;
                newDt = originalTable.Clone();
                newDt.Clear();
                i = 0;
            }
        }
        return tables;
    }
    
    public static bool Export(string destFilePath, DataTable dataTable)
    {
        StreamWriter streamWriter = (StreamWriter) null;
        try
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Join(",", (IEnumerable<string>) dataTable.Columns.Cast<DataColumn>().Select<DataColumn, string>((System.Func<DataColumn, string>) (column => $"\"{column.ColumnName}\"")).ToList<string>()) + "\n");
            dataTable.AsEnumerable().ToList<DataRow>().ForEach((Action<DataRow>) (row => stringBuilder.Append(string.Join(",", (IEnumerable<string>) ((IEnumerable<object>) row.ItemArray).Select<object, string>((System.Func<object, string>) (item => $"\"{item?.ToString()}\"")).ToList<string>()) + "\n")));
            string str = stringBuilder.ToString();
            streamWriter = new StreamWriter((Stream) new FileStream(destFilePath, FileMode.Append, FileAccess.Write));
            streamWriter.Write(str);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            streamWriter.Flush();
            streamWriter.Dispose();
            streamWriter.Close();
        }
    }

}