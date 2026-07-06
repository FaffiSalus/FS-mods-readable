namespace FS_mods_readable.Core;

public static class CreateDataTable
{
    public static DataTable CreateTable(IEnumerable<IMajorRecordGetter> recordGetters)
    {
        DataTable dataTable = new DataTable();
        bool firstRun = true;
        foreach (var rec in recordGetters)
        {
            if (firstRun)
            {
                foreach (var field in rec.GetType().GetProperties())
                {
                    DataColumn dataColumn = new DataColumn(field.Name);
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
                fieldData[i] = field.GetValue(rec)?.ToString();
                i++;
            }
            dataTable.Rows.Add(fieldData);
        }
        return dataTable;
    }
    
    public static List<DataTable> SplitTable(DataTable originalTable, int batchSize)
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
}