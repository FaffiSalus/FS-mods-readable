namespace FS_mods_readable.Core;

public static class CreateDataTable
{
    public static DataTable CreateTable(IEnumerable<IMajorRecordGetter> recordGetters)
    {
        var dataTable = new DataTable();
        var firstRun = true;
        foreach (var rec in recordGetters)
        {
            if (firstRun)
            {
                dataTable.TableName = rec.GetType().Name[..^13];
                foreach (var field in rec.GetType().GetProperties())
                {
                    if (field.Name == "ExportingExtraNam3") continue;
                    using var dataColumn = new DataColumn(field.Name);
                    dataColumn.AllowDBNull = true;
                    dataTable.Columns.Add(dataColumn);
                    firstRun = false;
                }
            }

            var i = 0;
            var max = dataTable.Columns.Count;
            var fieldData = new string?[max];
            foreach (var field in rec.GetType().GetProperties())
            {
                if (field.Name == "ExportingExtraNam3") continue;
                var value = field.GetValue(rec)?.ToString();
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
            // ReSharper disable once InvertIf
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

    private static List<Type> GetTypes(IEnumerable<IMajorRecordGetter> recordGetters)
    {
        var types = new List<Type>();
        foreach (var recordGetter in recordGetters)
        {
            if (types.Contains(recordGetter.GetType())) continue;
            types.Add(recordGetter.GetType());
        }

        return types;
    }

    public static List<DataTable> CreateDataTables(IEnumerable<IMajorRecordGetter> recordGetters)
    {
        var dataTables = new List<DataTable>();
        var types = GetTypes(recordGetters);
        foreach (var type in types)
            dataTables.Add(CreateTable(recordGetters.Select(x => x).Where(x => x.GetType() == type)));

        return dataTables;
    }
}