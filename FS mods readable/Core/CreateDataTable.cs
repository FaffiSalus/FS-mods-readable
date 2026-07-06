namespace FS_mods_readable.Core;

public static class CreateDataTable
{
    public static DataTable CreateTable(IEnumerable<IMajorRecordGetter> recordGetters, bool trimLength = false, int maxLength = 0)
    {
        var dataTable = new DataTable();
        var firstRun = true;
        foreach (var rec in recordGetters)
        {
            if (firstRun)
            {
                foreach (var field in rec.GetType().GetProperties())
                {
                    using var dataColumn = new DataColumn(field.Name);
                    dataColumn.AllowDBNull = true;
                    dataTable.Columns.Add(dataColumn);
                    firstRun = false;
                }
            }
            var i = 0;
            var max = rec.GetType().GetProperties().Length;
            var fieldData = new string?[max];
            foreach (var field in rec.GetType().GetProperties())
            {
                var value = field.GetValue(rec)?.ToString();
                if (trimLength && value != null && value.Length > maxLength)
                {
                    value = value[..maxLength];
                        
                }
                fieldData[i] = value;
                i++;
            }
            dataTable.Rows.Add(fieldData);
        }
        return dataTable;
    }
    
    public static List<DataTable> SplitTable(DataTable originalTable, int batchSize)
    {
        var tables = new List<DataTable>();
        var i = 0;
        var j = 1;
        var newDt = originalTable.Clone();
        newDt.Clear();
        foreach (DataRow row in originalTable.Rows)
        {
            var newRow = newDt.NewRow();
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
}